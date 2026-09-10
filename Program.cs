using System.Diagnostics;
using System.IO.Compression;

Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {byte.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();
Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float: {float.MinValue} ..{float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();
Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 для byte = {overflowed}");

Console.WriteLine();
Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; // char можно неявно превратить в int - это код символа в таблице Unicode

Console.WriteLine($"Символ: {firstLetter}, разделитель {separator}");
Console.WriteLine($"Код символа '{firstLetter}' в Unicode: {charAsNumber}");
Console.WriteLine($"Табуляция:\tпосле таба");
Console.WriteLine($"Перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal против double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"double: 0.1 + 0.2 = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20; // компилятор вывел int
var gpa = 4.75; // компилятор вывел double
var fullName = "Смирнов А.С"; // компилятор вывел string

Console.WriteLine($"{fullName}, возраст {studentAge}, средний балл {gpa}");

Console.WriteLine();
Console.WriteLine("Ввод текста");

Console.Write("Введите ваше имя: ");
string enteredName = Console.ReadLine();

Console.Write("Введите название вашей группы: ");
string enteredGroup = Console.ReadLine();

Console.WriteLine($"Здравствуйте, {enteredName} из группы {enteredGroup}!");

Console.WriteLine();
Console.WriteLine("Ввод чисел: Convert и Parse");

Console.Write("Введите ваш год рождения: ");
string birthYearInput = Console.ReadLine();

int birthYearConvert = Convert.ToInt32(birthYearInput);
int birthYearParse = int.Parse(birthYearInput);

Console.WriteLine($"Convert.ToInt32: {birthYearConvert}");
Console.WriteLine($"int.Parse:       {birthYearParse}");
Console.WriteLine($"В 2030 году вам будет: {2030 - birthYearConvert} лет");

Console.WriteLine();
Console.WriteLine("Ввод чисел: TryParse");

Console.Write("Введите количество прочитанных книг за семестр: ");
string booksInput = Console.ReadLine();

bool wasSuccessful = int.TryParse(booksInput, out int booksCount);

Console.WriteLine($"Удалось преобразить: {wasSuccessful}");
Console.WriteLine($"Значение переменной booksCount: {booksCount}");

Console.WriteLine();
Console.Write("Введите ваше имя и фамилию: ");
string name = Console.ReadLine();

Console.Write("Введите название группы: ");
string group = Console.ReadLine();

Console.Write("Введите год рождения: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Ваш средний балл за прошлый семестр: ");
double ball = double.Parse(Console.ReadLine());

Console.Write("Ваша любимая буква алфавита: ");
char favorite = Console.ReadLine()[0];

bool good = ball >= 4.0;

Console.WriteLine();
Console.WriteLine("    Анкета    ");
Console.WriteLine($"{name}, группа {group}");
Console.WriteLine($"Год рождения: {age} (в 2030 будет {2030 - age} год)");
Console.WriteLine($"Средний балл: {ball}");
Console.WriteLine($"Балл >= 4.0: {good}");
Console.WriteLine($"Любимая буква: {favorite}");

Console.WriteLine();
Console.WriteLine("    Калькулятор ИМТ    ");

Console.Write("Введите ваш рост в метрах: ");
double height = double.Parse(Console.ReadLine());

Console.Write("Введите ваш вес в килограммах: ");
double weight = double.Parse(Console.ReadLine());

double imt = weight / (height * height);

Console.WriteLine($"ИМТ: {imt:F2}");

Console.WriteLine();
Console.Write("Введите вашу фамилию: ");
string Surname = Console.ReadLine();

Console.Write("Введите ваше имя: ");
string Name = Console.ReadLine();

char first_letter = Name[0];

Console.WriteLine($"{Surname} {first_letter}.");

Console.WriteLine();
Console.Write("Введите целое число: ");
string intInput = Console.ReadLine();
bool intSuccessful = int.TryParse(intInput, out int intCount);
Console.WriteLine($"Целое число: успешно = {intSuccessful}, значение = {intCount}");

Console.Write("Введите дробное число: ");
string doubleInput = Console.ReadLine();
bool doubleSuccessful = double.TryParse(doubleInput, out double doubleCount);
Console.WriteLine($"Дробное число: успешно = {doubleSuccessful}, значение = {doubleCount}");

Console.Write("Введите дату: ");
string dateInput = Console.ReadLine();
bool dateSuccessful = DateTime.TryParse(dateInput, out DateTime dateCount);
Console.WriteLine($"Дата (дд.мм.гггг): успешно = {dateSuccessful}, значение = {dateCount}");