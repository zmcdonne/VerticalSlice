using UnityEngine;

public class BehaviourScript : MonoBehaviour
{
    [System.Serializable]
    public enum SocialWeirdness
    {
        Crashout,
        Eyecontact,
        HairTouching,
        Frown
    
    }

    [SerializeField] private SocialWeirdness m_Gesture;
    
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
