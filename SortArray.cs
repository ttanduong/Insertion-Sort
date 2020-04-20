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
	/* Insertion Sort for ascending */
	public void InsertionSortAsc(int[] a)
	{
		for (int j = 1; j < a.Length; j++)
		{
			int key = a[j];
			int i = j - 1;
			
			//Insert key into the sorted sequence a[0..j-1]
			//if the key is smaller than some elements of that sequence
			while ((i >= 0) && (a[i] > key))
			{
				a[i+1] = a[i];
				i--;				
			}		
			a[i+1] = key;
		}		
	}
	
	/* Insertion Sort for descending */
	public void InsertionSortDes(int[] a)
	{
		for (int j = a.Length-2; j >= 0; j--)
		{
			int key = a[j];
			int i = j + 1;
			
			//Insert a[j] into the sorted sequence a[j+1..Length-1]
			//if the key is greater than some elements of that sequence
			while ((i <= a.Length-1) && (a[i] > key))
			{
				a[i-1] = a[i];
				i++;				
			}		
			a[i-1] = key;
		}		
	}
	
	/* Selection Sort for ascending */
	public void SelectionSortAsc(int[] a)
	{
		for (int i = 0; i < a.Length-1; i++)
		{
			int min = a[i];
			int minIndex = i;
			
			//Find the smallest element of sequence a[i..Length-1]
			for (int j = i; j < a.Length; j++)
			{
				if (a[j] < min)
				{
					min = a[j];
					minIndex = j;
				}
			}
			
			//Swap the smallest element with the fisrt element of sequence a[i..Length-1]
			if (minIndex != i)
			{
				a[minIndex] = a[i];
				a[i] = min;
			}
		}
	}
	
	/* Merge Sort */
	public void MergeSort(int[] A, int start, int end)
	{
		if (start < end)
		{
			int mid = (int)(start + end)/2;
			
			//Merge sort for first sub-array
			MergeSort(A, start, mid);
			
			//Merge sort for second sub-array
			MergeSort(A, mid+1, end);
			
			//Merge 2 sorted sub-elements
			MergeSortRun(A, start, mid, end);
		}		
	}
	
	/* Merge 2 sorted sub-arrays of A[s..e]
	 * First sorted sub-array: L[] = A[s..m]
	 * Second sorted sub-array: R[] = A[m+1..e]
	 */
	public void MergeSortRun(int[] A, int start, int mid, int end)
	{		
		int[] L = new int[mid - start + 1];  	//Left sub-array
		int[] R = new int[end - mid];		//Right sub-array
		
		//Copy elements of A[] array to L[] and R[] sub-array
		for (int i = 0; i < L.Length; i++)
		{
			L[i] = A[start + i];
		}
		for (int i = 0; i < R.Length; i++)
		{
			R[i] = A[i + mid + 1];
		}		
				
		int lIndex = 0;		//Index of L[] sub-array
		int rIndex = 0;		//Index of R[] sub-array
		
		//Merge 2 sub-arrays back into array A[s..e]
		for (int i = start; i <= end; i++)
		{
			if (L[lIndex] < R[rIndex])	A[i] = L[lIndex++];				
			else	A[i] = R[rIndex++];				
			
			//In case all elements of L[] have already been copied to A[]
			//Copy remaining elements of R[] sub-array back into A[]
			if (lIndex >= L.Length)
			{
				Array.Copy(R, rIndex, A, i + 1, R.Length - rIndex);
				break;
			}
			
			//In case all elements of R[] have already been copied to A[]
			//Copy remaining elements of L[] sub-array back into A[]
			if (rIndex >= R.Length)
			{
				Array.Copy(L, lIndex, A, i + 1, L.Length - lIndex);
				break;
			}
		}
	}
}
