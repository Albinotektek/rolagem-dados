﻿using System.Security.Cryptography;

Console.WriteLine();

Console.WriteLine("Rolagem de dados");

Console.WriteLine();

Console.Write("Digite quantas faces tem o dado:");
int faces = Convert.ToInt32(Console.ReadLine());

int rolagem = RandomNumberGenerator.GetInt32(1, faces +1);

Console.WriteLine();

Console.WriteLine($"A rolagem do dado resultou em {rolagem}");
Console.WriteLine();