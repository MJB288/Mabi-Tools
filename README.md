# Mabi-Tools
In an effort to teach myself C#, I figured I would create some tools for a Massively Multiplayer Online Role-playing Game (MMORPG) I used to play called Mabinogi. Some of various tools are suggestions from friends who still play the game, others are ideas I have thought of. I won't claim they are unique ideas though, it is quite possible someone else may have already thought of them and made their own implementation.

## Standards
I do have some standards for what kind of tools I would create.

1. Nothing that plays the game for you (e.x. Macros)
2. No kind of software that allows the player to cheat or hack the game client or game server.


## Commerce Calculator
This was a suggestion from a friend. In the game, there is a commerce system that allows the player to transport goods between cities. The player pays for the goods they transport, and are paid according to value of the goods at the city they arrive. Players may choose any city to drop off their goods. Players also know the prices of a particular good in all of the other cities when selecting which goods to transport.

There are two main factors that affect price:

1. The further the distance, the higher the price.
2. The more players that trade a certain good to a city, the value of the good temporarily lowers in that city.

Because of point 2, there is no one single good trading route, the best route dynamically changes in accordance to the behavior of all the players in the current channel of the server.

Therefore, the idea behind this tool is to allow the player to quickly input the prices of a desired good and determine the best options. For the time being, I am to display:

1. The net profit at each city
2. Destination with the largest Profit
3. Destination with the Best time to money ratio
4. 
