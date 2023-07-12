using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace String_assign01
{
    internal class First_occurance
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter   string");
               string str = Console.ReadLine();
               Console.WriteLine(" enter a character");
               char character = Convert.ToChar(Console.ReadLine());

               Console.WriteLine();

               for (int i = 0; i < str.Length; i++)
               {
                   if (str[i] == character)
                   {
                       Console.WriteLine($"first occurance of character{i}");


                   }


               }

              // white space reoving using trim...
               Console.WriteLine(" Enter string");
               string str =Console.ReadLine();
               string trimmedResult =str.Trim();
               Console.WriteLine("trimmed string" + trimmedResult); 

            // find word occurance

            Console.WriteLine("Enter sentence");
            String sentence1 = Console.ReadLine();

            string sentence = sentence1.ToLower();

           
            Console.WriteLine("enter word which find out");
            string word = Console.ReadLine();

            string searchword=word.ToLower();
            
            string[] words = sentence.Split(' ');

            for(int i=0; i<words.Length; i++)
            {
                if (words[i] == searchword)
                {
                    Console.WriteLine($"{searchword} words{i+1}");
                    return;
                }
                else
                {
                    Console.WriteLine($"word{searchword}is not in sentence");
                }
                Console.WriteLine(); 
            } 


            Console.WriteLine(" Enter sentence");
            string sentence= Console.ReadLine();
            string[] words = sentence.Split(' ');
            int count=words.Length;
            Console.WriteLine($"total num of word"+ count);


            // occourance of char

            Console.WriteLine(" ENTER THE SENTENCE");
            String str1=Console.ReadLine();

            Console.WriteLine(" enter char");
            char character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            

                int count = 0;
             
            for(int i=0; i<str1.Length; i++)
            {
                if (str1[i] == character)
                {
                    count++;
                    
                }
               Console.WriteLine($" chracter{character}occour in{count}time");
            
            }

            // longest word

            Console.WriteLine("Enter sentence");
            string sentence1=Console.ReadLine();

            string[]words=sentence1.Split(' ');
            string logestword = "";
            for( int i=0; i<words.Length; i++ )
            {
                if(words[i].Length> logestword.Length)
                {
                    logestword = words[i];
                }
                
            }

            Console.WriteLine($" logest word in string is=" + logestword);


            // anagram or not
            string str = "listen";
            string str2 = "silent";

            char[]ch1= str.ToLower().ToCharArray();
            char[]ch2= str2 .ToLower(). ToCharArray();


            Array.Sort(ch1);
            Array.Sort(ch2);
            
            string val1= new string(ch1);
            string val2= new string(ch2);

            if(val1.Length == val2.Length)
            {
                Console.WriteLine("both the string are angram");
            }
            else
            {
                Console.WriteLine("both the string are not anagram");
            }

            // palindome or not

            Console.WriteLine("enter a string");
            string str1= Console.ReadLine();

            string str2 = string. Empty;
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 =str1 + str1[i];
            }
            if(str)
            {
                
            }

            int[] num = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    int j = i - 1;
                    num[i] = num[j] * num[j];


                }
                Console.WriteLine(num[i]);
            }

            int[] arr = new int[] { 4, 5, 7, 1, 2, 3, 0 };
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
                for(int i=0; i<arr.Length; i++)
            {
                
                for(int j = i+1;j<arr.Length-1; j++)
                 
                {
                    int sum = arr[j] + arr[j];
                    if (arr[j] + arr[i] == num)
                    {
                        Console.WriteLine($"({arr[i]},{arr[j]})");



                    }
                }
            }



            int[] arr = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };

            int zeros = arr.Length;
            for(int i = 0; i < zeros; i++)
            {
                for(int j=i+1; j < arr.Length-1; j++)
                {
                    int temp;
                    if (arr[j] == 0)
                    {
                        temp = arr[i];
                        arr[i]= arr[j];
                        arr[j]= temp;
                    }
                        

                    
                }
            }
                
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }


            int[] array = new int[] { 3, 0, 0, 1, 2, 0, 4, 0 };
            int j = array.Length - 1;
            for(int i = array.Length-1; i>=0; i--)
            {
                if (array[i] != 0)
                {
                    array[j]= array[i];
                    j--;
                }

            }
            for( int i = j; i>=0; i--)
            {
                array[j] = 0; j--;
            }
            foreach( int i in array)
            {
                Console.WriteLine(i);
            }


            int[] array = new int[] { 3, 8, 5, 1, 2, 9, 4, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])

                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

            }
        
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }   */





   
    
    }




}
