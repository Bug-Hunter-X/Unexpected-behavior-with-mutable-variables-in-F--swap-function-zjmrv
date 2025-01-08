# F# Mutable Variable Swap Bug

This repository demonstrates a common error involving mutable variables and unintended side effects in F#.

The `bug.fs` file contains a function that attempts to swap two mutable variables. However, due to the way mutable variables are handled in F#, the swap function modifies the original variables, leading to unexpected results.  The `bugSolution.fs` demonstrates the corrected approach.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.fs` using an F# compiler (e.g., fsharpc).
3. Observe that the output is not the expected swap of values.
4. Compile and run `bugSolution.fs` to see the corrected version.