# _WordCounter_

#### By _**Tavish OKeefe**_

## Description

_This is the back end logic for a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

## Specifications
* _**When a user inputs a word, it will be stored, and accessible.**_
* _**When a user inputs a sentence, it will be stored, and accessible.**_
* _**When a user inputs a word, and a sentence, program will determine whether the word is in the sentence. This should be the simplest code to write.**_
_Example Inputs: "dog", "I saw a dog"_
_Example Output: True_
* _**If word inputed is in the sentence inputed, program will break word into characters.**_
_Example input: "Dog"_
_Example output: ['D','o','g']_
* _**If word inputed is in the sentence inputed, program will break sentence into characters.**_
_Example input: "I saw a dog"_
_Example output: ['I', '', 'saw', 'a', 'dog']_
* _**When a user picks a word, the program will determine whether the first letter of the word matches the first letter of the first word in the inputed sentence.**_  
_Example Input: "a"_  
_Example Output: True or False_

* _**When a user picks a word, the program will determine whether the first letter matches the first letter of any of the words in the inputed sentence.**_  
_Example Input: "a"_  
_Example Output: True or False_

* _**If the result of the previous test is false, the program will cease.**_

* _**If the first letter of the inputed word matches the first letter of an inputed word in the sentence, program with check of following letters match.**_  
_Example Input: "and", "and"_
_Example Output: Console.WriteLine("your word matches a word!"), or Console.WriteLine("your word does not match any words.")

## Setup/Installation Requirements

* _Clone repository to your desktop_
* _Open in Atom, or text and source code editor of your choosing._

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Tavish OKeefe: okeefe.tavish@gmail.com_

## Technologies Used

* _CSharp_
* _JavaScript_

### License

Copyright (c) 2018, _Tavish O'Keefe_  

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:  

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE._
