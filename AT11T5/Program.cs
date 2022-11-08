// Inicio
int n = 0;
int cont = 0;
int i = 0;
while (cont < 10)
{
    Console.Write("Informe um valor: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 0)
    {
        i++;
    }
    cont++;
}
Console.WriteLine("Foram informados " + i + " valores negativos");
Console.ReadKey();
//Fim
