# 1470. Shuffle the Array
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

Return the array in the form [x1,y1,x2,y2,...,xn,yn].

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 2, 5, 1, 3, 4, 7], n = 3 | [ 2, 3, 5, 4, 1, 7 ] |

Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 1, 2, 3, 4, 4, 3, 2, 1 ], n = 4 | [ 1, 4, 2, 3, 3, 2, 4, 1 ] |


#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 1, 1, 2, 2 ], n = 2 | [ 1, 2, 1, 2 ] |

### Constraints:
* 1 <= n <= 500
* nums.length == 2n
* 1 <= nums[i] <= 10^3

---

### Approach & Efficiency
* Instantiate a list
* Iterate half the length of the input array
* Add the first element to the list from the input array, and then add the half of the length plus current index. This will shuffle back from the first half of the array, and the second half of the array.
* Return the newly shuffled list, and convert into array. 

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

