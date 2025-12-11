using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using GameJolt.API;
public class LevelSelectorScene : MonoBehaviour
{
    [SerializeField] Button[] levelsButtons;
    [SerializeField] public static bool[] levelsUnlocked;
    void Start()
    {
        levelsButtons = GetComponentsInChildren<Button>();
        Array.Resize<bool>(ref levelsUnlocked, levelsButtons.Length);
        levelsUnlocked[0] = true;
        UnlockLevels();
        SetRanking();
    }
    void UnlockLevels()
    {
        for(int i = 0; i < levelsButtons.Length; i++)
        {
            if (levelsUnlocked[i])
            {
                levelsButtons[i].enabled = true;
            }
            else
            {
                levelsButtons[i].enabled = false;
            }
        }
    }

    public void GoLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    
    void SetRanking()
    {
        int count = PlayerPrefs.GetInt("logged", 0);
        count++;
        PlayerPrefs.SetInt("logged", count);
        Scores.Add(count, $"Logued {count} times", 1048436);
    }
    
}
