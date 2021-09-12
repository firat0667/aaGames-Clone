using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    private bool gameHashEnded = false;
    public RotatorScript rotator;
    public PinSpawner spawner;
    public Animator anim;
   public void EndGame()
    {

        if (gameHashEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        anim.SetTrigger("EndGame");
        gameHashEnded = true;
            Debug.Log("END-GAME");

    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
