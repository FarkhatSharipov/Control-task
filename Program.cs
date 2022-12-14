// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна
// 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
string[] arrayInput = new string[7] {"git", "hub", "geek", "brains", "control", "task", "abc"};
string[] arrayOutput = new string[arrayInput.Length];
void ArrayOutput(string[] arrayInput, string[] arrayOutput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
    if(arrayInput[i].Length <= 3)
        {
        arrayOutput[count] = arrayInput[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayOutput(arrayInput, arrayOutput);
PrintArray(arrayOutput);
