using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Modul4HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                var starter = new Starter();
                starter.Run();
            }
        }
    }
}
