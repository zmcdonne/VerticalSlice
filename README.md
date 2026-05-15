# GDIM33 Vertical Slice
## Milestone 1 Devlog
1.   For my "dialogue", visual scripting graph where, after entering, player movement is turned off during this phase. The canvas is enabled, triggering automatic dialogue and buttons used to advance to the next scene. Additionally, the cursor lock status is no longer set to locked. This is a state in my visual script state machine.
   
2.  For my updated breakdown, I added my state machine overview and animator controller, along with how these intertwine with each other and the rest of the systems. My state machine works as planned, separating the controls for exploration mode and dialogue.
<img width="1704" height="1010" alt="Updated graph" src="https://github.com/user-attachments/assets/08c807b2-b58b-4ea8-af5d-28218b8dd7d8" />

3.    In exploration mode, the player can move the camera and character and interact with objects, with the mouse locked. In dialogue (socialization mode), the HUD, dialogue, and buttons are active, along with the likability meter, current objective, and scene switcher for one-on-one socialization. The state machine primarily changes which player controllers are active and turns the UI on and off. It is also related to other systems, such as dialogue, which is only playable and interactable during the socializing stage, triggered by clicking on an NPC.


## Milestone 2 Devlog

ANSWER THIS BEFORE CODING: Follow the same steps from the W5 Activity to write a 
### quick summary of my complicating gameplay feature

### task breakdown
1.
2.

Under each big step, write 2-6 more detailed steps towards completing that task. 


### AFTER CODING Did the task steps break-down activity & quiz question (from W5) help you build a feature for this Milestone? Why or why not, and what would you do to improve your break-downs to be more helpful if you were to do them again?
Explain how you bridged visual scripting and code in your game. I am bridign vis  in my code calling froma custum event, and method that checks the emotional state which is the enum attached to the scriptable object ,Are you calling a custom event from a Graph from a C# method, or vice versa, and what purpose does this serve in your architecture? Make sure to name the C# script(s) involved, and attach a screenshot of the relevant Graph.
## Unity system 
I want to me graded for my scriptable object unty system, you can find it being used in dialouge triggering the animator of my blound NPC. 

## Milestone 3 Devlog
Milestone 3 Devlog goes here.
## Milestone 4 Devlog
Milestone 4 Devlog goes here.
## Final Devlog
Final Devlog goes here.
## Open-source assets
- Cite any external assets used here!
