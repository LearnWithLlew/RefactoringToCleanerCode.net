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

- Automated refactorings "only"
- Commit after each refactoring
- Every refactoring commit prefixed with `r - `
- Rotate typist on commit
- No context menu

## Improvement Loop

1. Identify a smell
2. Refactor
3. Decide if you like the result
4. Commit (or revert)

# Do this

- [ ] ## Activity 1: Extract Paragraphs to methods

  1. Select a paragraph (a `case`) [`CTRL-W`]
  2. Extract a method to a Obvious Nonsense name [`CTRL-SHIFT-R`]
  3. Decide if you like the call (ignore the body)
  4. Fix and commit, or revert and try again

- [ ] ## Activity 2: Move behaviors onto new classes

  1. Move each method onto a new class x 4 [`CTRL-SHIFT-R`]
  2. Convert `switch` to `if`/`else` [`ALT-ENTER`]
  3. Remove redundant `else` in method [`ALT-ENTER`]
  4. Select the condition
  5. Extract to a method with a Nonsense name
  6. Move the method to the corresponding class, commit
  7. Repeat x 3

 - [ ] ## Activity 3: Remove duplication

   1. Make similar things identical
   1. Make each class non-static [recipe]
   1. Apply Refactoring Combo: Undo Make Static
   1. Surround each `if` with a block [`ALT-ENTER`]
   1. Introduce local variables [`CTRL-SHIFT-R`]
   1. Extract interface x 1 [`CTRL-SHIFT-R`]
   1. Apply interface x 3
   1. Specify type explicitly
   1. Use base type x 4
   1. Apply Refactoring Combo: Many-of-one (two, three, four)
   1. Extract variable `scorers`
   1. Extract method `ApplyScorers()`

# Resources

## Smell: bad names

1. Missing/Misleading -> (Obvious) Nonsense

2. Nonsense -> Honest (but incomplete)

3. Honest -> Honest-and-complete

4. Honest-and-Complete -> Does the right thing

5. Does the right thing -> Intent

6. Intent -> Domain Abstraction

## Refactoring Combo: Undo Make Static

**Insight:** A proven-correct refactoring means that the resulting code is the same as the beginning code. Therefore undoing a proven-correct refactoring is also a proven-correct refactoring.

1. Verify that Git shows no changes
2. Execute manual, unproven refactoring
3. Execute automated refactoring to undo #1
4. Save All
5. Verify that Git shows no changes
6. Undo the automated refactoring
7. Commit

## Refactoring Recipe: many-of-one

> This is not a proven-correct refactoring.

Given:

```c#
SOMETYPE somevar = ...;
// do something with somevar
```

Becomes:

```c#
foreach (SOMETYPE somevar in new SOMETYPE[]{ ... })
{
    // do something with somevar
}
```

1. Add curly braces (`{}`) around the eventual body
2. Prefix variable declaration with `foreach (`
3. Replace `=` with `in new SOMETYPE[]{`
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

