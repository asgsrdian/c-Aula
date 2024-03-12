/*1. Tipos de variáveis var, int, short, long, decimal, double, bool e string;
2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários;*/

//Console.WriteLine("Hello, World!");

/*int a = 5;
int b = 10;
int c = a + b;
var d = 33;
var e = "Algum texto";
//double f="algum texto";
double g = 10.55;
bool isprovado = true;
string s = "Algum texto";

//3. Estruturas de decisão if/else, ternárias e switch;

if (a == b && c > b)
{
    //faz alguma coisa
}

bool isverdadeiro = a == b ? true : false;

/*4. Estruturas de repetição while, do/while, for, foreach;
5. Arrays.*/

/*int[] vetor1 = new int[4];
int[] vetor2 = new int[] { 3, 6, 7, 2 };

for (int i = 0; i < 4; i++)
{
    int vlr = vetor2[i];
    Console.WriteLine("Valor vetor 1: " + vlr);
}

int contador = 0;

do
{
    Console.WriteLine("Digite um valor: ");
    var str = Console.ReadLine();
    vetor1[contador] = Convert.ToInt32(str);

    contador++;
} while (contador < 4);

foreach (var vrl in vetor1)
{
    Console.WriteLine("Valor do vetor 1: " + vrl);
}


Console.WriteLine("Escreva a altura: ");
int alt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escreva a largura: ");
int larg = Convert.ToInt32(Console.ReadLine());

int area = larg * alt;

Console.WriteLine("Area: " + area);*/


//declaração da função
static void Executar()
{

    Console.WriteLine("Matricula: ");
    string matricula = Console.ReadLine();

    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Nota 1: ");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Nota 2: ");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Matricula: {matricula}");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Nota1: {nota1} ");
    Console.WriteLine($"Nota1: {nota2} ");

    Console.WriteLine($"Somar: {calculadora.somar(nota1, nota2)}");
    Console.WriteLine($"Subtrair: {calculadora.sub(nota1, nota2)}");
    Console.WriteLine($"Multiplicar: {calculadora.mult(nota1, nota2)}");
    Console.WriteLine($"Dividir: {calculadora.dividir(nota1, nota2)}");
}

//invocação da função

Executar();

