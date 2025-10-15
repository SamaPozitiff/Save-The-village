using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameButton : ButtonEvent
{
    public Canvas MenuCanvas;
    public GameController gameController;
    public override void ButtonOnClick()
    {   
        gameController.Restart();
        gameManager.GameCanvas.gameObject.SetActive(true);
        Time.timeScale = 1;
        gameManager.Start();
        MenuCanvas.gameObject.SetActive(false);
    }
}
