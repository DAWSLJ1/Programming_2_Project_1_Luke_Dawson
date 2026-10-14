# College of Engineering, Construction and Living Sciences

## Bachelor of Information Technology

### ID511001: Programming 2

**Level 5, Credits 15, Version 1.0**

---

## Skills-Based Assessment

### Assessment Overview

In this individual assessment, you will develop code solutions to a range of problems that cover the key concepts taught in this course.

### Learning Outcomes

At the successful completion of this course, learners will be able to:

1. Build interactive, event-driven GUI applications using pre-built components.
2. Declare and implement user-defined classes using encapsulation, inheritance and polymorphism.

### Conditions of Assessment

You will complete this assessment during your learner-managed time. This assessment will need to be completed by **Thursday, 15 October at 11.55 AM**.

### Pass Criteria

This assessment is criterion-referenced (CRA) with a cumulative pass mark of 50% over all assessments in ID511001: Programming 2.

### Authenticity

You may bring one double-sided A4 cheat sheet to this assessment. Only this GitHub repository and Visual Studio may be used during the exam. Do not discuss your answers with other students. Doing so will result in a mark of zero for this assessment.

### Submission

You must submit your assessment via GitHub no later than **Tuesday, 26th May at 10.00 AM**.

### Extensions

Extensions are not applicable for this assessment.

### Resubmissions

Resubmissions are not applicable for this assessment.

### Resits and Reassessments

Resits and reassessments are not applicable for this assessment.

---

> **Remember to save your work regularly as you complete this skills-based assessment.**

---

## Task 1 (10 marks) - Learning Outcomes 1 and 2

In the assessment repository, you have been provided with an application called **01-TaskOne**. Once you have completed this task, add, commit and push your code to GitHub.

### `RebelAlliance` Class

1. Write a constructor that accepts `firstName`, `lastName` and `yearsInRebellion`. _(1.5 marks)_
2. Write a property for `firstName` and `lastName`. _(1 mark)_
3. In the `yearsInRebellion` property's set accessor, if `yearsInRebellion` is negative throw an `ArgumentOutOfRangeException` with the string `"Years in Rebellion cannot be negative"`. _(1.5 marks)_

### `Form1` Class

4. Using the `List<RebelAlliance> rebels`, write a LINQ query that returns a `List<RebelAlliance>` where a rebels's last name starts with `"S"`. Assign the result to a variable called `lastNameS`. _(1 mark)_
5. When `button1` is clicked, display `firstName` and `lastName` from `lastNameS` in `listBox1`. _(1 mark)_
6. Using the `List<RebelAlliance> rebels`, write another LINQ query that returns a `List<RebelAlliance>` where a rebels's years in alliance is between 3 and 5 (inclusive). Assign the result to a variable called `yearsRange`. _(2 marks)_
7. When `button2` is clicked, display `firstName` , `lastName`, and `yearsInRebellion` in a sentence from `yearsRange` in `listBox2`. _(1 mark)_
8. When `button3` is clicked, clear both `listBox1` and `listBox2`. _(1 mark)_

---

## Task 2 (12 marks) - Learning Outcomes 1 and 2

In the assessment repository, you have been provided with an application called **02-TaskTwo**. Once you have completed this task, add, commit and push your code to GitHub.

### `Transport` Class

1. Write three fields - `make`, `model` and `litres`. Use the appropriate access modifier as per the lecture notes. _(1 mark)_
2. Write a property for `make`, `model` and `litres`. _(1 mark)_
3. Write an abstract method called `Notice` that returns a `string`. _(1 mark)_

### `MotorVehicle` Class

4. Write a constructor that inherits from the `Transport` class. _(0.5 mark)_
5. Override the `Notice` method and return `"Check for blind spots!"`. _(1 mark)_

### `MotorBike` Class

6. Write a constructor that inherits from the `Transport` class. _(0.5 mark)_
7. Override the `Notice` method and return `"Remember your helmet!"`. _(1 mark)_

### `Form1` Class

8. Add three columns to `dataGridView1` - the first column is `make` and the second column`model` and the third column is `litres`. _(1 mark)_
9. Write a `foreach` loop that displays the `make`, `model` and `litres` of each transportation in `List<Transport> transportation` in `dataGridView1`. _(3 marks)_
10. Display the number of transportation entries that have a litres value greater than or equal to `25` in `label1`. _(2 marks)_

---

## Task 3 (13 marks) - Learning Outcome 1

In the assessment repository, you have been provided with an application called **03-TaskThree**. Once you have completed this task, add, commit and push your code to GitHub.

### `Form1` Class

1. When `button1` is clicked, generate 15 random circumference numbers between 1 and 200 using the `GenerateRandomCircumference` method. _(1 mark)_ 
2. Categorise the generated circumference numbers into three groups: _(6 marks)_
   - Small circle: circumference from 1–60
   - Medium circle: circumference from over 60–120
   - Large circle: circumference from over 120–200
3. Display each group in its appropriate `Label` control: _(3 marks)_
   - `label1` - Small circle (1–60)
   - `label2` - Medium circle (over 60–120)
   - `label3` - Large circle (over 120–200)
4. For each `Label` control, set the text colour using the `ForeColor` property to: _(3 marks)_
   - `label1` - purple
   - `label2` - teal
   - `label3` - orange

---

## Task 4 (8 marks) - Learning Outcome 2

In the assessment repository, you have been provided with an MSTest project called **04-TaskFour**. Once you have completed this task, add, commit and push your code to GitHub.

### `WhaleTests` Class

In the `WhaleTests` class:

1. Write a test called `Test_Set_Weight` that asserts that the `Whale` object's `AvgWeight` property is set correctly. _(2 marks)_
2. Write a test called `Test_Set_Length` that asserts that the `Whale` object's `AvgLength` property is set correctly. _(2 marks)_
3. Write a test called `Test_Set_Name` that asserts that the `Whale` object's `Name` property is set correctly. _(2 marks)_
4. Write a test called `Test_Krill` that asserts that the `Whale` object method `Krill` returns correct value. _(2 marks)_

---

## Task 5 (10 marks) - Learning Outcome 2

In the assessment repository, you have been provided with an application called **05-TaskFive**. Open the `StarShip` class and read through the code carefully. There are **5 bugs** hidden in the methods below - one bug per method. Find each bug and fix it. Each bug fixed is worth 2 marks.

You have also been provided with a set of unit tests in the `StarShipTests` class. You can run these tests to check if your fixes are correct. All 6 tests should pass once all 5 bugs have been fixed.

Once you have completed this task, add, commit and push your code to GitHub.

```csharp
public void TripleVolume()
{
    volume = volume + 1;  // Bug 1
}

public void ActivateShip()
{
    isOperating = false;  // Bug 2
}

public string GetInfo()
{
    return $"Ship Name: {name}, Volume: {volume}";  // Bug 3
}

public void ResetVolume()
{
    Volume = volume;  // Bug 4
}

public bool IsLarge()
{
    return volume < 150000;  // Bug 5
}
```

Use the following hints to help you find and fix each bug:

| Bug | Method       | Hint                                                           |
| --- | ------------ | -------------------------------------------------------------- |
| 1   | `Triple Volume` | The method should triple the volume                              |
| 2   | `ActivateShip` | The method should activate the star ship                    |
| 3   | `GetInfo`    | The return string should include all three fields of the class |
| 4   | `ResetVolume`  | The method should reset the volume to zero                       |
| 5   | `IsLarge`    | The method should return `true` when volume is over 150000         |

