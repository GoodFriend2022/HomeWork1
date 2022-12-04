// Написать программу, которая из имеющегося массива строк 
// формирует массив строк, длина которых меньше либо равна 3 символа.

void Prompt(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string[] FindElementLessThree(string[] array)
{
    string[] array2 = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[index] = array[i];
            index++;
        }
    }
    string[] elementLessThree = new string[index];
    for (int i = 0; i < elementLessThree.Length; i++)
    {
        elementLessThree[i] = array2[i];
    }
    return elementLessThree;
}

string[] words = {"Someday", "getting", "a", "full-fledged", "profession", "via",
    "the", "Internet", "will", "become", "a", "new", "reality", "for", "humanity"};
Prompt(words);

System.Console.WriteLine(words[2].Length);