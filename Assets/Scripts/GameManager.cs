using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour
{  
    public Text PeasantCountText;
    public Text WarriorsCountText;
    public Text WheatCountText;
    public Text DayCountText;
    public Text WarriorPriceText;
    public Text PeasantPriceText;
    public Text EnemyCountText;
    public Text DaysToRaidText;
    public Text LoseDayText;
    [HideInInspector] public int PeasantCount;
    [HideInInspector] public int WarriorsCount;
    [HideInInspector] public int WheatCount;
    [HideInInspector] public int EnemyCount;
    [HideInInspector] public int RaidAmount;
    [HideInInspector] public int DayCount;
    [HideInInspector] public int DaysToRaid;
    public int HirePeasantDuration;
    public int HireWarriorDuration;
    public int WarriorPrice;
    public int PeasantPrice;
    public Canvas LoseMenuCanvas;
    public Canvas GameCanvas;
    public Canvas WinCanvas;
    public int PeasantStartCount;
    public int WarriorsStartCount;
    public int WheatStartCount;
    public int EnemyStartCount;
    public int RaidStartAmount;
    public int DayStartCount;
    public int DaysBetweenRaids;
    
    public void Start()
    {
        PeasantCount = PeasantStartCount;
        WarriorsCount = WarriorsStartCount;
        WheatCount = WheatStartCount;
        EnemyCount = EnemyStartCount;
        RaidAmount = RaidStartAmount;
        DayCount = DayStartCount;
        DaysToRaid = DaysBetweenRaids;
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {   
        CheckWinCondition();
        CheckLoseCondition();
        UpdateText();
    }

    public void UpdateText()
    {
        PeasantCountText.text = PeasantCount.ToString();
        WheatCountText.text = WheatCount.ToString();
        WarriorsCountText.text = WarriorsCount.ToString();
        DayCountText.text = DayCount.ToString();
        WarriorPriceText.text = WarriorPrice.ToString();
        PeasantPriceText.text = PeasantPrice.ToString();
        EnemyCountText.text = EnemyCount.ToString();
        DaysToRaidText.text = DaysToRaid.ToString();
    }


    private void CheckWinCondition()
    {
        if (DayCount > 10)
        {
            Time.timeScale = 0;
            GameCanvas.gameObject.SetActive(false);
            WinCanvas.gameObject.SetActive(true);
        }
    }
    private void CheckLoseCondition()
    {
        if (WarriorsCount < 0 || WheatCount < 0)
        {
            Time.timeScale = 0;
            GameCanvas.gameObject.SetActive(false);
            LoseDayText.text = DayCount.ToString();
            LoseMenuCanvas.gameObject.SetActive(true);
            
        }
    }


    
    
    
}
