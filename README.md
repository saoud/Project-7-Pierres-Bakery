# _Pierre's Bakery_

#### _This program is a mock bakery. Come get some bread and pastries!_

#### By _**Saoud Rana**_

## Technologies Used

* _C#_
* _.NET_
* _MSBuild_
* _MSTest_

## Description

_This project was created to practice using C#. The user responds to several prompts to buy bread and pastries, and the program returns the total cost to the user._

## Setup/Installation Requirements

* _Clone repository from GitHub to desired location using: $ git clone https://github.com/saoud/Project-7-Pierres-Bakery.git
* _Navigate to and open project directory in terminal_
```cd Bakery.Solution```
* _Once in project directory, open project in code editor_
```code .```
* _To build project, in the terminal enter:_
```dotnet restore```
* _To run the program, navigate to production folder Bakery and in the terminal enter:_
```dotnet run```
* _Respond to the prompts in the command line._
* _To run tests: Navigate from the root directory to the Bakery.Tests directory. Then in terminal, type_
```dotnet restore```
* _Finally, to run the tests, make sure you are still in the Bakery.tests directory and in the terminal type_
```dotnet test```

## Specifications

| Behavior                                                                                     | Input                 | Output                                                                                                      |
|----------------------------------------------------------------------------------------------|-----------------------|-------------------------------------------------------------------------------------------------------------|
| The program will provide the user with a welcome message and the cost for bread and pastries |                       | "Welcome valued customer! Bread is buy 2, get one free or $5 per loaf. Pastries are one for $2 or 3 for $5" |
| The user will be able to specify how many loaves of bread they would like                    |           3           | "3 loaves of bread"                                                                                         |
| The program will return the cost of the user's bread order                                   | "3 loaves of bread"   | $10                                                                                                         |
| The user is able to specify how many pastries they'd like                                    |           3           | "3 pastries"                                                                                                |
| The program will return the cost of the user's pastry order                                  | "3 pastries"          | $5                                                                                                          |
| The program will return the total cost of the user's bread and pastry order                  | "3 bread, 3 pastries" | "Your total cost is $15"                                                                                    |
## Known Bugs

* _No known bugs_

    ## License
* [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/saoud/csharp-TDD-template/blob/main/LICENSE)
* Copyright 2021 Saoud Rana
## Contact
[Saoud Rana](mailto:githubissues@saoud.dev)
