string firstName = "Joao";
string lastName = "Conrado";

string note = lastName.ToUpper() + " " + firstName;

string initials = lastName[0] + " " + firstName[0];

Console.WriteLine("" + initials);

//Formatação de string
string texto = string.Format("{0} {1} nascido em {2}", firstName, lastName, "2008");

Console.WriteLine(texto);

//c# é uma linguagem filha do c++
//totalmente orientada a objetos
//portanto, tudo dentro do c é descendente do tipo object

int age = 18;
object ageBoxing = age;
Console.WriteLine(ageBoxing);

/*
Vetores unidimensionais
*/

//Declaração sem inicialozação
// Obs: Váriavel alocada mas numa
int [] numbers;

//Inicializando o vetor
numbers = new int[5];

// Atribuindo valores ao vetor
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// É possível declarar o vetor e já definir e atribuir
int[] number2 = new int[] {100, 200, 300};
int[] number3 = {1000, 2000, 3000, 4000};

// Percorrendo um vetor e adicionando valores dinamicamente
Console.WriteLine("Iniciando com vetores de números inteiros");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];

int total = 0; //Acumulador
int counter = 0; //Contador

for(int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(
        "Digite para [" + i + "]: "
    );
    myArray[i] = Convert.ToInt32(
        Console.ReadLine()
    );

    total += myArray[i];
    counter++;
}

Console.WriteLine("Totalizador = " + total);
Console.WriteLine("Contagem = " + counter);