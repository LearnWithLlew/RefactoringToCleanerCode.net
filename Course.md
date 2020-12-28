# Course Section 1 

## Testing Functional Code

* [ ] Validate environment
    * [ ] Run the test
    * [ ] Turn on NCrunch & show Risk/Progress window

**Scenario:** In this scenario, we are looking at large method that we don't understand, and we want to clean up. We are going to "follow our nose", leaning into the places we don't like and pulling out chunks and improving them.

1. Pulled out paragraphs from each case
2. Pulled out parameter object
3. Recognized things were wrong, and reverted (*send bug report to R#)
4. Pulled out whole `switch`
5. Pulled out parameters
6. Pulled out paragraphs from each case
7. Removed `goto`.

# Rules for today's refactorings

- [ ] Automated refactorings "only"
- [ ] Commit after each refactoring
- [ ] Every commit prefixed with `r   `
- [ ] Rotate typist on commit
  - [ ] Maybe switch to timer after first rotation

# Show Sparrow decks

- Sparrows
- Paragraphs
- Long methods

# Smell: bad names

- [ ] Missing/Misleading -> Nonsense

- [ ] Nonsense -> Honest (but incomplete)

- [ ] Honest -> Honest-and-complete

- [ ] Honest-and-Complete -> Does the right thing

- [ ] Does the right thing -> Intent

- [ ] Intent -> Domain Abstraction
# Smell: Inconsistency

- [ ] make consistent

  (surfaces duplication)

  

# Smell: Long Switch

- [ ] Prerequisite: every case is a single call
- [ ] Convert dispatch to strategy
  - [ ] switch->if/else
  - [ ] Remove redundant `else`
  - [ ] Extract method on condition
  - [ ] Move condition and action to another type
    - [ ] 
  - [ ] Convert first `if` to many-of-one
  - [ ] Convert next to many







# Smell: Long Method

- [ ] Identify a paragraph
- [ ] extract it
- [ ] Does the paragraph you extracted make sense?
	

# Smell: Improper class

- [ ] figure out what doesn't belong in the class and move it to another class

# Smell: Duplication

- [ ] Make similar things identical
- [ ] Extract the duplication
- [ ] 

# Smell: Duplication

- [ ] Extract interface



## Homework

* [ ] Print out the [homework sheet](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.slides/raw/master/Homework%20Printouts%20-%20Week%201.pdf) and keep it by your desk, to increase your awareness throughout the week.

### Homework details

* [ ] Redo today’s coding exercises on your own computer
    * Start from the code on the [master branch](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.cpp)
    * If you want to see the code we wrote together, check the [other branches](https://github.com/LearnWithLlew/TestingLegacyCodeCourse.cpp/branches)
* [ ] **Count** Number of times you encounter a **functional** method at work this week
* [ ] (Optional) If you **write** any **tests** for those methods, please **make a note** so we can share at the start of next week.
