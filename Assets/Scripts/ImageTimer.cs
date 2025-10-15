using UnityEngine;
using UnityEngine.UI;


public abstract class ImageTimer : MonoBehaviour
{   
    public float maxTime;
    private float currentTime;
    private Image img;
    public GameManager gameManager;
    public SoundManager soundManager;

    
    public void Start()
    {
        img = GetComponent<Image>();
        currentTime = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {   
            OnEvent();
            currentTime = maxTime;
        }

        img.fillAmount = currentTime / maxTime;
    }


    protected virtual void OnEvent()
    {
        
    }
}