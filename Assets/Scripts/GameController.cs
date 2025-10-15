using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameManager gameManager;
    public List<ImageTimer> imageTimerList = new List<ImageTimer>();
    public HirePeasantEvent hirePeasantEvent;
    public HireWarriorEvent hireWarriorEvent;
    
    public void Restart()
    {
        gameManager.Start();
        foreach (ImageTimer imageTimer in imageTimerList)
        {
            imageTimer.Start();
        }
        hireWarriorEvent.Restart();
        hirePeasantEvent.Restart();
    }
    
}
