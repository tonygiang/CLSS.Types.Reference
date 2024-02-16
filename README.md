# CLSS.Types.Reference

### Problem

Value types by themselves cannot be referenced in managed C# code. This becomes a problem when you have a value-type variable that frequently changes and you need to reflect those changes in many parts of your program.

### Solution

`Reference<T>` is a simple wrapper around any type to have a reference to the value encapsulated within.

**Example**:

```csharp
using CLSS;

int valA = 3;
int valB = valA;
valA = 4;
Console.WriteLine(valB); // output: 3

var refA = new Reference<int>(3);
var refB = refA;
refA.Value = 4;
Console.WriteLine(refB.Value); // output: 4
```

`Reference<T>` was created with the intention of encapsulating value types, but does not have any type constraint. Should you find a use case for encapsulating a reference type within another reference type, you can use `Reference<T>` for that purpose too. Subclassing `Reference<T>` into your own types is within the intended goal of this type.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).