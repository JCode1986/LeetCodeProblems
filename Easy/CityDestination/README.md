# 1436. Destination City
  
*Author: Joseph Hangarter*

---

### Problem Domain

You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi. Return the destination city, that is, the city without any path outgoing to another city.

It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.

### Inputs and Expected Outputs

#### Example 1:  
| Input | Expected Output |
| :----------- | :----------- |
| [["London","New York"],["New York","Lima"],["Lima","Sao Paulo"]] | "Sao Paulo" |

##### Explanation: 
Starting at "London" city you will reach "Sao Paulo" city which is the destination city. Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".


#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [["B","C"],["D","B"],["C","A"]] | "A" |

##### Explanation: 
All possible trips are: 
"D" -> "B" -> "C" -> "A".   
"B" -> "C" -> "A".   
"C" -> "A".   
"A".   
Clearly the destination city is "A".

#### Example 2:  
| Input | Expected Output |
| :----------- | :----------- |
| [["A","Z"]] | "Z" |

### Constraints:
* 1 <= paths.length <= 100
* paths[i].length == 2
* 1 <= cityAi.length, cityBi.length <= 10
* cityAi != cityBi
* All strings consist of lowercase and uppercase English letters and the space character.

---

### Approach & Efficiency
* Instantiate a hash set
* Iterate through sub-arrays, and add every first element (city a) to hash set
* Iterate again from the sub-array, and check every second element (city b) if first element (city a) is not in hash set
* If not in hash set return city b

### Big O

| Time | Space |
| :----------- | :----------- |
| O(n) | O(n) |

