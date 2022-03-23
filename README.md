Task #1
Given the rules above, come up with a bullet point list of unit tests for the code to ensure that
the rules are tested properly.

* Test end with number 0, it should not display anything.
* Test end with negative number, it should throw an exception
* Test start being greater than end, should throw an exception
* Test start with negative number, it should throw an exception
* Test with input 3 to see if it prints correctly "Fizz"
* Test with input 5 to see if it prints correctly Fizz and then Buzz
* Test with input 15 to see if it prints the sequence correctly and the word "FizzBuzz" on the last row

Task #2
There is a bug in the FizzBuzz code sample. Can you identify where the bug is and a solution to
resolve it?

Comment #1
The if statement in the constructor is wrong as the condition should be inverted to test the starting position is lower than the number of words.
Also if default start is 0, that means that start cannot be neither equal to end, as an index equal to the number will put the index at a greater position than the last number.

Example:
If we have 4 as "end", and 4 as start.
Being the index zero based, start = 4 will be a 5th position that doesn't exists.

So the condition would end up looking like this:
if (end <= start)
{
...
...
}

Comment #2
Additionally there is a typo so I will change:
"Start must be less end."
to 
"Start must be less than end."

Comment #3
In fact, to simplify the code, I could eve remove the support for the "start" parameters as it adds complexity, need to additional unit tests for a funcionalliy that is not listed as a requirement.
Normally I would ask before continuing to implement code that does "more" than what it was asked for, unless it doesn't impact a lot on mantainability, testability or understanding of the code.

Comment #4
Another question that I would make is if by "Ordinal" number we are referring to the order on which the numbers are printed, or the original ordinal number without taking into consideration the parameter "start"

So if we have end=5 and start=2, should the output be:

A)
3
4
Fizz

or

B)
Fizz
4
Buzz


This time it will choose to use approach "B" to simplify and avoid having to use something like:
foreach (var word in _numbers.Select((value, i) => new { i, value }))
{
	var value = word.value;
	var index = word.i;
}

Comment #5
I changed the error messages to constants so it's easier to test for exceptions if we have to.

Task #3
Given the skeleton code above. Implement RunFizzBuzz for all given rules in the Rules section.
Also implement at least 2-3 unit tests for the code.