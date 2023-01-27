using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelThree : MonoBehaviour
{
    public void StartLevelThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
