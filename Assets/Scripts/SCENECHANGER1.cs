using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENECHANGER1 : MonoBehaviour
{
   
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

   
    public void ChangeSceneTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }
}
