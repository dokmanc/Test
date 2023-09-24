using System;
using System.Configuration;
using System.IO;

namespace PGP
{
    public static class ApplicationSettings
    {
        public static string KeyFolder
        {
            get
            {
                return Path.Combine(Environment.CurrentDirectory, ConfigurationManager.AppSettings["PrivateKeyRelativeFolder"]);
            }
        }

        public static string PublicKeyPath
        {
            get
            {
                return Path.Combine(KeyFolder, "MyPublicKey.txt");
            }
        }

        public static string PrivateKeyPath
        {
            get
            {
                return Path.Combine(KeyFolder, "MyPrivateKey.txt");
            }

        }

        public static string SendToFolder
        {
            get
            {
                return Path.Combine(Environment.CurrentDirectory, ConfigurationManager.AppSettings["SendToRelativeFolder"]);
            }
        }


        public static string PassPhrase
        {
            get
            { 
                if (File.Exists(PassPhasePath))
                {
                    return File.ReadAllText(PassPhasePath);
                }

                return "";
            }
        }

        public static string PassPhasePath
        {
            get
            {
                return Path.Combine(ApplicationSettings.KeyFolder, "PassPhrase.txt");
            }
        }

        public static bool KeyFilesExist()
        {
            return (File.Exists(ApplicationSettings.PublicKeyPath) || File.Exists(ApplicationSettings.PrivateKeyPath));
        }
    }

}
