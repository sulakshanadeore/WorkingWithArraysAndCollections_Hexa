using LibraryForCollections;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] intarr = new int[5] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < intarr.Length; i++)
        {
            Console.WriteLine(intarr[i]);
        }
        Console.WriteLine("--------------------");
        int[] intarr2 = new int[5];
        intarr2[0] = 10;
        intarr2[1] = 12;
        intarr2[2] = 13;
        intarr2[3] = 14; 
        intarr2[4] = 15;

        var j = 90; //Implicitly typed variable, only integers would be allowed henceforth for i as variable
     foreach (var item in intarr2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------------");

        Array a  =Array.CreateInstance(typeof(int), 5);
        //a[0] = 100;
        //a[1] = 101;
        //a[2] = 102;
        a.SetValue(100, 0);
        a.SetValue( 101,1);
        a.SetValue( 105,4);

        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------");
        string[] strs = new string[5] {"Hello","Welcome","Here","To","C#" };
        foreach (var item in strs)
        {
            Console.WriteLine($"Length of {item}   =  {item.Length}");
        }
        Console.WriteLine("--------------------------------------------");

        string[] str1 = new string[2] { "Hello", "Welcome" };
        foreach (var item in str1)
        {
            char[] c= item.ToCharArray();
            foreach (var item1 in c)
            {
                Console.WriteLine(item1);
            }

        }













    }
}