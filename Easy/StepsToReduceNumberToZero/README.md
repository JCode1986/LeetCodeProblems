# 1342. Number of Steps to Reduce a Number to Zero
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given a non-negative integer num, return the number of steps to reduce it to zero. If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| 14 | 6 |

##### Explanation: 
Step 1) 14 is even; divide by 2 and obtain 7.   
Step 2) 7 is odd; subtract 1 and obtain 6.  
Step 3) 6 is even; divide by 2 and obtain 3.   
Step 4) 3 is odd; subtract 1 and obtain 2.   
Step 5) 2 is even; divide by 2 and obtain 1.   
Step 6) 1 is odd; subtract 1 and obtain 0.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| 8 | 4 |

##### Explanation: 
Step 1) 8 is even; divide by 2 and obtain 4.   
Step 2) 4 is even; divide by 2 and obtain 2.   
Step 3) 2 is even; divide by 2 and obtain 1.   
Step 4) 1 is odd; subtract 1 and obtain 0.  

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| 123 | 12 |

### Constraints:
* 0 <= num <= 10^6

---

### Approach & Efficiency
* Have a counter variable
* Utilizing a while loop, if the integer is not 0, check if the number is odd or even. If odd then deduct 1, otherwise divide by2
* Increment counter and return

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

