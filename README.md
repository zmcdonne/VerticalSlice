# GDIM33 Vertical Slice
## Milestone 1 Devlog
1.   For my "dialogue", visual scripting graph where, after entering, player movement is turned off during this phase. The canvas is enabled, triggering automatic dialogue and buttons used to advance to the next scene. Additionally, the cursor lock status is no longer set to locked. This is a state in my visual script state machine.
   
2.  For my updated breakdown, I added my state machine overview and animator controller, along with how these intertwine with each other and the rest of the systems. My state machine works as planned, separating the controls for exploration mode and dialogue.
<img width="1704" height="1010" alt="Updated graph" src="https://github.com/user-attachments/assets/08c807b2-b58b-4ea8-af5d-28218b8dd7d8" />

3.    In exploration mode, the player can move the camera and character and interact with objects, with the mouse locked. In dialogue (socialization mode), the HUD, dialogue, and buttons are active, along with the likability meter, current objective, and scene switcher for one-on-one socialization. The state machine primarily changes which player controllers are active and turns the UI on and off. It is also related to other systems, such as dialogue, which is only playable and interactable during the socializing stage, triggered by clicking on an NPC.


## Milestone 2 Devlog
 
### quick summary of my complicating gameplay feature
So for the complicating factor, the NPC will have animations that play in response to dialogue, hinting at certain personality traits, as well as a visual likability score using a traffic light system to signify the overall level of success currently. I believe this adds a level of complexity that will make this project challenging enough for this class. Certain choices will require the player to react to dialogue. The end product is a dialogue system where the character reacts to the player clicking on certain responses, which will affect both the animator and the UI.

#### Task breakdown
1.
2.

Under each big step, write 2-6 more detailed steps towards completing that task. 


#### AFTER CODING

#### Unity system 
I want to me graded for my scriptable object unty system, you can find it being used in dialouge triggering the animator of my blound NPC. 

## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
