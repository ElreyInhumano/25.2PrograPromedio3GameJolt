using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Level1Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text fallsTMP, timerTMP;
    [SerializeField] private float timer;
    void Start()
    {
        ChangeTMPs();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        ChangeTMPs();
        WinLevel1();
    }
    void ChangeTMPs()
    {
        timerTMP.text = $"Time To Survive: {timer}";
        fallsTMP.text = $"Falls: {PlayerDead.falls}";
    }
    void WinLevel1()
    {
        if(timer <= 0)
        {
            TrophiesUnlocked.totalFalls = PlayerDead.falls;
            PlayerDead.falls = 0;
            LevelSelectorScene.levelsUnlocked[1] = true;
            SceneManager.LoadScene("LevelSelectorScene");
        }
    }
}
