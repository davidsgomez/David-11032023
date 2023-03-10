using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Introducir un número entero: ");
        int altura = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < altura; i++) {
            for (int j = 0; j <= i; j++) {
                Console.Write(altura);
            }
            Console.WriteLine();
        }
    }
}