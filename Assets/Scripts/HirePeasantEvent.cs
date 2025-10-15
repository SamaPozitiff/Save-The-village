using UnityEngine;
using UnityEngine.UI;

public class HirePeasantEvent : ButtonEvent
{
    private float currentTime;
    public Image timerImage;
    public GameObject buttonText;
    public bool hiring;
    
    
    public void Restart()
    {
        hiring = false;
        currentTime = gameManager.HirePeasantDuration;
        buttonText.SetActive(true);
        timerImage.gameObject.SetActive(false);
        Update();
    }
    
    public void Update()
    {   button.interactable = gameManager.WheatCount >= gameManager.PeasantPrice && !hiring;
        if (!hiring) return;
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {   
            PeasantHired();
            currentTime = gameManager.HirePeasantDuration;
            hiring = false;
            buttonText.SetActive(true);
            timerImage.gameObject.SetActive(false);
        }

        timerImage.fillAmount = currentTime / gameManager.HirePeasantDuration;

    }
    
    private void PeasantHired()
    {
        gameManager.PeasantCount++;
        gameManager.UpdateText();
        
    }

    public override void ButtonOnClick()
    {   
        buttonText.SetActive(false);
        timerImage.gameObject.SetActive(true);
        hiring = true;
        gameManager.WheatCount -= gameManager.PeasantPrice;
        currentTime = gameManager.HirePeasantDuration;
        Update();
    }
}
