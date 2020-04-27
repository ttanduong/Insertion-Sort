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

    MERGE(A, p, q, r)

    n1 = q - p + 1
    
    n2 = r - q
    
    Let L[1..n1], R[1..n2] be new arrays
    
    for i = 1 to n1
    
       L[i] = A[p+i-1]
    
    for i = 1 to n1
    
       L[i] = A[p+i-1]
    
    i = 1
    
    j = 1
    
    for k = p to r
       
       if L[i] <= R[i]
       
          A[k] = L[i]
          
          i = i + 1
       
       else A[k] = R[i]
       
          j = j + 1
          
       if i >= L.Length
       
          Copy the rest of R[] array to A and break out of for loop
          
       if j >= R.Length
       
          Copy the rest of L[] array to A and break out of for loop
          

    MERGE-SORT(A, p, r)
    
    if p < r
    
       q = (p + r)/2
       
       MERGE-SORT(A, p, q)
       
       MERGE-SORT(A, q + 1, r)
       
       MERGE(A, p, q, r)

### Time complexity: O(n*lgn)

## 4. Mix Merge sort with insertion and selection

### Pseudocode

    MIXMERGEINSERTION(A, p, r)
            
    if p < r
       
       if r - q + 1 <= 20
       
          INSERTION-SORT(A)(A)
          
       else   m = (r + q)/2
          
          MERGE-SORT(A, p, m)
          
          MERGE-SORT(A, m + 1, r)
          
          MERGE(A, p, m, r)


    MIXMERGESELECTION(A, p, r)
            
    if p < r
       
       if r - q + 1 <= 15
       
          SELECTION-SORT(A)
          
       else   m = (r + q)/2
          
          MERGE-SORT(A, p, m)
          
          MERGE-SORT(A, m + 1, r)
          
          MERGE(A, p, m, r)

## 5. Bubble Sort

### Pseudocode

#### Ascending

    BUBBLE-SORT(A)

    for i = 1 to A:length - 1
    
       for j = A.Length dowto i + 1
          
          if A[j] > A[j-1]
             
             temp = A[i]
             
             A[i] = A[j-1]
             
             A[j-1] = temp

### Time complexity: O(n^2)
