# The Garden Id Kata

Suppose you are writing a web service that handles various operations on Garden.

You are going to be called with a "garden ID", a string.

Your job is to make sure the ID is valid:

* It has to be of length 7
* It must only contains digits

You can look at the existing tests to see examples of both valid and invalid ids.

You may have realized that returning a boolean in the method does not give the caller
any information as to *why* the value was rejected.

## Instructions

* Find at least 3 ways you return more information to the user
* Familiarize yourself on the Value Object concept and implement it
* Reflect on what you just did
