using System;
					
public class Program
{
	public static void Main()
	{
		int[] exampleArray = new int[]{51, 1, 15, 100, 8, 70, 32, 45};	
		SortArray sort = new SortArray();	
		
		for (int i = 0; i < exampleArray.Length; i++)
		{
			Console.Write(exampleArray[i] + " ");
		}	
		Console.WriteLine();
			
		//sort.InsertionSortDes(exampleArray);
		//sort.SelectionSortAsc(exampleArray);
		sort.MergeSort(exampleArray, 0, exampleArray.Length-1);
	
		for (int i = 0; i < exampleArray.Length; i++)
		{
			Console.Write(exampleArray[i] + " ");
		}
	}
}

public class SortArray
{	
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
	
	//Merge Sort
	public void MergeSort(int[] A, int start, int end)
	{
		if (start < end)
		{
			int mid = (int)(start + end)/2;
		
			MergeSort(A, start, mid);
			MergeSort(A, mid+1, end);
			MergeSortRun(A, start, mid, end);
		}		
	}
	
	public void MergeSortRun(int[] A, int start, int mid, int end)
	{		
		int[] L = new int[mid - start + 1];  
		int[] R = new int[end - mid];
		
		for (int i = 0; i < L.Length; i++)
		{
			L[i] = A[start + i];
		}
		for (int i = 0; i < R.Length; i++)
		{
			R[i] = A[i + mid + 1];
		}		
		
		int lIndex = 0, rIndex = 0;
		for (int i = start; i <= end; i++)
		{
			if (L[lIndex] < R[rIndex])
			{
				A[i] = L[lIndex];
				lIndex++;
			}
			else
			{
				A[i] = R[rIndex];
				rIndex++;
			}
			
			if (lIndex >= L.Length)
			{
				Array.Copy(R, rIndex, A, i + 1, R.Length - rIndex);
				break;
			}
			
			if (rIndex >= R.Length)
			{
				Array.Copy(L, lIndex, A, i + 1, L.Length - lIndex);
				break;
			}
		}
	}
}
