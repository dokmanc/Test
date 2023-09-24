using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGP.Classes
{
    public static class WindowsUtilities
    {
        public static void ShowFileInWindowsExplorer(string filePath)
        {
            try
            {
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }           
        }

        public static void OpenFolderInWindowsExplorer(string filePath)
        {
            try
            {
                Process.Start("explorer.exe", $"\"{filePath}\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
