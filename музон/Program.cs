using System;

class Program
{
    static int[] sixthOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    static int[] seventhOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
    static int[] eighthOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

    static int[] currentOctave;

    static void Main(string[] args)
    {
        currentOctave = sixthOctave;

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.F1)
                {
                    currentOctave = sixthOctave;
                    Console.WriteLine("6 октава");
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    currentOctave = seventhOctave;
                    Console.WriteLine("7 октава");
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    currentOctave = eighthOctave;
                    Console.WriteLine("8 октава");
                }
                else
                {
                    int index = GetKeyIndex(key.KeyChar);
                    if (index != -1)
                    {
                        Console.WriteLine("Клавиша " + key.KeyChar);
                        Noti(currentOctave[index]);
                    }
                }
            }
        }
    }

    static int GetKeyIndex(char key)
    {
        switch (char.ToUpper(key))
        {
            case 'Q':
                return 0;
            case 'A':
                return 1;
            case 'W':
                return 2;
            case 'S':
                return 3;
            case 'E':
                return 4;
            case 'D':
                return 5;
            case 'R':
                return 6;
            case 'F':
                return 7;
            case 'T':
                return 8;
            case 'G':
                return 9;
            case 'Y':
                return 10;
            case 'H':
                return 11;
            default:
                return -1;
        }
    }

    static void Noti(int kol)
    {
        Console.Beep(kol, 500);
    }
}