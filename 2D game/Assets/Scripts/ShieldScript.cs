using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour {

	public GameObject Shield;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton(1)) //right click on mouse
        {
            Shield.SetActive(true);
			Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
			float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(0f, 0f, rotZ);;
        } else {
			Shield.SetActive(false);
		}
	}
}