using System;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] secondLine = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            int minLenght = Math.Min(firstLine.Length, secondLine.Length);

            if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] == secondLine[i])
                    {
                        Console.WriteLine(string.Join(string.Empty, secondLine));
                        Console.WriteLine(string.Join(string.Empty, firstLine));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join(string.Empty, firstLine));
                        Console.WriteLine(string.Join(string.Empty, secondLine));
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < minLenght; i++)
                {
                    if (firstLine.Length>secondLine.Length)
                    {
                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            break;

                        }
                    }
                    else if (true)
                    {
                        if (firstLine[i] == secondLine[i])
                        {
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            break;
                        }
                        else if (firstLine[i] > secondLine[i])
                        {
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            break;
                        }
                        else
                        {
                            Console.WriteLine(string.Join(string.Empty, firstLine));
                            Console.WriteLine(string.Join(string.Empty, secondLine));
                            break;

                        }
                    }
                }
            }
        }
    }
}
