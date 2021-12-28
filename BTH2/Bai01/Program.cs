// Xuat tat ca tap tin va thu muc con.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bai01
{
    class Program
    {
        class File_Manager
        {
            private string filePath;
            public string FilePath
            {
                get
                {
                    return filePath;
                }
                set
                {
                    filePath = value != "" ? value : "F:\\";
                }
            }

            public File_Manager( string filePath = "F:\\")
            {
                this.filePath = filePath != "" ? filePath : "F:\\";
            }

            public void Enter_File_Name()
            {
                do
                {
                    Console.WriteLine("Nhap duong dan va ten file:");
                    filePath = Console.ReadLine();
                } while (filePath == "");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
        }
    }
}