using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldItem : MonoBehaviour {

	public int SelectedWeapon = 0;
	public bool Weapon1 = false;
	public bool Weapon2 = false;
	public bool Weapon3 = false;
	public bool Weapon4 = false;
	public bool Weapon5 = false;
	public bool Weapon6 = false;
	public bool Weapon7 = false;
	public bool Weapon8 = false;
	// Use this for initialization
	void Start () {
		SelectWeapon();
	}
	
	// Update is called once per frame
	void Update () {

		int previousSelectedWeapon = SelectedWeapon;

		if (Input.GetKeyDown(KeyCode.Alpha1)){
			SelectedWeapon = 0;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2 && Weapon1 == true){
			SelectedWeapon = 1;
		}

		if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3 && Weapon2 == true){
			SelectedWeapon = 2;
		}

		if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4 && Weapon3 == true){
			SelectedWeapon = 3;
		}

		if (Input.GetKeyDown(KeyCode.Alpha5) && transform.childCount >= 5 && Weapon4 == true){
			SelectedWeapon = 4;
		}

		if (Input.GetKeyDown(KeyCode.Alpha6) && transform.childCount >= 6 && Weapon5 == true){
			SelectedWeapon = 5;
		}
		if (Input.GetKeyDown(KeyCode.Alpha7) && transform.childCount >= 7 && Weapon6 == true){
			SelectedWeapon = 6;
		}
		if (Input.GetKeyDown(KeyCode.Alpha8) && transform.childCount >= 8 && Weapon7 == true){
			SelectedWeapon = 7;
		}
		if (Input.GetKeyDown(KeyCode.Alpha9) && transform.childCount >= 9 && Weapon8 == true){
			SelectedWeapon = 8;
		}
 
		if (previousSelectedWeapon != SelectedWeapon){
			SelectWeapon();
		}
		
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
		
        if (rotZ > 90 || rotZ < -90)
        {
			transform.localScale = new Vector3(1f, -1f, 1f);
        } else {
        	transform.localScale = new Vector3(1f, 1f, 1f);
        }	
	}

	void SelectWeapon(){
		int i = 0;
		foreach (Transform weapon in transform){
			if (i == SelectedWeapon)
				weapon.gameObject.SetActive(true);
			else
				weapon.gameObject.SetActive(false);
				i++;
		}
	}
}