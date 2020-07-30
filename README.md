# Mabi-Tools

##Table of Contents
1. [Standards](##Standards)
1. [Commerce Calculator](##Commerce-Calculator)

##Introduction [[TOC](##Table-of-Contents)]
In an effort to teach myself C#, I figured I would create some tools for a Massively Multiplayer Online Role-playing Game (MMORPG) I used to play called Mabinogi. Some of various tools are suggestions from friends who still play the game, others are ideas I have thought of. I won't claim they are unique ideas though, it is quite possible someone else may have already thought of them and made their own implementation.

## Standards [[TOC](##Table-of-Contents)]
These are some rules I have in place for what future tools I might make.

1. Nothing that plays the game for you (e.x. Macros)
2. No kind of software that allows the player to cheat or hack the game client or game server.


## Commerce Calculator [[TOC](##Table-of-Contents)]
This was a suggestion from a friend. In the game, there is a commerce system that allows the player to transport goods between cities. The player pays for the goods they transport, and are paid according to value of the goods at the city they arrive. Players may choose any city to drop off their goods. Players also know the prices of a particular good in all of the other cities when selecting which goods to transport. There is also a smuggler who you can also trade goods to at a higher price. There are downsides to doing this, but they are not relevant to the current project.

There are two main factors that affect price:

1. The further the distance, the higher the price.
2. The more players that trade a certain good to a city, the value of the good temporarily lowers in that city.

Because of point 2, there is no one single good trading route, the best route dynamically changes in accordance to the behavior of all the players in the current channel of the server.

Therefore, the idea behind this tool is to allow the player to quickly input the prices of a desired good and determine the best options.

These are the desired results to display to the player:

1. The net profit at each city
2. Destination with the largest Profit
3. Destination with the Best time to money ratio

The first and second metric should be simple and not hard to achieve. The third metric will require more work as well as data. Since the game does not list exact distances between each city, and research shows only how to determine short term distances. Thus I at the current moment see two options, chaining together methods for determining short distance and figuring out the character's movement speed to determine time - or run each route between cities myself and take an average time. The first method seems like an excessive time investment, plus any errors made in measurement would be harder to spot. On the flip side, while the time taking method is more error prone - I'm not looking for exact precision to come out of this method anyway, and if a user disagrees with my data - I have included tools to alter the dataset in the program.

Here are some of the assumptions I made when compiling my own time dataset:

1. Time spent moving around Bandit ambushes will be included - since it's not easy to uninclude it anyway
2. Time spent fighting Bandits will not be included (aka the timer is paused at these moments)
3. For the boat between Cobh and Belvast - maximum time spent waiting for the boat will be assumed.

For assumption 2 - the damage output of each user is different and there are different types of bandits - it's better to not factor them in. This primarily mostly affects the times of Osna Sail and somewhat affects Corrib Valley due to the narrowness of those two paths making some encounters unavoidable.

Even though the commerce system has not really changed that much for multiple years, I decided to accommodate the potential for changes by dynamically loading the data and including tools for the user to change the various data sets in the event I am unavailable to do so myself.

## Cooking Meter [[TOC](##Table-of-Contents)]
Not currently in development but the next idea would be to make my own cooking meter. This not an original idea, there are a few decently made cooking meters already. I just simply wanted to make my own as well. I will expand upon this feature in the README when I reach that phase in development.