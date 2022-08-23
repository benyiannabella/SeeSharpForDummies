//using System;
//using System.IO;

//namespace SeeSharpForDummies
//{
//    class LoopThroughFiles
//    {

//        static void LoopDir()
//        {
//            //if no dir name provided
//            string dirName;
//            if(args.Length == 0)
//            {
//                //get current dir;
//                dirName = Directory.GetCurrentDirectory();  
//            } else
//            {
//                //assume first argument is dir name
//                dirName=args[0];    
//            }
//            Console.WriteLine(dirName);

//            //get the list of all files from dir; fileinfo objects
//            FileInfo[] files = GetFileList(dirName);

//            //iterate trough the files; perform hex dump;
//            foreach(FileInfo file in files)
//            {
//                Console.WriteLine("\n\nhex dump of file {0}: ",  file.FullName);

//                //DUMP THE FILE TO THE CONSOLE
//                DumpHex(file);
//                Console.WriteLine("\nPress Enter to continue to next file.");
//                Console.ReadLine();
//            }
//            Console.WriteLine("No file lef!");
//            Console.Read();
            
//        }

//        public static void DumpHex(FileInfo file)
//        {
//            // Open the file.
//            FileStream fs;
//            BinaryReader reader;
//            try
//            {
//                fs = file.OpenRead();
//                // Wrap the file stream in a BinaryReader.
//                reader = new BinaryReader(fs);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("\ncan't read from \"{0}\"", file.FullName);
//                Console.WriteLine(e.Message);
//                return;
//            }
//            // Iterate through the contents of the file one line at a time.
//            for (int line = 1; true; line++)
//            {
//                // Read another 10 bytes across (all that will fit on a single
//                // line) -- return when no data remains.
//                byte[] buffer = new byte[10];
//                // Use the BinaryReader to read bytes.
//                // Note: Using FileStream is just as easy in this case.
//                int numBytes = reader.Read(buffer, 0, buffer.Length);
//                if (numBytes == 0)
//                {
//                    return;
//                }
//                // Write the data in a single line preceded by line number.
//                Console.Write("{0:D3} - ", line);
//                DumpBuffer(buffer, numBytes);
//                // Stop every 20 lines so that the data doesn't scroll
//                // off the top of the Console screen.
//                if ((line % 20) == 0)
//                {
//                    Console.WriteLine("Press Enter to continue another 20 lines" +
//                    " or type Q to go to the next file.");
//                    string Input = Console.ReadLine();
//                    if (Input.ToUpper() == "Q")
//                        break;
//                }
//            }
//        }
//        // DumpBuffer -- Write a buffer of characters as a single line in
//        // hex format.
//        public static void DumpBuffer(byte[] buffer, int numBytes)
//        {
//            for (int index = 0; index < numBytes; index++)
//            {
//                byte b = buffer[index];
//                Console.Write("{0:X2}, ", b);
//            }
//            Console.WriteLine();
//        }


//        public static FileInfo[] GetFileList(string dirName)
//        {
//            FileInfo[] files = new FileInfo[0];

//            try
//            {
//                //create dir object and get dir info
//                DirectoryInfo dir = new DirectoryInfo(dirName);

//                //add files to the array
//                files = dir.GetFiles(); 

//            } catch(Exception e)
//            {
//                Console.WriteLine("Directory {0} invalid", dirName);
//                Console.WriteLine(e.Message);
//            }

//            return files;
//        }
//    }
//}
