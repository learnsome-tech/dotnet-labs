# Exercises — Records, Pattern Matching, and Modern C#

Lesson `m01l06` · [Watch](https://learnsome.tech/courses/dotnet-course/watch?lesson=m01l06)

## Exercise 1: Exercise: a parcel, a band, and a missing arm

1. Declare a positional record Parcel(int Id, decimal Weight); print two equal parcels.
2. Write a switch expression mapping Weight to a band, with a discard arm at the bottom.
3. Match the middle band with a property pattern joining two relational patterns with and.
4. Delete the discard arm, read the compiler warning, then put it back.

> **Hint**: Relational patterns have no left-hand side: an arm reads `< 1m =>`, and `and` joins two of them.


---

© LearnSome.tech · support@iwantto.learnsome.tech
