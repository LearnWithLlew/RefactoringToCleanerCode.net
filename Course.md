Course Section 1 

## Testing Functional Code

* [ ] Validate environment
    * [ ] Run the test
    * [ ] Turn on NCrunch & show Risk/Progress window

**Scenario:** In this scenario, we are looking at large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.

# Starting Rules for today's refactorings

- Automated refactorings "only" 
- Commit after each refactoring
- Every commit prefixed with `r   `
- Rotate typist on commit

# Improvement Loop

- [ ] Identify a smell
- [ ] Improve it
- [ ] Commit

# Smells to look for

* Bad Names
* Inconsistency
* Long Switch
* Long Method
* Improper Class
* Duplication
* Mixed responsibilities / levels of abstraction

## Smell: bad names

- [ ] Missing/Misleading -> Nonsense

- [ ] Nonsense -> Honest (but incomplete)

- [ ] Honest -> Honest-and-complete

- [ ] Honest-and-Complete -> Does the right thing

- [ ] Does the right thing -> Intent

- [ ] Intent -> Domain Abstraction
## Smell: Inconsistency

- [ ] make consistent

  (surfaces duplication)

## Smell: Long Method

- [ ] Identify a paragraph
- [ ] Extract it
- [ ] Does the paragraph you extracted make sense?

## Smell: Long Switch

- [ ] Prerequisite: every case is a single call
- [ ] Convert dispatch to strategy
  - [ ] `switch`->`if`/`else`
  - [ ] Remove redundant `else`
  - [ ] Extract method on condition
  - [ ] Move condition and action to another type
  - [ ] Refactoring Combo: Make non-static
  - [ ] Convert first `if` to many-of-one
  - [ ] Convert next to many

## Smell: Improper class

- [ ] figure out what doesn't belong in the class and move it to another class

## Smell: Duplication

- [ ] Make similar things identical
- [ ] Extract the duplication

## Smell: Duplication

- [ ] Extract interface

# Refactoring Combo: Make non-static

  1. Introduce unused local instance variable in method
    2. Introduce parameter
         3. Make method non-static

# Homework

* Redo today’s coding exercises on your own computer

  * Start from the code on the [`main` branch](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net)
  * If you want to see the code we wrote together, check the [other branches](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net/branches)
  * Pay attention to:
    * how often you're able to execute a single refactoring - more is better
    * how many times you are able to pull out a paragraph into a new method
* Print out this sheet and keep it on your desk. Over the next week as you're doing your normal work:
  * note when you were able to improve the code with tiny refactorings
  * note when you found code you wish was better but couldn't improve at this time

