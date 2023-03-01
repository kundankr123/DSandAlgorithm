namespace DSandAlgorithmProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Master Branch of DS-Algo Problems");

            //Bubblesort sort = new  Bubblesort();
            //sort.Display();

            //Insertionsort sort = new Insertionsort();
            //sort.Display();

            int[] arr = { 510, 7, 501, 11, 101 };
            Console.WriteLine("Array before sorting:");
            Mergesort.PrintArray(arr);
            Mergesort.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nArray after sorting:");
            Mergesort.PrintArray(arr);
        }
    }
}