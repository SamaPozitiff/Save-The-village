using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButtonEvent : MonoBehaviour
{
    private bool SoundOn = true;

    public void ToggleSound()
    {
        SoundOn = !SoundOn;
        AudioListener.volume = SoundOn ? 1 : 0;
    }

}
