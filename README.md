## 🚀 Ref and Out Keywords Exercise

This exercise demonstrates the use of `ref` and `out` keywords in C#. It includes two methods that manipulate and return values, showcasing how these keywords can be used to pass variables by reference and obtain multiple outputs from a method.

### 🔄 `ref` Keyword

- **Method:** `SubtractHealth(ref int x)`
- **Purpose:** Decreases the value of `x` by 1 and returns a `bool` indicating if `x` is still greater than 0.
- **Usage:**
  - The `ref` keyword allows the method to modify the value of `x` directly.
  - After calling the method, `x` will be decremented by 1, and the method will return `true` if `x` is still greater than 0, otherwise `false`.
