﻿namespace BinaryTreeNamespace;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Розмір масиву чисел: ");
		int length = int.Parse(MyReadLine());

		int[] randomArray = GenerateRandomArray(length);
		Console.WriteLine("Масив: " + string.Join(", ", randomArray));

		BinaryTree binaryTree = new(randomArray);

		Console.WriteLine("\nЕлементи у зростальному порядку:");
		binaryTree.InOrderTraversal();

		Console.Write("\n\nЧисло яке потрібно знайти: ");
		int valueToFind = int.Parse(MyReadLine());
		bool isFound = binaryTree.FindValue(valueToFind);
		Console.WriteLine($"Значення {valueToFind} {(isFound ? "знайдено" : "не знайдено")} в бінарному дереві!");
	}

	static string MyReadLine() => Console.ReadLine() ?? string.Empty;
	static int[] GenerateRandomArray(int length) => Enumerable.Range(1, length).Select(i => new Random().Next(1, 101)).ToArray();
}