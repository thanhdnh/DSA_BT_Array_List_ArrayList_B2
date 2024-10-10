using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
internal class Program
{
    static Array Union(Array a, Array b)
    {//1
        Array temp = Array.CreateInstance(typeof(int), a.Length + b.Length);
        int index = 0;
        for (int i = 0; i < a.Length; i++)
        {
            temp.SetValue(a.GetValue(i), index++);
        }
        for (int i = 0; i < b.Length; i++)
        {
            if (Array.IndexOf(a, b.GetValue(i)) < 0)
            {
                temp.SetValue(b.GetValue(i), index++);
            }

        }
        Array union = Array.CreateInstance(typeof(int), index);
        for (int i = 0; i < index; i++)
        {
            union.SetValue(temp.GetValue(i), i);
        }
        return union;
    }
    static Array Intersection(Array a, Array b)
    {//2
        int sophantugiao = 0;
        Array giaoArray = Array.CreateInstance(typeof(int), (int)Math.Min(a.Length, b.Length));

        for (int i = 0; i < a.Length; i++)
        {
            int giatria = (int)a.GetValue(i);
            for (int j = 0; j < b.Length; j++)
            {
                int giatrib = (int)b.GetValue(j);

                if (giatria == giatrib)
                {
                    giaoArray.SetValue(giatria, sophantugiao);
                    sophantugiao++;
                }
            }
        }
        Array final = Array.CreateInstance(typeof(int), sophantugiao);
        for (int i = 0; i < sophantugiao; i++)
            final.SetValue(giaoArray.GetValue(i), i);
        return final;
    }
    static Array Subtraction(Array a, Array b)
    {//3
        Array temp = Array.CreateInstance(typeof(int), a.Length);
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (Array.IndexOf(b, a.GetValue(i)) < 0)
            {
                temp.SetValue(a.GetValue(i), count++);
            }
        }
        Array subtracted = Array.CreateInstance(typeof(int), count);
        for (int i = 0; i < count; i++)
        {
            subtracted.SetValue(temp.GetValue(i), i);
        }
        return subtracted;
    }
    static List<int> Union(List<int> a, List<int> b)
    {//4
        List<int> temp = new List<int>();
        int index = 0;
        for (int i = 0; i < a.Count; i++)
        {
            temp.Add(a[i]);
        }
        for (int i = 0; i < b.Count; i++)
        {
            if (Array.IndexOf(a.ToArray(), b[i]) < 0)
            {
                temp.Add(b[i]);
            }

        }
        return temp;
    }
    static List<int> Intersection(List<int> a, List<int> b)
    {//5
        List<int> giaoArray = new List<int>();

        for (int i = 0; i < a.Count; i++)
        {
            int giatria = a[i];
            for (int j = 0; j < b.Count; j++)
            {
                int giatrib = b[j];
                if (giatria == giatrib)
                {
                    giaoArray.Add(giatria);
                }
            }
        }
        return giaoArray;
    }
    static List<int> Subtraction(List<int> a, List<int> b)
    {//6
        List<int> temp = new List<int>();
        int count = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (Array.IndexOf(b.ToArray(), a[i]) < 0)
            {
                temp.Add(a[i]);
            }
        }
        return temp;
    }
    static ArrayList Union(ArrayList a, ArrayList b)
    {//7
        return null;
    }
    static ArrayList Intersection(ArrayList a, ArrayList b)
    {//8
        return null;
    }
    static ArrayList Subtraction(ArrayList a, ArrayList b)
    {//9
        return null;
    }
    private static void Main(string[] args)
    {
        Array arA = Array.CreateInstance(typeof(int), 4);
        Array arB = Array.CreateInstance(typeof(int), 3);
        arA.SetValue(2, 0); arA.SetValue(3, 1); arA.SetValue(5, 2); arA.SetValue(11, 3);
        arB.SetValue(6, 0); arB.SetValue(8, 1); arB.SetValue(11, 2);
        /*Array aunion = Union(arA, arB);
        Array aintersection = Intersection(arA, arB);
        Array asubtraction = Subtraction(arA, arB);
        Console.WriteLine("\nUnion: ");
        foreach (int val in aunion)
            Console.Write(" " + val);
        Console.WriteLine("\nIntersection: ");
        foreach (int val in aintersection)
            Console.Write(" " + val);
        Console.WriteLine("\nSubtraction: ");
        foreach (int val in asubtraction)
            Console.Write(" " + val);*/

        List<int> lA = new List<int> { 2, 3, 5, 11 };
        List<int> lB = new List<int> { 6, 8, 11 };
        List<int> lunion = Union(lA, lB);
        List<int> lintersection = Intersection(lA, lB);
        List<int> lsubtraction = Subtraction(lA, lB);
        Console.WriteLine("\nUnion: ");
        foreach (int val in lunion)
            Console.Write(" " + val);
        Console.WriteLine("\nIntersection: ");
        foreach (int val in lintersection)
            Console.Write(" " + val);
        Console.WriteLine("\nSubtraction: ");
        foreach (int val in lsubtraction)
            Console.Write(" " + val);

        ArrayList alA = new ArrayList() { 2, 3, 5, 11 };
        ArrayList alB = new ArrayList() { 6, 8, 11 };

        //Random rand = new Random();
        //rand.Next(10, 99);

        /*Array myarr = Array.CreateInstance(typeof(int), 5);

        for (int i = 0; i < myarr.Length; i++)
            myarr.SetValue(rand.Next(10, 99), i);

        foreach (int a in myarr)
            Console.WriteLine(a);*/
        /*Array myarr2 = Array.CreateInstance(typeof(int), 
                            new int[]{2, 3}, new int[]{1, 1});
        for(int i=myarr2.GetLowerBound(0);i<=myarr2.GetUpperBound(0); i++)
            for(int j=myarr2.GetLowerBound(1); j<=myarr2.GetUpperBound(1); j++)
                myarr2.SetValue(rand.Next(10, 99), i, j);
        
        for(int i=myarr2.GetLowerBound(0);i<=myarr2.GetUpperBound(0); i++){
            for(int j=myarr2.GetLowerBound(1); j<=myarr2.GetUpperBound(1); j++)
                Console.Write("{0, 3}", myarr2.GetValue(i, j));
            Console.WriteLine();
        }

        List<int> list = new List<int>();
        list.Add(22);
        list.AddRange(new int[]{33, 44});
        foreach(int a in list)
            Console.WriteLine(a);

        ArrayList arlist = new ArrayList();
        arlist.Add(22);
        arlist.AddRange(new int[]{33, 44});
        foreach(int a in arlist)
            Console.WriteLine(a);*/

        Console.ReadLine();
    }
}