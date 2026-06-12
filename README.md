
# GDIM33 Vertical Slice
## Milestone 1 Devlog
1.   For my "dialogue", visual scripting graph where, after entering, player movement is turned off during this phase. The canvas is enabled, triggering automatic dialogue and buttons used to advance to the next scene. Additionally, the cursor lock status is no longer set to locked. This is a state in my visual script state machine.
   
2.  For my updated breakdown, I added my state machine overview and animator controller, along with how these intertwine with each other and the rest of the systems. My state machine works as planned, separating the controls for exploration mode and dialogue.
<img width="1704" height="1010" alt="Updated graph" src="https://github.com/user-attachments/assets/08c807b2-b58b-4ea8-af5d-28218b8dd7d8" />

3.    In exploration mode, the player can move the camera and character and interact with objects, with the mouse locked. In dialogue (socialization mode), the HUD, dialogue, and buttons are active, along with the likability meter, current objective, and scene switcher for one-on-one socialization. The state machine primarily changes which player controllers are active and turns the UI on and off. It is also related to other systems, such as dialogue, which is only playable and interactable during the socializing stage, triggered by clicking on an NPC.


## Milestone 2 Devlog
 
### Quick summary of my complicating gameplay feature
 So, for the complicating factor, the NPC will have animations that play in response to dialogue, hinting at certain personality traits, as well as a traffic light visualizing the player's current likability score to signify the overall level of success currently. I believe this adds a level of complexity that will make this project challenging enough for this class. Certain choices will require the player to react to dialogue. The end product is a dialogue system where the character reacts to the player clicking on certain responses, which will affect both the animator and the UI. This completed feature is attached to the first NPC you speak with.

#### Task breakdown for animator + Ui triggers from dialouge

1. Make the enum categories, animation, and UI assets
* In the DialogueNode script, add a public enum called SocialWeirdness.
* Define categories that represent emotional  states.
* In the Animator, drag in and organize the character animations.
* Create a new Canvas for the UI with traffic light visuals (green, yellow, red)
  
2. Detect Scriptable Objects and Their Associated Enums in the Dialogue Progressor Graph
* In the dialogue progression visual graph, detect which Scriptable Object is currently active with a new custom dialogue node to get the emotional state 
* Use the enum as the start of a switch statement branch
*  Which animation should play
*  Which UI state should update

3. Hook the Dialogue System Into the Animator State Machine
* Use triggers to fire off different animation state transitions
* Update UI elements by setting the active color and deactivating other colors



#### AFTER CODING

 Yes, the quiz questions helped me for the first time map out tasks in properlists that actually helped me get started faster, and therfor had over a week to learn the steps i did nott know how to do and add them to my action list, while the step breakdown activity helped me realize a lot about my project scope and issues I was unaware of when scripting and trying to trouble shoot on my own. 

If I were to do it again, I would have more alternatives for points where I could get stuck, as going through the plans showed me that it was not going to work because of scaling issues within my architecture. I will need to make separate dialogue progression systems and obtain the Scriptable Object from each NPC, which is what I will do for milestone 3. Therfor i dodnt overcomplcate the feature of social score from my pitch and kept it as simple as possible, while the animator's reactions work as planned, and the player can see if the action they took was good(green), bad(red), and neutral (yellow).

I am bridging Visual Scripting in my code by calling from a custom event in the start of the dialouge progresser, and using a custom node from the scriptable objects, the method called dialouge node specifcally get enomtinal state, which is getting the enum attached to the Scriptable Object. Calling a custom event from a Graph through a C# method serves the purpose of creating the dialogue options to begin with, and a dialogue node. serving as a trigger to my dialogue buttons and text, interacting to create buttons from the attached scriptable object


<img width="784" height="434" alt="Screenshot 2026-05-14 at 10 57 27 PM" src="https://github.com/user-attachments/assets/8391e2fd-2da5-4140-bb84-62421631200e" />


<img width="707" height="270" alt="Screenshot 2026-05-14 at 10 57 17 PM" src="https://github.com/user-attachments/assets/67347e6b-67aa-445e-a9e9-beb8517293d3" />



<img width="152" height="121" alt="Screenshot 2026-05-14 at 10 57 33 PM" src="https://github.com/user-attachments/assets/d518ea17-4599-47d9-b9a4-58dabae8b4eb" />

#### Unity system 
I want to be graded for my scriptable object Unity system, you can find it being used in dialogue, triggering the animator of my blound NPC. 


## Milestone 3 Devlog

1. My Shader Graph shown here makes a post-processing effect that adds and subtracts textures, showing the face of whoever you are annoying as a flashing effect on the screen.
I used a decal edge mask with the sine time node to create a fade-in and fade-out effect and overlayed sevral texstures. This shader is used in the main scene of my game, where you can interact with the characters.

<img width="603" height="455" alt="image" src="https://github.com/user-attachments/assets/1ce6102f-ea99-43e4-a957-b24babe6d697" />

2.  Based on playtesting feedback, I increased the typing speed of the dialogue during narrative moments. I also added more dialogue, moved UI elements around, and allowed players to interact with more NPCs. In addition, I added colliders for all scene walls and gravity so the player can no longer fall off the map.

3. Since the last milestone, all NPCs now react with moods and animations, which helps show how the player is performing. I added new dialogue nodes to allow for more conversations, as well as new scenes and assets for a full level. I also created a new introduction with dialogue narration to explain the story to the player, along with new assets for that sequence. I added a new post-processing shader that will eventually trigger with the face of a character if the player is making mistakes or upsetting NPCs. NPCs can also now have different dialogue in the same scene, whereas before they were limited to only one conversation per scene.


## Final Devlog

1. My game is a narrative-driven social simulator with branching dialogue. The core gameplay loop involves talking to different NPCs who react to what the player says, with the player's social standing represented by a traffic light system and all characters reacting with animations and branching dialogue to the players actions. The game has a similar art style to "Closing Shift", featuring 3D models that I created and textured myself based on people I know. You play as Zoe, a game development prodigy who needs to learn social skills in order to make games with others. My original plan for this gameplay vertical slice was to showcase what the first level would be like, including the artistic direction, humor, and overall art style, which you see in the demo. This lets the players or potential investors know the overall humor, art style, and gameplay mechanics I'm going for.

2. My rendering effect is a shader that combines elements from several character faces with a post-processing effect. It uses a decal edge mask and a sine time node to create a fade-in and fade-out effect while overlaying several textures. This effect is connected to the gameplay logic and triggers when the player makes a bad choice. If you trigger an NPC's crash-out state through specific dialogue choices marked with the crash-out tag, the screen visually represents Zoe's panic. The C# file "RenderSwitcher" is a public class "MonoBehaviour" that switches between two render pipelines. The default renderer is set in the graphics and quality settings, which has no effect. When the crash-out status is detected, the graphics and quality settings switch to the crash-out renderer, which causes the faces to appear. Dividing and adding a decal edge mask that is multiplied with images and added to sine time creates a panic effect.

3. I break large projects down into subsystems by thinking about the logical order of the gameplay and how different systems connect to one another. Since I come from a visual background, I like illustrating systems and then drawing out how they interact. My current process works best when I first identify what I already know how to do and then create a list of all the new things I need to learn. I combine this into a visual bubble diagram and a list of major epics that need to be completed, which I then break down into more actionable tasks because I have ADHD. I want to continue using task breakdowns in my planning process because I struggle with learning new programming concepts. As someone who is still new to programming, I can become overwhelmed and intimidated, so breaking tasks down helps me prepare much more effectively. It also helps me identify exactly what I do not understand yet, allowing me to better estimate how long it will take to learn new skills. For my vertical slice, I knew I did not understand how visual graphs worked, along with many of the systems I needed to learn, such as branching dialogue and NPC behavior. I also wanted to avoid directly copying Professor Reid's scripts. This planning process gave me enough time to prepare, set aside time for learning, and ask for help when needed. I received a lot of support from the teaching team and took on many new challenges. Through this project, I learned more about 3D modeling, branching dialogue systems, and how dependent game development can be on collaboration with others. I needed a lot of help to get through this project, and I learned the importance of recognizing when I need assistance rather than trying to solve everything on my own. I also learned how important it is to break down tasks into manageable pieces so I do not become overwhelmed after spending hours working on a problem. Overall, I learned a lot about solo development, and in the future I want to continue planning projects in this way.




## Open-source assets
- [classroom building](https://sketchfab.com/3d-models/classroom-d4553cc2008242849214e4cbf8ad8551)- 3D asset for classroom scene
- [Bedroom asset](https://sketchfab.com/3d-models/low-poly-isometric-room-56cf7d5811304608b5e6d724195c6ccd) - intro scene room
- [All character animations](https://www.mixamo.com/#/) - Mixamo animations

