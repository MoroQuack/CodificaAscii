﻿// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Ciao Mondo!");
#region firma
Console.WriteLine("Classe 3 \nAS 2023/24 ");
//firma dell'autore
#endregion

//ASCII BASE
char c; //inizializzazione variabile char
Console.WriteLine("ASCII BASE");
for (int i = 0; i < 128; i++)
{
    c = (char)i;
    Console.WriteLine("Carattere numero " + i + ": " + c); //stampa a video dei caratteri
}

Console.WriteLine("Premi due tasti per chiudere il programma");
Console.ReadKey();
Console.ReadKey();
