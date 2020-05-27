using UnityEngine;
using System.Collections;

public class EnemyWait : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        GetComponent<enemyWeapon>().enabled = true;
        yield return new WaitForSeconds(2);
        GetComponent<EnemyWait>().enabled = false;
    }
}