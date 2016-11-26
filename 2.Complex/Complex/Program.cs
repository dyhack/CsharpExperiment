using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex
{
    public class Complex 
    {
        double RealPart;
        double ImaginPart;
        //1
        public Complex() 
        {
            this.RealPart = 0;
            this.ImaginPart = 0;
        }
        //2
        public Complex(double r, double i) 
        {
            this.RealPart = r;
            this.ImaginPart = i;
        }
        //3
        public double getReal() 
        {
            return this.RealPart;
        }
        //4
        public double getImagin() 
        {
            return this.ImaginPart;
        }
        //5
        Complex complexAdd(Complex a) 
        {
            Complex cpxAdd = new Complex();
            cpxAdd.RealPart = this.RealPart + a.RealPart;
            cpxAdd.ImaginPart = this.ImaginPart + a.ImaginPart;
            return cpxAdd;
        }
        //6
        Complex complexSub(Complex a) 
        {
            Complex cpxSub = new Complex();
            cpxSub.RealPart = this.RealPart - a.RealPart;
            cpxSub.ImaginPart = this.ImaginPart - a.ImaginPart;
            return cpxSub;
        }
        //7
        Complex complexMulti(Complex a) 
        {
            Complex cpxMulti = new Complex();
            cpxMulti.RealPart = this.RealPart * a.RealPart;
            cpxMulti.ImaginPart = this.ImaginPart * a.ImaginPart;
            return cpxMulti;
        }
        //8
        public String ToString() 
        {
            if (this.ImaginPart > 0)
                return this.RealPart + "+" + this.ImaginPart + "i";
            else if (this.ImaginPart == 0)
                return this.RealPart.ToString();
            else
                return this.RealPart + this.ImaginPart+"i";
        }
        //9
        //+
        public Complex operator +(Complex a,Complex b)
        {
            Complex cpxAdd = new Complex();
            cpxAdd.RealPart = a.RealPart + b.RealPart;
            cpxAdd.ImaginPart = a.ImaginPart + b.ImaginPart;
            return cpxAdd;
        }
        //-
        public Complex operator -(Complex a,Complex b)
        {
            Complex cpxAdd = new Complex();
            cpxAdd.RealPart = a.RealPart - b.RealPart;
            cpxAdd.ImaginPart = a.ImaginPart - b.ImaginPart;
            return cpxAdd;
        }
        //*
        public static  Complex operator *(Complex a,Complex b)
        {
            Complex cpxAdd = new Complex();
            cpxAdd.RealPart =a.RealPart * b.RealPart;
            cpxAdd.ImaginPart = a.ImaginPart * b.ImaginPart;
            return cpxAdd;
        }
        //++
         public Complex operator ++(Complex a)
        {
            Complex cpxAdd = new Complex();
            cpxAdd.RealPart = this.RealPart +1;
            cpxAdd.ImaginPart = this.ImaginPart +1;
            return cpxAdd;
        }
        //--
         public Complex operator --(Complex a)
         {
             Complex cpxAdd = new Complex();
             cpxAdd.RealPart = this.RealPart -1;
             cpxAdd.ImaginPart = this.ImaginPart -1;
             return cpxAdd;
         }
    }
    public class RealData:Complex
    {
        public RealData() 
        {            
        }
        static void Main(string[] args)
        {
            RealData rd = new Complex(1,1);
        }
    }   
}
