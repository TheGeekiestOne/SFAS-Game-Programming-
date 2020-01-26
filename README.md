# SFAS-Game Programming 
 Development Project Students are asked to adapt and improve upon an existing Unity C# project, developing upon a basic framework to create a playable, finished game. Students will need to plan & create additional content, including the development & implementation of gameplay, design & technical features, finally publishing the game as a finished product.

#SFASX Project Plan
#Ayran Olckers – Misadventures of Sir Noob-A-Lot

Intro
A classic dungeon crawler with action and rougelike elements. when you play as Sir Noob-A-Lot, a Model Noob robot that has to eradicate slime monsters in a dungeon.

Initial Ideas
•	Play as a robot  that has both Range and melee attacks.
•	Typical RPG elements:
o	Experience
o	Health
o	Inventory
o	Stats
o	Various enemies
	Range
	Melee
	Enemies follow (AI)

Research
For this game I had 2 main games which I got idea from. Baldurs Gate Dark Alliance and Hunter Wayward

Development
Todo
•	[X] Add player movement (could use improvement)
•	[X] Add shooting arrows
•	[X] Add sword combat
•	[X] Add damage detection for slime monster
•	[X] Add damage for player/slime attacks
•	[X] Add health
•	[ ] Dying
•	[ ] Health Bar (maybe like one in Farcry 2 where it is split into segments and only auto-regens one segment and you need potions to regen other sections.
•	[X] Add XP
•	[X] Add Levelling Up and Character Stats
•	[ ] Level Up Animation
•	[ ] Add implementation of effects of all Stats
•	[ ] Add dungeon generation? / Room progression
•	[ ] Data Persistence to Save stuff between Rooms
•	[X] Add different monsters
•	[ ] Ghost
•	[ ] Poison trail slime
•	[ ] Fire Slimes
•	[ ] Things other than slimes?
•	[ ] Others
•	[X] Inventory
•	[ ] Make equipping different items show different models in-game
•	[X] Items(Need Many More, but Framework is there)
•	[ ] Chests/Loot Bags
•	[ ] Items dropped by monsters
•	[ ] More Weapons and Items
•	[X] Menu/Settings
•	[ ] Proper UI Scaling
•	[X] Pause Menu
•	[ ] Options
•	[X] Start Menu
•	[ ] Play Menu?
•	[ ] Death Menu
•	[ ] Add Red Vision at Low Health (Maybe we don't need this, it might look weird)
•	[ ] Plot
•	[ ] Sprucing up Looks and Making it look more professional (Models, textures, lighting, rendering, animations, particles, etc.)
•	[ ] Tutorial
•	[ ] Music
•	[ ] Sound Effects
•	[ ] Path finding/Better AI

Things to Consider for future:
Items
How should items, items' stats and player item-related stats work?
Maybe: Each item is ranked by recharge speed, and strength. After each strike/shot there is a time before you can shoot/swing again, determined by the item recharge speed. Obviously, the strength would correlate to the damage done. The player's melee/ranged weapon skill improves the damage and the recharge speed? Or maybe just the damage done by each category of weapon respectively. 

Categories of Weapons and Approximate numbers:
•	Melee
o	Swords (10 in game) - Middle of the road stats for speed/strength
o	Hammers/Axes (7 in game) - high strength and low speed
o	Knives (5 in game) - low strength high speed
•	Ranges
o	Bow (10 in game) - Some have balanced speed/strength but some also have higher speed and lower strength
o	Crossbow (5 in game) - high strength lower speed

Saving
Should players be allowed to save? - No - Save & Quit Button Between Levels - Whenever you quit to title - Autosave - Save should clear on death
Assets and tools
Sounds: 
https://freesound.org/

