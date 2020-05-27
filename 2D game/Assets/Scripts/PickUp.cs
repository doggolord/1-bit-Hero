using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

	public HoldItem Script;

	public Weapon Ammo_UZI;
	public Weapon Ammo_Minigun;
	public Weapon Ammo_AR;
	public Weapon Ammo_SMG;
	public ShotgunWeapon Ammo_Shotgun;
	public Weapon Ammo_Sniper;
	public Weapon Ammo_Goldengun;
	public Weapon Ammo_BSG;

	public Text ItemPickUp;

	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject.tag == "P_Uzi")
		{
			ItemPickUp.text = "UZI was picked up";
			if(Script.Weapon1 == true)
			{
				if(GameObject.Find("UZI"))
				{
					if (Ammo_UZI.MaxAmmo <= 250)
					{
						Ammo_UZI.MaxAmmo = Ammo_UZI.MaxAmmo + 25;
						if (Ammo_UZI.MaxAmmo >= 250){
							Ammo_UZI.MaxAmmo = 250;
						}
					}
				}
			} else {
				Script.Weapon1 = true;
			}
		}

		if(col.gameObject.tag == "P_Minigun")
		{
			ItemPickUp.text = "Minigun was picked up";
			if(Script.Weapon2 == true)
			{
				if(GameObject.Find("Minigun"))
				{
					if (Ammo_Minigun.MaxAmmo <= 600)
					{
						Ammo_Minigun.MaxAmmo = Ammo_Minigun.MaxAmmo + 100;
						if (Ammo_Minigun.MaxAmmo >= 600){
							Ammo_Minigun.MaxAmmo = 600;
						}
					}
				}
			} else {
				Script.Weapon2 = true;
			}
		}

		if(col.gameObject.tag == "P_AR")
		{
			ItemPickUp.text = "Assultrifle was picked up";
			if(Script.Weapon3 == true)
			{
				if(GameObject.Find("Assaultrifle"))
				{
					if (Ammo_AR.MaxAmmo <= 300)
					{
						Ammo_AR.MaxAmmo = Ammo_AR.MaxAmmo + 30;
						if (Ammo_AR.MaxAmmo >= 300){
							Ammo_AR.MaxAmmo = 300;
						}
					}
				}
			} else {
				Script.Weapon3 = true;
			}
		}

		if(col.gameObject.tag == "P_SMG")
		{
			ItemPickUp.text = "SMG was picked up";
			if(Script.Weapon4 == true)
			{
				if(GameObject.Find("SMG"))
				{
					if (Ammo_SMG.MaxAmmo <= 240)
					{
						Ammo_SMG.MaxAmmo = Ammo_SMG.MaxAmmo + 30;
						if (Ammo_SMG.MaxAmmo >= 240){
							Ammo_SMG.MaxAmmo = 240;
						}
					}
				}
			} else {
				Script.Weapon4 = true;
			}
		}

		if(col.gameObject.tag == "P_Shotgun")
		{	
			ItemPickUp.text = "Shotgun was picked up";
			if(Script.Weapon5 == true)
			{
				if(GameObject.Find("Shotgun"))
				{
					if (Ammo_Shotgun.MaxAmmo <= 32)
					{
						Ammo_Shotgun.MaxAmmo = Ammo_Shotgun.MaxAmmo + 8;
						if (Ammo_Shotgun.MaxAmmo >= 32){
							Ammo_Shotgun.MaxAmmo = 32;
						}
					}
				}
			} else {
				Script.Weapon5 = true;
			}
		}

		if(col.gameObject.tag == "P_Sniper")
		{	
			ItemPickUp.text = "Sniper was picked up";
			if(Script.Weapon6 == true)
			{
				if(GameObject.Find("50.Cal"))
				{
					if (Ammo_Sniper.MaxAmmo <= 45)
					{
						Ammo_Sniper.MaxAmmo = Ammo_Sniper.MaxAmmo + 10;
						if (Ammo_Sniper.MaxAmmo >= 45){
							Ammo_Sniper.MaxAmmo = 45;
						}
					}
				}
			} else {
				Script.Weapon6 = true;
			}
		}

		if(col.gameObject.tag == "P_Goldengun")
		{	
			ItemPickUp.text = "Golden gun was picked up";
			if(Script.Weapon7 == true)
			{
				if(GameObject.Find("Goldengun"))
				{
					if (Ammo_Goldengun.MaxAmmo <= 10)
					{
						Ammo_Goldengun.MaxAmmo = Ammo_Goldengun.MaxAmmo + 1;
						if (Ammo_Goldengun.MaxAmmo >= 10){
							Ammo_Goldengun.MaxAmmo = 10;
						}
					}
				}
			} else {
				Script.Weapon7 = true;
			}
		}

		if(col.gameObject.tag == "P_Cannon")
		{	
			ItemPickUp.text = "BSG was picked up";
			if(Script.Weapon8 == true)
			{
				if(GameObject.Find("BSG"))
				{
					if (Ammo_BSG.MaxAmmo <= 20)
					{
						Ammo_BSG.MaxAmmo = Ammo_BSG.MaxAmmo + 2;
						if (Ammo_BSG.MaxAmmo >= 20){
							Ammo_BSG.MaxAmmo = 20;
						}
					}
				}
			} else {
				Script.Weapon8 = true;
			}
		}

		if(col.gameObject.tag == "P_Health")
		{	
			ItemPickUp.text = "Health was picked up";
			PlayerStats.Lives = PlayerStats.Lives + 50;
			if (PlayerStats.Lives >= 100){
				PlayerStats.Lives = 100;
			}
		}

		if(col.gameObject.tag == "P_Ammo")
		{	
			ItemPickUp.text = "Ammo was picked up";

			Ammo_UZI.MaxAmmo = Ammo_UZI.MaxAmmo + 125;
			if (Ammo_UZI.MaxAmmo >= 250){
				Ammo_UZI.MaxAmmo = 250;
			}

			Ammo_Minigun.MaxAmmo = Ammo_Minigun.MaxAmmo + 300;
			if (Ammo_Minigun.MaxAmmo >= 600){
				Ammo_Minigun.MaxAmmo = 600;
			}

			Ammo_AR.MaxAmmo = Ammo_AR.MaxAmmo + 150;
			if (Ammo_AR.MaxAmmo >= 300){
				Ammo_AR.MaxAmmo = 300;
			}

			Ammo_SMG.MaxAmmo = Ammo_SMG.MaxAmmo + 120;
			if (Ammo_SMG.MaxAmmo >= 240){
				Ammo_SMG.MaxAmmo = 240;
			}
		
			Ammo_Shotgun.MaxAmmo = Ammo_Shotgun.MaxAmmo + 16;
			if (Ammo_Shotgun.MaxAmmo >= 32){
				Ammo_Shotgun.MaxAmmo = 32;
			}
		
			Ammo_Sniper.MaxAmmo = Ammo_Sniper.MaxAmmo + 28;
			if (Ammo_Sniper.MaxAmmo >= 45){
				Ammo_Sniper.MaxAmmo = 45;
			}		
			
			Ammo_Goldengun.MaxAmmo = Ammo_Goldengun.MaxAmmo + 5;
			if (Ammo_Goldengun.MaxAmmo >= 10){
				Ammo_Goldengun.MaxAmmo = 10;
			}	

			Ammo_BSG.MaxAmmo = Ammo_BSG.MaxAmmo + 10;
			if (Ammo_BSG.MaxAmmo >= 20){
				Ammo_BSG.MaxAmmo = 20;
			}	
		}
		if(
			col.gameObject.tag == "P_Ammo" ||
			col.gameObject.tag == "P_Health" || 
			col.gameObject.tag == "P_Uzi" ||
			col.gameObject.tag == "P_Minigun" ||
			col.gameObject.tag == "P_AR" ||
			col.gameObject.tag == "P_SMG" ||
			col.gameObject.tag == "P_Shotgun" ||
			col.gameObject.tag == "P_Sniper" ||
			col.gameObject.tag == "P_Goldengun" ||
			col.gameObject.tag == "P_Cannon"
		) {
			StartCoroutine(Timer());
		}
	}

    IEnumerator Timer()
    {
        ItemPickUp.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3);
        ItemPickUp.gameObject.SetActive(false);
    }
}