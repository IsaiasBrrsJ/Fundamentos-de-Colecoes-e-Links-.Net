int[] numeros = { 5, 10, 8, 3, 6, 12 };

//Query syntax:
IEnumerable<int> numQuery1 =
from num in numeros
where num % 2 == 0
orderby num
select num;

//Methos Syntax:
IEnumerable<int> numQuery2 = numeros.Where(x => x % 2 == 0).OrderBy(x => x);


Console.WriteLine("Números pares query: " + string.Join(", ", numQuery1));
Console.WriteLine("Números pares métodos: " + string.Join(", ", numQuery2));

Console.WriteLine("Maior Valor: " + numQuery1.Max());
Console.WriteLine("Menor Valor: " + numQuery1.Min());
Console.WriteLine("Média Valores: " + numQuery1.Average().ToString("0.0"));
System.Console.WriteLine("Soma: " + numQuery1.Sum());
System.Console.WriteLine("Valores Únicos: " + string.Join(", ", numQuery1.Distinct().ToArray()));