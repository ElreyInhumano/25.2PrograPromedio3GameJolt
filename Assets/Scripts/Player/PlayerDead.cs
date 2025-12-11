using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    string sceneToLoad;
    public static int falls;
    private void Start()
    {
        sceneToLoad = SceneManager.GetActiveScene().name;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            falls++;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
