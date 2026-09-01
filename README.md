# 🧮 MCalculator (v1.0.0)

> **A clean desktop calculator built with C# and WinForms, focused on event handling, input management, and fundamental arithmetic operations.**

<p align="center">
  <img src="Screenshots/Calculator.png" alt="MCalculator Dashboard" width="800">
</p>

---

## 📑 Table of Contents

- [Overview](#-overview)
- [Key Features](#-key-features)
- [How It Works](#-how-it-works)
- [Architecture & Design](#-architecture--design)
- [Technologies](#-technologies)
- [Project Structure](#-project-structure)
- [Project Timeline](#-project-timeline)
- [Acknowledgments](#-acknowledgments)
- [License](#-license)
- [Author](#-author)

---

## 📖 Overview

**MCalculator** is a desktop calculator application developed using **C# and .NET WinForms**.

The project focuses on practicing fundamental programming concepts through an interactive calculator interface, with particular attention to **event handling, button-driven input, variable management, arithmetic processing, and calculator state management**.

The application provides a simple and practical interface for entering mathematical expressions and obtaining calculated results.

---

## ✨ Key Features

### 🔢 Basic Arithmetic Operations

Supports the fundamental calculator operations:

- Addition `+`
- Subtraction `-`
- Multiplication `*`
- Division `/`
- Modulus `%`

### 🔘 Interactive Numeric Input

- Number buttons append their values to the calculation field.
- Buttons use their assigned `Tag` values for input processing.
- Decimal input is supported through the decimal point button.

### ⚡ Event-Driven Processing

The calculator uses Windows Forms event handlers to respond to:

- Numeric button clicks
- Mathematical operator clicks
- Equal button actions
- Delete actions
- Clear actions

### 🧮 Expression Processing

The entered expression is processed by separating its numbers and operators, then calculating the resulting value through the implemented arithmetic logic.

### ⚠️ Invalid Expression Handling

The application checks whether the expression ends with an arithmetic operator before attempting to calculate it.

If the expression is invalid, the result displays:

**`Faild!`**

with a visual error indication.

### 🗑️ Delete & Clear Controls

- **Delete:** Removes the last entered character.
- **Clear:** Resets the calculation and result fields and clears the stored operator state.

### 🎨 Dark Calculator Interface

The application includes a dark-themed interface with:

- Dark background
- Distinct numeric and operator button colors
- Highlighted equal button
- Clear separation between calculation input and result output

---

## 🔄 How It Works

The calculator follows a simple event-driven flow:

1. The user enters numbers using the numeric buttons.
2. Mathematical operators are stored while the expression is built.
3. The entered expression is separated into numbers.
4. The stored operators determine which arithmetic operation is performed.
5. The calculated value is displayed in the result field.
6. The internal operator state is reset after calculation.

This approach keeps the implementation focused on the core concepts practiced in the project.

---

## 🏗️ Architecture & Design

The project follows a straightforward **WinForms event-driven structure** centered around the calculator form.

### Core Logic

- **`ClickNum()`** handles numeric input.
- **`IsSign()`** tracks mathematical operators.
- **`IsFaild()`** validates the current expression before calculation.
- **`btnEqual_Click()`** processes the entered expression and calculates the result.
- Delete and clear handlers manage the calculator's current state.

### Design Approach

The implementation emphasizes:

- Event-driven programming
- Reusable input handling
- Simple state management
- Clear separation between input and calculation processing
- Direct interaction between UI controls and calculation logic

---

## 🛠️ Technologies

| Technology | Purpose |
| :--- | :--- |
| **C#** | Core programming language |
| **.NET WinForms** | Desktop graphical user interface |
| **Visual Studio** | Development environment |

---

## 📁 Project Structure

    MCalculator-v1.0.0/
    ├── Properties/
    ├── Resources/
    ├── Screenshots/
    │   └── Calculator.png
    ├── App.config
    ├── Calculator_Project.csproj
    ├── Calculator_Project.sln
    ├── Form1.Designer.cs
    ├── Form1.cs
    ├── Form1.resx
    ├── Program.cs
    ├── README.md
    └── calculator-app-icon-blue-white-vector-59622521.ico

---

## 📅 Project Timeline

| Milestone | Date |
| :--- | :--- |
| **Start Date** | 2026/03/28 |
| **Completion Date** | 2026/03/28 |
| **Duration** | 1 Day |
| **Version** | v1.0.0 |

---

## 🙏 Acknowledgments

Special thanks to **Dr. Mohammed Abu-Hadhoud** for simplifying complex programming concepts and providing guidance throughout the learning journey.

---

## 📄 License

This project is open-source and available under the **MIT License**.

You are free to use, modify, and distribute the project, provided that proper attribution to the original author is maintained.

---

## 👨‍💻 Author

**Mohammed Abdullah Noman Qaid Mohammed**

---

<p align="center">
  <strong>🧮 MCalculator — Simple Logic. Clean Interface. Practical Learning.</strong>
</p>
```0
