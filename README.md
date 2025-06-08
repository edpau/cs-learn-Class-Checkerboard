# 🧠 Checkerboard in C# – Lessons 1 & 2 with Classes, Methods, Properties, and Validation

This project refactors a basic checkerboard printing program in C# using **object-oriented principles**. We gradually evolve from hardcoded logic to a modular, reusable, and encapsulated design using **classes**, **methods**, **constructors**, **properties**, and **input validation**.

---

## 📘 Lesson 1 – From Procedural Code to Class

### ✅ What You Learn:
- What a **class** is in C#
- The role of **constructors** and **methods**
- Making functionality **reusable** and **encapsulated**
- Using a **2D array** to represent the board

### 🔧 Key Concepts:
- A **class** is a blueprint for an object. In C#, it's defined with the `class` keyword.
- A class bundles together **data (fields)** and **behavior (methods)**.
- The `Board` class holds a 2D array `checkers`, and logic to **populate** and **print** it.
- **Constructor**: A method with the same name as the class, used to initialize it.
- `Setup()` populates the board with alternating 0s and 1s to simulate a checkerboard.
- `Print()` outputs the board row-by-row.

### 🧱 Structure:
```csharp
Board board = new Board(4, 4);
board.Print();
```

- `Board` constructor creates the 4x4 grid and populates it with alternating values using nested loops.
- Output is a visual checkerboard of 0s and 1s.

---

## 📘 Lesson 2 – Clean Code, Files, Namespaces, Properties, and Validation

### ✅ What You Learn:
- Splitting classes into **separate files**
- Using **namespaces** and the `using` directive
- Adding **method overloading** with multiple constructors
- Using **properties** (`get`/`set`) to expose internal fields safely
- Creating **validation logic** (e.g. column count must be even)
- Handling **null** checks and preventing runtime errors

### 🧱 Updated Code Architecture:
```
Checkerboard/
│
├── Program.cs      // main application entry point
└── Boards.cs       // contains the Board class inside the Boards namespace
```
---

## 🚧 Validation Logic and Null Handling

### 🔍 Why prevent odd columns?
- An odd column count **breaks the alternating checker pattern** (e.g., starts the next row incorrectly).
- Instead of letting this happen, the setter method validates the input and prints a warning.

### ❓ What if the board is invalid?
- The `checkers` array is not created, avoiding runtime errors.
- The `Print()` method checks `checkers != null` before printing.

---

## 🧠 Concepts Covered (Mapped to .NET 9)

| Concept | Covered | .NET 9 Notes |
|--------|---------|--------------|
| Class & Object | ✅ | Standard OOP |
| Constructor Overloading | ✅ | Same name, different params |
| Namespace & `using` | ✅ | Modern convention |
| Properties with `get`/`set` | ✅ | Auto-implemented or manual |
| Method Visibility (`private` / `public`) | ✅ | Core to encapsulation |
| Validation with `if` statements | ✅ | Modular via private helper |
| `null` checks | ✅ | Prevent runtime exceptions |
| Modulo operator `%` | ✅ | Used for odd/even checking |

---

## 💬 Example Output (6x5 Board - Invalid Columns)

```
5 is not a valid number of columns. Columns must be even
```

---

## ✅ Next Steps 
- Add **data validation** for rows.
- Introduce **custom exceptions**.
- Allow user input and interact via console.
- Explore **encapsulation best practices** and **unit testing** with xUnit.

---

## 📎 Final Tip
- If you're using VS Code and seeing repeated outputs collapsed in Debug Console, go to:
  `Preferences → Settings → Features → Debug` and uncheck **"Collapse Identical Lines"** for clearer logs.

---
