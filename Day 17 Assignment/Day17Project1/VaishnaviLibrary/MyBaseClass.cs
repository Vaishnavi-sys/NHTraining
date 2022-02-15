using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// **********************************
// Author : Nanam Vaishnavi
//Purpose : Access Modifiers
// *********************************

namespace VaishnaviLibrary
{
    /// <summary>
    /// Access Modifiers in Within Class
    /// </summary>
     public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        int e;
        protected internal int f;
        public void MyBaseClassMethod()
        {
            a = 5;
            b = 7;
            c = 9;
            d = 11;
            e = 13;
            f = 15;
        }
    }
   
    /// <summary>
    /// Access Modifiers in Derived Class
    /// </summary>
    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 2;
            b = 4;
            c = 6;
            d = 8;
            e = 10;
            f = 12;
        }
    }

    /// <summary>
    /// Access Modifiers in Other Class
    /// </summary>
    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            {
                mb.a = 1;
                mb.b = 2;
                mb.c = 3;
                mb.d = 4;
                mb.e = 5;
                mb.f = 6;
            }
            
        }
            
        
    }
}
