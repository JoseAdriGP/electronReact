using ElectronCgi.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myassembly = Assembly.LoadFrom("HelloWorld.dll");
            var connection = new ConnectionBuilder()
                .WithLogging()
                .Build();
            
            connection.On<string, string>("greeting", name => "The c# part sais hello: " + name);
            
            connection.Listen();    
        }
    }
}
