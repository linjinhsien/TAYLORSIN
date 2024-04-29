using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorSinxCalculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                // 常量
                const double Pi = Math.PI;

                // 變量
                double x, sum, result_a;
                int n, K;

                Console.WriteLine("Enter x (in degrees): ");
                double angleDegrees = Convert.ToDouble(Console.ReadLine());
                x = angleDegrees * Pi / 180.0;

                // 利用內建正弦函數計算x的正弦值
                double sinX = Math.Sin(x);
                Console.WriteLine($"利用內建正弦函數計算sin(x) = {sinX:F16}");

                Console.WriteLine("\n項數 計算結果 內建正弦函數差異");
                Console.WriteLine("=================================");

                for (K = 1; K <= 10; K++)
                {
                    sum = 0;
                    for (n = 1; n <= K; n++)
                    {
                        // 計算每一項的值
                        result_a = Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n - 1) / Factorial(2 * n - 1);
                        sum += result_a;
                    }

                    Console.WriteLine($"{K,3} {sum,20:F16} {sum - sinX,20:F16}");
                }
            }

            // 計算階乘
            static double Factorial(int n)
            {
                double ans = 1;
                for (int i = 1; i <= n; i++)
                {
                    ans *= i;
                }
                return ans;
            }
        }

    }

