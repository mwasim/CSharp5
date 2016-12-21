using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Streams
{
    public class StreamExamples
    {
        const string filePath = "files/";
        public static void WriteByteFileExample()
        {
            Console.Write("Please enter the name of the file to create:");
            var fileName = Console.ReadLine();

            if (!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);
            using (var fs = new FileStream(GetFullFileName(fileName), FileMode.Create))
            {
                Console.Write("\n\nHow many numbers would you like to enter?");
                var n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    var number = int.Parse(Console.ReadLine());
                    fs.WriteByte((byte)number);
                }
            }
        }

        private static string GetFullFileName(string fileName)
        {
            return string.Format("{0}{1}.txt", filePath, fileName);
        }

        public static void ReadByteFileExample()
        {
            Console.Write("Please enter the name of the file to read:");
            var fileName = Console.ReadLine();
            using (var fs = new FileStream(GetFullFileName(fileName), FileMode.Open))
            {
                Console.WriteLine("\nThe data in the byte file is:");
                int i = 0;
                do
                {
                    i = fs.ReadByte();
                    if (i != -1) Console.WriteLine((byte)i);
                } while (i != -1);
            }
        }

        public static void ReadFileRandomly()
        {
            Console.Write("Please enter the name of the file to read:");
            var fileName = Console.ReadLine();
            using (var fs = new FileStream(GetFullFileName(fileName), FileMode.Open))
            {
                //read the first byte
                fs.Seek(0, SeekOrigin.Begin);
                int i = fs.ReadByte();
                if (i != -1) Console.WriteLine("First byte is: {0}", (byte)i);

                //read the 4th byte
                fs.Seek(3, SeekOrigin.Begin);
                i = fs.ReadByte();
                if (i != -1) Console.WriteLine("The fourth byte is: {0}", (byte)i);

                Console.WriteLine("The data in the byte file in reverse order is: ");
                fs.Seek(-1, SeekOrigin.End);

                try
                {
                    while (i != -1)
                    {
                        i = fs.ReadByte();
                        if (i != -1) Console.WriteLine("Byte Read: {0}", (byte)i);

                        if (fs.Position != 1) fs.Seek(-2, SeekOrigin.Current); else break;
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("IO exception - " + ex.Message);
                }
            }
        }

        public static void WriteBinaryFileExample()
        {
            Console.Write("Please enter the name of the file to write:");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            if (File.Exists(fileNameFull))
            {
                Console.WriteLine("The file {0} already exists.", fileNameFull);
                Console.WriteLine("Ending program...");
                return;
            }

            using (var fs = new FileStream(GetFullFileName(fileName), FileMode.CreateNew))
            {
                using (var bw = new BinaryWriter(fs))
                {
                    string input;
                    do
                    {
                        Console.Write("Enter data to write to the file or 'quit' to quit: ");
                        input = Console.ReadLine();

                        if (input != "quit")
                            bw.Write(input);

                    } while (input != "quit");
                }
            }
        }

        public static void ReadBinaryFileExample()
        {
            Console.Write("Please enter the name of the file to read: ");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            using (var fs = new FileStream(fileNameFull, FileMode.Open))
            {
                using (var br = new BinaryReader(fs))
                {
                    Console.WriteLine("Data in the file is: ");
                    while (br.PeekChar() != -1)
                    {
                        var output = br.ReadString();
                        Console.WriteLine(output);
                    }
                }
            }
        }

        public static void StreamWriterExample()
        {
            Console.WriteLine("StreamWriter Example:");
            Console.WriteLine("-----------------------");
            Console.Write("Please enter the name of the file to write:");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            if (File.Exists(fileNameFull))
            {
                Console.WriteLine("The file {0} already exists.", fileNameFull);
                Console.WriteLine("Ending program...");
                return;
            }

            using (var fs = new FileStream(GetFullFileName(fileName), FileMode.CreateNew))
            {
                using (var bw = new StreamWriter(fs))
                {
                    string input;
                    do
                    {
                        Console.Write("Enter data to write to the file or 'quit' to quit: ");
                        input = Console.ReadLine();

                        if (input != "quit")
                            bw.WriteLine(input);

                    } while (input != "quit");
                }
            }

            Console.WriteLine("\n\n");
        }

        public static void StreamReaderExample()
        {
            Console.Write("Please enter the name of the file to read: ");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            using (var fs = new FileStream(fileNameFull, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    Console.WriteLine("Data in the file is: ");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        public static void TextWriterExample()
        {
            Console.WriteLine("StreamWriter Example:");
            Console.WriteLine("-----------------------");
            Console.Write("Please enter the name of the file to write:");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            if (File.Exists(fileNameFull))
            {
                Console.WriteLine("The file {0} already exists.", fileNameFull);
                Console.WriteLine("Ending program...");
                return;
            }

            using (TextWriter tw = new StreamWriter(fileNameFull))
            {
                string input;
                do
                {
                    Console.Write("Enter data to write to the file or 'quit' to quit: ");
                    input = Console.ReadLine();

                    if (input != "quit")
                        tw.WriteLine(input);

                } while (input != "quit");
            }

            Console.WriteLine("\n\n");
        }

        public static void TextReaderExample()
        {
            Console.Write("Please enter the name of the file to read: ");
            var fileName = Console.ReadLine();
            var fileNameFull = GetFullFileName(fileName);

            using (var sr = new StreamReader(fileNameFull))
            {
                Console.WriteLine("Data in the file is: ");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }


        public static void StringWriterReaderExample()
        {
            var sb = new StringBuilder();
            using (var sw = new StringWriter(sb))
            {
                Console.Write("Enter text or 'quit' to quit: ");

                string input;
                do
                {
                    input = Console.ReadLine();

                    if (input != "quit")
                        sw.WriteLine(input);

                } while (input != "quit");
            }

            Console.WriteLine("You entered the following text: ");
            using (var sr = new StringReader(sb.ToString()))
            {
                while (sr.Peek() > -1)
                {
                    var line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }

        public static void FileReadAllLines()
        {
            Console.Write("Please enter the name of the file to read.");
            var fileName = Console.ReadLine();
            var filePath = GetFullFileName(fileName);

            var lines = File.ReadAllLines(filePath);
            Console.WriteLine("\n\nText in the file is below,\n");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void FileReadAllText()
        {
            Console.Write("Please enter the name of the file to read.");
            var fileName = Console.ReadLine();
            var filePath = GetFullFileName(fileName);

            try
            {
                var text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception caught - {0}", ex.Message);
            }
        }

        public static void MemoryStreamExample()
        {
            var message = "Hello World!";
            var byteArray = Encoding.ASCII.GetBytes(message);
            using (var ms = new MemoryStream(byteArray))
            {
                using (var sr = new StreamReader(ms))
                {
                    Console.WriteLine("Output using stream reader initialized by memory stream.");
                    var text = sr.ReadToEnd();
                    Console.WriteLine(text);

                    Console.WriteLine("\n\nReadByte in the Memory Stream, output below:");
                    ms.Position = 0;
                    int bite = ms.ReadByte();
                    do
                    {
                        Console.Write((char)bite);
                        bite = ms.ReadByte();
                    } while (bite != -1);

                    Console.WriteLine("\n\nWriting bytes to the memory stream:");
                    ms.Position = 0;
                    ms.WriteByte(Convert.ToByte('b'));
                    ms.WriteByte(Convert.ToByte('y'));
                    ms.WriteByte(Convert.ToByte('e'));
                    ms.Position = 0;

                    Console.WriteLine("\n\nDisplaying updated text:");
                    text = sr.ReadToEnd();
                    Console.WriteLine("\n{0}", text);
                }
            }

        }

        public static void DirectoryAndFilesExample()
        {
            var dirInfo = new DirectoryInfo(filePath);
            var files = Directory.GetFiles(filePath);
            var dirs = dirInfo.GetDirectories();

            Console.WriteLine("The subdirectories are:");
            foreach (var subDir in dirs)
            {
                Console.WriteLine(subDir.Name);
            }

            Console.WriteLine("\n\nThe file names are: ");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
