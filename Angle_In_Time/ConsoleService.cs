using System;

namespace Angle_In_Time
{
    class ConsoleService
    {
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public int GetInput()
        {
            bool success = int.TryParse(Console.ReadLine(), out int input);
            if (!success) input = -1;
            return input;
        }
        public int InputHours()
        {
            PrintMessage(Constants.Hours);
            int h = GetInput();
            return h;
        }
        public int InputMinutes()
        {
            PrintMessage(Constants.Minutes);
            int m = GetInput();
            return m;
        }
        public bool ValidateInput(int h, int m)
        {
            if (h < 0 || m < 0 || h > 12 || m > 60)
            {
                PrintMessage(Constants.Unsuccessful);
                return false;
            }
            if (h == 12) h = 0;
            if (m == 60)
            {
                m = 0;
                h += 1;
                if (h > 12)
                    h = h - 12;
            }
            PrintMessage(Constants.Successful);
            return true;
        }
        public void Angle(Time time)
        {
            double Angle = time.Hours * 30 + (double)time.Minutes / 2 - time.Minutes * 6; //Hours angle - Minutes angle
            if (Angle > 180) Angle = 360 - Angle;
            if (Angle < 0) Angle *= -1;
            PrintMessage(Constants.Angle + Angle + "\n");
        }
        public void ProcessInput()
        {
            int h = InputHours();
            int m = InputMinutes();
            while (!ValidateInput(h, m))
            {
                h = InputHours();
                m = InputMinutes();
            }
            Time time = new Time(h, m);
            Angle(time);
        }
    }
}
