using UnityEngine;
using System.Collections;

// Classe que contém a função OnClick(), que é chamada ao clicarmos no botão
public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // A função OnClick() troca de cena
    // Lembrem que adicionamos as cenas que nosso jogo conterá em File->Build Settings
	public void OnClick(){
		Application.LoadLevel("wormScene");
	}
}
