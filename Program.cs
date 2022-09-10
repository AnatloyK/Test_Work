Console.WriteLine("Здравствуйте");
Console.WriteLine("Напишите слова через пробел");
string text = Console.ReadLine();
string[] array = text.Split(" ").ToArray();
Console.WriteLine("[{0}]", string.Join(", ", array));
string[] NewArray = new string[array.Length];
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3) 
    {
        NewArray[count] = array[i];
        count++;
    }
}
NewArray = NewArray.Where(x => x != null).ToArray();
Console.WriteLine("[{0}]", string.Join(", ", NewArray));