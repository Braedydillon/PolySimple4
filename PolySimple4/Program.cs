using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple4//When a method in a subclass has the same name as a mehtod in
                     // its base class, but we use the new keyword to hide it
{
    class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method");
        }
    }
    class Child : Parent
    {
        public new void Show()
        {
            Console.WriteLine("Child's Show Method");
        }
    }
        class Program
    {
        static void Main()
        {
            Parent obj1 = new Parent();
            obj1.Show();//Output: Parent's Show Method

            Child obj2 = new Child();
            obj2.Show(); // Output: Childs show Method

        }
    }
}
