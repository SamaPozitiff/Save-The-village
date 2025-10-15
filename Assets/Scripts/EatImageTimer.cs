
public class EatImageTimer : ImageTimer
{
    protected override void OnEvent()
    {   
        gameManager.WheatCount -= gameManager.WarriorsCount*4;
        gameManager.DayCount++;
        gameManager.DaysToRaid = gameManager.DayCount%gameManager.DaysBetweenRaids;
        soundManager.PlayEatSound();
    }
}
