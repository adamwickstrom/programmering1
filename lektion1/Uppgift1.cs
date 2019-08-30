using System;

class MainClass {
  public static void Main (string[] args) {
    Console.Write ("Är det fint väder? ");
    string svar = Console.ReadLine();
    if (svar == "ja" || svar == "Ja")
    Console.WriteLine ("vi går på picknick!");
