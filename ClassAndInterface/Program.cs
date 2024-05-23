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
            Person person = new Student();
            person.Run();
            Console.ReadKey();

        }
    }
    /**
     * 
     * 
     * 在C#中，如果子类方法没有明确使用 override 关键字，那么它不会覆盖基类中的虚方法，而是隐藏它。
     * 这种隐藏是在编译时处理的，基于变量的声明类型而非其运行时类型。因此，当你的代码执行到下面这行时：   
     * 虽然 person 变量实际上引用的是一个 Student 对象，但是因为它的声明类型是 Person，所以调用的是 Person 类的 Run 方法。
     * 
     * 在 Java 中，所有的方法默认情况下都可以被覆盖，除非它们被声明为 final。当子类中声明了一个和基类中具有相同名称和参数的方法时，
     * 它会默认覆盖基类中的方法（假设基类方法没有被声明为 final），不需要使用任何特殊关键字。如果你希望在子类中隐藏而非覆盖方法，你必须显式地改变方法签名，或使用不同的方法名称。
     * 
     * 在 C# 中，如果你没有显式指定 override 关键字，则子类的方法会隐藏（而非覆盖）基类的方法，这种隐藏是静态的，基于变量的编译时类型。
     * 要在C#中覆盖基类的方法，必须在基类方法上使用 virtual 关键字，并在子类方法上使用 override 关键字。
     * 
     */
    class Person
    {
        public void Run(){
            Console.WriteLine("Person can run!");
        }
    }

    class Student: Person{
        public void Run()
        {
            Console.WriteLine("Student can run!");
        }
    }
}
