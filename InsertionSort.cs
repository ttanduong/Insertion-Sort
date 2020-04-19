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

public class InsertionSort
{
	private int[] a;
	
	//Constructor
	public InsertionSort(int[] arr)
	{
		a = arr;
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
	
	//Insertion Sort for Descending	 
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
}
