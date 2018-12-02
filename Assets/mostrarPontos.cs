using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mostrarPontos : MonoBehaviour {

    public Text tex;
    public int rece;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rece = metod_jogo.pontos;
        tex= GameObject.Find("ext").GetComponent<Text>();
        tex.text = "Pontos : "+metod_jogo.pontos;
    }

    public void voltarMenu()
    {
        SceneManager.LoadSceneAsync(metod_jogo.numerocena, LoadSceneMode.Single);
        metod_jogo.numerocena = 0;
    }

}
