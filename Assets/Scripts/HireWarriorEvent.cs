using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HireWarriorEvent : ButtonEvent
{   
    private float currentTime;
    public Image timerImage;
    public GameObject buttonText;
    public bool hiring;

    public void Restart()
    {
        hiring = false;
        currentTime = gameManager.HireWarriorDuration;
        buttonText.SetActive(true);
        timerImage.gameObject.SetActive(false);
        Update();
    }
    
    
    
    public void Update()
    {   button.interactable = gameManager.WheatCount >= gameManager.WarriorPrice && !hiring;
        if (!hiring) return;
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {   
            WarriorHired();
            currentTime = gameManager.HireWarriorDuration;
            hiring = false;
            ChangeButton();
        }

        timerImage.fillAmount = currentTime / gameManager.HireWarriorDuration;

    }
    
    private void WarriorHired()
    {
        gameManager.WarriorsCount++;
        gameManager.UpdateText();
        
    }

    public override void ButtonOnClick()
    {   
        ChangeButton();
        hiring = true;
        gameManager.WheatCount -= gameManager.WarriorPrice;
        currentTime = gameManager.HireWarriorDuration;
        Update();
    }


    private void ChangeButton()
    {
        buttonText.SetActive(!buttonText.activeSelf);
        timerImage.gameObject.SetActive(!timerImage.gameObject.activeSelf);
    }
}
