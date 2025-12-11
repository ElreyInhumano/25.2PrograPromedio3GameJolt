using UnityEngine;
using UnityEngine.UI;
using GameJolt.UI;
public class RankingsButton : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameJoltUI.Instance.ShowLeaderboards();
        });
    }
}
