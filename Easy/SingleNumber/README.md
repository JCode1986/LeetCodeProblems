# 136. Single Number
  
*Author: Joseph Hangarter*

---

### Problem Domain
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [2,2,1] | 1 |

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [4,1,2,1,2] | 4 |

---

### Approach & Efficiency
* Instantiate a dictionary, and iterate through array adding the element as the key and a counter as the value
* Iterate through dictionary and return key with value of one

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

