
using System;

public class Triangle
    {
        public static string TriangleDefinition(double a, double b, double c)
        {
            double[] max = { a,b,c};
        for(int j=0; j<2;j++)
            for (int i = 0; i < 2; i++)
            if(max[i]<max[i+1])
                Swap(ref max[i], ref max[i+1]);
      
            
        Console.WriteLine(max[0] + "  " + max[1] + "  " + max[2]);
            if (max[0] > max[1] + max[2]||a<=0||b<=0||c<=0)
                return "impossible";
            else
            {
                double temp = -max[0] * max[0] + max[1] * max[1] + max[2] * max[2];
                if (temp > 0)
                    return "acute";
                else if (temp == 0)
                    return "rectangular";
                else
                    return "obtuse";
            }
           
        }
        public static void Swap(ref double a,ref double b)
        {
            double c = a;
            a = b;
            b = c;
        }
    }

