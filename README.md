# Tournament Tracker

_Content_

1. [Lesson 0 - Introduction](#lesson-0---introduction)
2. [Lesson 1 - Initial Planning](#lesson-1---initial-planning)
3. [Lesson 2 - Overview Planning](#lesson-2---overview-planning)

## Lesson 0 - Introduction

This is the first medium-size project I will be doing along with [IAmTimCorey](https://www.youtube.com/channel/UC-ptWR16ITQyYOglXyQmpzw) video lessons on YouTube.
Technologies used:

1. Multi-Form Windows application
2. In-depth Class Library
3. SQL Database
4. Text File Storage
5. Dapper
6. Linq
7. Interfaces
8. Emailing from C#
9. Custom events
10. Advanced Debugging
11. More...

[Please visit lesson for more understanding...](https://www.youtube.com/watch?v=HalXZUHfKLA&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=1)

## Lesson 1 - Initial Planning

Your friends come to you and ask you to do a tournament tracker. They are always playing games and want to determine who is best. The idea is that you create a bracket tournament system where the computer will tell them who to play in a single-elimination style bracket. At the end, the winner should be identified. Their model is the NCAA Basketbal tournament bracket for March Madness.

### Requirements

Once the stakeholder gives such a vague order, as a developer you should narrow down the requirements. Here is what Tim did:

1. Tracks games played and their outcomes (who won)
2. Multiple Competitors
3. Creates a tournament plan (who plays in what order)
4. Schedules the game
5. A single loss eliminates the team or player
6. The last standing player or team is the winner

Once you as a developer understand what the stakeholder wants, it is time to ask your questions in detail. The more exact question you give, the more clear the vision of development would become.

### Questions

1. How many players will the tournament has? Is it a variable (changing)?
2. What if a tournament has less than a full complement of players? Do some team become 'byes' (jumpers to next round)?
3. Should ordering be random or sorted by input order?
4. Should we schedule the game or do they play whenever?
5. If yes, how we handle it? Or do we simply declare the time slots and let the user insert the score anytime?
6. If no, can the game in the second round be played before the first round is fully over?
7. Does the systems need to store the scores or just who won?
8. What type of front-end does the stakeholder wants (Windows Forms, Web Page, App, etc.)?
9. Where is the data gonna be stored (text files, excel spreadshits, database, etc.)?
10. Does the system handle entry fees, prizes or payouts?
11. How to report the results?
12. Who can fill the results of a game?
13. Are there varying levels of access?
14. Should the system contact the players about upcoming events?
15. Is it individual or team tournament tracker?

**Here is lesson outcome:**
At first the developer should set clear vision of what he will be doing
[Please visit lesson for more understanding...](https://www.youtube.com/watch?v=YF-3SpIGkYM&list=PLLWMQd6PeGY3t63w-8MMIjIyYS7MsFcCi&index=3&t=0s)

## Lesson 2 - Overview Planning
