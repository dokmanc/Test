using Cinchoo.PGP;
using System;
using System.IO;

namespace PGP
{
    public static class PgpEncryption
    {
        public static void EncryptFile(string fileToEncryptedPath,
                                       string outputFilePath,
                                       string publicKeyFilePath,
                                       bool withArmour,
                                       bool withIntegrityCheck)
        {
            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {

                choPGPEncryptDecrypt.EncryptFile(inputFilePath: fileToEncryptedPath,
                                                 outputFilePath: outputFilePath,
                                                 publicKeyFilePath: publicKeyFilePath,
                                                 armor: withArmour,
                                                 withIntegrityCheck: withIntegrityCheck);
            }
        }

        internal static void DecryptText(string text, string privateKeyPath, object passphrase)
        {
            throw new NotImplementedException();
        }

        public static void EncryptFileAndSign(string fileToEncryptedPath,
                                              string outputFilePath,
                                              string publicKeyFilePath,
                                              bool withArmour,
                                              bool withIntegrityCheck,
                                              string privateKeyFilePath,
                                              string passPhrase)
        {
            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {

                choPGPEncryptDecrypt.EncryptFileAndSign(inputFilePath: fileToEncryptedPath,
                                                        outputFilePath: outputFilePath,
                                                        publicKeyFilePath: publicKeyFilePath,
                                                        privateKeyFilePath: privateKeyFilePath,
                                                        passPhrase: passPhrase,
                                                        armor: withArmour,
                                                        withIntegrityCheck: withIntegrityCheck);
            }
        }

        public static void DecryptFile(string inputFilePath,
                                       string outputFilePath,
                                       string privateKeyFilePath,
                                       string passPhrase)
        {
            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {
                choPGPEncryptDecrypt.DecryptFile(inputFilePath, outputFilePath, privateKeyFilePath, passPhrase);
            }
        }


        public static void GenerateKey(string publicKeyFilePath,
                                       string privateKeyFilePath,
                                       string userName,
                                       string password)
        {
            if (!Directory.Exists(ApplicationSettings.KeyFolder))
            {
                Directory.CreateDirectory(ApplicationSettings.KeyFolder);
            }

            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {
                choPGPEncryptDecrypt.GenerateKey(publicKeyFilePath,
                                                 privateKeyFilePath,
                                                 userName != "" ? userName : null,
                                                 password != "" ? password : null);
            }
        }

        public static string EncryptText(string textToEncrypt, string publicKeyFilePath, bool withArmor, bool withIntegrityCheck)
        {
            string fileToEncryptPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            string encryptedFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            File.WriteAllText(fileToEncryptPath, textToEncrypt);

            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {

                choPGPEncryptDecrypt.EncryptFile(inputFilePath: fileToEncryptPath,
                                                 outputFilePath: encryptedFilePath,
                                                 publicKeyFilePath: publicKeyFilePath,
                                                 armor: withArmor,
                                                 withIntegrityCheck: withIntegrityCheck);
            }

            File.Delete(fileToEncryptPath);
            string encryptpedText = File.ReadAllText(encryptedFilePath);
            File.Delete(encryptedFilePath);
            return encryptpedText;
        }

        public static string DecryptText(string textToDecrypt,
                                          string privateKeyFilePath,
                                          string passPhrase)
        {
            string filePathToDecrypt = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            string decryptedFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            File.WriteAllText(filePathToDecrypt, textToDecrypt);

            using (var choPGPEncryptDecrypt = new ChoPGPEncryptDecrypt())
            {
                choPGPEncryptDecrypt.DecryptFile(filePathToDecrypt, decryptedFilePath, privateKeyFilePath, passPhrase);
            }

            string decryptedText = File.ReadAllText(decryptedFilePath);
            File.Delete(filePathToDecrypt);
            File.Delete(decryptedFilePath);
            return decryptedText;
        }

        public static bool IsPgpEncrypted(string text)
        {
            return (text.StartsWith("-----BEGIN PGP MESSAGE-----"));
        }
    }
}

