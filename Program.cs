using System;

namespace GuidGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GUID: "+Guid.NewGuid().ToString());
        }
    }
}
