using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_Assignment__2
    //ramandeep singh c0732140
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

  DelegateExcercises de = new DelegateExcercises();
de.Method2();
        }
    }
    public class DelegateExcercises
{
    public delegate void MyDelegate();

    void Method1()
    {
        Console.WriteLine("Method1");
        Console.ReadLine();
    }
    public void Method2()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
}
