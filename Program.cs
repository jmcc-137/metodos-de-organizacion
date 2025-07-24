internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {

            Console.Clear();
            Console.WriteLine("ALGORITMOS DE ORDENAMIENTO,Escoge un algioritmo de ordenamiento:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Merge Sort");
            Console.WriteLine("5.Quick Sort");
            Console.WriteLine("6.salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
                    Console.WriteLine("Array original: " + string.Join(", ", arr));
                    BubbleSort(arr);
                    Console.WriteLine("Array ordenado: " + string.Join(", ", arr));
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 2:
                    int[] arr2 = { 64, 25, 12, 22, 11 };
                    Console.WriteLine("Array original: " + string.Join(", ", arr2));
                    InsertionSort(arr2);
                    Console.WriteLine("Array ordenado: " + string.Join(", ", arr2));
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    int[] arr3 = { 64, 25, 12, 22, 11 };
                    Console.WriteLine("Array original: " + string.Join(", ", arr3));
                    SelectionSort(arr3);
                    Console.WriteLine("Array ordenado: " + string.Join(", ", arr3));
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4:
                    int[] arr4 = { 38, 27, 43, 3, 9, 82, 10 };
                    Console.WriteLine("Array original: " + string.Join(", ", arr4));
                    mergeSort.MergeSort(arr4, 0, arr4.Length - 1);
                    Console.WriteLine("Array ordenado: " + string.Join(", ", arr4));
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 5:
                    int[] arr5 = { 10, 7, 8, 9, 1, 5 };
                    Console.WriteLine("Array original: " + string.Join(", ", arr5));
                    quickSort.QuickSort(arr5, 0, arr5.Length - 1);
                    Console.WriteLine("Array ordenado: " + string.Join(", ", arr5));
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opcion no valida. PONGA ESO BIEN");
                    break;
            }
        }
    }

    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Intercambio
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

    }
    public static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int actual = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > actual)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = actual;
        }
    }

    public static void SelectionSort(int[] arr)
    {

        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }
    public static class mergeSort
    {
        public static void MergeSort(int[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int medio = (inicio + fin) / 2;

                MergeSort(arr, inicio, medio);
                MergeSort(arr, medio + 1, fin);
                Merge(arr, inicio, medio, fin);
            }
        }

        public static void Merge(int[] arr, int inicio, int medio, int fin)
        {
            int[] resultado = new int[fin - inicio + 1];

            int i = inicio, j = medio + 1, k = 0;

            while (i <= medio && j <= fin)
            {
                if (arr[i] <= arr[j]) resultado[k++] = arr[i++];
                else resultado[k++] = arr[j++];
            }

            while (i <= medio) resultado[k++] = arr[i++];
            while (j <= fin) resultado[k++] = arr[j++];

            for (int l = 0; l < resultado.Length; l++)
                arr[inicio + l] = resultado[l];
        }
    }

    public class quickSort
    {
        public static void QuickSort(int[] arr, int bajo, int alto)
    {
        if (bajo < alto)
        {
            int pi = Particionar(arr, bajo, alto);

            QuickSort(arr, bajo, pi - 1);
            QuickSort(arr, pi + 1, alto);
        }
    }

    public static int Particionar(int[] arr, int bajo, int alto)
    {
        int pivote = arr[alto];
        int i = bajo - 1;

        for (int j = bajo; j < alto; j++)
        {
            if (arr[j] < pivote)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]); // Intercambio
            }
        }

        (arr[i + 1], arr[alto]) = (arr[alto], arr[i + 1]);
        return i + 1;
    }
    }
}