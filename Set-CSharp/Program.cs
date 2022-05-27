using System;
using Set_CSharp;

class Program
{
    static void Main()
    {
        MySet<int> mySet = new MySet<int>(4);
        MySet<int> mySet2 = new MySet<int>(1);

        mySet.Add(5);
        mySet.Add(6);
        mySet.Add(8);
        mySet.Add(19);
        
        mySet2.Add(2);
        mySet2.Add(3);
        mySet2.Add(4);
        mySet2.Add(5);

        MySet<int> union = mySet.Union(mySet2);
        MySet<int> intersection = mySet.Intersection(mySet2);
        MySet<int> difference = mySet.Difference(mySet2);
    }
}