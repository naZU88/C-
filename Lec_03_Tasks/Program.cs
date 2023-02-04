
/* Методы в C#:
1 группа(void): не принимают - не возвращают
2 группа(void): принимают - не возвращают
3 группа: не принимают - возвращают
4 группа: принимают - возвращают

1 группа:
void Method1()
{
    Console.WriteLine("Автор...");
}

Вызов:
Method1();

2 группа:
void Method1(string msg)
{
    Console.WriteLine(msg);
}

Вызов:
Method1("Текст сообщения");

*/

//Задача: заменить все к на К, а С на с

string text = "– Я думаю, – сказал князь, улыбаясь," +
"– что, ежели бы вас послали вместо нашего милого Винценгероде," + 
"вы бы взяли приступом согласие прусского короля. Вы так красноречивы." + 
"Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result +$"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '+');
Console.WriteLine(newText);

//Задача: сортировка
int[] array = {1, 2, 5, 5, 8, 3, 0};
