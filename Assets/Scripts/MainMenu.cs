using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Training()
    {
        SceneManager.LoadScene(1); //training scene
    }
    
    public void PlaySolo()
    {
        SceneManager.LoadScene(2); //solo play scene
    }
    public void Multiplayer()
    {
        SceneManager.LoadScene(3); //solo play scene
    }
}
