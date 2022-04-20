// // Вид1 
// // Описание
// Console.WriteLine();
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

// // Вид2
// //Описание
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Вызов
// Console.WriteLine();
// Method2(msg: "Текст сообщения");

// // Описание
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Вызов
// Console.WriteLine();
// Method21(msg:"Текст", count:4);
// Console.WriteLine();
// Method21(count:4, msg:"Новый текст");
// Console.WriteLine();


// // Вид3
// // Описание
//  int Method3()
//  {
//      return DateTime.Now.Year;
//  }
//  int year = Method3();
//  Console.WriteLine(year);
//  Console.WriteLine();

//  // Вид4
//  //Описание
//  string Method4(int count, string text)
//  {
//      int i = 0;
//      string result = String.Empty;
//      while (i < count)
//      {
//          result = result + text;
//          i++;
//      }
//      return result;
//  }
// string res = Method4(10, "z");
// Console.WriteLine(res);
// Console.WriteLine();

// string Method41(int index, string tekst)
// {
//     string results = String.Empty;
//     for (int i = 0; i < index; i++)
//     {
//         results = results + tekst;
//     }
//     return results;
// }
// string res2 = Method41(20, "x");
// Console.WriteLine(res2);
// Console.WriteLine();


// for (int x = 2; x <= 10; x++)
// {
//     for (int y = 2; y <= 10; y++)
//     {
//         Console.WriteLine($"{x} * {y} = {x * y}");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// string tex = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             +"ежели бы вас послали вместо нашего милого Винценгороде,"
//             +"вы бы взяли приступом согласие прусского короля."
//             +"Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string tex, char OldValue, char NewValue)
// {
//     string resultat = String.Empty;
//     int length = tex.Length;
//     for (int z = 0; z < length; z++)
//     {
//         if(tex[z] == OldValue) resultat = resultat + $"{NewValue}";
//         else resultat = resultat + $"{tex[z]}";
//     }
//     return resultat;
// }
// string newTex = Replace(tex, ' ', '|');
// Console.WriteLine(newTex);
// Console.WriteLine();
// newTex = Replace(tex, 'к', 'К');
// Console.WriteLine(newTex);
// Console.WriteLine();



// Задача по упорядочиванию массива
// Функции (продолжение) | Лекция 3
// Допустим имеется какая-то последовательность чисел 6 8 3 2 1 4 5 7.
// Задача - выбрать самый первый элемент и в оставшихся числах выбрать минимальное.
// После того, как найден минимальный элемент, нужно поменять его местами с первым
// элементом. То есть последовательность теперь будет 1 8 3 2 6 4 5 7.
// Далее выбирается второй рабочий элемент (8) и он меняется местами с минимальным числом 
// из оставшихся, то есть последовательность будет 1 2 3 8 6 4 5 7. и т.д.
// Таким образом, все числа должны быть в последовательном порядке 1 2 3 4 5 6 7 8.


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int num = array.Length;
    for (int a = 0; a < num; a++)
    {
        Console.Write($"{array[a]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int a = 0; a < array.Length - 1; a++)
    {
        int minPosition = a;
        for (int b = a + 1; b < array.Length; b++)
        {
            if(array[b] < array[minPosition]) minPosition = b;
        }
        int temporary = array[a];
        array[a] = array[minPosition];
        array[minPosition] = temporary;
        //Console.WriteLine(array[a]);
        //Console.Write(array[minPosition]);
    }
} 
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);