# Course Section 1 

## Testing Functional Code

**In File:** `https://github.com/dotnet/roslyn/blob/master/src/Compilers/CSharp/CSharpAnalyzerDriver/CSharpDeclarationComputer.cs`

* [ ] Validate environment
    * [ ] Run the test
    * [ ] Fix the test
**In File:** `exercises/exercise1/tests/TrigMathTests.cpp`

**Scenario:** In this scenario, we are looking at large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.



1. Pulled out paragraphs from each case
2. Pulled out parameter object
3. Recognized things were wrong, and reverted (*send bug report to R#)
4. Pulled out whole `switch`
5. Pulled out parameters
6. Pulled out paragraphs from each case
7. Removed `goto`.
8. 





* [ ] Pull out paragraphs from each case
    
    * [ ] Start with a nonsense names
    * [ ] Tried to pull
    * [ ] Uncomment the REQUIRE line
    * Confirmation: See failure message
    
    

## Homework

* [ ] Print out the [homework sheet](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.slides/raw/master/Homework%20Printouts%20-%20Week%201.pdf) and keep it by your desk, to increase your awareness throughout the week.

### Homework details

* [ ] Redo today’s coding exercises on your own computer
    * Start from the code on the [master branch](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.cpp)
    * If you want to see the code we wrote together, check the [other branches](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.cpp/branches)
* [ ] **Count** Number of times you encounter a **functional** method at work this week
* [ ] (Optional) If you **write** any **tests** for those methods, please **make a note** so we can share at the start of next week.
