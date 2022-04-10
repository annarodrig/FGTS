double fgts, salario;

Console.Write("Salário (R$):");
salario = Convert.ToDouble (Console.ReadLine ());

fgts = (8 * salario) / 100 ;

Console.WriteLine($"\nFGTS......:R$ {fgts:N2}");