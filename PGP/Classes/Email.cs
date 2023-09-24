using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using MailKit.Net.Imap;
using MailKit;
using MailKit.Search;
using MimeKit;
using System.IO;

namespace PGP.Classes
{
    internal static class Email
    {
        public static void ReadComcastMail(string password)
        {
            // Comcast IMAP settings
            string imapServer = "imap.comcast.net";
            int imapPort = 993;
            bool useSsl = true;

            // Your Comcast email credentials
            string email = "chaddokmanovich@comcast.net";
            //string password = ComcastPassword;

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(imapServer, imapPort, useSsl);
                client.Authenticate(email, password);

                var inbox = client.Inbox;
                //var folders = client.GetFolders(client.PersonalNamespaces[0]);

                inbox = client.GetFolder("UUE");

                inbox.Open(FolderAccess.ReadOnly);

                IList<UniqueId> uids = inbox.Search(SearchQuery.All);
                IEnumerable<MimeMessage> messages = uids.Select(uid => inbox.GetMessage(uid));

                // Sort messages by Date Sent in descending order
                var sortedMessages = messages.OrderByDescending(message => message.Date);

                foreach (var message in sortedMessages)
                {
                    Console.WriteLine("Subject: " + message.Subject);
                    Console.WriteLine("From: " + message.From);
                    Console.WriteLine("Date: " + message.Date);
                    Console.WriteLine("Body: " + message.TextBody);
                }

                var folder = client.GetFolder("Church");
                folder.Open(FolderAccess.ReadOnly);

                // Search for all messages in the specified folder
                uids = folder.Search(SearchQuery.All);


                // Search for all unread messages
                //var uids = inbox.Search(SearchQuery.All);

                //foreach (var uid in uids)
                //{
                //    var message = inbox.GetMessage(uid);

                //    Console.WriteLine("Subject: " + message.Subject);
                //    Console.WriteLine("From: " + message.From);
                //    Console.WriteLine("Date: " + message.Date);
                //    Console.WriteLine("Body: " + message.TextBody);

                //    // Mark the email as seen
                //    inbox.AddFlags(uid, MessageFlags.Seen, true);
                //}

                client.Disconnect(true);
            }
        }

        public static void SendUsingComcast(string filePath, string senderEmail, string password, string recipientEmail)
        {
            if (!filePath.EndsWith("-1.uue") && !filePath.EndsWith("-1.uuee"))
            {
                throw new Exception("filePath must end with '-1.uue' or '-1.eeue'");
            }

            if (!File.Exists(filePath))
            {
                throw new Exception($"The file {filePath} is not found");
            }

            FileInfo filePathFileInfo = new FileInfo(filePath);
            string baseFileName = filePathFileInfo.Name.Substring( 0, filePathFileInfo.Name.Length - filePathFileInfo.Extension.Length - 2);
            int index = 1;
            
            string smtpServer = "smtp.comcast.net";
            int smtpPort = 587;
            
            SmtpClient smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(senderEmail, password),
                EnableSsl = true, // Use SSL/TLS
            };

            while (true)
            {
                string currentFileBase = $"{baseFileName}-{index}{filePathFileInfo.Extension}";
                string path = Path.Combine(filePathFileInfo.DirectoryName, currentFileBase);

                if (!File.Exists(path))
                {
                    return;
                }

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = currentFileBase,
                    Body = File.ReadAllText(path),
                    IsBodyHtml = false,
                };

                mailMessage.To.Add(recipientEmail);

                try
                {
                    // Send the email
                    smtpClient.Send(mailMessage);
                    Console.WriteLine("Email sent successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to send email: {ex.Message}");
                }

                System.Threading.Thread.Sleep(30000);

                index++;
            }

            smtpClient.Dispose();
        }
    }
}
