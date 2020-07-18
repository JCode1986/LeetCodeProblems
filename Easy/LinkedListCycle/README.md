# 141. Linked List Cycle

  
*Author: Joseph Hangarter*

---

### Problem Domain
Given a linked list, determine if it has a cycle in it.

To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| head = [3,2,0,-4], pos = 1 | true |

##### Explanation: 
There is a cycle in the linked list, where tail connects to the second node.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| head = [1,2], pos = 0| true |

##### Explanation: 
There is a cycle in the linked list, where tail connects to the first node.

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| head = [1], pos = -1| false |

##### Explanation: 
There is no cycle in the linked list.

### Constraints:
Can you solve it using O(1) (i.e. constant) memory?

---

### Approach & Efficiency



### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

