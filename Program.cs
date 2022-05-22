using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaValor
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // EjemploTresDatos();
            //EjemploCuatroDatos();
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Menu();
            
          
        }

        static void Menu()
        {
            int opcion;
            
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("**********MENU DE VALORES MAYORES Y MENORES**********" + "\n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Tres Valores.");
            Console.WriteLine("2. Cuatro Valores.");
            Console.WriteLine("Seleccione una opcion (1 - 2):");
            opcion = int.Parse(Console.ReadLine());
        



            //OPCION SELECTIVO
            switch (opcion)
            {
                case 1:
                    int valorUno = 0, valorDos = 0, valortres = 0;
                    int maximoValor, mininoValor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("escriba valor uno:");
                    valorUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("escriba valor dos:");
                    valorDos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("escriba valor tres:");
                    valortres = Convert.ToInt32(Console.ReadLine());
                    
                    //para sacar mayor de 3 numeros
                    if (valorUno > valorDos && valorUno > valortres)
                    {
                        maximoValor = valorUno;
                    }
                    else
                    {
                        if (valorDos > valorUno && valorDos > valortres)
                        {
                            maximoValor = valorDos;
                        }
                        else
                        {
                            maximoValor = valortres;
                        }
                    }

                    //para valor minino de 3 valores
                    if (valorUno < valorDos && valorUno < valortres)
                    {
                        mininoValor = valorUno;
                    }
                    else
                    {
                        if (valorDos < valorUno && valorDos < valortres)
                        {
                            mininoValor = valorDos;
                        }
                        else
                        {
                            mininoValor = valortres;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("el numero mayor es: " + maximoValor.ToString() + "\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("el numero menor es: " + mininoValor.ToString() + "\n\n");
                    
                    break;
                    
                case 2:
                    int datoUno = 0, datoDos = 0, datoTres = 0, datoCuatro = 0;
                    int valorMax, valorMin;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("escriba valor uno: ");
                    datoUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("escriba valor dos: ");
                    datoDos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("escriba valor tres: ");
                    datoTres = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("escriba valor cuatro: ");
                    datoCuatro = Convert.ToInt32(Console.ReadLine());

                    //Para sacar mayor de 4 valores
                    if (datoUno > datoDos && datoUno > datoTres && datoUno > datoCuatro)
                    {
                        valorMax = datoUno;
                    }
                    else
                    {
                        if (datoDos > datoUno && datoDos > datoTres && datoDos > datoCuatro)
                        {
                            valorMax = datoDos;
                        }
                        else
                        {
                            if (datoTres > datoUno && datoTres > datoCuatro && datoTres > datoDos)
                            {
                                valorMax = datoTres;
                            }
                            else
                            {
                                valorMax = datoCuatro;
                            }
                        }
                    }

                    //Para sacar menor de 4 valores
                    if (datoUno < datoDos && datoUno < datoTres && datoUno < datoCuatro)
                    {
                        valorMin = datoUno;
                    }
                    else
                    {
                        if (datoDos < datoUno && datoDos < datoTres && datoDos < datoCuatro)
                        {
                            valorMin = datoDos;
                        }
                        else
                        {
                            if (datoTres < datoUno && datoTres < datoCuatro && datoTres < datoDos)
                            {
                                valorMin = datoTres;
                            }
                            else
                            {
                                valorMin = datoCuatro;
                            }
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("el numero mayor es: " + valorMax.ToString() + "\n\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("el numero menor es: " + valorMin.ToString() + "\n\n");
                   
                    break;
                default:
                    Console.WriteLine("seleccione una opcion correcta");
                    break;

            }
            Console.ReadKey();

        }


        /*static void EjemploTresDatos()
        {
            int valorUno = 0, valorDos = 0, valortres = 0;
            int maximoValor, mininoValor;
            Console.WriteLine("escriba valor uno:");
            valorUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor dos:");
            valorDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valortres = Convert.ToInt32(Console.ReadLine());
            //para sacar mayor de 3 numeros
            if (valorUno > valorDos && valorUno > valortres)
            {
                maximoValor = valorUno;
            }
            else
            {
                if (valorDos> valorUno && valorDos>valortres)
                {
                    maximoValor=valorDos;
                }
                else
                {
                    maximoValor = valortres;
                }
            }
            
            //para valor minino de 3 valores
            if (valorUno < valorDos && valorUno < valortres)
            {
                mininoValor = valorUno;
            }
            else
            {
                if(valorDos<valorUno && valorDos <valortres)
                {
                    mininoValor = valorDos;
                }
                else
                {
                    mininoValor = valortres;
                }   
            }
            Console.WriteLine("el numero mayor es: " + maximoValor.ToString() + "\n\n");
            Console.WriteLine("el numero menor es: " + mininoValor.ToString() + "\n\n");      
        }
        
        
        static void EjemploCuatroDatos()
        {
            int valorUno = 0, valorDos = 0, valortres = 0, valorCuatro = 0;
            int maximoValor, mininoValor;
            Console.WriteLine("escriba valor uno:");
            valorUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor dos:");
            valorDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valortres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriba valor tres:");
            valorCuatro = Convert.ToInt32(Console.ReadLine());

            //Para sacar mayor de 4 valores
            if (valorUno > valorDos && valorUno > valortres && valorUno > valorCuatro )
            {
                maximoValor = valorUno;
            }
            else
            {
                if (valorDos > valorUno && valorDos > valortres && valorDos > valorCuatro)
                {
                    maximoValor = valorDos;
                }
                else
                {
                    if (valortres>valorUno && valortres > valorCuatro && valortres > valorDos)
                    {
                        maximoValor=valortres;
                    }
                    else
                    {
                        maximoValor = valorCuatro;
                    }
                }               
            }

            //Para sacar menor de 4 valores
            if (valorUno < valorDos && valorUno < valortres && valorUno< valorCuatro)
            {
                mininoValor = valorUno;
            }
            else
            {
                if (valorDos < valorUno && valorDos < valortres && valorDos < valorCuatro)
                {
                    mininoValor = valorDos;
                }
                else
                {
                    if (valortres<valorUno && valortres < valorCuatro && valortres < valorDos)
                    {
                        mininoValor = valortres;
                    }
                    else
                    {
                        mininoValor = valorCuatro;
                    }
                }
               
            }
            Console.WriteLine("el numero mayor es: " + maximoValor.ToString() + "\n\n");
            Console.WriteLine("el numero menor es: " + mininoValor.ToString() + "\n\n");
        }*/
    }
    
    
}
