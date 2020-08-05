using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, introduce tu nombre porfavor!");
            string nombre = Console.ReadLine();
            Console.WriteLine($"{nombre} vamos a calcular tu pago");
            Console.WriteLine("Introduce el n° del mes que corresponde");
            int mes = int.Parse(Console.ReadLine());
            int sueldo = 5000;
            double comision;
            double total;
            switch (mes)
            {
                
                case 1:
                    comision = (sueldo * 0.40);
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Enero, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 2:
                    comision = (sueldo * 0.30) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Febrero, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 3:
                    comision = (sueldo * 0.20) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Marzo, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 4:
                    comision = (sueldo * 0.15) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Abril, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 5:
                    comision = (sueldo * 0.10) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Mayo, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 6:
                    comision = (sueldo * 0.40) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Junio, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 7:
                    comision = (sueldo * 0.20) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Julio, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 8:
                    comision = (sueldo * 0.10) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Agosto, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 9:
                    comision = (sueldo * 0.10) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Septiembre, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 10:
                    comision = (sueldo * 0.25) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Octubre, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 11:
                    comision = (sueldo * 0.30) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Noviembre, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;

                case 12:
                    comision = (sueldo * 0.30) + sueldo;
                    total = sueldo + comision;
                    Console.WriteLine($"{nombre} elegiste el mes de Diciembre, tu sueldo es de {sueldo} mas una comision del {comision} es igual a {total} pesos");
                    break;





                default:
                    break;
            }
        }
    }
}
