using System;
					
public class Program
{
	public static void Main()
	{
		int[] arr = new int[]{31, 41, 59, 26, 41, 58};	
		
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}	
		
	//	InsertionSortAsc(arr);
		InsertionSortDes(arr);
			
		Console.WriteLine();
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}
	}
	
	//Insertion Sort for ascending
	static void InsertionSortAsc(int[] a)
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
	static void InsertionSortDes(int[] a)
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
