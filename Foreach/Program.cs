using System;

namespace Foreach{

	class Program{
        static void Main(string[] args)
		{
			string[] palavras = { "Victor", "Lima", "Guia de programação", "Formação", "Node", "Curso de C#", "Udemy" };

			foreach (string palavra in palavras)
			{ // para cada (palavra no array palavras, repita o bloco de codigos)
				Console.WriteLine(palavra);
			}
			Console.WriteLine("FIM DA LINHA");
			Console.ReadLine();
		}
	}
}