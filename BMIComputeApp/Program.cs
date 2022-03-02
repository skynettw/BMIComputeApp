using System;

namespace BMIComputeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, weight;
            double bmi;
            string res;
            Console.Write("身高(公分)：");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("體重(公斤)：");
            weight = Convert.ToInt32(Console.ReadLine());
            bmi = weight / (height / 100.0 * height / 100.0);
            if (bmi<18.5)
            {
                res = "過瘦";
            } else if (bmi >= 18.5 && bmi <24)
            {
                res = "正常";
            } else
            {
                res = "過重";
            }
            bmi = Math.Round(bmi, 2);
            Console.WriteLine($"你的BMI是{bmi}，體位判定為：{res}。");
        }
    }
}
