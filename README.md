# **В репозитории решена следующая задача:**

>### Написана программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

Первоначальный массив задается на старте выполнения алгоритма

Например:

~~~
{
    string[] words = {"Someday", "getting", "a", "full-fledged", "profession", "via",
    "the", "Internet", "will", "become", "a", "new", "reality", "for", "humanity"};
}
~~~

Затем из заданного массива выбираем элементы, удовлетворяющие условию задачи, и формируем из них новый массив:

~~~
{
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
}
~~~

После чего возвращаем в терминал вновь созданный массив.