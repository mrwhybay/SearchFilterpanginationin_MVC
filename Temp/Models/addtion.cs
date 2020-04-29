using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Temp.Models
{
    interface Calculation
    {

        void Calculation();
    
    }

    public interface ICalculation
    {
         int a { get; set; }
         int b { get; set; }
         int Result { get; set; }

        void calculate();
    
    }





    public class addtion : ICalculation
    {
        public int a { get; set; }
        public int b { get; set; }
        public int Result { get; set; }

        public void calculate()
        {
            Result = (a + b);
            
        }
    }

   

    
   public  class Subsraction : ICalculation
    {
        public int a { get; set; }
        public int b { get; set; }
        public int Result { get; set; }

        public void calculate()
        {
            Result = (a - b);
        }
    }
    public class Multiplication : ICalculation
    {
        public int a { get; set; }
        public int b { get; set; }
        public int Result { get; set; }

        public void calculate()
        {
            Result = (a * b);
        }
    }




}