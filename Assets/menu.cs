using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    int recebe;
	void Start () {
		
	}
	
	
	void Update () {
        recebe = metod_jogo.numerocena;

    }
    public void sair()
    {
        Application.Quit();
    }
    public void iniciar()
    {
        SceneManager.LoadSceneAsync(metod_jogo.numerocena, LoadSceneMode.Single);
        metod_jogo.numerocena++;
        metod_jogo.numerocena++;
    }
}
