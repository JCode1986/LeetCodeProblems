# 283. Move Zeroes
  
*Author: Joseph Hangarter*

---

### Problem Domain
Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [0,1,0,3,12] | [1,3,12,0,0] |

### Constraints:
* You must do this in-place without making a copy of the array.
* Minimize the total number of operations.

---

### Approach & Efficiency
* Iterate through array, and find zeroes
* If element is zero, iterate from that element to the end of the array, and swapping non zeroes with current index

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(1) |

