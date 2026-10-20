# Eric Nguyen: DevLog Week 1: Log 01
## October 20th, 2026
---
### Changes
- I got the projects structure set up

### Future Changes
- A starting screen
- the map for the game

### Plan to Do
- Since I am making a Tower Defense Game about Bones vs Dogs, I will focus on making:
- Game name: Bones vs Bites TD
- one map
    - a yellow dirt road with greenery
    - It will be a grid with squares all over the map except for the yellow dirt road
- one bone tower
    - The Spinal Tap - A skeleton uses a spine as a whip to hit enemies
    - the range of the towers to be able to hit the dogs
- one enemy
    - Labrador Retriever - base unit
    - a death animation for the dogs
- pile of bones with 100 health points
    - as the objective that the dogs will go after
- Dog Collars as currency
- a starting screen
- a lose screen
- a win screen
- 5 waves
- Add a play button to start the waves

### Core Gameplay Loop
- Overview:
    - The bones are trying to protect the pile of bones from the dogs trying to chew them.
- Loop:
    - Starting screen pops up
    - The map loads in with a yellow dirt path, greenery, and a grid where the user can place the towers on any of the squares
        - Note: The user can place the tower on any square they want as long as it's not on the path the dogs run on
    - The user will have enough starting currency (Dog Collars) to buy and place at least one tower
    - The user will click a play button to start a wave
    - Whatever tower they chose will defeat the first wave of dogs and the dogs will drop more Dog Collars
    - They can either buy more towers or upgrade the ones they already have
    - Start the next wave
    - This repeats until either the towers fail to kill all the dogs and causes the user to lose with a lose screen popping up or the towers clear the final wave and a win screen pops up