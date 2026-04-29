using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace W4Activity
{
    public class DialogueButtonW4 : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _button;

        public void SetupButton (PlayerReply reply)
        {
            _text.text = reply.line;
            
            _button.onClick.AddListener(delegate
            {
                DialogueAdvancer._Instance.ChooseDialogue(reply.nextNode);
            });
        }
    }
}