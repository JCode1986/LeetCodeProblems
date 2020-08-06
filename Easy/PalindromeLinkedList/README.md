# 234. Palindrome Linked List
  
*Author: Joseph Hangarter*

---

### Problem Domain
Given a singly linked list, determine if it is a palindrome.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| 1->2  | false |

Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| 1->2->2->1 | true |

---

### Approach & Efficiency

### Big O
Iterating through every element in array, and creating a new array with n elements.

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

