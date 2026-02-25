using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void printarray(int[] arr)
        //פעולה זו עוברת על מערך ומדפיסה אותה
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0) Console.Write("{ ");
                Console.Write(arr[i] + " ");
                if (i == arr.Length - 1) Console.Write("}");
            }
            Console.WriteLine();
        }
        //מערך צוברים

        //static double[] buildmilkarray(int numofcows)
        //{
        //    double[] arr = new double[numofcows];
        //    for (int day = 1; day <= 5; day++)
        //    {
        //        for (int i = 1; i <=numofcows; i++)
        //        {
        //            Console.Write("day" + day + "cow" + i + ":");
        //            arr[i-1]+=double.Parse(Console.ReadLine());
        //        }
        //    }
        //    return arr;
            //לא לשכוח בmain 
            //int num = int.Parse(Console.ReadLine());
            //double[] milk = buildmilkarray(num);
            //printarray(milk);
        //}

        //static void Task1()
        //{
        //    Random rnd = new Random();
        //    int[] counter=new int[6];
        //    for (int i = 0;i < 20;i++)
        //    {
        //        int num=rnd.Next(1,7);
        //        Console.Write(num + "  ");
        //        counter[num-1]++;
        //    }
        //    printarray(counter);
        //}


        //static void task2()
        //כמה פעמים כל אות מופיעה במערך
        //{
           
        //    int[] arr = { 'a', 'b', 'c', 'a', 'b', 'a' };
        //    int max=0;
        //    int[] counter = new int[26];
        //    for(int i = 0;i < arr.Length;i++)
        //    {
        //        counter[arr[i]-'a']++;
        //    }
        //    printarray(counter);
        //    for(int i = 0; i < counter.Length;i++)
        //    {
        //        if (counter[i] > max)
        //            max=i;
        //    }
        //    Console.Write((char)(max+'a'));
        //}



        //last \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //static void task1()
        //{
        //    Random rnd = new Random();
        //    int count = 0;
        //    for (int i = 0;i<=10;i++)
        //    {
        //       int num=rnd.Next(0,10);
        //        Console.WriteLine(num);
        //        if (num == 3) count++;
        //    }
        //    Console.WriteLine(count);
        //}

        //static void task3()
        //    //הורדת כפילויות
        //{
        //    Random rnd = new Random();
        //    int[] arr = new int[10];
        //    int[] counter= new int[10];
        //    int[] newarr = new int[arr.Length];
        //    for (int i = 0;i < arr.Length;i++)
        //    {
        //        arr[i] = rnd.Next(0, 10);
        //    }
        //    printarray(arr);
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newarr[i] = arr[i];
        //    }
        //        for (int i = 0; i < arr.Length; i++)
        //    {
        //        counter[arr[i]]++;
        //    }
        //        printarray(counter);
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if (counter[arr[i]] > 1)
        //            counter[arr[i]] = -99;
        //        else if (counter[arr[i]] != 1)
        //            newarr[i] = -1;
        //    }
        //      printarray(newarr);
        //}

        //static void task4()
        //{
        //    int[] counter = new int[26];
        //    char ch=char.Parse(Console.ReadLine());
        //    while (ch!='.')
        //    {
        //        if(ch>'z' || ch<'a')
        //            Console.WriteLine("invalid code");
        //        else counter[ch-'a']++;  
        //        ch = char.Parse(Console.ReadLine());
        //    }
          
        //    for(int i = 0;i<counter.Length;i++)
        //    {
        //        Console.WriteLine("for this char" + (char)(i + 'a') + ":" + counter[i]+"times");
        //    }
        //}  

        //static void task6()
        //{
        //    int[] counter = new int[10];
        //    int choice;
        //    Console.WriteLine("please a number from 1-10 as you please");
        //    choice =int.Parse(Console.ReadLine());
        //    int maxvotes = counter[choice];
        //    int maxind = choice;
        //    counter[choice]++;
        //    int numofworkers = 1;
        //    while (choice!=0)
        //    {
        //        Console.WriteLine("please a number from 1-10 as you please,enter 0 to exit");
        //        choice =int.Parse(Console.ReadLine());
        //        counter[choice]++;
        //        numofworkers++;
        //        if (counter[choice]>maxvotes)
        //        {
        //            maxvotes=counter[choice];
        //            maxind = choice;
        //        }
        //    }
        //    printarray(counter);
        //    Console.WriteLine("the max votes is "+maxvotes+" with th ind of "+maxind);
        //}
      

        //static void nyfunc()
//0 are in the end
        //{
        //    Random rnd = new Random();
        //    int[] arr = new int[15];
        //    int[] newArr = new int[arr.Length];
        //    int j = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = rnd.Next(0, 6);
        //    }

        //    printarray(arr);

        //    // מעתיקים רק את הלא-אפסים
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] != 0)
        //        {
        //            newArr[j] = arr[i];
        //            j++;
        //        }
        //    }

        //    // השאר כבר 0 אוטומטית
        //    printarray(newArr);
        //  }

        //static void myfunc()
            //תוכנית זו בודקת אם ישנו ילד שהשם שלו כבר ב 8 שמות המצורפים לכיתה
        //{
        //    string[] names= new string[4];
        //    for (int i = 0;i < names.Length-1;i++)
        //    {
        //        Console.WriteLine("enter a name");
        //        names[i] = Console.ReadLine();
        //    }
        //    Console.WriteLine("enter another name");
        //    string name1= Console.ReadLine();
        //    for (int i = 0; i < names.Length-1; i++)
        //    {
        //        if(names[i] != name1)
        //        {
        //            names[names.Length]=name1;
        //            printarray(names);
        //        }
                  
        //        else Console.WriteLine("cannot join ");

        //    }
        //}

        static void order()
        {
            int[] sum=new int[3];
            bool flag = true;
            Console.WriteLine("enter 1 for pizza ");
            Console.WriteLine("enter 2 for pasta  ");
            Console.WriteLine("enter 3 for salad  ");
            int choice =int.Parse(Console.ReadLine());
            Console.WriteLine("what is the amount of the food");
            int amount = int.Parse(Console.ReadLine());
            if(choice>0&&choice<4)
            {
                if (choice == 1) sum[0] += amount;
                else if(choice == 2) sum[1] += amount;
                else sum[2] += amount;
            }
            else Console.WriteLine("invalid code");
            int max = sum[0];
            int min = sum[0];
            while (flag)
            {
                Console.WriteLine("enter 1 for pizza enter 0 to exit ");
                Console.WriteLine("enter 2 for pasta  ");
                Console.WriteLine("enter 3 for salad  ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    break;
                Console.WriteLine("what is the amount of the food ");
                amount = int.Parse(Console.ReadLine());

                if (choice > 0 && choice < 4)
                {
                    if (choice == 1) sum[0] += amount;
                    else if (choice == 2) sum[1] += amount;
                    else sum[2] += amount;
                }
            }
                Console.WriteLine("pizza:"+ sum[0]);
                Console.WriteLine("pasta:" + sum[1]);
                Console.WriteLine("salad:" + sum[2]);
                for (int i = 0; i < sum.Length; i++)
                {
                    if (sum[i] > max)
                    {
                         max = sum[i];

                    }
                    if (sum[i] < min)
                    {
                        min = sum[i];
                    }
                }
                if (max == sum[0])
                    Console.WriteLine("pizza max:" + sum[0]);
                else if (max == sum[1])
                    Console.WriteLine("pasta max:" + sum[1]);
                else Console.WriteLine("salad max:" + sum[2]);

                if (min == sum[0])
                    Console.WriteLine("pizza min:" + sum[0]);
                else if (min == sum[1])
                    Console.WriteLine("pasta min:" + sum[1]);
                else
                    Console.WriteLine("salad min:" + sum[2]);

            
        }
            static void Main(string[] args)
        {
            order();
          
        }
    }
}
