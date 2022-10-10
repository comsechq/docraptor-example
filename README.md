## Description

This is a simple CLI app used to reproduced the [issue 28](https://github.com/DocRaptor/docraptor-csharp/issues/28).

Why is docraptor compliled with a reference to restsharp that doesn't specifiy a publicKeyToken?

![Public Key Token is not set when insecting the docraptor.dll](https://github.com/comsechq/docraptor-example/raw/main/PublicKeyTokenNotSet.png)

This means if your code has two dependencies on different nuget packages that require a different version of docraptor, the code will fail.

## Steps to reproduce

1. Open the solution with visual studio (tested in VS2022)
1. Hit F5 to start debugging
1. A `TypeInitializationException` is thrown.

![Type Initialization Exception](https://github.com/comsechq/docraptor-example/raw/main/TypeInitializationException.png)
