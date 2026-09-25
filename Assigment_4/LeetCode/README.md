# LeetCode Problem Explanations & Concepts

---

## 1. Valid Anagram
[LeetCode Problem Link](https://leetcode.com/problems/valid-anagram/submissions/)

### Explanations & Answers

* **How the solution determines whether the two strings are anagrams:**
  Two strings are anagrams if they contain the exact same characters with the exact same frequencies, regardless of character order. The solution counts the frequency of each character in both strings (e.g., using a fixed-size integer array or hash map) and verifies that every character count in the first string matches the count in the second string.

* **What happens when the strings have different lengths:**
  If the lengths of string $s$ and string $t$ are not equal ($s.\text{Length} \neq t.\text{Length}$), they cannot possibly be anagrams. The solution immediately returns `false` at the very beginning as a guard clause, avoiding unnecessary processing.

* **How character frequencies can be compared:**
  * **Array/Frequency Table (Optimal for fixed alphabet):** For lowercase English letters (`a`-`z`), an integer array of size 26 is used. Increment the count for each character in $s$ (`count[s[i] - 'a']++`) and decrement for each character in $t$ (`count[t[i] - 'a']--`). Finally, check if all values in the array are `0`.
  * **Hash Map:** For general Unicode inputs, a dictionary maps each character to its frequency. Count occurrences in $s$, subtract occurrences for $t$, and check if all resulting values are zero.

* **Time Complexity:**
  $$\mathcal{O}(n)$$
  where $n$ is the length of the strings. Traversing each string to compute and verify character counts takes linear time.

* **Space Complexity:**
  $$\mathcal{O}(1)$$
  when using a fixed array of size 26 for English letters (or $\mathcal{O}(k)$ where $k$ is the number of distinct characters for general Unicode characters).

---

## 2. Greatest Common Divisor of Strings
[LeetCode Problem Link](https://leetcode.com/problems/greatest-common-divisor-of-strings/submissions/2152512151/)

### Explanations & Answers

* **What it means for one string to divide another string:**
  A string $T$ divides string $S$ (written as $T \mid S$) if $S$ can be constructed by concatenating $T$ with itself one or more times. That is, $S = T + T + \dots + T$.

* **How repeated string patterns are detected:**
  A fundamental property of string divisibility is that if two strings $str1$ and $str2$ share a common divisor string, concatenating them in different orders must yield identical results:
  $$str1 + str2 == str2 + str1$$
  If this equality holds, a repeating pattern exists across both strings. If it does not hold, no common divisor string exists.

* **Why some pairs of strings have no common divisor string:**
  Some pairs fail to satisfy $str1 + str2 == str2 + str1$ because their underlying character sequences or base patterns differ (e.g., $str1 = \text{"CODE"}$, $str2 = \text{"LEET"}$). Because their character compositions do not align periodically, no single string $T$ can repeatedly build both $str1$ and $str2$.

* **How the greatest valid pattern can be found:**
  1. Check if $str1 + str2 == str2 + str1$. If false, return `""` (empty string).
  2. Calculate $L = \text{GCD}(str1.\text{Length}, str2.\text{Length})$ using Euclidean algorithm.
  3. The greatest common divisor string is the prefix of $str1$ (or $str2$) of length $L$:
     $$\text{Result} = str1[0 \dots L-1]$$

* **Time Complexity:**
  $$\mathcal{O}(m + n)$$
  where $m$ and $n$ are the lengths of $str1$ and $str2$. Concatenating strings takes $\mathcal{O}(m + n)$ time, and computing the integer GCD takes logarithmic time $\mathcal{O}(\log(\min(m, n)))$, making string operations the dominant factor.

* **Space Complexity:**
  $$\mathcal{O}(m + n)$$
  to store the concatenated strings ($str1 + str2$ and $str2 + str1$) for validation and to extract the resulting substring prefix.