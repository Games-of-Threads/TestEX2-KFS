# TestEX2-KFS

## Tasks

this exercise follows the tasks specified [here](https://github.com/datsoftlyngby/soft2018spring-test-teaching-material/blob/master/exercises/Static%20Test%20Techniques%20Exercises.pdf)

## Task #1
See moodle handin.

## Task #2

### part 1
Metric tool: [Code Metrics](https://marketplace.visualstudio.com/items?itemName=Elisha.CodeMetrices)   
Code standard tool: [Resharper](https://www.jetbrains.com/resharper/download/)   

### part 2
first Examination revealed this.   
![](https://i.gyazo.com/d941443b203f70965c5302a2053391eb.png)   
somehow a addtional ";" got in there   
![](https://i.gyazo.com/f5be50346b6c9c275e963abce2439592.png)   
A few constraints suggesting better nameing, and a pointer that 3 existing values has the possibility of being null, however they are within try catch statement, but I imagine it's because they exist on the same switch level, that they also get instantiated, which technically mean if the system where to skip the "start" case, it would be possible to reach those values and hit a null reference situation.   
![](https://i.gyazo.com/0066a4106ab19dad31e849179cd4bcb6.png)   
otherwise no major issues.   

### part 3
![](https://i.gyazo.com/fecbddf96a8072d0f22d79c0240b80c0.png)   
the metric analyses reveals a rather complex code setup, where the primary complexity stems from ```triangle() : void``` a deeper observation shows the entire function is a spiderweb of switches and if statements, which have room for large improvements.   

### part 4
From observating the above mentioned function and referencing [this](http://www.aivosto.com/project/help/pm-complexity.html) I can conclude it's standard CC and not CC2 or CC3.   

### part 5
after seeing the complexity I made a refactor pass and got the following result.   
![](https://i.gyazo.com/d1a036df21a60035460a9d5c9f946baf.png)   
although it's only minor reduction for the class, the complexity have been spread out for easier management, this was achieved by removing alot of the case functions, and reducing the if statments in a logical deduction that if the inputs are correct, it's either 3 cases, there's only 1 state for either equilavante and scalene, so testing only those reduces the overhead as testing all possible isolence would be exhaustive.
after writing this I think I removed check for 0 or below, xunit test should reveal this though.

### part 6
to be continued.   

## Task 3
to be continued.   

## Task 4
given the throw exception part of the addperson function doesn't outright stop itself, the code will continue to the code that adds the person, so when the first test that expect a throw and expect the operation to not add the person finishes, the second test fails as it expects the list of people to contain 0 people in it.

## Task 5
I don't really care about naming conventions, the most important idea is keeping things simple, if you keep the function size low and have descriptions on said function, any programmer of any background and deduct what happens where and when, the more complex a function becomes the harder it becomes to deduce it's original and current purpose.
This is especially important for mainenance as taking over code for new people will always result in them having to adapt to a new naming convention, so keeping it simple and seperated larger functions to smaller and document them will improve the production for everyone.   
But to increase team productivity it's best the team decide for the respective product, what naming convention and code structure is to be used doing development.

## Task 6
since I was sadly sick, but have been there last spring semester so I'm fairly sure I remmeber the last time I had that presentation, I can state from hazy memory the three most important things about testing that I remmeber.
### #1
From the moment we as programmers even concieve a function or variable, we are already running test cases in our head to verify that the code we're about to write is the correct answer to our problems, therefor by improving ourselfs as testers we improve ourselfs as programmers.
### #2
the most expensive part of any software life cycle is the maintenance phase. Any issue that slips by the previous phases of any software will exponentially grow in cost to either repair or maintain, so testing early and well can make reduce wasted man hours and money on any softwares life cycle.
### #3
Softwares life cycle are extended through continues development which results in very larges complex structures of code, although the system have worked as it should, some defects in the system can be activated by minor additions or changes in areas unrelated to where the defect exist, by continues recursive testing is it possible to identify a issue when and where it appears even after a products release.
