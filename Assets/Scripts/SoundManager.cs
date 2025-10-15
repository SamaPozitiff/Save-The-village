using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> hirePeasantsSounds = new List<AudioClip>();
    public List<AudioClip> hireWarriorsSounds = new List<AudioClip>();
    public List<AudioClip> battleSounds = new List<AudioClip>();
    public List<AudioClip> eatSounds = new List<AudioClip>();
    public List<AudioClip> harvestSounds = new List<AudioClip>();
    public AudioSource hirePeasantsAudio;
    public AudioSource hireWarriorsAudio;
    public AudioSource battleAudio;
    public AudioSource eatAudio;
    public AudioSource harvestAudio;


    public void PlayHirePeasantSound()
    {
        int index = Random.Range(0, hirePeasantsSounds.Count);
        hirePeasantsAudio.clip = hirePeasantsSounds[index];
        hirePeasantsAudio.Play();
    }
    
    public void PlayHireWarriorSound()
    {
        int index = Random.Range(0, hireWarriorsSounds.Count);
        hireWarriorsAudio.clip = hireWarriorsSounds[index];
        hireWarriorsAudio.Play();
    }

    public void PlayBattleSound()
    {
        int index = Random.Range(0, battleSounds.Count);
        battleAudio.clip = battleSounds[index];
        battleAudio.Play();
    }

    public void PlayEatSound()
    {
        int index = Random.Range(0, eatSounds.Count);
        eatAudio.clip = eatSounds[index];
        eatAudio.Play();
    }

    public void PlayHarvestSound()
    {
        int index = Random.Range(0, harvestSounds.Count);
        harvestAudio.clip = harvestSounds[index];
        harvestAudio.Play();
    }
}