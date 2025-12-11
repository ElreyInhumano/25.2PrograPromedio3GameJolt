using UnityEngine;
using UnityEngine.UI;
using GameJolt.UI;
public class TrophiesButton : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            GameJoltUI.Instance.ShowTrophies();
        });
    }
}
