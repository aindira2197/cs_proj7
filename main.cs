int CountEven(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
        if (num % 2 == 0) count++;
    return count;
}
