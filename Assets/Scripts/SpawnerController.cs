using UnityEngine;
using System.Collections;

// Responsavel por criar o barris que caem no inicio do jogo
public class SpawnerController : MonoBehaviour {

	public GameObject oilDrumPrefab; // ref para o GameObject ( pre-fabricado ) que da origem ao 5 barris(clones) que criamos

	// Use this for initialization
	void Start () {
		// Criando os 5 barris e sorteando uma posiçao aleatoria em x
		for( int i = 0; i < 5; i++ ){
			float posX = Random.Range(-10f, 10f);
			GameObject oilDrum = Instantiate(oilDrumPrefab);
			oilDrum.transform.position = new Vector3( posX, transform.position.y, 0f );
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
