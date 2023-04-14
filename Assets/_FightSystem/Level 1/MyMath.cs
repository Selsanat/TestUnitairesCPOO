using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_GC_A2_Partiel_POO.Level_1
{
    public class MyMath
    {
        // Interdictions :
        // classe Math & MathF
        public static int Abs(int input)
        {
            if (input > 0)
            {
                return input;
            }
            else
            {
                return - input;
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Clamp(int input, int min, int max)
        {
            if (input < min)
            {
                return min;
            }
            else
            {
                if (input > max)
                {
                    return max;
                }
                else
                {
                    return input;
                }
            }
        }

        // Interdictions :
        // classe Math & MathF
        public static int Floor(float input)
        {
            return (int)input;
        }

        // Interdictions :
        // classe Math & MathF
        public static int Ceil(float input)
        {
            if (input > (int)input)
            {
                return (int)input + 1;
            }
            return (int)input;
        }

        // Interdictions :
        // classe Math & MathF
        public static int Round(float input)
        {
                if ((Ceil(input) - input) > input - Floor(input)){
                    
                return (int)Floor(input);
            }
            return (int)Ceil(input);


        }

        // Interdictions :
        // classe Math & MathF
        // LINQ & Enumerable
        public static float CalculateAverage(int[] input)
        {
            int somme = 0;
            foreach(int i in input)
            {
                somme += Floor(i);
            }
            return somme / input.Count();
        }

    }
}
