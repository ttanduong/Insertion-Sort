using System;
					
public class Program
{
	public static void Main()
	{
		int[] exampleArray = new int[]{31, 41, 59, 26, 41, 58};	
		InsertionSort sort = new InsertionSort(exampleArray);		
		
		for (int i = 0; i < exampleArray.Length; i++)
		{
			Console.Write(exampleArray[i] + " ");
		}	
			
		//sort.InsertionSortAsc(exampleArray);
		sort.InsertionSortDes(exampleArray);
			
		Console.WriteLine();
		for (int i = 0; i < exampleArray.Length; i++)
		{
			Console.Write(exampleArray[i] + " ");
		}
	}
}

public class SortArray
{
	private int[] array;
	
	//Constructor
	public SortArray(int[] a)
	{
		array = a;
	}
	
	//Insertion Sort for ascending
	public void InsertionSortAsc(int[] a)
	{
		for (int j = 1; j < a.Length; j++)
		{
			int key = a[j];
			int i = j - 1;
			
			while ((i >= 0) && (a[i] > key))
			{
				a[i+1] = a[i];
				i--;				
			}		
			a[i+1] = key;
		}		
	}
	
	//Insertion Sort for descending	 
	public void InsertionSortDes(int[] a)
	{
		for (int j = a.Length-2; j >= 0; j--)
		{
			int key = a[j];
			int i = j + 1;
			
			while ((i <= a.Length-1) && (a[i] > key))
			{
				a[i-1] = a[i];
				i++;				
			}		
			a[i-1] = key;
		}		
	}
	
	//Selection Sort for ascending
	public void SelectionSortAsc(int[] a)
	{
		for (int i = 0; i < a.Length-1; i++)
		{
			int min = a[i];
			int minIndex = i;
			
			for (int j = i; j < a.Length; j++)
			{
				if (a[j] < min)
				{
					min = a[j];
					minIndex = j;
				}
			}
			
			if (minIndex != i)
			{
				a[minIndex] = a[i];
				a[i] = min;
			}
		}
	}
}
