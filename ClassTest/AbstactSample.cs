using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassTest
{
      //Creating an Abstract Class
      abstract class absClass
      {
            //A Non abstract method
            public int AddTwoNumbers(int Num1, int Num2)
            {
                return Num1 + Num2;
            }

            //An abstract method, to be
            //overridden in derived class
            public abstract int MultiplyTwoNumbers(int Num1, int Num2);
      }

      //A Child Class of absClass
      class absDerived:absClass
      {
          int Num1, Num2;
          public absDerived()
          {
              this.Num1 = 99;
              this.Num2 = 1000;
          }

            //using override keyword,
            //implementing the abstract method
            //MultiplyTwoNumbers
            public override int MultiplyTwoNumbers(int Num1, int Num2)
            {
                return Num1 * Num2;
            }
      }
}