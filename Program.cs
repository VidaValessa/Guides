﻿using System;

namespace Guides
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;
            // var texto = "O preço do produto é " + price + "penas na promção";
            // var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
            var texto = $"O preço do produto é {price} apenas na promoção";

            Console.WriteLine(texto);
        }
    }
}
