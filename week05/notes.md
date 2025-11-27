# Inheritance
- Inheritance is the ability for one class to obtain the attributes and methods of another class directly, without having to type them. It follows the same idea of people inheriting certain characteristics from their parents.


- `base` is used inside a derived (child) class to call members of the parent (base) class.
- base(parameter) → base calls the parent class and goes straight to the constructor and assign that parameter to the parent class.

# 🧩 Inheritance + Encapsulation
- When you inherit:

- The child class gets all the parent’s members.

- But if the parent’s variables are marked private, the child cannot access them directly.

- To use them, the parent must expose public or protected methods/properties.

# Gotchas and Errors
- If theres a parent function that hasn't been assigned a constructor but the child class has been assigned a constructor, use base(parameter).
- Similarly, If theres a parent function that hasn't been assigned a constructor, the child class hasn't been assigned a constructor, DONT use base(parameter), it will be provided for you.


## Side note to Inheritance
Inheritance is the third principle of programming with classes. The key to understanding it is to remember that inheritance is mechanism for code reuse. Instead of writing the same thing over and over again we can simply inherit from one class to another.

Be careful though. As a certain uncle once said to his budding superhero nephew, "with great power comes great responsibility!" Discipline yourself in how you apply inheritance. Keep your hierarchies shallow and manageable. You'll be able to add more functionality in less time all while ensuring your program stays maintainable.