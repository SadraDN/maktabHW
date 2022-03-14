
Console.WriteLine("please enter interger array:");
var input = Console.ReadLine();
string [] inputArray = input.Split(',');
int[] inputNumber = new int[inputArray.Length];

for (int i = 0; i < inputArray.Length; i++)
{
    inputNumber[i] = Convert.ToInt32(inputArray[i]);
}

Console.WriteLine("Minimum : " + Min(inputNumber));


int [] reverseResult = new int [inputNumber.Length];
reverseResult = Reverse(inputNumber);
Console.Write("Reverse:");
for (int i = 0; i < reverseResult.Length; i++)
{
    Console.Write( reverseResult[i] + ",");
}

Sort(inputNumber);

for (int i = 0; i < inputNumber.Length; i++)
{
    Console.Write (inputNumber[i]+ ",");
}


//Min
int Min (int[] arr)
{ 
            int min = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                    min = item;
            }
            return min;
    
}

//Reverse
int[] Reverse (int[] arr)
{
    int[] reverse = new int[arr.Length];
    for (int i = arr.Length-1 ; i >= 0 ; i--)
    {
        reverse[arr.Length-1-i] = arr[i];
    }
    return reverse;
}



//Sort
void Swap(int[] arr, int index1, int index2)
{
    int temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;
}

void Sort(int[] arr)
{
    while (true)
    {
        bool unchanged = true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                Swap(arr, i, i + 1);
                unchanged = false;
            }
        }
        if (unchanged == true)
            return;
    }
}

//SecondArray
Console.WriteLine("How many numbers do you want to enter for second array?");
int input2 = Convert.ToInt32(Console.ReadLine());
int[] inputNumber2 = new int[input2];
for (int i = 0; i < input2; i++)
{
    Console.WriteLine($"enter number {i + 1}");
    inputNumber2[i] = Convert.ToInt32(Console.ReadLine());
}
