using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class metod_jogo : MonoBehaviour {

    public static  int pontos;
    public  Text tex;
    public string pot;
    public GameObject dicarr;
    public GameObject voltar;
    public static int numerocena;

	void Start () {
		
        
	}
	
	// Update is called once per frame
	void Update () {
        tex = GameObject.Find("TextoPontos").GetComponent<Text>(); ;
        tex.text =  "Pontos :" + pontos;
		
        if (pontos < 0)
        {
            pontos = 0;
        }


	}
    public void ganharPontos()
    {
        pontos++;
        SceneManager.LoadSceneAsync(numerocena, LoadSceneMode.Single);
        numerocena++;
    }
    public void perderPontos()
    {
        pontos--;
        SceneManager.LoadSceneAsync(numerocena, LoadSceneMode.Single);
        numerocena++;
    }
    public void voltarr()
    {
        dicarr.SetActive(false);
        voltar.SetActive(true);
        
       
    }
    public void dica()
    {
        dicarr.SetActive(true);
        voltar.SetActive(false);
    }
  
}
