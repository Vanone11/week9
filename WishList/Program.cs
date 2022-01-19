using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            myWishList.Add("Thing1");
            myWishList.Add("Thing2");
            myWishList.Add("Thing3");

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }

        }
    }
}
