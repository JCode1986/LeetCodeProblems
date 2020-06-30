# 771. Jewels and Stones
  
*Author: Joseph Hangarter*

---

### Problem Domain

You're given strings J representing the types of stones that are jewels, and S representing the stones you have.  Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.

The letters in J are guaranteed distinct, and all characters in J and S are letters. Letters are case sensitive, so "a" is considered a different type of stone from "A".

### Inputs and Expected Outputs

#### Example 1:  
| Input (J, S)| Expected Output |
| :----------- | :----------- |
| J = "aA" , S = "aAAbbbb" | 3 |

##### Explanation: 
Three characters from `S` that `J` has.

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| "z" | "ZZ" |

### Constraints:
* S and J will consist of letters and have length at most 50.
* The characters in J are distinct.

---

### Approach & Efficiency
* Solution 1
  * Have a counter
  * Check every stone and iterate through the jewels, checking if they match
  * Increment counter if the stone is a jewel
  * Return counter
* Solution 2
  * Have a counter, and add all the stones into a `hash set`.
  * Iterate through jewels, and check it a jewel is in the hash set, and increment counter
  * Return counter

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

