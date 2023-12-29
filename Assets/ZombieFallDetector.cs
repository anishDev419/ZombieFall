using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZombieFallDetector : MonoBehaviour {

	public GameMananger gameManager;

	void OnEnable () {

	}

	void OnDisable () {
			
	}

	void OnTriggerEnter(Collider other){
		GameObject fallenZombie = other.gameObject;
		gameManager.HandleFallenZombie (fallenZombie);
	}

}
