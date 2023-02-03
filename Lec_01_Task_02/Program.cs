int[] array = {1, 2, 3, 4, 5, 6, 7, 8 , 9};
int Chosen(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int max = Chosen( 
Chosen(array[0], array[1], array[2]), 
Chosen(array[3], array[4], array[5]), 
Chosen(array[6], array[7], array[8])
);

Console.WriteLine(max);