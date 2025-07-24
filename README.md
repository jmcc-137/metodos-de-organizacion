# ALGORITMOS DE ORDENAMIENTO EN PROGRAMACION

## QUE SON?

 Los algoritmos de ordenamiento son un conjunto de instrucciones que se utilizan para arreglar o organizar un arreglo o lista  en un orden en especifico

 ## Cuales son:


1. Buble Sort(ORDENAMIENTO BURBUJA)
2. Insertiopn Sort(burbuja)
3. Selection Sort(insercion)
4. Merge Sort(combinacion)
5. Quick Sork(monton)
6. Heap Sort(conteo)
7. Counting Sort(raiz)
8. Radix Sort(cubo)

## EPLICACION DE CADA UN CON EJEMPLOS EN C#

## 1.BUBBLE SORT (ORDENAMIENTO BURBUJA)
#### explicacion
compara elementos adyacentes  y los  intercambia si estan en el orden correcto

```c#
void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i; i < n - 1; i ++)
    {
        for(int j =0; j<n -i -1; j++ )
        {
            if(arr[j] > arr{j+1})
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp
            }
        }
    }
}
```


## 2.INSERTION SORT(INSERCION)

### EXPLICACION:
Toma un elemento y lo inserta en su posicion correcta en una sublista ordenada

```c#
void InsertionSort(int[] arr)
{
    for (int i = 1; < arr.Lenghth; i ++)
    {
        int key = arr[i];
        int j = i-1;
        while(j => 0 && arr[j] >key)
        {
            arr[j + 1] = arr [j];
            j--;
        }
        arr[j+1] = key
    }
}
```


## 3.Selection Sort
### Explicaion:
Busca el menor elemento del arreglo  y lo coloca en la posicion correcta.

```c#
void SelectionSort(int[] arr )
{
    for(int i = 0 ; i < arr.Length-1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < arr. Length; j++)
        {
            if (arr[j] < arr[arrIndex])
            minIndex = j;
        }
        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }
}
```

## 4.Merge Sort(Ordenamiento por mezcla)
### Eplicacion:
Divede ele arreglo en mitades, Oedena cada mitad y luego las mezcla ordenadamente

```c#
    void Merge(int[] arr, int left, int mid, int right)
    {
        if ()
        {
            int mid =(left + right)/2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, int right);
        } 
    }

    void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp new int[right - left +1];
        int i = left, j=mid + 1, k =0;

        while(i<= mid && j <= right)
        {
            if (arr[i] <= arr[j]) temp[k++] = arr[i++];
            else temp[k++] = arr[j++];
        }
        while(i <= mid) temp[k++] = arr[i++];
        while(j <= right) temp[k++] = arr[j++];

        for(i = left; i <= right; i++)
            arr[i] = temp[i - left];

    }
```

## 5.Quick Sort(monton)
### explicacion:
Elige un pivote, divide el arreglo en dos partes(menores y mayores al pivote) y ordena recursivamente

```c#
 void QuickSort(int[] arr, int low, int high)
 {
    if(low < high)
    {
        int pi = Partition(arr, low, high);
        QuickSort(arr, low,pi -1);
        QuickSort(arr, pi + 1, high);
    }
 }
    int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j<high;j++)
        {
            if(arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp
            }
        }
        int t = arr[i + 1];
        arr[i = 1] = arr[high];
        arr[high] = t;

        return i + 1;
    }
 
```
