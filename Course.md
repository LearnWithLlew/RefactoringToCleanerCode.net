## Refactoring to Cleaner Code

* [ ] Validate environment
    * [ ] Run the tests (`Ctrl-U, Ctrl-L`)
* [ ] NCrunch (`Alt-U`)
    * [ ] Enable NCrunch
    * [ ] Ensure **Risk/Progress** window is open and floating

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

- [ ] ## Activity 1: Extract Paragraphs to methods

    1. Identify a paragraph (`case`)
    2. Extract a method to a obvious nonsense name
    3. Evaluate it at the caller (ignore the body)
    4. Fix or revert and try again
    5. Commit
    
- [ ] ## Activity 2: Move methods onto new classes

    1. Pick a method
    2. Move into a better class
    3. Evaluate at caller
    4. Commit (or revert)

- [ ] ## Activity 3: Clean up the main method

	1. Convert `switch` to `if`/`else`, commit
	2. Remove redundant `else` in method, commit
	3. Extract condition, commit
	4. Move method, commit
	
 - [ ] ## Activity 4: Remove duplication

    1. Make similar things identical
    2. Surround with blocks
    4. Apply Refactoring Combo: Make non-static
    2. Extract local variable
    5. Extract interface
    6. Many-of-one
    7. Use base type
    8. Apply interface and move to many
    9. Extract list of scorers
    10. Extract apply scorers

## Smell: bad names

1. Missing/Misleading -> (Obvious) Nonsense

2. Nonsense -> Honest (but incomplete)

3. Honest -> Honest-and-complete

4. Honest-and-Complete -> Does the right thing

5. Does the right thing -> Intent

6. Intent -> Domain Abstraction
## Refactoring Combo: Make non-static

1. Introduce unused local instance variable in method
2. Introduce parameter
3. Refactor -> Make method non-static
4. Commit

## Refactoring Combo: Provable Undo

1. Execute manual, unproven refactoring
2. Execute automated refactoring to undo #1
3. Save All
4. Verify that Git shows no changes
5. Undo (CTRL-Z) once
6. Commit

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

