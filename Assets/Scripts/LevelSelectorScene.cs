using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
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
    

    
}
