// Дан файл numsTask2.txt с вещественными числами, расположенными через «;» Переберите все числа до 0.
// Определите сумму положительных элементов получившейся последовательности;

using System;
using System.IO;
class work_4_2
{
    static void Main()
    {
        string fael = "numsTask2.txt"; 
        string[] faelNumbers = File.ReadAllText(fael).Split(';'); 
        float sum = 0;

        foreach (string i in faelNumbers)
        {
            if (float.TryParse(i, out float number)) 
                if (number > 0)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"Сумма положительный чисел: {sum}");
                    break;
                }
            }
        }
    }

}

