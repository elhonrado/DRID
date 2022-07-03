using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    bool end = false;
    public float delay=3f;

    public GameObject UI;

    public void leveldone()
    {
        UI.SetActive(true);
    }

    public void EndGame ()
    {
        if(end == false)
        {
            end= true;
            Debug.Log("Game Over");
            Invoke("restart",delay);
        }
    }
    
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
