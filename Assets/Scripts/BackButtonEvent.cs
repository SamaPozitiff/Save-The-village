using UnityEngine;

public class BackButtonEvent : MonoBehaviour
{
    public Canvas MenuCanvas;
    public Canvas RulesCanvas;
    public void OnClickEvent()
    {
        MenuCanvas.gameObject.SetActive(true);
        RulesCanvas.gameObject.SetActive(false);
    }
}
