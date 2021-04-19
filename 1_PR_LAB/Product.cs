/**************************************************************
--------------------------------------------------------------
Класс Product.сs
Группа П33
Разработчик: Крыштанов М.А.
Модифицирован: 19 апреля 2021 
--------------------------------------------------------------
***************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_PR_LAB
{
    class Product
    {
        private string Name;
        private int Amount;
        private float Cost;
        public Product()
        {
            Name = "";
            Amount = 0;
            Cost = 0;
        }
        public void ShowName()
        {
            Console.WriteLine("The current product name is {0}", Name);
        }
        public void ShowAmount()
        {
            Console.WriteLine("The current product amount = {0}", Amount);
        }
        public void ShowCost()
        {
            Console.WriteLine("The current product cost = {0}", Cost);
        }
        public string NAME
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int AMOUNT
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = value;
            }
        }
        public float COST
        {
            get
            {
                return Cost;
            }
            set
            {
                Cost = value;
            }

        }
    }
}
