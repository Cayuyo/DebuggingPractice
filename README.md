# Práctica de Depuración

Repositorio publico para el bootcamp de Coding Dojo sobre logica de programacion, bucles y condicionales
.
<h3>Objetivo:</h3>
    <li>Evaluar el código preescrito en busca de errores​​</li>
    <li>Indicar en los comentarios qué problemas se encontraron y cómo se resolvieron​​</li>
    

<h4>Instrucciones</h4>

<p>Crea un proyecto de consola con el nombre "DebuggingPractice" y pega el código proporcionado a continuación en tu archivo Program.cs. ¡Este código está lleno de errores! Utiliza lo que has aprendido hasta ahora sobre depuración para abrirte camino a través de cada desafío. Toma nota de cuáles eran los problemas y cómo los resolviste. Cuando hayas terminado, sube el proyecto corregido a la plataforma (¡con todos los archivos y carpetas que lo rodean, por favor!)​

Nota: no existe una única forma de resolver algunos de estos problemas (de hecho, algunos podrían no tener solución). Tú decides cómo abordar el problema.​<p>

<pre><code class='language-cs'>
// Challenge 1
bool amProgrammer = "true";
int Age = 27.9;
List<string> Names = new List<string>();
Names = "Monica";
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", 0);
// This is a tricky one! Hint: look up what a char is in C#
string MyName = 'MyName';
// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(MoreNumbers[i]);
}
// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        num = 0;
    }
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString[7] = "p";
// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
</code></pre>