Console.Clear();

//Стиль Pascal
int BackColor = 0;

//Стиль Camel
string bordColor = String.Empty;

//Переменные стиль Camel методы стиль Pascale

//TODO: пишем временный код



bool Method(int number)
{
    return number % 2 == 0;
}
//Можно записать так 
bool Method_2 (int number) => number % 2 == 0;

//Или так 
var Method_3 = (int number) => number % 2 == 0;

//var - автоматически определяет тип
var str = "Hello";
var num = 4;

//Узнаем тип переиенных с помощью GetType().Name
Console.WriteLine(str.GetType().Name);
Console.WriteLine(num.GetType().Name);
