using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HarvestImageTimer : ImageTimer
{
    protected override void OnEvent()
    {
        gameManager.WheatCount += gameManager.PeasantCount;
        soundManager.PlayHarvestSound();
    }
    
}
