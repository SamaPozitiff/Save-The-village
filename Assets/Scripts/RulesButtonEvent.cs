using UnityEngine;

public class RulesButtonEvent : MonoBehaviour
{   
    public Canvas MenuCanvas;
    public Canvas RulesCanvas;
    public void OnClickEvent()
    {
        MenuCanvas.gameObject.SetActive(false);
        RulesCanvas.gameObject.SetActive(true);
    }
}
