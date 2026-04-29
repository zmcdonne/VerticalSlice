using UnityEngine;
using Unity.VisualScripting;

namespace W4Activity
{
    
    public class DialogueAdvancer : MonoBehaviour
    {
        [SerializeField] 
        private DialogueNode DialogueNode ;
        // Singleton stuff- allows this class to be accessed from anywhere in the codebase without a reference (like a member variable)
        // do not edit this line
        public static DialogueAdvancer _Instance {get; private set;}

        // More Singleton stuff
        // do not edit this method
        private void Awake() {
            if (_Instance != null && _Instance != this) {
                Destroy(this);
                return;
            }

            _Instance = this;
        }

void Start()
    {
       ChooseDialogue(DialogueNode);
    }
        // Button hooks up to this method
        // do not edit this method
        public void ChooseDialogue (DialogueNode nextLine)
        {
            EventBus.Trigger(EventNames.NewDialogueEvent, nextLine);
        }
    }
}