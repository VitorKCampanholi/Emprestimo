


using Projeto;
using System.Globalization;


Salario s = new Salario();


Console.WriteLine("Insira seus dados : ");
Console.Write("Nome : ");
s.Nome = Console.ReadLine();
Console.Write("Salário : ");
s.Salar = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Idade : ");
s.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Score : ");
s.Score = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




if (s.Salar > 1500)
{
    Console.WriteLine("Salário Aprovado para empréstimo");
}

else
{
    Console.WriteLine("Salário não compativel para empréstimo");
}


if (s.Score > 499)
{
    Console.WriteLine("Score : Aprovado");
}
else
{
    Console.WriteLine("Score : Repovado");
}

    Console.WriteLine("Para continuar o processo de emprestimo digite s/n");
    Console.Write("Deseja continuar?");
    s.resposta = (Console.ReadLine());

if (s.resposta == "s")
{
    Console.WriteLine("Vamos para o próximo passo");
}
else if (s.resposta == "n")
{
    Console.WriteLine("Encerrando a operação de empréstimo");
}
else
{
    Console.WriteLine("Operação invalida digite 's' para sim e 'n' para não ");
    
}