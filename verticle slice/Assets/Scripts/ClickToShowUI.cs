using UnityEngine;

public class ClickToShowUI : MonoBehaviour
{
    public GameObject uiImage;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    Debug.Log("Clicked object!");
                    uiImage.SetActive(true);
                }
            }
        }
    }
}