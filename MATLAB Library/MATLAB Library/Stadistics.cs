using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLAB_Library
{
    public class Stadistics
    {
        /// <summary>
        /// Retorna el valor promedio de un arreglo de datos 
        /// </summary>
        /// <param name = "input"> Arreglo de datos </param>
        /// <returns> Promedio </returns>
        public double Mean(double[] input)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();

            double output;
            double suma = MATLAB.SumList(input);
            output = Math.Round(MATLAB.Div(suma, input.Length), 4);

            return output;
        }

        /// <summary>
        /// Retorna la varianza de un arreglo de datos para una distribución normal o gaussiana
        /// </summary>
        /// <param name = "input"> Arreglo de datos </param>
        /// <returns> Varianza </returns>
        public double Var(double[] input)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();

            double output;
            double promedio = Mean(input);
            double n = input.Length;
            double suma = 0;

            for (int i = 0; i <= n - 1; i++)
            {
                suma = MATLAB.Sum(suma, Math.Pow(MATLAB.Resta(input[i], promedio), 2));
            }

            output = Math.Round(MATLAB.Div(suma, n), 4);

            return output;
        }

        /// <summary>
        /// Retorna la desviación estandar de un arreglo de datos para una distribución normal o gaussiana
        /// </summary>
        /// <param name = "input"> Arreglo de datos </param>
        /// <returns> Desviacon Estandar </returns>
        public double Std(double[] input)
        {
            double output = Math.Sqrt(Var(input));
            output = Math.Round(output, 4);

            return output;
        }

        /// <summary>
        /// Retorna un arreglo con la distribucion normal o gaussiana mediante parametros, un arreglo de datos (input1), el promedio (input2) y la desviación estandar (input3)
        /// </summary>
        /// <param name = "input1"> Arreglo de datos </param>
        /// <param name = "input2"> Promedio de los datos </param>
        /// <param name = "input3"> Desviación estandar de los datos </param>
        /// <returns> Distribución normal en arreglo </returns>
        public double[] Normpdf(double[] input1, double input2, double input3)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();

            double exp;
            double fx;
            double[] output = new double[input1.Length];

            for (int i = 0; i < input1.Length; i++)
            {
                exp = MATLAB.Div(MATLAB.Prod(-1, Math.Pow(MATLAB.Resta(input1[i], input2), 2)), MATLAB.Prod(2, Math.Pow(input3, 2)));
                fx = MATLAB.Prod(MATLAB.Div(1, MATLAB.Prod(input3, Math.Sqrt(MATLAB.Prod(2, Math.PI)))), Math.Exp(exp));
                output[i] = Math.Round(fx, 4);
            }

            return output;
        }

        /// <summary>
        /// Retorna el valor asociado a la distribucion normal o gaussiana mediante parametros, un datos (input1), el promedio asociado (input2) y la desviación estandar asociada(input3)
        /// </summary>
        /// <param name = "input1"> Dato </param>
        /// <param name = "input2"> Promedio del dato </param>
        /// <param name = "input3"> Desviación estandar del dato </param>
        /// <returns> Distribucion normal individual </returns>
        public double Normpdf(double input1, double input2, double input3)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();

            double exp;
            double fx;
            double output;

            exp = MATLAB.Div(MATLAB.Prod(-1, Math.Pow(MATLAB.Resta(input1, input2), 2)), MATLAB.Prod(2, Math.Pow(input3, 2)));
            fx = MATLAB.Prod(MATLAB.Div(1, MATLAB.Prod(input3, Math.Sqrt(MATLAB.Prod(2, Math.PI)))), Math.Exp(exp));
            output = Math.Round(fx, 4);

            return output;
        }

        /// <summary>
        /// Regresa una tupla que contine como primer elemento la ordenada al origen y como segundo elemento la pendiente
        /// </summary>
        /// <param name="input1"> Arreglo de datos para X </param>
        /// <param name="input2"> Arreglo de datos para Y </param>
        /// <returns> Tupla con ordenada y pendiente </returns>
        public Tuple<double, double> Regression(double[] input1, double[] input2)
        {
            //LLamado de nuestra libreria para funciones básicas
            Basics MATLAB = new Basics();

            //Numero de datos
            int n = input1.Length;
            //Para obtener la ordenada
            //Obtenemos la serie de x al cuadrado
            double[] XX = MATLAB.ProdArray(input1, input1);
            //Sumatoria de x al cuadrado
            double sumXX = MATLAB.SumList(XX);
            //Sumatoria de y
            double sumY = MATLAB.SumList(input2);
            //Obtenemos la serie de xy
            double[] XY = MATLAB.ProdArray(input1, input2);
            //Sumatoria de xy
            double sumXY = MATLAB.SumList(XY);
            //Sumatoria de x
            double sumX = MATLAB.SumList(input1);
            //Obtenemos la ordenada al origen
            double output1 = ((sumXX * sumY) - (sumXY * sumX)) / ((n * sumXX) - (Math.Pow(sumX, 2)));
            //Para obtener la pendiente
            //Promedio de x
            double MeanX = Mean(input1);
            //Promedio de y
            double MeanY = Mean(input2);
            //Obteniendo la pendiente
            double output2 = (sumXY - (n * MeanX * MeanY)) / (sumXX - ((Math.Pow(sumX, 2) / n)));
            output1 = Math.Round(output1, 4);
            output2 = Math.Round(output2, 4);

            return new Tuple<double, double>(output1, output2);
        }
    }
}
