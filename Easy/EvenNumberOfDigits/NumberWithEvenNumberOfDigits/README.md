# 1295. Find Numbers with Even Number of Digits
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given an array nums of integers, return how many of them contain an even number of digits.

### Inputs and Expected Outputs

| Input | Args | Expected Output |
| :----------- | :----------- | :----------- |
| [ 12, 345, 2, 6, 7896 ]   | N/A | 2 |

#### Explanation:   
* 12 contains 2 digits (even number of digits).   
* 345 contains 3 digits (odd number of digits).     
* 2 contains 1 digit (odd number of digits).   
* 6 contains 1 digit (odd number of digits).   
* 7896 contains 4 digits (even number of digits).    
* Therefore only 12 and 7896 contain an even number of digits. 

| Input | Args | Expected Output |
| :----------- | :----------- | :----------- |
| [ 555, 901, 482, 1771 ]   | N/A | 1 |

#### Explanation:   
* Only 1771 contains an even number of digits.

### Constraints:  
* 1 <= nums.length <= 500  
* 1 <= nums[i] <= 10^5  

---

### Approach & Efficiency


### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

