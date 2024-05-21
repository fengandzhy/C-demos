using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Run();
            Console.ReadKey();

        }
    }

    class Person{
        public void Run(){
            Console.WriteLine("Person can run!");
        }
    }

    class Student: Person{

    }
}
