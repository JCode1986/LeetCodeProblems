# 1431. Kids With the Greatest Number of Candies
  
*Author: Joseph Hangarter*

---

### Problem Domain

Given the array candies and the integer extraCandies, where candies[i] represents the number of candies that the ith kid has.

For each kid check if there is a way to distribute extraCandies among the kids such that he or she can have the greatest number of candies among them. Notice that multiple kids can have the greatest number of candies.

### Inputs and Expected Outputs

#### Example 1:
| Input (candies, extraCandies) | Expected Output |
| :----------- | :----------- |
| [ 2, 3, 5, 1, 3 ], 3   | [ true, true, true, false, true ]  |

#### Explanation:   
Kid 1 has 2 candies and if he or she receives all extra candies (3) will have 5 candies --- the greatest number of candies among the kids. 
Kid 2 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids. 
Kid 3 has 5 candies and this is already the greatest number of candies among the kids. 
Kid 4 has 1 candy and even if he or she receives all extra candies will only have 4 candies. 
Kid 5 has 3 candies and if he or she receives at least 2 extra candies will have the greatest number of candies among the kids.

#### Example 2:
| Input (candies, extraCandies) | Expected Output |
| :----------- |  :----------- |
| [ 4, 2, 1, 1, 2 ], 1   | [ true, false, false, false, false ]  |

#### Explanation:   
There is only 1 extra candy, therefore only kid 1 will have the greatest number of candies among the kids regardless of who takes the extra candy.

#### Example 3:
| Input (candies, extraCandies) | Expected Output |
| :----------- | :----------- |
| [ 12, 1, 12 ], 10   | [ true, false, true ]  |

### Constraints:  
* 2 <= candies.length <= 100
* 1 <= candies[i] <= 100
* 1 <= extraCandies <= 50

---

### Approach & Efficiency
* Have a `greatest` variable, to obtain kid with highest amount of candies
* Instantiate an array to store booleans
* Iterate through kids, and store the kid with the highest amount candies in `greatest` 
* Iterate through kids again, and if the kid with candies + extra candies is greater than or equal to `greatest`, then add true to bool array. Otherwise add false.
* Return bool array

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

