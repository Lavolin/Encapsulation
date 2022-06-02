using System;
using InternalAccessModifier;

namespace InternalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InternalAccessModifier.PublicClass publicClass = new InternalAccessModifier.PublicClass();

            publicClass.q
        }
    }
}
