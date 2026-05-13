using UnityEngine;
using TMPro;

public class SocialScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _finalScoreText;
       public void Activate(int finalScore)
    {
        gameObject.SetActive(true);


        _finalScoreText.text = "FINAL SCORE: " + finalScore;
    }


}
