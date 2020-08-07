# Mabi-Tools

## Table of Contents
1. [Standards](#standards-toc)
1. [Commerce Calculator](#commerce-calculator-toc)

## Introduction [[TOC](#table-of-contents)]
In an effort to teach myself C#, I figured I would create some tools for a Massively Multiplayer Online Role-playing Game (MMORPG) I used to play called Mabinogi. Some of various tools are suggestions from friends who still play the game, others are ideas I have thought of. I won't claim they are unique ideas though, it is quite possible someone else may have already thought of them and made their own implementation.

## Standards [[TOC](#table-of-contents)]
These are some rules I have in place for what future tools I might make.

1. Nothing that plays the game for you (e.x. Macros)
2. No kind of software that allows the player to cheat or hack the game client or game server.


## Commerce Calculator [[TOC](#table-of-contents)]
This was a suggestion from a friend. In the game, there is a commerce system that allows the player to transport goods between cities. The player pays for the goods they transport, and are paid according to value of the goods at the city they arrive. Players may choose any city to drop off their goods. Players also know the prices of a particular good in all of the other cities when selecting which goods to transport. There is also a smuggler who you can also trade goods to at a higher price. There are downsides to doing this, but they are not relevant to the current project.

The idea is to make a tool that allows a user to input the prices of a good in each City and give statistics

### Price Factors

There are two main factors that affect price:

1. The further the distance, the higher the price.
2. The more players that trade a certain good to a city, the value of the good temporarily lowers in that city.

Because of point 2, there is no one single good trading route, the best route dynamically changes in accordance to the behavior of all the players in the current channel of the server.

Therefore, the idea behind this tool is to allow the player to quickly input the prices of a desired good and determine the best options.

### Desired Output 

These are the desired results to display to the player:

1. The net profit at each city
2. The money/time ratio of each city

The first should be simple and not hard to achieve. The second metric will require more work as well as data. The game does not list exact distances between each city, and research shows only how to determine short term distances. Thus, some data collection and measurement will be necessary. 

At the current moment see two options, chaining together methods for determining short distance and figuring out the character's movement speed to determine time - or run each route between cities myself and take an average time. The first method seems like an excessive time investment, also does not reflect the presence of Bandits on each route. On the flip side, while the time taking method is more error prone, it incorporates the presence of Bandits since players, even when more than capable of dealing with them, avoid them.

### Base Data Set Assumptions

I timed each route by using [Livesplit](https://livesplit.org/). I have developed a time editor form to easily allow a user to edit the time data as they please. I also used this tool to record my time data.

Here are some of the assumptions I made when compiling my own time dataset:

1. Time spent moving around Bandit ambushes will be included - it's a fundamental part of transportation
2. The timer will be paused if attacked by Bandits
3. Time spent waiting for the boat between Cobh and Belvast will not be in the base data set - instead programatically added
4. No movement speed boosting titles, potions, or related options were used
5. Time starts with the first step from the trade post, time stops as soon as within talking distance of the Trade Assistant at each trade post 

For assumption 2 - the damage output of each user is different and there are different types of bandits - it's better to not factor them in. Plus the transport does not move during bandit encounters, so time should not be affected anyway. This mostly affects the times of Osna Sail and Corrib Valley due to the narrowness of those two paths making some encounters unavoidable. For assumption 4 - I will eventually have a feature that will allow the user to input their movement speed bonus in percentage and factor that in.

If you wish to make your own time data set - you do not have to follow the assumptions made above. You can even set the Belvast boat time to 0 to avoid using that feature 

### Data Editors

Even though the commerce system has not really changed that much for multiple years, I decided to accommodate the potential for changes by dynamically loading the data and including tools for the user to change the various data sets in the event I am unavailable to do so myself, or if the user wishes to tailor the data to their specific needs.

Currently the user can edit the following data sets:
 
* The Time Data set
* Transports
* City and Goods

## Cooking Meter [[TOC](#table-of-contents)]
Not currently in development but the next idea would be to make my own cooking meter. This not an original idea, there are a few decently made cooking meters already. I just simply wanted to make my own as well. 
