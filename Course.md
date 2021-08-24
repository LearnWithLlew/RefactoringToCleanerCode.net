# Run tests manually
* Validate the environment
    * [ ] Run all tests (`Ctrl-U, L`)
# Run tests automatically
* Open NCrunch menu (`Alt-U`)
    * [ ] Enable NCrunch
    * [ ] Ensure **Risk/Progress** window is open and visible and out of the way.
# Read this:
## Scenario
We are looking at a large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.
## Starting Rules for today's refactorings
- Automated refactorings only
- Commit after each refactoring
- Every refactoring commit prefixed with `r - `
# Activity 1: Quickly break up a long method
*We can't see the whole method, so it's hard to reason about it. Let's break it up.*
1. Identify a paragraph (a `case`)
2. Extract a method to a Obvious Nonsense name
3. Looking at the call site, what do you think of the result?
   - Do you like the parameter list?
## Activity 1a: Improve parameter names
*The methods we extracted have parameters with inconsistent names.*
1. Rename parameters
 ## Activity 1b: Deal with `bigScore`
*Most of our new methods take the same parameters, but `bigScore` is different.*
1. Inline `bigScore`
2. Extract Variable `bigScore`.
# Activity 2: Improve Names
*Now that we can see the whole method, we can give things better names.*
1. Rename each Nonsense-named method to a name that is honest and complete.
# Resources
## Smell: bad names
1. Missing/Misleading -> (Obvious) Nonsense
2. Nonsense -> Honest (but incomplete)
3. Honest -> Honest-and-complete
4. Honest-and-Complete -> Does the right thing
5. Does the right thing -> Intent
6. Intent -> Domain Abstraction
# Homework
* Redo today’s coding exercises on your own computer
  * Start from the code on the [`main` branch](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net)
* Print out [this sheet](https://github.com/LearnWithLlew/RefactoringToCleanerCode.Slides/raw/main/Homework%20Printouts.pdf) and keep it on your desk. Over the next week as you're doing your normal work:
  * note when you were able to improve the code with a single, committed refactoring
  * note when you extract a paragraph
  * Make a TODO list of code you wish was better but couldn't improve at this time
* Share your results in the #x-clean-code Slack channel.
