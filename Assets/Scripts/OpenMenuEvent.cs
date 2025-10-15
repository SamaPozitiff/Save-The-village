using UnityEngine;

public class OpenMenuEvent : MonoBehaviour
{
    public Canvas MenuCanvas;
    public Canvas GameCanvas;
    public void OpenMenu()
    {
        Time.timeScale = 0;
        MenuCanvas.gameObject.SetActive(true);
        GameCanvas.gameObject.SetActive(false);
        
    }


public void CloseMenu()
    {   
        Time.timeScale = 1;
        GameCanvas.gameObject.SetActive(true);
        MenuCanvas.gameObject.SetActive(false);
    }
}
