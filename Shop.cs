using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_06_2024
{
    internal class Shop
    {
        /// клас «Магазин». Додайте до вже створеного класу
       // інформацію про площу магазину.Виконайте навантаження операторiв
        public string Name { get; set; }

        public double Square { get; set; }

        public Shop() { }
        public Shop(string name, double square)
        {
            Name = name;
            Square = square;
        }

        public static double operator+(Shop shop,double x)
        {
            shop.Square += x;
            return shop.Square;


        }


        public static double operator-(Shop shop,double x)
        {
            shop.Square -= x;
            return shop.Square;
        }

        public static bool operator==(Shop shop,Shop shop2)
        {
            return shop.Square == shop2.Square;
        }

        public static bool operator!=(Shop shop,Shop shop2)
        {
            return shop.Square != shop2.Square;
        }


        public static bool operator <(Shop shop,Shop shop2)
        {
            return shop.Square < shop2.Square;

        }

        public static bool operator> (Shop shop,Shop shop2)
        {
            return shop.Square > shop2.Square;
        }


        public override bool Equals(object obj)
        {
            if(this.Square != ((obj as Shop).Square))
            {
                return false;
            }
            return true;
        }


    }
}
