using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

   public enum SocialWeirdness
     {
         Crashout,//0
         Eyecontact,//1
         HairTouching,
         Frown,
         Nuteral 
    
     }



[CreateAssetMenu(fileName = "DialogueLine", menuName = "ScriptableObjects/DialogueLine", order = 1)]
public class DialogueNode : ScriptableObject
{
    private int counter = 0 ;

    //---------------------------------------------------------------------
    // Variables
    //---------------------------------------------------------------------
    [Tooltip("The line of dialogue the NPC says in this node.")]
    public string Line;

    [Tooltip("[Optional] The dialogue options for the player's response, and what node each response leads to.")]
    public List<PlayerReply> ReplyOptions;
    public SocialWeirdness EmotinalState; 


}


