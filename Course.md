# Run tests manually

* Validate the environment
    * [ ] Run all tests (`Ctrl-U, L`)

# Run tests automatically

* Open NCrunch menu (`Alt-U`)
    * [ ] Enable NCrunch
    * [ ] Ensure **Risk/Progress** window is open and visible and out of the way.

# Read this:

## Scenario

We are looking at large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.

## Starting Rules for today's refactorings

- Automated refactorings "only"
- Commit after each refactoring
- Every refactoring commit prefixed with `r - `
- Rotate typist on commit

## Improvement Loop

1. Identify a smell
2. Improve it
3. Evaluate
4. Commit (or revert)

# Do this

- [ ] ## Activity 1: Extract Paragraphs to methods

    1. Identify a paragraph (a `case`)
    2. Extract a method to a Obvious Nonsense name
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
	3. Extract condition to a method with a Nonsense name, commit
	4. Move method, commit
	
 - [ ] ## Activity 4: Remove duplication

    1. Make similar things identical
    2. Surround each `if` with a block
    3. Apply Refactoring Combo: Provable Undo to make non-static
    4. Make each class non-static
    5. Extract local variables
    6. Extract interface
    7. Use base type
    8. Many-of-one
    9. Apply interface and move to many
    10. Extract list of scorers
    11. Extract apply scorers

# Resources

## Smell: bad names

1. Missing/Misleading -> (Obvious) Nonsense

2. Nonsense -> Honest (but incomplete)

3. Honest -> Honest-and-complete

4. Honest-and-Complete -> Does the right thing

5. Does the right thing -> Intent

6. Intent -> Domain Abstraction
 
## Refactoring Combo: Provable Undo

**Insight:** A proven-correct refactoring means that the resulting code is the same as the beginning code. Therefore undoing a proven-correct refactoring is also a proven-correct refactoring.

1. Verify that Git shows no changes
2. Execute manual, unproven refactoring
3. Execute automated refactoring to undo #1
4. Save All
5. Verify that Git shows no changes
6. Undo (CTRL-Z) once
7. Commit

## Refactoring Recipe: many-of-one

> This is not a proven-correct refactoring.

Given:

```c#
T x = ...;
// do something with x
```

Becomes:

```c#
foreach (T x in new T[]{ ... })
{
    // do something with x
}
```

1. Add curly braces (`{}`) around the body
2. Prefix with `foreach (`
3. Replace `=` with `in new T[]{`
4. Replace `;` with `})`


## Homework

* Redo today’s coding exercises on your own computer

  * Start from the code on the [`main` branch](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net)
  * If you want to see the code we wrote together, check the [other branches](https://github.com/LearnWithLlew/RefactoringToCleanerCode.net/branches)
  * Pay attention to:
    * how often you're able to execute a single refactoring - more is better
    * how many times you are able to pull out a paragraph into a new method
* Print out this sheet and keep it on your desk. Over the next week as you're doing your normal work:
  * note when you were able to improve the code with a single, committed refactoring
  * note when you extract a paragraph
  * Make a TODO list of code you wish was better but couldn't improve at this time

