using System;
using AccessLayer;
namespace AD06ConsoleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a connection string which is used to store the details.
            string connect = "Data Source=DESKTOP-CKH5QSL;Initial Catalog=HarvestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //access the function from the access layer class
            Access.Connect(connect);
           
        }
    }
}

