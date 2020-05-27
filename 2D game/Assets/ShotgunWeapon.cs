using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotgunWeapon : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;

    public GameObject bulletPrefab;

    public float fireRate = 0.5F;
    private float nextFire = 0.0F;

    public int MaxAmmo = 32;
    public int AmmoCount = 8;
    private int ClipSize;
    private int LastCount;
    public float ReloadTime = 1f;
    private bool isReloading = false;

    public Text MaxAmmoRead;
    public Text AmmoCountRead;

    public AudioClip Shootclip;
	public AudioSource ShootSource;

	void Start () {
        ClipSize = AmmoCount;
	}

    void Update()
    {
 		ShootSource.clip = Shootclip;

        if(isReloading){
            return;
        }

        if (Input.GetMouseButton(1) == false)
        {
            Shoot();
        }

        MaxAmmoRead.text = MaxAmmo.ToString("0");
        AmmoCountRead.text = AmmoCount.ToString("0");
    }

    void Shoot () 
    {
        if (AmmoCount <= 0 || Input.GetKey("r"))
        {        
            StartCoroutine(Reload());
            return;
        } else {

            if (Input.GetMouseButton(0) && Time.time > nextFire) //left click on mouse
            {
                AmmoCount --;
                nextFire = Time.time + fireRate;
                Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
                Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
                Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
                Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
                Instantiate(bulletPrefab, firePoint5.position, firePoint5.rotation);
	
                if (GameObject.FindWithTag("Player"))
                {
                   ShootSource.Play();
                }
            }
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(ReloadTime);
        MaxAmmo -= ClipSize - AmmoCount;

        if (MaxAmmo <= 0)
        {
            AmmoCount += LastCount;
            MaxAmmo = 0;
            LastCount = 0;
        } else {
            AmmoCount = ClipSize;
            LastCount = MaxAmmo;
        }

        isReloading = false;
    }

    void OnEnable()
    {
        isReloading = false;
    }
}