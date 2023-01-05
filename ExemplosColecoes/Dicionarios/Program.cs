Dictionary<string, string> estados = new Dictionary<string, string>();


estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");


foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine("Chave: " + item.Key + " Valor: " + item.Value);
}

var valorBuscado = "BA";
// Console.WriteLine("Buscando pela chave");
// Console.WriteLine(estados[valorBuscado]);

//Atualizando
Console.WriteLine("Valor");
Console.WriteLine(estados[valorBuscado]);
estados[valorBuscado] = "BA - Valor Atualizado";
Console.WriteLine("Valor Atualizado");
Console.WriteLine(estados[valorBuscado]);

Console.WriteLine("Remover um valor");
estados.Remove(valorBuscado);

//Acessar de maneira segura

if (estados.TryGetValue(valorBuscado, out string valorEncontrado)) // tenta buscar o valor 
{
    Console.WriteLine("Valor encontrado\n " + valorEncontrado);
}
else
{
    Console.WriteLine("Valor não encontrado");
}