using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SaveZone : MonoBehaviour
{
    [SerializeField] private TMP_Text fallsTMP;
    [SerializeField] private bool level2, level3;
    private void Update()
    {
        ChangeTMPs();
    }
    void ChangeTMPs()
    {
        fallsTMP.text = $"Falls: {PlayerDead.falls}";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(level2) WinLevel2();

            if (level3) WinLevel3();
        }
    }
    void WinLevel2()
    {
        TrophiesUnlocked.totalFalls += PlayerDead.falls;
        PlayerDead.falls = 0;
        LevelSelectorScene.levelsUnlocked[2] = true;
        SceneManager.LoadScene("LevelSelectorScene");
    }
    void WinLevel3()
    {
        TrophiesUnlocked.totalFalls += PlayerDead.falls;
        PlayerDead.falls = 0;
        TrophiesUnlocked.victory = true;
        if(TrophiesUnlocked.totalFalls <= 0)
        {
            TrophiesUnlocked.perfectVictory = true;
        }
        SceneManager.LoadScene("LevelSelectorScene");
    }
}
