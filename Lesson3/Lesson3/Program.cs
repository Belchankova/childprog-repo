using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the task number to check: ");
            int tasknumber = int.Parse(Console.ReadLine());
            switch (tasknumber)
            {
                case 0:
            int[] Array0 = { 12, 34, 45, 56, 78 };
            Console.WriteLine("Enter a number:\t");
            int x = 0;
            int arraynumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array0.Length; i++)
            {
                if (arraynumber == Array0[i])
                {
                    Console.WriteLine("The number is included in the array.");
                }
                else
                {
                    x++;
                }
            }
            if (x == Array0.Length)
            {
                Console.WriteLine("The number is not included in the array");
            }
            
                    break;
                case 1:
                 x = 0;
                    int[] Array1 = { 1, 2, 3, 2, 4, 2, 5, 2 };
            Console.WriteLine("The source array:");
            Console.WriteLine(String.Join(",", Array1));
            Console.WriteLine("Enter an unnecessary number:\t");
            int unnecessarynumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array1.Length; i++)
            {
                if (unnecessarynumber == Array1[i])
                {
                    x++;
                }

            }
            if (x != 0)
            {
                Array1 = Array1.Where(e => e != unnecessarynumber).ToArray();
                Console.WriteLine(String.Join(",", Array1));

            }
            else
            {
                Console.WriteLine("The number is missing in the array. Try again!");
            }
                    break;
                case 2:
            Random rand = new Random();
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] Array2 = new int[size];
            for (int i = 0; i < Array2.Length; i++)
            {
                Array2[i] = rand.Next(20);
            }
            Console.WriteLine(String.Join(",", Array2));
            int minValue = Array2[0];
            for (int i = 1; i < Array2.Length; i++)
            {
                if (Array2[i] < minValue)
                {
                    minValue = Array2[i];
                }
            }
            Console.WriteLine("Minimum value: " + minValue);
            int maxValue = Array2[0];
            for (int i = 1; i < Array2.Length; i++)
            {
                if (Array2[i] > maxValue)
                {
                    maxValue = Array2[i];
                }
            }
            Console.WriteLine("Maximum value: " + maxValue);
            int sum = 0;
            for (int i = 0; i < Array2.Length; i++)
            {
                sum += Array2[i];
            }
            int average = sum / Array2.Length;
            Console.WriteLine("The average value: " + average);
                    break;

                case 3:
                    Random rand1 = new Random();
                    int[] Array31 = new int[5];
            for (int i = 0; i < Array31.Length; i++)
            {
                Array31[i] = rand1.Next(20);
            }
            Console.WriteLine(String.Join(",", Array31));
            int[] Array32 = new int[5];
            for (int i = 0; i < Array32.Length; i++)
            {
                Array32[i] = rand1.Next(20);
            }
            Console.WriteLine(String.Join(",", Array32));
            sum = 0;
            for (int i = 0; i < Array31.Length; i++)
            {
                sum += Array31[i];
            }
            int average1 = sum / Array31.Length;
            Console.WriteLine("The average value of the first array: " + average1);
            sum = 0;
            for (int i = 0; i < Array32.Length; i++)
            {
                sum += Array32[i];
            }
            int average2 = sum / Array32.Length;
            Console.WriteLine("The average value of the second array: " + average2);
            if (average1 > average2)
            {
                Console.WriteLine("The average value of the first array is greater. ");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("The average value of the second array is greater. ");
            }
            else if (average1 == average2)
            {
                Console.WriteLine("The average values of the arrays are equal. ");
            }
                    break;

                case 4:
                    Random rand2 = new Random();
                    Console.WriteLine("Enter the size of the array [6..10]: ");
                    size = int.Parse(Console.ReadLine());
                    if (5 < size && size <= 10)
                    {
                        int[] Array4 = new int[size];
                        for (int i = 0; i < Array4.Length; i++)
                        {
                            Array4[i] = rand2.Next(20);
                        }
                        Console.WriteLine(String.Join(",", Array4));
                        int evenCount = 0;
                        for (int i = 0; i < Array4.Length; i++)
                        {
                            if (Array4[i] % 2 == 0) 
                            
                           {
                                evenCount++;
                                    }
                        }
                        int[] evenArr = new int[evenCount];
                        for (int i = 0,j = 0; i < Array4.Length; i++)
                        {
                            if (Array4[i] % 2 == 0)
                            {
                                evenArr[j++] = Array4[i];
                            }
                        }
                        Console.WriteLine(String.Join(", ", evenArr));
                    }
                    else
                    {
                        Console.WriteLine("The number is not in the specified range, try again!");
                    }

                    break;

                case 5:
                    Random rand3 = new Random();
                    Console.WriteLine("Enter the size of the array: ");
                    size = int.Parse(Console.ReadLine());
                        int[] Array5 = new int[size];
                        for (int i = 0; i < Array5.Length; i++)
                        {
                            Array5[i] = rand3.Next(20);
                        }
                        Console.WriteLine(String.Join(",", Array5));
                    
                    for (int i =0; i < Array5.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Array5[i] = 0;
                        }
                    }
                    Console.WriteLine(String.Join(", ", Array5));

                    break;
                case 6:
                    string[] Array6 = { "Ben","Alex","Katty","Spenser","Sam","Jimmy" };
                    string s;
                    Console.WriteLine(String.Join(", ", Array6));
                    for (int i = 0; i < Array6.Length - 1; i++)
                    {
                        for (int j = i; j >= 0; j--)
                            if (String.Compare(Array6[j], Array6[j + 1]) > 0) 
                            {
                                s = Array6[j];
                                Array6[j] = Array6[j + 1];
                                Array6[j + 1] = s;
                            }
                    }
                    Console.WriteLine("Sorted array: ");
                    Console.WriteLine(String.Join(", ", Array6));
                    break;
                case 7:
                    Random rand4 = new Random();
                    Console.WriteLine("Enter the size of the array: ");
                    size = int.Parse(Console.ReadLine());
                    int[] Array7 = new int[size];
                    for (int i = 0; i < Array7.Length; i++)
                    {
                        Array7[i] = rand4.Next(20);
                    }
                    Console.WriteLine(String.Join(",", Array7));

                    for (int i = 0; i < Array7.Length; i++)
                        for (int j = 0; j < Array7.Length - i - 1; j++)
                        {
                            if (Array7[j] > Array7[j + 1])
                            {
                                int temp = Array7[j];
                                Array7[j] = Array7[j + 1];
                                Array7[j + 1] = temp;
                            }
                        }
                    Console.WriteLine(String.Join(",", Array7));
                    break;
                case 8:
                    int[,] Array81 = new int[3, 4]
                    {
                        {1,0,0,0 },
                        {0, 1, 0,0 },
                        {0, 0, 0, 0 },

                    };
                    int[,] Array82 = new int[4, 3]
                    {
                        {1,2,3 },
                        {1,1,1},
                        {0,0,0},
                        {2,1,0 },

                    };
                    int[,] resultMatrix = new int[3, 3];
                    for (int i = 0; i < Array81.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array82.GetLength(1); j++)
                        {
                            for (int k = 0; k < Array82.GetLength(0); k++)
                            {
                                resultMatrix[i, j] += Array81[i, k] * Array82[k, j];
                            }
                            Console.Write(resultMatrix[i, j] + ", ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 9:
                    int[,] Array9 = new int[4, 3]
                    {
                        {1,2,3 },
                        {1,1,1},
                        {9,8,7},
                        {2,1,3 },

                    };
                    sum = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += Array9 [i,j];
                         }
                    }
                    Console.WriteLine("The sum of the matrix elements: " + sum);
                    break;
                case 10:
                    int[,] Array10 = new int[3, 3]
                    {
                        {1,2,3 },
                        {1,1,1},
                        {9,8,7},
                    };
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (i == j)
                            {
                                Console.WriteLine( Array10[i, j]);
                            }
                        }
                    }
                    break;
                case 11:
                    int[,] Array11 = new int[3, 3]
                    {
                        {1,2,3 },
                        {1,1,1},
                        {9,8,7},
                    };
                    for (int i = 0; i < Array11.GetLength(0); i++)
                    {
                        for (int j = 0; j < Array11.GetLength(1); j++)
                        {
                            Console.Write(Array11[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Sorted array:");
                    int row, col;
                 

                    for (col = 0; col < 3; ++col)
                    {
                        for (row = 1; row < 3; ++row)
                        {
                            if (Array11[row,col] < Array11[row - 1,col])
                            {
                                int tmp = Array11[row,col];
                                Array11[row,col] = Array11[row - 1,col];
                                Array11[row - 1,col] = tmp;
                                row = 0;
                            }
                        }
                    }

                    for (row = 0; row < 3; ++row)
                    {
                        for (col = 0; col < 3; ++col)
                        {
                            Console.Write(Array11[row,col]);
                            Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;
                    
        }
            Console.ReadKey();
        }
        
    }
}
