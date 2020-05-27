using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIguns : MonoBehaviour {

	public HoldItem Script;
	public Image pistol, UZI, minigun, assultrifle, SMG, Shotgun, sniper, g_gun, BSG;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Script.SelectedWeapon == 0){
			pistol.gameObject.SetActive(true);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}
		if (Script.SelectedWeapon == 1){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(true);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}
		if (Script.SelectedWeapon == 2){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(true);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}
		if (Script.SelectedWeapon == 3){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(true);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}
		if (Script.SelectedWeapon == 4){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(true);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}	
		if (Script.SelectedWeapon == 5){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(true);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}	
		if (Script.SelectedWeapon == 6){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(true);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(false);
		}	
		if (Script.SelectedWeapon == 7){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(true);
			BSG.gameObject.SetActive(false);
		}	
		if (Script.SelectedWeapon == 8){
			pistol.gameObject.SetActive(false);
			UZI.gameObject.SetActive(false);
			minigun.gameObject.SetActive(false);
			assultrifle.gameObject.SetActive(false);
			SMG.gameObject.SetActive(false);
			Shotgun.gameObject.SetActive(false);
			sniper.gameObject.SetActive(false);
			g_gun.gameObject.SetActive(false);
			BSG.gameObject.SetActive(true);
		}	
	}
}
