# Sort algorithm

## 1. Insertion Sort

### Pseudocode

    for j = 2 to A:length

       key = A[j]

       // Insert A[j] into the sorted sequence A[1..j-1].

       i = j - 1

       while i > 0 and A[i] > key

          A[i+1] = A[i]

          i = i - 1

       A[i+1] = key

### Time cost: O(n^2)

## 2. Selection Sort

### Pseudocode

    for j = 1 to A:length-1
    
       min = A[i]
       
       // Find smallest element of A[i..Length]
       
       for j = i to A.Length

          if A[j] < min
          
             min = A[j]
             
             minIndex = j
          
       if minIndex != i
       
          A[minIndex] = A[i]
          
          A[i] = min
       
### Time cost: O(n^2)
