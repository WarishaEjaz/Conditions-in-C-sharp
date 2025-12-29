# Conditions-in-C-sharp
## Conditional Statements in C#

**Conditional statements** are decision-making statements used in C# to control the flow of program execution. They allow a program to evaluate conditions and execute different blocks of code depending on whether the condition is true or false.

### What Are Conditional Statements?

Conditional statements help a program make decisions during execution. Based on specific conditions, the program determines which statements should be executed and which should be skipped.

### Types of Conditional Statements in C#
### 1. if Statement

The if statement is used to execute a block of statements only when a given condition evaluates to true.

### Syntax:

if (condition)

{

    statements;
    
}

### 2. if–else Statement

The if–else statement is used when there are two possible outcomes. One block of code runs if the condition is true, and another block runs if the condition is false.

### Syntax:

if (condition)

{
  
    statements;

}

else

{

    statements;
    
}

### 3. if–else-if Statement

The if–else-if statement is used to check multiple conditions one after another. The block related to the first true condition is executed.

### Syntax:

if (condition1)

{

    statements;

}

else if (condition2)

{

     statements;
    
}

else

{

    statements;
    
}

### 4. Nested if Statement

A nested if statement is an if statement placed inside another if or else block. It is used when one condition depends on another condition.

### Syntax:

if (condition1)

{

    if (condition2)
   
    {
        
        statements;
   
    }

}

### 5. switch Statement

The switch statement is used to select one block of code from multiple fixed choices based on the value of a variable or expression.

### Syntax:

### switch (expression)
{
  
    case value1:
        
        statements;
        
        break;

    case value2:
     
        statements;
    
        break;

    default:
     
        statements;
     
        break;

}

## Conclusion

**Conditional statements are an essential part of C# programming. They help programs respond differently based on conditions, making applications more flexible, efficient, and intelligent.**
