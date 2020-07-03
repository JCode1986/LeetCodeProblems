# 876. Middle of the Linked List
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given a non-empty, singly linked list with head node head, return a middle node of linked list.

If there are two middle nodes, return the second middle node.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,3,4,5] | 3 |

##### Explanation
Input: [1,2,3,4,5]  
Output: Node 3 from this list (Serialization: [3,4,5])  
The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).  
Note that we returned a ListNode object ans, such that:  
ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.  

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [1,2,3,4,5,6] | 4 |

##### Explanation
Input: [1,2,3,4,5,6]
Output: Node 4 from this list (Serialization: [4,5,6])
Since the list has two middle nodes with values 3 and 4, we return the second one.

### Constraints:
* The number of nodes in the given list will be between 1 and 100.

---

### Approach & Efficiency
* Have 2 nodes, one slow node, and one fast node
* Iterate through linkedlist, moving the fast node twice as fast as the slow node
* When the fast node is null, return slow node

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(1) |

