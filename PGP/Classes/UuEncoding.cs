using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGP.Classes
{
    public static class UuEncoding
    {
        static public void UuEncode(string inputFilePath, string outputDirectory, int maxSizeKB, string recipientPublicKeyPath)
        {
            if (!File.Exists(inputFilePath))
            {
                throw new Exception($"The input file {inputFilePath} is not found");
            }

            if (!string.IsNullOrWhiteSpace(recipientPublicKeyPath) && !File.Exists(recipientPublicKeyPath))
            {
                throw new Exception($"The Recipient Public Key file {recipientPublicKeyPath} is not found");
            }
            
            FileInfo fileInfo = new FileInfo(inputFilePath);
            string inputFileName = fileInfo.Name;

            int maxFileSizeBytes = maxSizeKB * 1024; // Convert KB to Bytes
            byte[] buffer = new byte[maxFileSizeBytes];

            using (FileStream inputFile = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                int fileNumber = 1;

                while (true)
                {
                    int bytesRead = inputFile.Read(buffer, 0, maxFileSizeBytes);

                    if (bytesRead == 0)
                        break;

                    string uuencodedData = Convert.ToBase64String(buffer, 0, bytesRead);
                    string uueOutputFilePath = Path.Combine(outputDirectory, $"{inputFileName}-{fileNumber}.uue");

                    using (StreamWriter outputFile = new StreamWriter(uueOutputFilePath))
                    {
                        outputFile.WriteLine($"begin 644 {Path.GetFileName(uueOutputFilePath)}");
                        outputFile.WriteLine(uuencodedData);
                        outputFile.WriteLine("end");
                    }

                    if (!string.IsNullOrEmpty(recipientPublicKeyPath))
                    {
                        string uueeOutputFilePath = uueOutputFilePath + "e";
                        PgpEncryption.EncryptFile(uueOutputFilePath, uueeOutputFilePath, recipientPublicKeyPath, true, true);
                        File.Delete(uueOutputFilePath);
                    }
                    
                    fileNumber++;
                }
            }
        }

        static public string RebuildFromUuEncoded(string startPath, string outputFileFolder, string privateKeyPath, string providedPassPhase)
        {
            if (!File.Exists(startPath))
            {
                throw new Exception($"The file {startPath} is not found");
            }

            bool includeDecodingStep = (startPath.EndsWith(".uuee", StringComparison.OrdinalIgnoreCase));

            if (includeDecodingStep)
            {
                if (string.IsNullOrWhiteSpace(privateKeyPath))
                {
                    throw new Exception("If rebuilding from an encrypyed file (*.uuee), you must also pass a path to the private key file.");
                }
                
                if (!File.Exists(privateKeyPath))
                {
                    throw new Exception($"The private key file {privateKeyPath} is not found");
                }
            }

            string originalFileName = GetOriginalFileNameFromFirstLine(startPath, privateKeyPath, providedPassPhase);
            FileInfo startUueFileInfo = new FileInfo(startPath);
            string outputFilePath = Path.Combine(outputFileFolder, originalFileName);
            int startFileNumber = 1;

            using (FileStream outputFile = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            {
                int fileNumber = startFileNumber;

                while (true)
                {             
                    string currentFilePath;
                    string currentUueIndexPath = "";

                    if (includeDecodingStep)
                    {                        
                        currentFilePath = Path.Combine(startUueFileInfo.DirectoryName, $"{originalFileName}-{fileNumber}.uuee");

                        if (!File.Exists(currentFilePath))
                        {
                            break;
                        }

                        currentUueIndexPath = Path.Combine(startUueFileInfo.DirectoryName, $"{originalFileName}-{fileNumber}.uue");
                        PgpEncryption.DecryptFile(currentFilePath, currentUueIndexPath, privateKeyPath, providedPassPhase);
                    }
                    else
                    {
                        currentUueIndexPath = Path.Combine(startUueFileInfo.DirectoryName, $"{originalFileName}-{fileNumber}.uue");
                    }

                    if (!File.Exists(currentUueIndexPath))
                    {
                        break;
                    }

                    string[] lines = File.ReadAllLines(currentUueIndexPath);
                    string uuencodedData = string.Join(string.Empty, lines, 1, lines.Length - 2); // Exclude "begin" and "end" lines
                    byte[] binaryData = Convert.FromBase64String(uuencodedData);
                    outputFile.Write(binaryData, 0, binaryData.Length);
                    File.Delete(currentUueIndexPath);

                    fileNumber++;
                }
            }

            return outputFilePath;
        }

        private static string GetOriginalFileNameFromFirstLine(string filePath, string privateKey, string providedPassPhase)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception($"{filePath} does not exist");
            }

            FileInfo startFileInfo = new FileInfo(filePath);
            string currentFilePath;

            if (startFileInfo.Extension == ".uuee")
            {
                string eeuPath = filePath.Substring(0, filePath.Length - 1);
                PgpEncryption.DecryptFile(filePath, eeuPath, privateKey, providedPassPhase);
                currentFilePath = eeuPath;
            }
            else
            {
                currentFilePath = filePath;
            }

            using (StreamReader reader = new StreamReader(currentFilePath))
            {
                // Read the first line of the file
                string firstLine = reader.ReadLine();
                const string headerPrefix = "begin 644 ";
                string fileName = "";

                if (firstLine != null && firstLine.StartsWith(headerPrefix))
                {
                    fileName = firstLine.Substring(headerPrefix.Length);
                }

                string expectedSuffix = "-1.uue";
                return fileName.Substring(0, fileName.Length - expectedSuffix.Length);
            }
        }
    }
}
