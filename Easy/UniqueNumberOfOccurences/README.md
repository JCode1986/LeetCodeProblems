# 1207. Unique Number of Occurrences
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,2,1,1,3] | true |

##### Explanation: 
The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2] | false |

Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [-3,0,1,-3,1,1,1,-3,10,0] | true |
 
### Constraints:
* 1 <= arr.length <= 1000
* -1000 <= arr[i] <= 1000

---

### Approach & Efficiency

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

