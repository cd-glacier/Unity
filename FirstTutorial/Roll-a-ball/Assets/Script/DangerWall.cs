using UnityEngine;
using System.Collections;


public class DangerWall : MonoBehaviour {

	public GameObject gameOverLabelObject;

	void OnCollisionEnter(Collision hit){
		if(hit.gameObject.CompareTag("Player")){
			gameOverLabelObject.SetActive(true);
		}
	}

}
