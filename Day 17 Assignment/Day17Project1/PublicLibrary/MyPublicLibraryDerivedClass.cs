using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaishnaviLibrary;
// ********************************
// Author : Nanam Vaishnavi
// Purpose : Other Assembly
// *********************************

namespace PublicLibrary
{
    /// <summary>
    /// derived class on other assembly
    /// </summary>
    public class MyPublicLibraryDerivedClass : MyBaseClass
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
    /// Other Class in other Assembly
    /// </summary>
    public class MyPublicLibraryOtherClass : MyBaseClass
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
