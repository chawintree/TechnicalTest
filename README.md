# Technical Test

### Welcome to the technical test! 

This test involves four separate tasks - the first three will be coding challenges, with the fourth task asking questions on how you completed the challenges.

Tasks one and two may take ~15 minutes each, task three ~45 minutes and task four ~20 minutes; please **do not** spend more than **2 hours** total on the test. If after **1½** hours you have not reached task four we recommened finishing what you're working on  (even if it's not complete) and completing the final task.

Please read the questions and requirements thoroughly before attempting the tasks, and if you have any questions please get in touch with your recruitment contact.

## Completing the Test
To start the test you should checkout the repository this README is contained within - this includes all the code required to complete the first three tasks. 

It is expected that you will make regular commits whilst completing the tests; these will give an insight into your development process and also to show the amount of time spent on the test.

When submitting the code please make a `.zip` file containing the repository, named in the format `{your-name}-technical-test.zip`, and send to your recruitment contact.

### With all that in mind, let's begin - good luck!

## Task One
Locate `TaskOne.cs` in the `TechnicalTest` project - this class contains three separate methods which perform basic tasks. Your challenge for this task is to implement the methods as per the below requirements and ensure that they pass the unit tests in `TechnicalTest.Tests`. 

1. **ReverseString** - a string parameter should be accepted and reversed. Ensure that the original case is kept, for instance the parameter **"Hello"** should be reversed to **"olleH"**.
2. **IsPalindrome** - a palindrome is a word which is spelt the same backwards as it is forwards, for example **"Racecar"**. A string parameter should be accepted and return a `true` or `false` response depending on if the string is a palindrome - the case of the word should not matter.
3. **SumOfNumbersFromOne** - an integer parameter should be accepted and sum the numbers from 1 to the parameter. For example, the parameter **5** would return **15** as **(1 + 2 + 3 + 4 + 5) = 15**;

**Note:** It is advised not to alter `TaskOneTests.cs` - if done, please provide a justification for doing so.

## Task Two
There are two classes within the `TaskTwo` folder: `TextInput` and `NumberInput`. The basic functionality of these classes is to add characters to a string and retrieve the value, using the methods `Add()` and `GetValue()`.

`TextInput` should allow the addition of any character via the `Add()` method and should return a string of the characters added via `GetValue()`. For example, the following code should return "Hi!".

``` csharp
    var input = new TextInput();
    input.Add("H");
    input.Add("i");
    input.Add("!");
    Console.WriteLine(input.GetValue());
```

`NumberInput` should perform the same behaviour as `TextInput`, except that when a non-numerical character is entered an `ArgumentException` should be thrown. For example, the following will throw an exception on line 3:

``` csharp
    var input = new NumberInput();
    input.Add("4");
    input.Add("H");
```

The initial structure of the classes is simply a guideline - the only requirement is that the classes have the methods `Add()` & `GetValue()` and the above functionality is met.

## Task Three
This task involves examining a user story, with requirements, and providing a proof of concept (PoC) solution for the user.

### User Story

*As a **customer**, I want to **get a list of restaurants using a postal code** so that **I know local places to eat**.*

### Requirements

* A user enters a postal code and receives a list of restaurants
* Restaurants should include a name, address, type of food and contact information 
* A valid postal code must be entered, otherwise an error message is shown

### Notes

* New projects and classes can be created within `TechnicalTest.sln`
* The PoC should include unit tests covering functionality
* Enterprise level code is not required, but good software design is still expected
* Any UI can be used, such as a command line application, web app etc.
* As it is a PoC there is no existing data, from a database or otherwise - feel free to return hard coded data to the user.
* Requirements are limited to allow for more creative solutions!

## Task Four
You've made it this far! For the final task, please answer the below questions to the best of your ability:

**In task one, when summing the numbers 1 - n, how efficient was your method and do you think there should be a more efficient way of calculating the result? Feel free to refer to Big O notation in your answer.**

*Answer here*

**After completing task two, did you utilise inheritence / polymorphism? If so, why?**

*Answer here*

**Is there anything you didn't get to finish or wanted to improve in task three?**

*Answer here*

**Have you written any code recently which you were proud of or thought was really cool? Tell us about it!**

*Answer here*

**What was something you worked on recently that you found really difficult?**

*Answer here*

**Is there any upcoming technology that you're excited about?**

*Answer here*