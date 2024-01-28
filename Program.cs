using System;
using System.Globalization;
using static System.Console;

namespace Module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullNameStudent = "Name LastName Surname";
            string fullName = "Full Name";

            string emailStudent = "test@mail.com";
            string email = "Email";

            string pointPrograming = "Point programing";
            string sumProgramString = "Sum programing";
            float  sumPointProgram;
            string ProgPoint_1 = "5";
            string ProgPoint_2 = "6.2";
            string ProgPoint_3 = "4.5";

            string pointMath = "Point math";
            string sumMathString = "Sum Math";
            float  sumPointMath = 0f;
            string MathPoint_1 = "3.3";
            string MathPoint_2 = "6.4";
            string MathPoint_3 = "4.5";

            string pointPhysic = "Point physic";
            string sumPhysicString = "Sum Physic";
            float  sumPointPhysic = 0f;
            string PhysPoint_1 = "9.9";
            string PhysPoint_2 = "3.3";
            string PhysPoint_3 = "5";

            string AverageString = "Average";
            double AveragePoints = 0f;

            sumPointProgram = float.Parse(ProgPoint_1, CultureInfo.InvariantCulture.NumberFormat) + 
                              float.Parse(ProgPoint_2, CultureInfo.InvariantCulture.NumberFormat) + 
                              float.Parse(ProgPoint_3, CultureInfo.InvariantCulture.NumberFormat);

            sumPointMath = float.Parse(MathPoint_1, CultureInfo.InvariantCulture.NumberFormat) +
                           float.Parse(MathPoint_2, CultureInfo.InvariantCulture.NumberFormat) +
                           float.Parse(MathPoint_3, CultureInfo.InvariantCulture.NumberFormat);

            sumPointPhysic = float.Parse(PhysPoint_1, CultureInfo.InvariantCulture.NumberFormat) +
                           float.Parse(PhysPoint_2, CultureInfo.InvariantCulture.NumberFormat) +
                           float.Parse(PhysPoint_3, CultureInfo.InvariantCulture.NumberFormat);

            AveragePoints = sumPointProgram + sumPointMath + sumPointPhysic / 3;

            Console.Write($"|{fullName,-16} | ->| {fullNameStudent,10} |\n" +
                          $"|{email,-16} | ->| {emailStudent,10}         |\n" +
                          $"|{pointPrograming,5} | ->| {ProgPoint_1,5}, {ProgPoint_2}, {ProgPoint_3,-10}|\n" +
                          $"|{pointMath,-16} | ->| {MathPoint_1,5}, {MathPoint_2,-2}, {MathPoint_3,-10}|\n" +
                          $"|{pointPhysic,-16} | ->| {PhysPoint_1,5}, {PhysPoint_2,-2}, {PhysPoint_3,-10}|\n" +
                          $"-----------------------------------------------\n" +
                          $"|{sumProgramString,-16} | ->| {sumPointProgram,10}|\n" +
                          $"|{sumMathString,-16} | ->| {sumPointMath,10}|\n" +
                          $"|{sumPhysicString,-16} | ->| {sumPointPhysic,10}|\n" +
                          $"-----------------------------------------------\n" +
                          $"|{AverageString,-16} | ->| {AveragePoints,10}|\n");
        }
    }
}
