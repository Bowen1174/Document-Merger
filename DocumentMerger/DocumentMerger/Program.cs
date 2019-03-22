
using System;
using System.IO;

namespace Test
{
    class DocumentMerger
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <A> <B>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of " +
                "the resulting merged text file as command line arguments.");
            }
            else
            {
                String outFile = args[args.Length - 1];  
                StreamWriter sw = new StreamWriter(outFile); 
                try
                {
                    String line;
                    int i = 0;
                    while (i < (args.Length - 1))
                    {
                        using (StreamReader sr = new StreamReader(args[i]))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine(line);
                            }
                        }
                        i++;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                    Console.WriteLine("Program exiting....");
                }
                finally
                {
                    sw.Close();
                }
                Console.ReadLine(); 
            }
        }
    }
}