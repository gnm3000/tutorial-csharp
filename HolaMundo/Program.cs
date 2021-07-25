using System;
namespace HolaMundo
{
    class Program
    {
        //int edad;
        // int , sbyte,short,long, 
        // float , double, decimal (en app financieras alta precision),
        //float x = 99,99f;
        // bool
        // char
        // string
        //public static int Sumar(int n1, int n2) {
        //    return n1 + n2;
        //}
        // Sintaxis metodo
        // <especificador de acceso> <Tipo de retorno> <number del metodo> (Lista de parametros){ cuerpo del metodo }
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //int num1 = 15;
            //Console.WriteLine(num1);
            //double d1 = 1.2;
            //double d2 = 1.4;
            //string name = "German";
            //string number = "15";
            //int number2;
            //bool success = Int32.TryParse(number, out number2);
            //if (success) {
            //Console.WriteLine(number2);
            //}
            
            Console.Read();
        }
    }
    public abstract class Bird
    {
        public int _wings;
        public Bird(int wings) => _wings = wings;
    }
    interface IFly {
        void IFly();
    }
    interface ISwim {
        void ISwim();
    }
    interface IRun {
        int Legs { get; set; }
        void IRun();    
    }
    public class Ostrich : Bird, IRun,ISwim
    {
        public int _legs;
        public int Legs {
            get { return _legs; }
            set { _legs = value; } }

        public Ostrich(int wing) : base(wing) { 
        }
        public void IRun()
        {
            Console.WriteLine("run bird!");
        }

        public void ISwim()
        {
            Console.WriteLine("i am swimming");
        }
    }


}
