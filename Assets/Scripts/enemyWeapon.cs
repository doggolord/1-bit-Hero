using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWeapon : MonoBehaviour {

	public GameObject bullet;
    public Transform firePoint;

	private float timeBtwShots;
    public float startTimeBtwShots;

    private Transform player;
    public Transform target;

    void start()
    {
        timeBtwShots = startTimeBtwShots;
    }

    void Update()
    {

        if (GetComponent<EnemyWait>().enabled == false)
        {
            Shoot();
        }

        if (PlayerStats.Lives <= 0 || Timer.currentTime <= 0)
        {
            Destroy(this);
        }
	}

    void Shoot () {
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            timeBtwShots = startTimeBtwShots;
        } else {
            timeBtwShots -= Time.deltaTime;
        }
    }
}