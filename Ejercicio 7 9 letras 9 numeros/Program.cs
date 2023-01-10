// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Mediante un ciclo, pedir 9 letras y 9 números, ordenar descendentemente
//las letras, ascendentemente los números. Imprimir concatenando una letra y un número.
Console.WriteLine("Este programa ordenará 9 letras y 9 números, además de unirlas cada una");
//DE
char[] letra = new char[9];
int[] numero = new int[9];
//Procedimiento
Console.WriteLine("Capturaremos 10 letras");
for (int i = 0; i < letra.Length; i++)//Hacemos un ciclo para capturar las letras
{
    Console.WriteLine("Captura la letra No. " + (i+1));//Ciclo para la captura
    letra[i] = Convert.ToChar(Console.ReadLine());//Lectura de cada letra
}
for (int i = 0; i < letra.Length; i++)//Haremos un ordenamiento de la burbuja para imprimir las letras en orden descendente. 
{
    for (int j = 0; j < letra.Length-1; j++)//Ciclo para ordenar
    {
        if (letra[i] > letra[j])
        {
            char temp = letra[i];//Ordenaremos todo y utulizaremos una variable temporal
            letra[i] = letra[j];
            letra[j] = temp;
        }
    }
}
Console.WriteLine("Capturaremos 10 números");
for (int k = 0; k < numero.Length; k++)
{
    Console.WriteLine("Captura el número No. " + (k+1));//Ciclo para la captura de los números. 
    numero[k] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < numero.Length; i++)//Haremos un ordenamiento de la burbuja para imprimir los números en orden ascendente. 
{
    for (int j = 0; j < numero.Length - 1; j++)//Ciclo para ordenar
    {
        if (numero[i] < numero[j])//Para ordenar de mayor a menor cambiaremos el signo por un <
        {
            int temp = numero[i];//Ordenaremos todo y utulizaremos una variable temporal
            numero[i] = numero[j];
            numero[j] = temp;
        }
    }
}
//Imprimiremos una letra con un número. 
Console.WriteLine("Uniremos la primera letra en orden descendente con el primer número en orden ascendente, quedará de la siguiente manera; " + " No. 1 " + letra[0] + numero[0] + " No.2 " + letra[1] + numero[1] + " No.3 "+
    letra[2] + numero[2] + " No.4 "+ letra[3] + numero[3] + " No.5 "+ letra[4] + numero[4] + " No.6 "+ letra[5] + numero[5] + " No.7 "+ letra[6] + numero[6] + " No.8 "+ letra[7] + numero[7] + " No.9 "+ letra[8] + numero[8]);
