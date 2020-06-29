# 1365. How Many Numbers Are Smaller Than the Current Number
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 8, 1, 2, 2, 3 ] | [ 4, 0, 1, 1, 3 ] |

##### Explanation:   
For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3).   
For nums[1]=1 does not exist any smaller number than it.  
For nums[2]=2 there exist one smaller number than it (1).   
For nums[3]=2 there exist one smaller number than it (1).   
For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 6, 5, 4, 8 ] | [ 2, 1, 0, 3 ] |

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [ 7, 7, 7, 7 ] | [ 0, 0, 0, 0 ] |

### Constraints:

* 2 <= nums.length <= 500  
* 0 <= nums[i] <= 100

---

### Approach & Efficiency
* Instantiate a dictionary, a result array, and sort out the input array
* Iterate through the sorted array, and add the element as the key, and the index as the value
* Iterate through input array, and obtain the value from the dictionary by using the element from the input array
* Put the obtained value from the key to the result array
* Return array

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

