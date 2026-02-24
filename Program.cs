using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
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
        }
        // static bool ispolindrom1(int[] arr)
        // {
        //    int left=0, right=arr.Length-1;
        //     bool ispolindrom = true;
        //     while(left < right && ispolindrom)
        //     {
        //         if (arr[left] != arr[right])
        //             ispolindrom = false;
        //         left++;
        //         right--;
        //     }
        //     return ispolindrom;
        // }

        //static void rotatearray(int[] arr)
        // {
        //     int tmp = arr[0];
        //     for (int i = 1; i < arr.Length; i++)
        //         arr[i - 1] = arr[i];

        //     arr[arr.Length-1] = tmp;

        // }
        // static void copyarray()
        // {
        // int[] arr1 = { 1, 2, 3, 4, 5 }; //מערך מקור
        // int[] arr2 = new int[arr1.Length]; //יצירת מערך חדש בגודל זהה למערך המקורי
        //     // העתקת הערכים מהמערך המקורי למערך החדש
        // for (int i = 0; i<arr1.Length; i++)
        // {
        //    arr2[i] = arr1[i];
        // }
        // }

        // static void maximuminarray()
        // {
        // int[] arr = { 23, 28, 31 };

        // int max = arr[0]; // משתנה לאחסון הערך המקסימלי

        // for (int i = 1; i<arr.Length; i++)
        // {
        //  if (arr[i] > max)
        //        {
        //       max = arr[i];
        //       }
        //     }
        // }



        // static void maxindex()
        // {
        //     int[] temperatures = { 23, 28, 31, 26, 30 };

        //     // משתנים לאחסון הערך המקסימלי ואינדקסו
        //     int max = temperatures[0];
        //     int maxIndex = 0;

        //     for (int i = 1; i < temperatures.Length; i++)
        //     {
        //         if (temperatures[i] > max)
        //         {
        //             max = temperatures[i];
        //             maxIndex = i;
        //         }
        //     }

        //     Console.WriteLine("The highest temperature is: " + max);
        //     Console.WriteLine("It occurred on day number: " + (maxIndex + 1));
        // }


        // static void reversearr()
        // {
        //     int[] arr = { 1, 2, 3, 4, 5 }; //מערך מקור

        //     int[] reversed = new int[arr.Length]; //יצירת מערך חדש בגודל זהה

        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         reversed[i] = arr[arr.Length - 1 - i];
        //     }
        //     printarray(reversed);
        // }


        //static void task3()
        //{
        //    int[] arr;
        //    int sum = 0;
        //    double avg = 0;
        //    while (true)
        //    {
        //        Console.WriteLine("pick a number for the array,please enter a valid one");
        //        int size = int.Parse(Console.ReadLine());
        //        if (size > 0)
        //        {
        //            arr = new int[size];
        //            break;
        //        }
        //        else Console.WriteLine("invalid,write again");
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());
        //    }
        //    //sum
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    //avg
        //    avg = (double)sum / arr.Length;
        //    //max
        //    int max = arr[0];
        //    int maxind = 0;
        //    int min = arr[0];
        //    int minind = 0;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //            maxind = i;
        //        }

        //    }
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //            minind = i;
        //        }
        //    }
        //    int[] counter = new int[max];
        //    for (int i = 0; i < counter.Length; i++)
        //          { 
        //                counter[i]=0;
        //            }
        //            for(int i=0;i<counter.Length;i++)
        //            {
        //                counter[arr[i]-1]++;
        //            }
        //            printarray(arr);
        //            printarray(counter);

        //        }


        //static void task4()
        //{
        //    int[] arr=new int[10];
        //    int countp = 0;
        //    int countn = 0;
        //    int count0 = 0;
        //    Random rnd=new Random();
        //    for (int i = 0;i < arr.Length;i++)
        //    {
        //        arr[i] = rnd.Next(-11,11);
        //    }
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //            countp++;
        //        else if (arr[i] < 0) countn++;
        //        else count0++;
        //    }
        //        printarray(arr);
        //    Console.WriteLine(countp);
        //    Console.WriteLine(countn);
        //    Console.WriteLine(count0);
        //}

        //        static void task5()
        ////fibunachi
        //{
        //    int[] arr = new int[20];
        //    arr[0] = 1;
        //    arr[1] = 1;
        //    for(int i=2;i<arr.Length;i++)
        //    {
        //        arr[i] = arr[i - 2] + arr[i-1];
        //    }
        //}


        //static void myfunc2()
        //if the number exists you check it and tells him to try again
        //{
        //    int[] arr= new int[10]; 
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("enter a full number");
        //        int num = int.Parse(Console.ReadLine());
        //        bool exists = false;
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (arr[j] == num)
        //            {
        //                exists = true;
        //                break;
        //            }
        //        }
        //        if (exists)
        //        {
        //            Console.WriteLine("Number already exists, try again.");
        //            i--;
        //        }
        //        else arr[i] = num;
        //    }
        //    printarray(arr);
        //}

//        static void myfunc3(int[] arr1, int[] arr2)
//// in this function we take 2 of the arrays and take the numbers that are the same in both arrays
//        {
//            bool flag = false;
//            int counter = 0;
//            for (int i = 0;i< arr1.Length;i++)
//            {
//                flag = false;
//                for(int j=0;j<arr2.Length;j++)
//                {
//                    if (arr1[i]==arr2[j])
//                    {
//                    flag = true;
//                    break;
//                    }
                        
//                }
//                if (flag==true) counter++;    
//            }
//            int[] newarr= new int[counter];
//            int index = 0;
//            for (int i = 0; i < arr1.Length; i++)
//            {
//                flag = false;
//                for (int j = 0; j < arr2.Length; j++)
//                {
//                    if (arr1[i] == arr2[j])
//                    {
//                        flag = true;
//                        break;
//                    }

//                }
//                if (flag == true)
//                    newarr[index++] = arr1[i];
//            }
//            printarray(newarr);
//        }
        


        //static void myfunc4(int[] arr1, int[] arr2)
        //in this function we take 2 of the arrays and take the numbers that are diffrent in both arrays
        //{
        //    bool flag = false;
        //    int counter = 0;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        flag = false;
        //        for (int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr1[i] == arr2[j])
        //            {
        //                flag = true;
        //                break;
        //            }
        //        }
        //        if (flag != true) counter++;
        //    }
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        flag = false;
        //        for (int j = 0; j < arr1.Length; j++)
        //        {
        //            if (arr2[i] == arr1[j])
        //            {
        //                flag = true;
        //                break;
        //            }
        //        }
        //        if (flag != true) counter++;
        //    }
        //    int[] newarr = new int[counter];
        //    int index = 0;
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        flag = false;
        //        for (int j = 0; j < arr2.Length; j++)
        //        {
        //            if (arr1[i] == arr2[j])
        //            {
        //                flag = true;
        //                break;
        //            }
        //        }
        //        if (flag != true) newarr[index++] = arr1[i];
        //    }
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        flag = false;
        //        for (int j = 0; j < arr1.Length; j++)
        //        {
        //            if (arr2[i] == arr1[j])
        //            {
        //                flag = true;
        //                break;
        //            }
        //        }
        //        if (flag != true) newarr[index++] = arr2[i];
        //    }
        //    printarray(newarr);
        //}

        static void task8()
        {
            int[] arr=new int[10];
            int counter1 = 0;
            int counter2 = 0;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length;i++)
            {
              arr[i] = rnd.Next(9,100);
            }
            for (int i = 0;i < arr.Length-1;i++)
            {
                if (arr[i] == arr[i+1])
                    counter1++;
                else if (arr[i] != arr[i + 1])
                    counter2++;
            }
            printarray(arr);
            if (counter1 == 10)
                Console.WriteLine("this array numbers are all even");
            if (counter2 == 10)
                Console.WriteLine("this array numbers are all diffrent");
            else Console.WriteLine("none of them");
        }

        static void Main(string[] args)
        {
           
            int[] arr1 = { 1, 2,6,9,2,8,10,11,12,13,14,15};
            int[] arr2 = { 1, 6, 8, 2, 9, 0 };   
           task8();
        }
    }
}
