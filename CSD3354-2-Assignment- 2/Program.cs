using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_Assignment__2
    //ramandeep singh c0732140
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }

    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");


        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }
    }
}