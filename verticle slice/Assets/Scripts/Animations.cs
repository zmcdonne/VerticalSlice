 using UnityEngine;

 public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] GameObject privateAnimationClip ; 
    private Animator animator; void 
    Start() 
    { animator = GetComponent<Animator>(); 
    } 
    }


// {
//     private Animator animator;

//     void Start()
//     {
//         // Get the Animator component from the character
//         animator = GetComponent<Animator>();
//     }

//     void Update()
//     {

//         if 
//         {
//             animator.SetTrigger("FlatteredTrigger");
//         }
//         if 
//          {
//animator.SetTrigger("ScaredTrigger");
//}
//     }
// }
