# 1480. Running Sum of 1d Array
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 1, 2, 3, 4 ] | [ 1, 3, 6, 10 ] |

Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 1, 1 ,1, 1, 1 ] | [ 1 ,2, 3 ,4, 5 ] |

Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 3, 1, 2, 10, 1 ] | [ 3, 4, 6, 16, 17 ] |

### Constraints:

1 <= nums.length <= 1000  
-10^6 <= nums[i] <= 10^6

---

### Approach & Efficiency
* Have a running sum variable, and a result array for the running sums
* Iterate through array; update the running sum by adding every element, place this running sum in the result array
* Return result array

### Big O
Iterating through every element in array, and creating a new array with n elements.

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

