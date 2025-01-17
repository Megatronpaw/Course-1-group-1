using System;
using System.IO;
namespace testtt
{
    internal class Program
    {
            static void WriteFile()
            {
                string[] hello = new string[5];
                for (int i = 0; i < hello.Length; i++)
                {
                    hello[i] = "Hello, World!";
                }
                File.WriteAllLines("test.txt", hello);
            }
            static void ReadFile()
            {
                string[] hello = File.ReadAllLines("test.txt");
                foreach (string line in hello)
                {
                    Console.WriteLine(line);
                }
            }
            static void Main(string[] arg)
            {
                WriteFile();
                ReadFile();
            }
     }
 }
