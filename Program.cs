using System;
using System.IO;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(EvenOrOdd(5));
            // Square(2);
            // Triangle(4);
            // Isosceles(8);
            
            string[] words = {"Lerato", "Fane", "a", "Boitumelo"};
            // Longest(words);
            // MultiLongest(words);4

            // int[] arr1 = {1, 3, 5 , 7};
            // int[] arr2 = {2, 4, 6 , 8};

            // CombineArrays(arr1, arr2);

            PrintFrame(words);
        }

        // Check if the number is Odd or Even
        static string EvenOrOdd(int num) {
            // Check number is even or odd
            if (num % 2 == 0) {
                return "Even";
            }
            return "Odd";
        }

        // Print a Square
        static void Square(int num) {
            for(int i = 0; i < num; i++) {
                for(int j = 0; j < num; j++) {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }

        // Print a Right Angle triangle
        static void Triangle(int num) {
            for (int i = 0; i < num; i++) {
                for(int j = 0; j < i + 1; j++) {
                    Console.Write("#");
                }
                Console.WriteLine("");;
            }
        }

        // Print Isosceles triangle
        static void Isosceles(int num) {
            int n = 1;
            for (int i = 0; i < num; i++) {
                // Print space
                for (int j = 0; j < num - (i + 1); j++) {
                    Console.Write(" ");
                }
                
                // Print hashes
                for (int j = 0; j < n + i; j++) {
                    Console.Write("#");
                }

                n++;
                Console.WriteLine("");
            }
        }

        // Print Longest word in an array
        static void Longest(string[] words) {
            string longestWord = "";

            foreach(string word in words) {
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);
        }

        // Print multiple longest words
        static void MultiLongest(string[] words) {
            foreach(string word in words) {
                if (word.Length > 1) {
                    Console.WriteLine(word);
                }
            }
        }
    
        // Combine two arrays
        static void CombineArrays(int[] arr1, int[] arr2) {
            int[] newArr = new int[8];
            int n = 0;

            for(int i = 0; i < arr1.Length; i++) {
                newArr[n] = arr1[i];
                n++;

                newArr[n] = arr2[i];
                n++;
            }

            foreach(int arr in newArr) {
                Console.WriteLine(arr);
            }
        }

        // Print text frame
        static void PrintFrame(string[] words) {
            // Top part
            string longestWord = "";

            // Get longest word
            foreach(string word in words) {
                if (word.Length > longestWord.Length) {
                    longestWord = word;
                }
            }

            Console.WriteLine(longestWord);

            // Print stars
            string longestRow = "****";
            foreach(char word in longestWord) {
                longestRow += "*";
            }

            Console.WriteLine(longestRow);

            // Print stars
            foreach(string word in words) {
                string row = "* " + word;
                
                for(int i = 0; row.Length < longestRow.Length -1; i++) {
                    row += " ";
                }

                row += "*";
                Console.WriteLine(row); 
            }

            Console.WriteLine(longestRow);

        }

    }
}
