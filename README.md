[![Build & Test](https://github.com/lyndychivs/Permutations/actions/workflows/build-test.yml/badge.svg?branch=main)](https://github.com/lyndychivs/Permutations/actions/workflows/build-test.yml)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Flyndychivs%2FPermutations%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/lyndychivs/Permutations/main)
[![NuGet Downloads](https://img.shields.io/nuget/dt/lyndychivs.Permutations?style=flat&logo=nuget)](https://www.nuget.org/packages/lyndychivs.Permutations/)

# lyndychivs.Permutations
A simple library for generating permutations of an enumerable collection.

## Example
```csharp
var result = Permutations.GetPermutations([1, 2]);

// result: [1, 2], [2, 1]
```

## Tests
All Unit Tests can be found under the [Permutations.Tests](https://github.com/lyndychivs/Permutations/tree/main/Permutations.Tests) namespace.

## Package
Available on:
- [NuGet](https://www.nuget.org/packages/lyndychivs.Permutations/)
- [GitHub](https://github.com/lyndychivs/Permutations/pkgs/nuget/lyndychivs.Permutations)
