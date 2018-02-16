# TestEX2-KFS
>by Kristian Flejsborg Sørensen (cph-kf96)

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
after some work on implementing Xunit tests, I hit the previous mentioned problem.   
![](https://i.gyazo.com/ab2f39cca678b61b483da780d08ffad0.png)   
shows that i'm inputting a 0 which isn't a acceptable value, and I'm expecting a exception, but the test shows no exception is thrown.   

after some work I found that it wasn't just any type of exceptions but a argumentexception.   
![](https://i.gyazo.com/bfe965829afe17c7fc9acbf28dfad2a9.png)   
and I'm starting to wonder if my constant chase for learning this new tool, have resulted in me trying to appease my test cases instead of following them correctly, I'm unsure how to best explain it but it feels like I'm doing the reverse scientific method, as of writing I'm tired of going in circles, and I'll revisit this part on sunday if I have energy for it.

## Task 3
task is to explain ![this](https://smartbear.com/learn/code-review/guide-to-code-review-process/) checklist step by step, and what I as a programmer feel are most useful.   

It mostly descripes 2 main factors, one being pre production work, that's aimed at increasing the quality and quantity of each individual developer by both agreeing on guidelines, and setting quantifyable goals to allow better monitoring of the progess.
the second is a focus on structured testing and code reviewing, since the paper indicates shorter sessions of code review have the best effect, while longer processes results in fatigue.   
I greatly dislike the undermessage of that checklist for reason I wont go into, but I value number 1 greatly as explain further in task 5.   
Number 6 also have good advice, depending on code conventions and how packed the lines are, it can be easy to experience "tunnel vision" making one unable to see the big picture, as one follows around the code like a endless rabbit chase, without breaks in between review sessions you wont have those pauses that resets ones viewpoint of the code.   
Number 11 is also good, but it has to be taken with a grain of salt, since putting trust into tools can result in problems, they can be very helpful and prove the correct things, but even if you had a developer specifically write that tool, the general idea is humans are prone to error, so the tool is prone to error because of it's creator, the tool can help us but we must ensure that we don't let it guide us to the wrong conclusion.

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
