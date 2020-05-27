using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffects : MonoBehaviour {

	public ParticleSystem ParticleDeath;

	public GameObject Enemy;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Enemy != null){
		
			Instantiate (ParticleDeath, Enemy.transform.position, Enemy.transform.rotation);
		} else {
			return;
		}
	}
}
