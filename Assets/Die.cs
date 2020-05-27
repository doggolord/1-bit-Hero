using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour {
	// Update is called once per frame
	void Start() {
		StartCoroutine(Timer());
	}

    IEnumerator Timer()
    {
        yield return new WaitForSecondsRealtime(3);
		GameObject.Destroy(gameObject);
    }
}