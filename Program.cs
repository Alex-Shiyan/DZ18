//
// Домашнее задание к занятию 18. Коллекции
//
// Задача 1. Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
// Проверить, корректно ли в ней расставлены скобки.
// Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
// Указание: задача решается однократным проходом по символам заданной строки слева направо;
// для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
// каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
// в конце прохода стек должен быть пуст.

Console.WriteLine("Введите строку");
string stringS = Console.ReadLine();

if (Check(stringS) == true)
    Console.WriteLine("Строка корректна");
else
    Console.WriteLine("Строка не корректна");

Console.ReadKey();


static bool Check(string stringS)
{

    Stack<char> stackS = new Stack<char>();

    Dictionary<char, char> dictionaryD = new Dictionary<char, char>
    {
        {'(',')'},
        {'[',']'},
        {'{','}'},
    };

    foreach (char c in stringS)
    {
        if (c == '(' || c == '{' || c == '[')
            stackS.Push(dictionaryD[c]);
        if (c == ')' || c == '}' || c == ']')
        {
            if (stackS.Count == 0 || stackS.Pop() != c)
                return false;
        }
    }
    if (stackS.Count == 0)
        return true;
    else
        return false;   
}

