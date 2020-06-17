# Tournament Tracker

_Content_

1. [Lesson 0 - Introduction](#lesson-0---introduction)
2. [Lesson 1 - Initial Planning](#lesson-1---initial-planning)
3. [Lesson 2 - Overview Planning](#lesson-2---overview-planning)
4. [Lesson 3 - Data Design](#lesson-3---data-design)
5. [Lesson 4 - Logic Planning](#lesson-5---logic-planning)

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

1. How many players will the tournament has? Is it a variable (changing)?

   The application should be able to handle a variable number of players.

2. What if a tournament has less than a full complement of players? Do some team become 'byes' (jumpers to next round)?

   If there is no complement for some teams, it is ok for some to skip the first round as if they won.

3. Should ordering be random or sorted by input order?

   Random

4. Should we schedule the game or do they play whenever?

   The game should be played in any order and any time.

5. If yes, how we handle it? Or do we simply declare the time slots and let the user insert the score anytime?

   No, each round should be fully completed first.

6. If no, can the game in the second round be played before the first round is fully over?

-

7. Does the systems need to store the scores or just who won?

   Recording the scores would be nice.

8. What type of front-end does the stakeholder wants (Windows Forms, Web Page, App, etc.)?

   Currently, WinForms is enough. But in the future there might be UI changes.

9. Where is the data gonna be stored (text files, excel spreadshits, database, etc.)?

   Ideally, Micrasoft SQL would be great. However, text file storage also would be a good add-on.

10. Does the system handle entry fees, prizes or payouts?

    Yes. There will be an entry fee. Plus, the administrator decides how much percentage or what prize to give to the winner.

11. How to report the results?

    It is good to have message in the form about the winner. Plus, emailing the administrator and the player would be nice.

12. Who can fill the results of a game?

    Anyone using the app. We think that the app would be installed in the pc of the admin so that no one can access the program.

13. Are there varying levels of access?

    No

14. Should the system contact the players about upcoming events?

    Yes, the program should email users.

15. Is it individual or team tournament tracker?

    The should be option to add other members to the team.

### Big Picture Design

Once every question is answered, it is time to think about the technologies we will be using for program development.

1. **Structure**: Windows Forms and Class Library
2. **Data**: SQL and/ or Text Files.
3. **Users**: One user at a time.

### Key Concepts

Once you know what technologies you will be using, you should identify what are some of features. For this particular program the key concepts are:

- Emailing through C#
- SQL
- Custom Events
- Error Handling
- Interfaces
- Random Ordering
- Texting

## Lesson 3 - Data Design

In this stage you have to think through and jot down what data you will be using in this program. Below you can find the data mapping process for the current application:

**Team**

- TeamMembers (Lis<Person>)
- TeamName (string)

**Person**

- FirstName (string)
- LastName (string)
- EmailAddress (string)
- PhoneNumber

**Tournament**

- TournamentName (string)
- EntryFee (decimal)
- EnteredNumber (List<Team>)

**Prize**

- PlaceNumber (int)
- PlaceName (string)
- PlaceAmount
- PrizePercentage (double)

**Matchup**

- Entries (List<MarchupEntry>)
- Winner (Team)
- MatchupRound (int)

**MatchupEntry**

- TeamCompeting (Team)
- Score (double)
- ParentMatchup (Matchup)

## Lesson 4 - User Interface Planning

Now in this stage as a developer, you should sketch the basic form layout of the program. This help to visualize what you will be building. In the early days of programming you might not have the designer who will be drawing professional look for your app. Therefore, I would highly recommend to draw on paper first since in this way you can easily make changes to the layout.

## Lesson 5 - Logic Planning

This is the special stage of your development process. It is time for you to think about the functionality of each feature. You do not really need to know how exactly implement the feature but you have to what what each button does, to what form it redirect.

_Make sure you don't have many layers inside each form_

## Lesson 6 - Creating Class Library

So far we have been working in the planning stage of the programm. That took nearly 5 steps for us to actually start coding. From this step on we will be building what we have been thinking so far. Now the development phase is supposed to be more straighforward as we clearly envisioned what we will be building.
