 using UnityEngine;
 public class BehaviourScript : MonoBehaviour
{
    Animator animator;

void Start()
    {
        animator = GetComponent<Animator>();
    }
}

 

 

//     [SerializeField] private SocialWeirdness m_Gesture;
    
//  protected new void AnimationState()
// {
//     switch (_state)
//     {
//         case NPCsState.Idle:

//             if (_hasAnimator)
//             {
//                 _animator.SetBool("IsRunning", false);
//                 _animator.SetBool("IsStruggling", false);
//             }

//             RunIdleState();
//             break;

//         case NPCsState.Wandering:

//             if (_hasAnimator)
//             {
//                 _animator.SetBool("IsRunning", true);
//                 _animator.SetBool("IsStruggling", false);
//             }

//             RunWanderState();
//             break;

//         case NPCsState.Pursued:

//             if (_hasAnimator)
//             {
//                 _animator.SetBool("IsRunning", true);
//                 _animator.SetBool("IsStruggling", false);
//             }

//             RunPursueState();
//             break;

//         case NPCsState.PickedUp:

//             if (_hasAnimator)
//             {
//                 _animator.SetBool("IsRunning", false);
//                 _animator.SetBool("IsStruggling", true);
//             }

//             _escapeTime -= Time.deltaTime;
//             if (_escapeTime <= 0)
//             {
//                 Escape();
//             }

//             break;

//         default:
//             Debug.LogError("unhandled state " + _state);
//             break;
//     }
// }

//     public void RunState()
//     {
//         switch (_state)
//         {
//             case NPCsState.Wandering:
//                 RunWanderState();
//                 break;

//             case NPCsState.Pursued:
//                 RunPursueState();
//                 break;

//             case NPCsState.PickedUp:
//                 if (_hasAnimator)
//                 {
//                     _animator.SetBool("_IsCaught", true);
//                 }
//                 //implement fighting later
//                 break;
//             default:
//                 Debug.LogError("unhandled state " + _state);
//                 break;
//         }
//     }
// }
