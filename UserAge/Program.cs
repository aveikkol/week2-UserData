﻿using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis
            

            Console.WriteLine("Palun, sisesta oma vanus :");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - userAge;

            //Console.WriteLine("Oled " + UserAge + " aastat vana.");

            //string interpolation 

            Console.WriteLine($"Oled sündinud aastal { yearOfBirth}.");

        }
    }
}
