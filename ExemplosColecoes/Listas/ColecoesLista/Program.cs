

List<int> valores = new List<int> { 3, 4, 5, 6, 3 };

//adcionar um novo valor em uma posição
valores.Insert(1, 10);


valores.Remove(3); // remove o primeiro elemento que encontrar com esse valor que aqui no caso é 3
var exibirValore = string.Join(",", valores); // exibe os valores da lista separados por ","
Console.WriteLine(exibirValore);
