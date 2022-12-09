using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Auditory__09._12._22_
{
    internal static class Program
    {
        //Вопрос 6:
        //Опишите разницу между public и protected. Приведите примеры.
        //Модификатор public делает члены класса видимыми для всех наследуемых классов и позволяет
        //наследникам использовать поля,свойства и методы родительского класса так, как если бы они
        //были определены в самом наследнике.
        //Модификатор protected делает члены класса видимыми для наследуемых классов, но наследники
        //не могут использовать методы, поля и свойства родительского класса как свои.
        //Пример:
        private class A
        {
            public A() { }
            public int id { get; set; }
            protected string name { get; set; }
            public void SetID(int value)
            {
                id = value;
            }
            protected void SetName(string s)
            {
                name = s;
            }
        }
        private class B : A
        {
            public B() { }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Вопрос 6:
            B b = new B();
            b.id = 0;
            b.SetID(1);
            //b.name = "Jacob";
            //b.SetName("Jhone");

        }
    }
}
