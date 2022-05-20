using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene("Level_1");
    }

    public void OpenOptions(){
        optionsScreen.SetActive(true);
    }

    public void CloseOptions(){
        optionsScreen.SetActive(false);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("quited");
    }
}
