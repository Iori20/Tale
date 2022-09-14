using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string cena;
    public GameObject CreditPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void StartGame()
    {
    SceneManager.LoadScene(cena);
    }


    public void QuitGame()
    {
        //Editor Unity
        UnityEditor.EditorApplication.isPlaying = false;
        //Jogo Compilado
        //Application.Quit();
    }

    public void Showcredit()
    {
CreditPanel.SetActive(true);
    }

    public void BackToMenu()
    {
    CreditPanel.SetActive(false);
    }
}
