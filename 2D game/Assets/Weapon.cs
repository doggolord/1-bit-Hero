using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

        if (rotZ > 90 || rotZ < -90)
        {
            transform.localScale = new Vector3(0.1309371f, -0.1309371f, 0.1309371f);
        }

        else
        {
            transform.localScale = new Vector3(0.1309371f, 0.1309371f, 0.1309371f);
        }
    }
}