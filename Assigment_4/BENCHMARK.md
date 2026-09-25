# Assignment 4: String vs StringBuilder Benchmark Summary

## 1) Benchmark Results

| Method | Iterations | Mean | Error | StdDev | Gen0 | Gen1 | Gen2 | Allocated |
| :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- | :--- |
| **StringConcatenation** | 100 | 73.10 us | 3.101 us | 8.847 us | 80.4443 | 1.8311 | - | 493.01 KB |
| **StringBuilderConcatenation** | 100 | 17.55 us | 0.410 us | 1.144 us | 5.2490 | 0.3052 | - | 32.35 KB |
| **StringConcatenation** | 1000 | 5,099.13 us | 101.802 us | 186.152 us | 8265.6250 | 3265.6250 | 3257.8125 | 47119.7 KB |
| **StringBuilderConcatenation** | 1000 | 236.79 us | 5.827 us | 17.091 us | 30.2734 | 30.2734 | 30.2734 | 251.46 KB |

---

## 2) Key Insights & Performance Comparison

* **Performance Advantage:** StringBuilder is massively faster and uses a fraction of the memory compared to standard string concatenation[cite: 5].
* **String Immutability:** Every time you use `+` or `+=`, a new string is created inside memory.
* **In-Place Modification:** StringBuilder uses only one string/buffer to modify text directly in place.

---

## 3) Is StringBuilder Always Better?

* **Verdict:** No, StringBuilder is not always better than normal string operations.
* **Summary:** StringBuilder is optimal for repeated string modifications in loops, while string operations are faster and more memory-efficient for simple, fixed concatenations.