# 896. Monotonic Array
  
*Author: Joseph Hangarter*

---

### Problem Domain

An array is monotonic if it is either monotone increasing or monotone decreasing.

An array A is monotone increasing if for all i <= j, A[i] <= A[j].  An array A is monotone decreasing if for all i <= j, A[i] >= A[j].

Return true if and only if the given array A is monotonic.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,2,3] | true |

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [6,5,4,4] | true |

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,3,2]| false |

#### Example 4:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,4,5]| true |

#### Example 5:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,1,1]| true |

### Constraints:
* 1 <= A.length <= 50000
* -100000 <= A[i] <= 100000

---

### Approach & Efficiency


### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(1) |

