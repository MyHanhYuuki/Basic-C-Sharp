using System;
using System.Collections.Generic;
using System.IO;

namespace Bai01
{
    class Program
    {

        public static void Main()
        {
            Console.Write("Ban hay nhap vao duong dan:");
            string filePath = Console.ReadLine();
            Console.WriteLine("File Information:");
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                Console.WriteLine("Creation Time: " + fileInfo.CreationTime.ToString());
                Console.WriteLine("Last Access Time: " + fileInfo.LastAccessTime.ToString());
                Console.WriteLine("File Length (bytes): " + fileInfo.Length.ToString());
                Console.WriteLine("File Attributes: " + fileInfo.Attributes.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Directory Information");
            DirectoryInfo directoryInfo = fileInfo.Directory;
            if (directoryInfo.Exists)
            {
                Console.WriteLine("Creation Time: " + directoryInfo.CreationTime.ToString());
                Console.WriteLine("Last Access Time: " + directoryInfo.LastAccessTime.ToString());
                Console.WriteLine("Directory contains: " + directoryInfo.GetFiles().Length.ToString() + " files");
            }
            Console.WriteLine();
            Console.WriteLine("Drive Information");
            DriveInfo driveInfo = new DriveInfo(fileInfo.FullName);
            if (driveInfo.IsReady)
            {
                Console.WriteLine("Drive Name: " + driveInfo.Name);
                Console.WriteLine("Drive Type: " + driveInfo.DriveType.ToString());
                Console.WriteLine("Drive Format: " + driveInfo.DriveFormat.ToString());
                Console.WriteLine("Drive Free Space: " + driveInfo.AvailableFreeSpace.ToString());
            }
            
            Console.ReadKey();
        }
    }
}