using LibraryForCollections;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //WorkingWithArrays();
        ArrayList alist = new ArrayList(1);//all data types data is allowed
        alist.Add(12.3f);
        alist.Add(23432.234d);
        alist.Add("Namita");
        alist.Add(true);
        alist.Add("Atul");
        alist.Add('B');

        foreach (var i in alist)
        {
            Console.WriteLine(i);//compiler has a load of checking the type of data, then taking it into var i and then printing it
        
        }
        alist.RemoveAt(4);//removes "Atul"
        ArrayList a2 = new ArrayList(10);
        a2.Add(1);
        a2.Add(2);
        a2.Add("Two");
        a2.Add('T');
        a2.Add(21);
        a2.Add(212); 
        a2.Add(new DateTime(2025,3,31));
        a2.Add(3424.34d);
        a2.Add(2234.3f);

        alist.AddRange(a2);//adds at last
        Console.WriteLine("After addrange on arraylist");
        foreach (var item in alist)
        {
            Console.WriteLine(item);
        }
        alist.Insert(3, "Welcome");//insert at position
        Console.WriteLine("After insert on arraylist");
        foreach (var item in alist)
        {
            Console.WriteLine(item);
        }
        alist.InsertRange(3, a2);

        Console.WriteLine("after insert range......");
        foreach (var item in alist)
        {
            Console.WriteLine(item);
        }
        //alist.Remove(12.3f);
        //alist.RemoveRange(0, 2);
        //Console.WriteLine("After removing....");
        //foreach (var item in alist)
        //{
        //    Console.WriteLine(item);
        //}








        //List<int> listobj = new List<int>(); //only ints allowed
        //listobj.Add(12);
        //listobj.Add(121);
        //listobj.Add(3312);
        //listobj.Add(122);
        //foreach (var item in listobj)// no checking datatype becoz evrything will be int
        //{
        //    Console.WriteLine(item);
        //}


    }

    private static void WorkingWithArrays()
    {
        int[] intarr = new int[5] { 91, 21, 13, 41, 75 };

        //Quick Sort
        Array.Sort(intarr);

        Array.Reverse(intarr);
        foreach (var item in intarr)
        {
            Console.WriteLine(item);
        }


        //  Array.Clear(intarr);
        //Console.WriteLine("After clear.....");
        //foreach (var item in intarr)
        //{
        //    Console.WriteLine(item);
        //}

        int[] copiedArr = new int[intarr.Length];
        Console.WriteLine("After copying...");
        //Array.Copy(intarr,copiedArr, intarr.Length); //copy all elements
        Array.Copy(intarr, copiedArr, 2);
        foreach (var item in copiedArr)
        {
            Console.WriteLine(item);
        }








        //   for (int i = 0; i < intarr.Length; i++)
        //   {
        //       Console.WriteLine(intarr[i]);
        //   }
        //   Console.WriteLine("--------------------");
        //   int[] intarr2 = new int[5];
        //   intarr2[0] = 10;
        //   intarr2[1] = 12;
        //   intarr2[2] = 13;
        //   intarr2[3] = 14; 
        //   intarr2[4] = 15;

        //   var j = 90; //Implicitly typed variable, only integers would be allowed henceforth for i as variable
        //foreach (var item in intarr2)
        //   {
        //       Console.WriteLine(item);
        //   }

        //   Console.WriteLine("---------------------------------");

        //   Array a  =Array.CreateInstance(typeof(int), 5);
        //   //a[0] = 100;
        //   //a[1] = 101;
        //   //a[2] = 102;
        //   a.SetValue(100, 0);
        //   a.SetValue( 101,1);
        //   a.SetValue( 105,4);
        //   //a.GetValue(0);
        //   foreach (var item in a)
        //   {
        //       Console.WriteLine(item);
        //   }
        //   Console.WriteLine("--------------------------------");
        //   string[] strs = new string[5] {"Hello","Welcome","Here","To","C#" };
        //   foreach (var item in strs)
        //   {
        //       Console.WriteLine($"Length of {item}   =  {item.Length}");
        //   }
        //   Console.WriteLine("--------------------------------------------");

        //   string[] str1 = new string[2] { "Hello", "Welcome" };
        //   foreach (var item in str1)
        //   {
        //       char[] c= item.ToCharArray();
        //       foreach (var item1 in c)
        //       {
        //           Console.WriteLine(item1);
        //       }

        //   }
    }
}