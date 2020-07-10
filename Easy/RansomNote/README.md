# 383. Ransom Note
  
*Author: Joseph Hangarter*

---

### Problem Domain
Given an arbitrary ransom note string and another string containing letters from all the magazines, write a function that will return true if the ransom note can be constructed from the magazines ; otherwise, it will return false.

Each letter in the magazine string can only be used once in your ransom note.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| ransomNote = "a", magazine = "b" |  false  |

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| ransomNote = "aa", magazine = "ab" | false |

#### Example 3:  
| Input | Expected Output |
| :----------- | :----------- |
| ransomNote = "aa", magazine = "aab" | true |

#### Constraints:
* You may assume that both strings contain only lowercase letters.
---

### Approach & Efficiency
* Instantiate a dictionary
* Add every character as the key from magazine to dictionary, and have a counter for how many times the character appears as the value
* Iterate through ransom note, if the character is present, decrement the counter
* If character is not present or counter is 0, return false
* Otherwise return true

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

