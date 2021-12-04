using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLAB_Library
{
    public class Basics
    {
        /// <summary>
        /// Suma de dos valores, devuelve el valor de la suma 
        /// </summary>
        /// <param name = "input1"> Sumando 1 </param>
        /// <param name = "input2"> Sumando 2 </param>
        /// <returns> Suma </returns>
        public double Sum(double input1, double input2)
        {
            double output = input1 + input2;
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Retorna la suma de los valores de un arreglo
        /// </summary>
        /// <param name = "input"> Arreglo de datos </param>
        /// <returns> Suma </returns>
        public double SumList(double[] input)
        {
            double output = 0;

            for (int i = 0; i < input.Count(); i++)
            {
                output = Sum(output, input[i]);
            }
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo resultante de sumar una constante a cada uno de los elementos de un arreglo
        /// </summary>
        /// <param name="input1"> Arreglo de datos </param>
        /// <param name="input2"> Constante </param>
        /// <returns> Arreglo de sumas </returns>
        public double[] SumDot(double[] input1, double input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Sum(input1[i], input2), 4);
            }

            return output;
        }

        /// <summary>
        /// Regresa la suma de dos arreglos elemento por elemento en un nuevo arreglo, todos de la misma dimension
        /// </summary>
        /// <param name="input1"> Arreglo de datos 1 </param>
        /// <param name="input2"> Arreglo de datos 2 </param>
        /// <returns> Arreglo de sumas </returns>
        public double[] SumArray(double[] input1, double[] input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Sum(input1[i], input2[i]), 4);
            }

            return output;
        }

        /// <summary>
        /// Resta de dos valores, devuelve el valor de la resta
        /// </summary>
        /// <param name = "input1"> Minuendo </param>
        /// <param name = "input2"> Sustraendo </param>
        /// <returns> Resta </returns>
        public double Resta(double input1, double input2)
        {
            double output = input1 - input2;
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuleve un arreglo de las diferencias de sus elementos de manera consecutiva en un nuevo arreglo
        /// </summary>
        /// <param name = "input"> Arreglo de datos </param>
        /// <returns> Arreglo de diferencias </returns>
        public double[] Diff(double[] input)
        {
            int l = input.Length - 1;
            double[] output = new double[l];

            for (int i = 0; i < l; i++)
            {
                double valor = input[i + 1];
                output[i] = Math.Round(Resta(valor, input[i]), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuleve un arreglo resultante de la resta de dos arreglos, resta y resultado por dato, con la misma dimensión
        /// </summary>
        /// <param name="input1"> Arreglo de minuendos </param>
        /// <param name="input2"> Arreglo de sustraendos </param>
        /// <returns> Arreglo de restas </returns>
        public double[] DiffArray(double[] input1, double[] input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Resta(input1[i], input2[i]), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve el producto de dos números
        /// </summary>
        /// <param name="input1"> Factor 1 </param>
        /// <param name="input2"> Factor 2 </param>
        /// <returns> Producto </returns>
        public double Prod(double input1, double input2)
        {
            double output = input1 * input2;
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve el arreglo resultante de multiplicar cada elemento por una constante
        /// </summary>
        /// <param name="input1"> Arreglo de datos </param>
        /// <param name="input2"> Constante </param>
        /// <returns> Arreglo de productos </returns>
        public double[] ProdDot(double[] input1, double input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Prod(input1[i], input2), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo resultante de multiplicar elemento por elemento de dos vectores de misma longitud
        /// </summary>
        /// <param name="input1"> Arreglo de factores 1 </param>
        /// <param name="input2"> Arreglo de factores 2 </param>
        /// <returns> Arreglo de productos </returns>
        public double[] ProdArray(double[] input1, double[] input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] = Math.Round(Prod(input1[i], input2[i]), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve el cociente entre dos números
        /// </summary>
        /// <param name="input1"> Dividendo </param>
        /// <param name="input2"> Divisor </param>
        /// <returns> Cociente </returns>
        public double Div(double input1, double input2)
        {
            double output = input1 / input2;
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo tras dividir cada elemento de un arreglo entre una constante
        /// </summary>
        /// <param name="input1"> Arreglo de datos </param>
        /// <param name="input2"> Constante </param>
        /// <returns> Arreglo de cocientes </returns>
        public double[] DivDot(double[] input1, double input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Div(input1[i], input2), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo resultante de dividir elemento a elemento entre dos arreglos
        /// </summary>
        /// <param name="input1"> Arreglo de dividendos </param>
        /// <param name="input2"> Arreglo de divisores </param>
        /// <returns> Arreglo de cocientes </returns>
        public double[] DivArray(double[] input1, double[] input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Div(input1[i], input2[i]), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo desde input1 a input2 con un espaciado de input3 entre todos los valores del arreglo
        /// </summary>
        /// <param name = "input1"> Valor inicial del arreglo </param>
        /// <param name = "input2"> Valor final del arreglo </param>
        /// <param name = "input3"> Espaciado de los datos </param>
        /// <returns> Arreglo dimensionado </returns>
        public double[] Linspace(double input1, double input2, double input3)
        {
            double paso = input3;
            int l = Convert.ToInt32(((Math.Abs(input2 - input1)) / paso) + 1);
            double[] output = new double[l];

            if (input1 > input2) //Si el valor inicial es mayor que el final, se crea el arreglo de manera decreciente
            {
                for (int i = 0; i < l; i++)
                {
                    output[i] = Math.Round((input1 - (paso * i)), 4);
                }
            }

            else //Se crea el arreglo de manera creciente
            {
                for (int i = 0; i < l; i++)
                {
                    output[i] = Math.Round((input1 + (paso * i)), 4);
                }
            }

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo con el error cuadrático medio de cada elemento a partir de un arreglo de datos y un valor esperado
        /// </summary>
        /// <param name="input1"> Arreglo de datos obtenidos </param>
        /// <param name="input2"> Valor esperado </param>
        /// <returns> Arreglo de errores cuadraticos medios </returns>
        public double[] ECM(double[] input1, double input2)
        {
            int l = input1.Length;
            double[] output = new double[l];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Math.Pow((input1[i] - input2), 2), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo con el error cuadrático de cada elemento a partir de un arreglo de datos y otro de valores esperados
        /// </summary>
        /// <param name="input1"> Arreglo de datos obtenidos </param>
        /// <param name="input2"> Arreglo de datos esperados </param>
        /// <returns> Arreglo de errores cuadráticos medios</returns>
        public double[] ECM(double[] input1, double[] input2)
        {
            int l = input1.Length;
            double[] output = new double[l];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Math.Pow((input1[i] - input2[i]), 2), 4);
            }

            return output;
        }

        /// <summary>
        /// Devuelve el error cuadrático medio acumulado de un arreglo de errores generado a partir de dos arreglos de datos
        /// </summary>
        /// <param name="input1"> Arreglo de datos obtenidos </param>
        /// <param name="input2"> Arreglo de datos esperados </param>
        /// <returns> Suma de errores </returns>
        public double ErrAccum(double[] input1, double[] input2)
        {
            double[] errores = ECM(input1, input2);
            double output = SumList(errores);
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve el error cuadrático medio acumulado de un arreglo de errores generado a partir de un arreglo y un valor esperado
        /// </summary>
        /// <param name="input1"> Arreglo de datos obtenidos </param>
        /// <param name="input2"> Arreglo de datos esperados </param>
        /// <returns> Suma de errores </returns>
        public double ErrAccum(double[] input1, double input2)
        {
            double[] errores = ECM(input1, input2);
            double output = SumList(errores);
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve un arreglo de errores porcentuales calculados a partir de dos arreglos de datos
        /// </summary>
        /// <param name="input1"> Arreglo de datos esperados </param>
        /// <param name="input2"> Arreglo de datos obtenidos </param>
        /// <returns> Arreglo de errores porcentuales </returns>
        public double[] ErrorPrc(double[] input1, double[] input2)
        {
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                output[i] = Math.Round(Div(Math.Abs(Resta(input1[i], input2[i])), input1[i]), 4) * 100;
            }

            return output;
        }

        /// <summary>
        /// Devuelve el error cuadrático medio acumulado de un arreglo de errores generado a partir de dos arreglos de datos
        /// </summary>
        /// <param name="input1"> Arreglo de datos obtenidos </param>
        /// <param name="input2"> Arreglo de datos esperados </param>
        /// <returns> Suma de errores </returns>
        public double ErrAccumPrc(double[] input1, double[] input2)
        {
            double[] errores = ErrorPrc(input1, input2);
            double output = SumList(errores);
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Devuelve el arreglo de valores correspondientes a una recta
        /// </summary>
        /// <param name="input1"> Pendiente </param>
        /// <param name="input2"> Ordenada </param>
        /// <param name="input1"> Arreglo de datos </param>
        /// <returns> Arreglo de rectas </returns>
        public double[] Vector(double input1, double input2, double[] input3)
        {
            double[] vector = ProdDot(input3, input1);
            double[] output = SumDot(vector, input2);

            return output;
        }

        /// <summary>
        /// Devuelve el valor del punto con error acumulado de cero
        /// </summary>
        /// <param name="input1"> Punto aleatorio </param>
        /// <param name="input2"> Ordenada </param>
        /// <param name="input3"> Arreglo de valores obtenidos </param>
        /// <param name="input4"> Arreglo de valores deseados </param>
        /// <param name="input5"> Tamaño del incremento/decremento </param>
        /// <returns> Punto mínimo </returns>
        public void Descenso(double input1, double input2, double[] input3, double[] input4, double input5)
        {
            double p = Math.Round(input1, 4);
            double step = Math.Round(input5, 4);
            double pSup = p + step;
            double pInf = p - step;
            bool noterminar = true;

            do
            {
                //Punto base
                double[] y = Vector(p, input2, input3);
                double error = ErrAccum(input4, y);
                
                //Punto superior
                y = Vector(pSup, input2, input3);
                double errorSup = ErrAccum(input4, y);

                //Punto inferior
                y = Vector(pInf, input2, input3);
                double errorInf = ErrAccum(input4, y);

                //Si el error del punto inferior es mayor que el error actual
                if (errorInf > error)
                {
                    p = Math.Round(pSup, 4);
                    pSup += step;
                    if (errorSup == 0)
                    {
                        //Si llegamos al error minimo, terminamos el ciclo
                        noterminar = false;
                    }
                }
                //Si el error del punto inferior es menor que el actual
                else
                {
                    p = Math.Round(pInf, 4);
                    pInf -= step;
                    if (errorInf == 0)
                    {
                        //Si llegamos al error minimo, terminamos el ciclo
                        noterminar = false;
                    }
                }
                //Se crea el nuevo arreglo con el punto actual
                y = Vector(p, input2, input3);
                //Se calcula el error acumulado con el punto actual
                error = ErrAccum(input4,y);
                //Mostramos el error y puntos asociados, ademas del arreglo obtenido con dicho punto
                Console.WriteLine("Valor del error: {0}, valor del punto: {1}", error, p);
                PrintArray(y);
            } while (noterminar != false);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------
        
        //SOLO PARA CONSOLA

        /// <summary>
        /// Imprime un arreglo en cosola con formato
        /// </summary>
        /// <param name="input"> Arreglo de entrada </param>
        public static void PrintArray(double[] input)
        {
            int len = input.Length;
            Console.Write("[{0}", input[0].ToString("0.0000"));
            for (int i = 1; i < len; i++)
            {
                Console.Write(", ");
                Console.Write(input[i].ToString("0.0000"));
            }
            Console.WriteLine("]");
            Console.Write("\n");
        }

        /// <summary>
        /// Imprime un arreglo en consola con formato exponencial
        /// </summary>
        /// <param name="input"> Arreglo de entrada </param>
        public static void PrintArrayE(double[] input)
        {
            int len = input.Length;
            Console.Write("[{0}", input[0].ToString("E"));
            for (int i = 1; i < len; i++)
            {
                Console.Write(", ");
                Console.Write(input[i].ToString("E"));
            }
            Console.WriteLine("]");
            Console.Write("\n");
        }
    }
}
