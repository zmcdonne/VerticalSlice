
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

My ShaderGraph works. You must cite something technical about the shader (like ShaderGraph Nodes used, or concepts learned in class about vertex data or the rendering pipeline) and accurately explain the shader. Attach a screenshot of your ShaderGraph. Please make sure it's also very clear from your explanation where the graders can find this shader in the game to give you credit for it.
2. In a paragraph or less, explain to the grading team what you improved in your gameplay based on feedback from playtesting.
3. In a paragraph or less, explain to the grading team what new content you added since the last Milestone, and its context in the gameplay loop

## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
