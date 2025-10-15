using Unity.VisualScripting;

public class RaidImageTimer : ImageTimer
{   
    protected override void OnEvent()
    {
        gameManager.WarriorsCount -= gameManager.EnemyCount;
        gameManager.EnemyCount += gameManager.RaidAmount;
        gameManager.RaidAmount *= gameManager.RaidAmount;
        soundManager.PlayBattleSound();
    }
}
