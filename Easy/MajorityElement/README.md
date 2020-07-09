# 169. Majority Element

*Author: Joseph Hangarter*

---

### Problem Domain

Given an array of size n, find the majority element. The majority element is the element that appears more than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the majority element always exist in the array.

### Inputs and Expected Outputs

#### Example 1:  
| Input (J, S)| Expected Output |
| :----------- | :----------- |
| [3,2,3] | 3 |

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [2,2,1,1,1,2,2] | 2 |

---

### Approach & Efficiency
* Have 2 variables for the most seen element (result) and a counter for the most seen element
* Instantiate a dictionary - Iterate through array and add element as key, and how many it times it appears as a counter but not setting to our counter variable.
* Iterate through dictionary, and compare values (times it appeared) to counter variable. If value is greater than counter then update counter, and update result variable to the key (element).
* Return result. 

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

