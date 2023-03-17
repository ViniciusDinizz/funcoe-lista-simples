using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPestanalista
{
    internal class ListIten
    {
        public Item Begin { get; set; }
        public Item End { get; set; }

        public ListIten()
        {
            Begin = null;
            End = null;
        }

        public void Insert(Item value)
        {
            if (Empty())
            {
                Begin = value;
                End = value;
            }
            else
            {
                if (value.value <= Begin.value)
                {
                    InsertFirst(value);
                }
                else if (value.value >= End.value)
                { 
                    InsertLast(value);
                }
                else
                {
                    InsertMid(value);
                }
            }
        }

        public void InsertFirst(Item value)
        {
            value.next = Begin;
            Begin = value;
        }
        public void InsertMid(Item value)
        {
            value.next = Begin.next;
            Begin.next = value;
        }

        public void InsertLast(Item value)
        {
            End.next = value;
            End = value;
        }

        public void Find(Item Value)
        {
            if (Begin == null)
            {
                Console.WriteLine("Lista Vazia.");
            }
            else
            {
                Item aux = Begin;
                while (aux.next != null)
                {
                    Console.WriteLine($" {aux} ");
                    if (aux == Value)
                    {
                        Console.Write($" LocalizedValue: {Value} ");
                    }
                    aux = aux.next;
                }
            }
        }
        public bool Empty()
        {
            if (Begin == null && End == null) return true; return false;
        }

        public void Print()
        {
            if (Empty())
            {
                Console.WriteLine("Lista vazia.");
            }
            else
            {
                Item aux = Begin;
                while (aux != null)
                {
                    Console.Write($" {aux} ");
                    aux = aux.next;
                }
            }
        }

        public void Remove(Item value)
        {
            Item aux = Begin;
            while (aux != null) 
            {
                if(aux.next == value)
                {
                    aux.next = value.next;
                    break;
                }
                aux = aux.next;
            }
        }
    }
}
