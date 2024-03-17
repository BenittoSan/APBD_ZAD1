﻿// See https://aka.ms/new-console-template for more information



using System;

public class Program
{
   
//Modyfication1
//Modyfikacja 2
// Modyfikacja 3 :DD
    public static double ObliczSrednia(int[] liczby)
    {
        if (liczby == null || liczby.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        int suma = 0;
        foreach (int liczba in liczby)
        {
            suma += liczba;
        }

        double srednia = (double)suma / liczby.Length;
        return srednia;
    }

    public static void Main()
    {
        int[] mojeLiczby = { 1, 2, 3, 4, 5 };
        double wynik = ObliczSrednia(mojeLiczby);
        Console.WriteLine($"Średnia wartość: {wynik}");
    }
}