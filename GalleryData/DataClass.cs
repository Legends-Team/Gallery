using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace GalleryData
{
    public static class DataClass
    {
        private static string[] defaultFilters = { "jpg", "jpeg", "jfif", "png", "gif", "tiff", "bmp", "svg" };
        public static List<string> filters = defaultFilters.ToList();
        public static bool recursiveLookup = true;
        public static int sizeX = 102;
        public static int sizeY = 102;

        // Get all files in directory
        public static List<string> GetFilesFrom(String searchFolder, String[] filters, bool isRecursive)
        {
            List<String> filesFound = new List<String>();
            var searchOption = isRecursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            foreach (var filter in filters)
            {
                filesFound.AddRange(Directory.GetFiles(searchFolder, String.Format("*.{0}", filter), searchOption));
            }
            return filesFound;
        }

        // Open file in windows photo viewer
        public static void OpenPhotos(string file)
        {
            string AbsolutePath = Path.GetFullPath(file);
            string ApplicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            var process = new ProcessStartInfo("rundll32.exe", String.Format("\"{0}{1}\", ImageView_Fullscreen {2}",
                Environment.Is64BitOperatingSystem ?
                ApplicationPath.Replace(" (x86)", "") :
                ApplicationPath, @"\Windows Photo Viewer\PhotoViewer.dll", AbsolutePath));
            process.UseShellExecute = false;
            Process.Start(process);
        }
    }
}
