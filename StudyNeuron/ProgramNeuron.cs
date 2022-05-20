using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyNeuron
{
    internal class ProgramNeuron
    {
        class Neuron
        {
            private decimal weight = 0.5m;
            public decimal LastError { get; private set; }
            public decimal Smoothing { get; set; } = 0.000001m;

            public decimal ProcessInputData(decimal input)
            {
                return input * weight;
            }

            public decimal RestoreInputData(decimal output)
            {
                return output / weight;
            }

            public void Train(decimal input, decimal expectedResult)
            {
                var actualResult = input * weight;
                LastError = expectedResult - actualResult;
                var correction = (LastError / actualResult) * Smoothing;
                weight += correction;
            }
        }

        static void Main(string[] args)
        {
            decimal km = 100;
            decimal miles = 62.1371m;

            Neuron neuron = new Neuron();

            int i = 0;
            do
            {
                i++;

                neuron.Train(km, miles);

                if (i % 1000000 == 0)
                {
                    Console.WriteLine($"Итерация: {i}\tОшибка:\t{neuron.LastError}");
                }

            }
            while (neuron.LastError > neuron.Smoothing || neuron.LastError < -neuron.Smoothing);

            Console.WriteLine($"{neuron.ProcessInputData(100)} миль в {100} км");

            Console.WriteLine($"{neuron.ProcessInputData(75)} миль в {75} км");

            

            Console.ReadKey();
        }
    }
}
