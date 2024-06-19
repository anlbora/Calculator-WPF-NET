# Windows Forms Calculator Application

![2](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/926f6b28-0e5e-4247-9368-8656391bac8b)

![4](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/230fd0c3-3823-49aa-a759-805d1627ae60)


## Overview

This repository contains a simple calculator application built using Windows Forms in C#. The calculator supports basic arithmetic operations and has features for evaluating complex expressions with parentheses and handling square root operations.

![1](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/c069538a-863f-499f-9e54-0ef7cdbd8988)

## Features

- **Basic Arithmetic**: Supports addition, subtraction, multiplication, and division.
- **Complex Expressions**: Allows for multiple operations and parentheses for operator precedence.
- **Square Root Calculation**: Can compute the square root of the current input or the result displayed.
- **Dynamic Display**: Adjusts the font size dynamically to fit longer expressions in the display.
- **Keyboard Support**: Allows numeric and operation input via the keyboard.

  ![2](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/926f6b28-0e5e-4247-9368-8656391bac8b)

## Components

### Main Form (`mainApp`)

- **Controls**: The form includes buttons for digits (0-9), arithmetic operations (`+`, `-`, `*`, `/`), special functions (square root, parentheses, clear, delete, and toggle sign), and equal for evaluating the expression.
- **Label**: `lbl_answer` displays the current input or result, dynamically adjusting its font size based on the length of the text.

### Key Functionalities

1. **Numeric Input**:
    - Handled through both button clicks and keyboard input.
    - Appended to the current `input` and reflected in the `expression` for display.

2. **Operation Handling**:
    - Adds operation signs (`+`, `-`, `*`, `/`) to the `expression`.
    - Supports continuation of operations after the equal button is pressed.

   ![3](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/83b8ec52-cb64-4aec-b8fa-414f3c6a7398)

   ![4](https://github.com/anlbora/Calculator-WPF-NET/assets/100442507/230fd0c3-3823-49aa-a759-805d1627ae60)

4. **Expression Evaluation**:
    - Uses the `DataTable.Compute` method to evaluate the full expression, considering operator precedence and parentheses.
    - Updates the `expression` to display the result after evaluation.

5. **Square Root Calculation**:
    - Computes the square root of the current input or the displayed result if no new input is provided.
    - Updates the `expression` to reflect the square root operation result.

6. **Dynamic Font Adjustment**:
    - Adjusts the font size of `lbl_answer` based on the length of the text to ensure readability.

7. **Keyboard Input Handling**:
    - Supports numeric input and operations through keyboard shortcuts.
    - Allows users to control the calculator without using the mouse.
