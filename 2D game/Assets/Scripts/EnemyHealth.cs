using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public ParticleSystem ParticleDeath;
	public int Lives = 50;

	    [System.Serializable]
    public class DropCurrency
    {
        public string name;
        public GameObject item;
        public int dropRarity;
    }
 
    public List <DropCurrency> LootTable = new List <DropCurrency> ();
    public int dropChance;

	void start () {
		ParticleDeath = GetComponent<ParticleSystem>();
        ParticleDeath.Stop();
	}

	public void GetHit(int Damage) {
		Lives = Lives - Damage;
	}

	void Update () {
		if (Lives <= 0){
			Instantiate (ParticleDeath, transform.position, transform.rotation);		
			ParticleDeath.Play();
			Destroy(gameObject);
            Score.enemy = true;
			CalculateLoot();
		}
        if (gameObject.transform.position.y <= -10) {
            Score.enemy = true;
			Destroy(gameObject);
		}
	}
//loot pool
	public void CalculateLoot ()
    {
        int calc_dropChance = Random.Range (0, 101);
 
        if (calc_dropChance > dropChance)
        {
            return;
        }
 
        if (calc_dropChance <= dropChance)
        {
            int itemWeight = 0;
 
            for (int i = 0; i < LootTable.Count; i++)
            {
                itemWeight += LootTable [i].dropRarity;
            }
 
            int randomValue = Random.Range (0, itemWeight);
 
            for (int j = 0; j < LootTable.Count; j++)
            {
                if (randomValue <= LootTable [j].dropRarity)
                {
                    Instantiate (LootTable [j].item, transform.position, Quaternion.identity);
                    return;
                }
                randomValue -= LootTable [j].dropRarity;
            }
        }
    }
}