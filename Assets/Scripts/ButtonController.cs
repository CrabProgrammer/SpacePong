using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{

    public void Exit()
    {
        SceneManager.LoadScene(0); //Main menu scene
    }
    public void Replay() //play current scene one more time
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
