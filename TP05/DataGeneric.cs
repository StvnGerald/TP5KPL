using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP05
{
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: " + data);
        }
    }

    class Program
    {
        static void Main()
        {
            DataGeneric<string> data = new DataGeneric<string>("103022300155");
            data.PrintData();
        }
    }

    /*Bentuk input data sendiri
    static void Main()
    {
        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
    */
}
