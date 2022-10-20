Console.Write("Введите несколько чисел Через запятую: ");
string strNumbers = Console.ReadLine();

int countNumbers = 1;

for (int i = 0; i < strNumbers.Length; i++)
{
    if (strNumbers[i] == ',')
        countNumbers++;
}

int[] numbers = new int [countNumbers];
int indexNumber = 0;
string substring = string.Empty;
for (int i = 0; i < strNumbers.Length; i++)
{
    if( strNumbers[i] != ',')
    {
        substring += strNumbers[i];
    }
    else
    {
        numbers[indexNumber] = Convert.ToInt32(substring);
        indexNumber++;
        substring = string.Empty;
    }
}

numbers[indexNumber] = Convert.ToInt32(substring);

