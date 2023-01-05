#region  FILA QUEUE

// Queue<string> Fila = new Queue<string>();
// Fila.Enqueue("Alberto");
// Fila.Enqueue("José");
// Fila.Enqueue("Eliana");
// Fila.Enqueue("Eliene");


// while (Fila.Count > 0)
// {
//     Console.WriteLine("Pessoas na Fila: " + Fila.Count);
//     Console.WriteLine("Vez doª: " + Fila.Peek());
//     Console.WriteLine($"{Fila.Dequeue()} Atendido");
// }
// Console.WriteLine("Pessoas na Fila: " + Fila.Count);

#endregion


#region  PILHA STACK
Stack<string> pillhaLivros = new Stack<string>();

pillhaLivros.Push("O código da inteligência");
pillhaLivros.Push("Armadilhas da mente");
pillhaLivros.Push("Prisioneiros da mente");
pillhaLivros.Push("Técnicas de invasão");

while (pillhaLivros.Count > 0)
{
    Console.WriteLine("Próximo livro para leitura: " + pillhaLivros.Peek());
    Console.WriteLine("Livro lido: " + pillhaLivros.Pop());
    Console.WriteLine("--------------");
}
#endregion