# 1351. Count Negative Numbers in a Sorted Matrix
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given a m * n matrix grid which is sorted in non-increasing order both row-wise and column-wise. 

Return the number of negative numbers in grid.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [[4, 3, 2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]] | 8 |

##### Explanation: There are 8 negatives number in the matrix.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [[3,2],[1,0]] | 0 |


#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| [[1,-1],[-1,-1]] | 3 |

#### Example 4:  
| Input | Expected Output |
| :----------- | :----------- |
| [[-1]] | 1 |

### Constraints:
* m == grid.length
* n == grid[i].length
* 1 <= m, n <= 100
* -100 <= grid[i][j] <= 100

---

### Approach & Efficiency
* Have a counter variable
* Two loops for outer and inner array
* If integer is less than 0; increment counter by 1
* Return counter;

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(0) |

