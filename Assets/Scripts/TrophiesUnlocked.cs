using UnityEngine;
using GameJolt.API;
public class TrophiesUnlocked : MonoBehaviour
{
    public static bool falls, victory, perfectVictory;
    void Update()
    {
        if (LevelSelectorScene.levelsUnlocked[1])
        {
            Trophies.TryUnlock(285496);
        }
        if (LevelSelectorScene.levelsUnlocked[2])
        {
            Trophies.TryUnlock(285499);
        }
        if (falls)
        {
            Trophies.TryUnlock(285497);
        }
        if (victory)
        {
            Trophies.TryUnlock(285498);
        }
        if (perfectVictory)
        {
            Trophies.TryUnlock(285500);
        }
    }
}
