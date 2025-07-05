int[] numbers = { 1, 2, 3, 4, 5 };

var rotatedNumbers = ArrayRotation(numbers, 3);

foreach (var num in rotatedNumbers)
{
    System.Console.WriteLine(num);
}


int[] ArrayRotation(int[] array, int k)
{
    int n = array.Length;
    if (n == 0 || k <= 0 || array == null)
    {
        return array; // No rotation needed
    }

    k = k % n; /// Normalize k to avoid unnecessary rotations

    ReverseArray(array, 0, n - 1); /// Reverse the entire array, array = { 5, 4, 3, 2, 1 }
    ReverseArray(array, 0, k - 1); /// Reverse the first k elements, array = { 3, 4, 5, 2, 1 }
    ReverseArray(array, k, n - 1); /// Reverse the remaining n-k elements, array = { 3, 4, 5, 1, 2 }

    return array;
}

void ReverseArray(int[] array, int start, int end)
{
    if (start < 0 || end >= array.Length || start >= end)
    {
        return; // Invalid parameters, no action taken
    }

    while (start < end)
    {
        var temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        start++;
        end--;
    }
}
