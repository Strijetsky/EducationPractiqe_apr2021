/**************************************************************
--------------------------------------------------------------
Класс Program.сs
Группа П33
Разработчик: Крыштанов М.А.
Модифицирован: 19 апреля 2021 
--------------------------------------------------------------
***************************************************************/
using System;

namespace _1_PR_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product_1 = new Product();
            Product_1.NAME = "IPONEH";
            Product_1.AMOUNT = 100000;
            Product_1.COST = 999999.99F;
            Product_1.ShowName();
            Product_1.ShowAmount();
            Product_1.ShowCost();
        }
    }
}
