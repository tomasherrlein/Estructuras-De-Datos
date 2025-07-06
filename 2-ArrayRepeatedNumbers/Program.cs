int[] numbers = { 1, 2, 3, 4 };

System.Console.WriteLine(HasRepeatedNumbers(numbers));
bool HasRepeatedNumbers(int[] array)
{
    var uniqueValues = new HashSet<int>();

    foreach (var number in array)
    {
        if (!uniqueValues.Add(number))
        {
            return true;
        }
    }

    return false;
}
