using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stp4list
{
    public class example
    {
        internal class Spisok
        {
            public int value;
            public Spisok Next, Previous;
            private Spisok First, Last; //первый и последний узел списка, следит за началом и концом списка
            public int count;
            public Spisok()//с пом него создаем список в мейне
            {
                count = 0;
                First = null; 
                Last = null;
            }
            public Spisok(int value)
            { this.value = value; }
            public void AddFirst(int value)
            {
                Spisok a = new Spisok(value);
                Spisok Temp = First;
                First = a;
                First.Next = Temp;//создаем из 0 стрелку в 1
                    if (count==0)
                    {
                        Last= First;
                    }
                    else
                    {
                     Temp.Previous = First;   
                    }
                count++;
            }

            public void AddLast(int value)
            {
                Spisok a = new Spisok(value);
               
                if (count == 0)
                {
                    First = a;
                }
                else
                {
                    Last.Next = a;
                    a.Previous = Last;
                }
                count++;
                Last = a;
            }
            public void RemoveFirst()
            {
                if (count!=0)
                {
                    First= First.Next;
                    count--;
                    if (count==0)
                    {
                        Last = null;
                    }
                }
                else { First.Previous = null; }
            }

            public void RemoveLast()
            {
                if (count != 0)
                {
                    if (count == 1)
                    {
                        First = null;
                        Last = null;
                    }
                }
                else 
                {
                    Last.Previous.Next = null; //было 3 4, сначала переходим от 4 к 3, и у 3 берем поле .next, т.е. стираем стрелку от 3 к 4 
                    Last = Last.Previous;
                }
                count--;
            }


        }
        static void Main(string[] args)
        {
            Spisok b= new Spisok();
            for (int i=1; i<=10; i++)
            {
                b.AddFirst(i);//создаем список, мы добавляем в начало, получится список от 10 до 1
            }
            Console.WriteLine(b.count);//добавили 10 элементов
            for (int i = 1; i <= 4; i++)
            {
                b.RemoveLast();
            }
            Console.WriteLine(b.count); 
            Console.ReadKey();
        }
    }
}
