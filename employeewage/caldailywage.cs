﻿using System;
namespace employeewage
{
    public class caldailywage
    {
        int hour = 8;
        int rateperhour = 20;
        bool present;


        public void Caldailywage()
        {
            Random value = new Random();

            int empCheck = value.Next(0, 2);

            if (empCheck == 1)
            {
                present = true;
                int salary = hour *  rateperhour;

                Console.WriteLine("daily wage is {0}", salary);
            }
            else
            {
                present = false;
                Console.WriteLine("Employee is absent");
            }
        }

    }
}
