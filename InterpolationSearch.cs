class Interpolation
{
    public static void Main()
    {
        int[] arr = new int[] { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 25 };

        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());

        int n = arr.Length; 
        int index = InterpolationSearch(arr, 0, n - 1, x);

        if(index != -1)
            Console.WriteLine("Element found at index " + index);

        else
            Console.WriteLine("Element not Found");
    }
    static int InterpolationSearch(int []arr,int low,int high,int x)
    {
        int position;

        if(low <= high && x >= arr[low] && x < arr[high])
        {
            position = low + (((high - low) / (arr[high] - arr[low])) * (x - arr[low]));

            if(arr[position] == x)
                return position;

            if (arr[position] < x)
                return InterpolationSearch(arr,position+1,high,x);

            if(arr[position] > x)
                return InterpolationSearch(arr,position-1,low,x);
        }
        return -1;
    }
}