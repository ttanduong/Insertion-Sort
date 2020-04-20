# Sort algorithm

## 1. Insertion Sort

### Pseudocode

#### Ascending

    INSERTION-SORT(A)

    for j = 2 to A:length

       key = A[j]

       // Insert A[j] into the sorted sequence A[1..j-1].

       i = j - 1

       while i > 0 and A[i] > key

          A[i+1] = A[i]

          i = i - 1

       A[i+1] = key

#### Descending

    for j = A:length-1 downto 1

       key = A[j]

       // Insert A[j] into the sorted sequence A[j+1..Length].

       i = j + 1

       while i < A.Length and A[i] > key

          A[i-1] = A[i]

          i = i + 1

       A[i-1] = key

### Time complexity: O(n^2)

## 2. Selection Sort

### Pseudocode

    SELECTION-SORT(A)

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
       
### Time complexity: O(n^2)

## 3. Merge Sort

### Pseudocode

#### Ascending

## 4. Bubble Sort

### Pseudocode

#### Ascending

    BUBBLE-SORT(A)

    for i = 1 to A:length - 1
    
       for j = A.Length dowto i + 1
          
          if A[j] > A[j-1]
             
             temp = A[i]
             
             A[i] = A[j-1]
             
             A[j-1] = temp
