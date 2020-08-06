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

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| 1->2->2->1 | true |

---

### Approach & Efficiency
* Instantiate an empty list
* Iterate through linked list and add every node value to list
* Iterate through linked list, and iterate through list with values starting at the end (length - 1)
* Compare node values and list values
* Return false if values does not match, otherwise return true

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

