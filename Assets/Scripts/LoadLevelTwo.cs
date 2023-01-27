using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelTwo : MonoBehaviour
{
    public void StartLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
