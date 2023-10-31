// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Práctica de Depuración by Coding Dojo & Cayuyo

// Challenge 1
bool amProgrammer = true; // bool amProgrammer = "true"; El tipo es Booleano y el valor se escribió con " " lo que indica que el valor escrito es un Sting, para corregirlo se debe escribir solamente true/false sin comillas o cambiar la variable de bool a string.
int Age = 28; // int Age = 27.9; La variable int se utiliza para numero enteros (1, 19, 100) no decimales, para ello se debe utilizar variables double o float los cuales admiten numeros decimales (12.4, 44.7, 123.5545) o eliminar el numero decimal y convertirlo a entero
List<string> Names = new List<string>();
Names.Add("Monica"); // Names = "Monica"; El valor que se trata de agregar es String por lo que no podrá ser agregado de esa forma a la lista, para poder agregarla se debe utilizar el metodo Add(), de esta forma = Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0"); // MyDictionary.Add("Hi there", 0); El segundo argumento se encuentra en numero (int) por lo que no puede agregarse al diccionario que solicita string, string, para corregirlo hay que poner un string con comillas ""  
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName"; // Error de sintaxis, los string deben ir con comillas dobles ("") no simples ('')

// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--) // int i = Numbers.Count; i >= 0; i--; indice fuera del rango de la lista, para corregirlo el .Count debe restarsele 1 para que itere corectamente la lista.
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9}; // Error de indice, el elemento 'i' no es un indice, por lo cual no accederá correctamente a los elementos de la lista, para solucionarlo se debe agregar una variable o cambiar el ciclo "foreach" por un "for" 
/* foreach(int i in MoreNumbers)
{
    Console.WriteLine(MoreNumbers[i]);
} */

for(int i = 0; i < MoreNumbers.Count; i++)
{
    Console.WriteLine(MoreNumbers[i]);
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14}; // Error de logica en el ciclo 'foreach', solo asigna 0 a la variable 'num' en cada ciclo donde hay un numero divisible por 3, para corregirlo se debe utilizar un ciclo "for"
/*
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        num = 0;
    }
}
*/

for(int i = 0; i < EvenMoreNumbers.Count; i++)
{
    EvenMoreNumbers[i] %= 3;
    Console.WriteLine(EvenMoreNumbers[i]);
}


// Challenge 5
// What can we learn from this error message?
// Las cadenas (String) no se pueden modificar.

/*string MyString = "superduberawesome";
MyString[7] = "p";*/ // Error al tratar de modificar el String en el indice 7, ya que los String en C# son inmutables, lo que no permite su modificacion una vez ceadas. Para solicionarlo se debe utilizar un arreglo (Array) que permita la modificacion de caracteres.

char[] MyArray = "superduberawesome".ToCharArray();
MyArray[7] = 'p';


// Challenge 6
// Hint: some bugs don't come with error messages

Random rand = new Random();
int randomNum = rand.Next(12); // rand.Next(12) devuelve un entero positivo entre 0 y 11.
if(randomNum == 13) // if(randomNum == 12); RandomNum nunca devolverá 12 ya que lo que se genera es menor al numero indicado por lo que nunca imprimirá "hello" en consola, para corregirlo se debe aumentar el numero igual o superior a 13.
{
    Console.WriteLine("Hello");
}

