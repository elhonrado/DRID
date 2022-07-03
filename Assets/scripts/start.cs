using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}