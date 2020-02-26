using System;
using System.Collections.Generic;
using System.Text;

namespace _01
{
    class Produkt
    {
        private string name { get; set; }
        private int amount { get; set; }
        private float cost { get; set; }


        public Produkt()
        {
            this.name = "Название";
            this.amount = 0;
            this.cost = 0;
        }
        public Produkt(string name, int amount, float cost)
        {
            this.name = name;
            this.amount = amount;
            this.cost = cost;

        }
        public string Name
        {
            set
            {
                name = value;
            }
        }
        public int Amount
        {
            set
            {
                amount = value;
            }
        }
        public float Cost
        {
            set
            {
                cost = Convert.ToSingle(value);
            }
        }
        public void tovar()

        {
            Console.Write("Введите наименование товара ");
            name = Console.ReadLine();
            Console.Write("Введите количество товара ");
            amount = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость ");
            cost = int.Parse(Console.ReadLine());

        }
        public void GetInfo()
        {
            Console.WriteLine("Наименование - {0}; количество - {1}; стоимость - {2}.", name, amount, cost);
        }

    }
}

