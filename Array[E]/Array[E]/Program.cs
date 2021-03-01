using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_E_
{
    class Account
    {
        private int accountNumber;
        private string accountName;

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public void PrintAccount()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}",this.accountNumber,this.AccountName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //1. Single dimensional array
            //2. Multi-dimensional array
            //3. Jagged array

            //Single dimensional array

            //int[] array= new int[3];
            //array[0] = 20;
            //array[1] = 30;
            //array[2] = 40;
            //Console.WriteLine(array[3]);//Error

            //int[] array = new int[3] { 5, 7, 8 };
            //int[] array = new int[] { 5, 7, 8 ,10};
            //int[] array = { 5, 7, 8, 10 };

            //for (int i=0;i<array.Length;i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Multi-dimensional
            //int[,] array = new int[2,3];
            //array[0, 0] = 10;
            //array[0, 1] = 20;
            //array[0, 2] = 30;

            //array[1, 0] = 40;
            //array[1, 1] = 50;
            //array[1, 2] = 60;

            //Console.WriteLine(array[1,1]);
            //int[,] array = new int[2, 3] { 
            //                                 { 1,2,3},
            //                                 { 4,5,6} 
            //                             };

            //int[,] array = new int[,] {
            //                                 { 1,2,3},
            //                                 { 4,5,6}
            //                             };

            //int[,] array =  {
            //                    { 1,2,3},
            //                    { 4,5,6}
            //                };

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Jagged array

            //int[][] array = new int[2][];
            //array[0] = new int[3] { 1,2,3};
            //array[1] = new int[2] { 4, 5 };
            //Console.WriteLine(array[1][0]);

            //int[][] array = new int[2][] {
            //                                new int[]{ 1,2,3},
            //                                new int[]{4,5}
            //                            };
            //int[][] array = new int[][] {
            //                                new int[]{ 1,2,3},
            //                                new int[]{4,5}
            //                            };

            //int[][] array = {
            //                    new int[]{ 1,2,3},
            //                    new int[]{4,5}
            //                 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        Console.Write(array[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach(int[] items in array)
            //{
            //    foreach(int item in items)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Array of objects
            Account[] accounts = new Account[2];
            Account account1 = new Account() { AccountNumber = 1001, AccountName = "Shakib" };
            accounts[0] = account1;
            accounts[1] = new Account() { AccountNumber = 2002, AccountName = "Tamim" };
            accounts[1].PrintAccount();
        }
    }
}
