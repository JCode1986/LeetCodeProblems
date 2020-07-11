# 160. Intersection of Two Linked Lists
  
*Author: Joseph Hangarter*

---

### Problem Domain
Write a program to find the node at which the intersection of two singly linked lists begins.

For example, the following two linked lists:

### Inputs and Expected Outputs

#### Example 1:  
| Input (J, S)| Expected Output |
| :----------- | :----------- |
| listA = [4,1,8,4,5], listB = [5,6,1,8,4,5] | 8 |

##### Explanation: 
The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [4,1,8,4,5]. From the head of B, it reads as [5,6,1,8,4,5]. There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| listA = [1,9,1,2,4], listB = [3,2,4]| 2 |

##### Explanation: 
The intersected node's value is 2 (note that this must not be 0 if the two lists intersect). From the head of A, it reads as [1,9,1,2,4]. From the head of B, it reads as [3,2,4]. There are 3 nodes before the intersected node in A; There are 1 node before the intersected node in B.

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| listA = [2,6,4], listB = [1,5]| null |

##### Explanation: 
From the head of A, it reads as [2,6,4]. From the head of B, it reads as [1,5]. Since the two lists do not intersect, intersectVal must be 0, while skipA and skipB can be arbitrary values. The two lists do not intersect, so return null.

### Constraints:
* If the two linked lists have no intersection at all, return null.
* The linked lists must retain their original structure after the function returns.
* You may assume there are no cycles anywhere in the entire linked structure.
* Each value on each linked list is in the range [1, 10^9].
* Your code should preferably run in O(n) time and use only O(1) memory.

---

### Approach & Efficiency
* Solution 1

* Solution 2


### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

