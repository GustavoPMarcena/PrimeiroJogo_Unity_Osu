using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string NameScene;
    public void Play()
    {
        SceneManager.LoadScene(NameScene);
    }

    public void Exit()
    {
        Debug.Log("Saindo do jogo");
        Application.Quit();
    }
}
