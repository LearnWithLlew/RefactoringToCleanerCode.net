## Refactoring to Cleaner Code

* [ ] Validate environment
    * [ ] Run the test
* [ ] NCrunch
    * [ ] Enable
    * [ ] Show Risk/Progress window floating

## Scenario

We are looking at large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.

## Starting Rules for today's refactorings

- Automated refactorings "only" 
- Commit after each refactoring
- Every commit prefixed with `r -    `
- Rotate typist on commit

## Improvement Loop

1. Identify a smell
2. Improve it
3. Evaluate
4. Commit (or revert)

- [ ] ## Restriction 1: Extract Paragraphs to methods

    1. Identify a paragraph
    2. Extract a method
    3. Evaluate the signature (ignore the body)
    4. Fix or revert and try again
    5. Commit
    
- [ ] ## Restriction 2: Move methods onto new classes

    1. Find a method
    2. Move into a better class
    3. Evaluate signature
    4. Commit

- [ ] ## Restriction 3: Clean up the main method

	1. Convert `switch` to `if`/`else`
	2. Remove redundant code
	3. Extract condition and move onto class
	4. Commit
	
 - [ ] ## Restriction 4: Remove duplication

    1. Make similar things identical
    2. Apply Refactoring Combo: Make non-static
    3. Surround with block
    4. Extract local variable
    5. Extract interface
    6. Many-of-one
    7. Use base type
    8. Apply interface and move to many
    9. Extract list of scorers
    10. Extract apply scorers

## Smell: bad names

- [ ] Missing/Misleading -> (Obvious) Nonsense

- [ ] Nonsense -> Honest (but incomplete)

- [ ] Honest -> Honest-and-complete

- [ ] Honest-and-Complete -> Does the right thing

- [ ] Does the right thing -> Intent

- [ ] Intent -> Domain Abstraction
## Refactoring Combo: Make non-static

    1. Introduce unused local instance variable in method
    2. Introduce parameter
    3. Refactor -> Make method non-static

## Homework

* Redo today’s coding exercises on your own computer

  * Start from the code on the [`main` branch](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net)
  * If you want to see the code we wrote together, check the [other branches](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net/branches)
  * Pay attention to:
    * how often you're able to execute a single refactoring - more is better
    * how many times you are able to pull out a paragraph into a new method
* Print out this sheet and keep it on your desk. Over the next week as you're doing your normal work:
  * note when you were able to improve the code with tiny refactorings
  * note when you found code you wish was better but couldn't improve at this time

