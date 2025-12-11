using UnityEngine;
using GameJolt.UI;
public class MainScene : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn();
    }

}
