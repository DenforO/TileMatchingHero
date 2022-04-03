# Tile Matching Hero
First course project, made during second semester at Technical university for the OOP course. The aim of this project is to apply fundamental OOP paradigms through an original concept. 

![](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/MainMenu.png)

## Overview
Tile Matching Hero is a fantasy-themed RPG style game based on the standard "match-three" mechanic, where the player manipulates tiles in order to make them disappear. The objective is to place as many tiles of the same type next to each other as possible, by dragging only one at a time. Each type of tiles gives the player points that can be used in order to perform specific actions in a duel with a mystical creature.

![movingTile](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/tileMoving2.gif)  
   
## Gameplay

### Battle  
The player can choose out of four levels of difficulty that determine how many enemies he/she will be facing as well as how powerful they are going to be. Then the player starts dueling the enemies one by one. The following actions are possible:  

- **draging a tile** over the board, matching as many same-type tiles as possible in order to collect elemental points (once per turn)  

   ![movingTile](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/tileMoving3.gif)
   
- activating a **Magic action** when enough of the required elemental points are collected  

  ![MagicAction](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/magicAction2.gif)
 
- using a **Potion** to earn more elemetal points (once per turn)  

  ![UsePotion](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/potionUse1.gif)

- performing a **Basic attack** (once per turn), that can be powered up with coins, collected after the battle  

  ![BasicAttack](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/basicAttack2.gif)
  
After the player's turn is finished, the enemy performs one of its actions, chosen randomly.

![EndTurn](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/endTurn1.gif)

It's the player's turn again. The game goes on until the enemy's Life points (or the player's) reach 0. Then the next enemy appears.

### Shop

After the duel is finished, the player earns coins according to the difficulty of the completed challenge. Then he/she can visit the shop and look through the available goods.  

![Shop2](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/shop2.gif)  

Coins can be used to:  
- Buy more Potions
- Buy a new Magic action
- Upgrade the player's stats  

![Shop](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/shop1.gif)

### Inventory

The player could also visit the Inventory to view his/her stored Potions and/or choose a different set of Magic actions to bring into the next challenge.

![Inventory](https://github.com/Yrd-Q/TileMatchingHero/blob/main/Screenshots/inventory1.gif)  

## OOP Requirements

The project fulfills the following OOP requirements (with examples):  
- **Inheritance**  
  - The different types of tiles (Circle, Triangle, Diamond...) inherit the abstract class Shape
    - Each shape has a center, color, etc., but has a different way of painting, calculating wether the cursor is inside it or not, etc.
  - The different types of Enemies (Dragon, Goblin, Witch) inherit the abstract class Enemy  
    - Each enemy has the same set of stats (Life points, Defence points, ...) but the set of Action it chooses from depends on its type (Goblin - Basic attack or Shield, Witch - Weak magic attack or Attack basend on lost Life points...)  

- **Encapsulation**
  - The player's and the enemies' stats are protected and can be accessed only through Properties. Some of them allow only reading since modifying the respective stat happens exclusively inside the class.
- **Polymorphism**
  - After defeating an enemy, a new one is created. The RandomEnemy generating method's return type is Enemy, although it returns either a Goblin, a Witch or a Dragon object. During its "StartOfTurn" the created instance performs an action which varies for each one of the tree classes. For example if the created instance was a Dragon, it may deal damage and also gain Life points, while if it was a Witch, it may deal damage, equal to the Life points it has lost so far.
- **Virtual methods**
  - The Enemy class's Attack method is abstract and overriden by each of its child classes with a specific effect.
- **Different access modifiers**
  - Protected fields in the parent classes Shape and Enemy, private fields in the class Hero, public properties in all classes.
- **Properties**
  - Properties corresponding to all fields that should be accessible (eather to only read or read and write) outside of the Enemy, Shape and Hero class.
- **Delegates**
  - The Enemy class holds a List of delegates that are the possible actions, specified by each of its child classes. The delegate states that each action should be a void method that takes the Hero (Player's stats) as a parameter.
  - The Magic class holds a delegate for the different Magic Actions. They take the player's and the enemy's stats, and return void. Their effects are defined as lambda expressions outside of the Magic class and in the Shop form (Form3) where they are initially created.
- **Events**
  - Clicking inside a tile, dragging it over the board and releasing it, as well as pushing any of the buttons, raises different events in the battle form (Form4).
- **GUI**
  - A graphic user interface made with Windows Forms.
- **A specific functionality, interacting with the created class hierarchy**
  - Using the System.Drawing library to draw the grid and the tiles inside of it.
- **Storing files via serialization**
  - The game stores the player's Inventory and coins after closing the application (MainForm_Closing event in Form1) and loads them when it's started again (Form1_Load).
- **Use of LINQ**
  - The list of Potions and Magic abilities in the Inventory form (Form2) and Shop form (Form3) can be sorted by name or price and filtered by type using LINQ.
- **Implementing a library**
  - The hierarchy of enemies and the hero are implemented in a CharactersLibrary, which is indepenendent of the Windows Forms classes.
