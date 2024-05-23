using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    /**
     * 在 C# 中，当实现接口的方法时，override 关键字不是必需的，这是因为接口只定义了行为的规范而不提供任何实现。
     * 所以，当类实现一个接口时，它必须提供所有接口方法的具体实现，但这些实现并不是“覆盖”任何现有的行为，因为接口本身并不包含实现。
     * 这与继承基类中的 virtual 或 abstract 方法并使用 override 关键字来修改它们的行为不同。
     * 
     *      
     */

    class Light : IUsb
    {
        public void work()
        {
            Console.WriteLine("台灯亮了!");
        }
    }

    interface IUsb
    {
        void work();
    }
}
