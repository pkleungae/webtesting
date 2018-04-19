using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadScene : MonoBehaviour {

	

    public void LoadScenetofirstScene()
    {
        SceneManager.LoadScene("firstScene");
    }

    public void LoadScenetohelpScene()
    {
        SceneManager.LoadScene("helpScene");
    }

    public void LoadScenetosearchScene()
    {
        SceneManager.LoadScene("searchScene");
    }

    public void LoadScenetoresultScene()
    {
        SceneManager.LoadScene("resultScene");
    }

    public void LoadScenetosearchbyvoiceScene()
    {
        SceneManager.LoadScene("searchbyvoiceScene");
    }

    public void LoadScenetoresultSceneBackup()
    {
        SceneManager.LoadScene("resultSceneBackup");
    }
}
