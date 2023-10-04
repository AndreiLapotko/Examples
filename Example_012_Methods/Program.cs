// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
// маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого "
            + "Винценгероде, вы бы взяли приступом согласие "
            + "прусского короля. Вы так красноречивы. Вы "
            + "дадите мне чаю?";

string Replace(string txt, char oldChar, char newChar)
{
    string result = string.Empty;

    for (int i = 0; i < txt.Length; i++)
    {
        if (txt[i] != oldChar) result += txt[i];
        else result += newChar; 
    }

    return result;
}

string newText = Replace(text, ' ', '|');
string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);