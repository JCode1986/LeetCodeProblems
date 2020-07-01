# 1281. Subtract the Product and Sum of Digits of an Integer
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given an integer number n, return the difference between the product of its digits and the sum of its digits.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| 234 | 15 |

##### Explanation: 
Product of digits = 2 * 3 * 4 = 24 
Sum of digits = 2 + 3 + 4 = 9 
Result = 24 - 9 = 15

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| 4421 | 21 |

##### Explanation: 
Product of digits = 4 * 4 * 2 * 1 = 32 
Sum of digits = 4 + 4 + 2 + 1 = 11 
Result = 32 - 11 = 21
 
### Constraints:
* 1 <= n <= 10^5

---

### Approach & Efficiency
* Have a variable for `product` set to 1 and `sum` set to 0
* Iterate through array, and get product & sum of elements in array
* Return the product minus the sum

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

