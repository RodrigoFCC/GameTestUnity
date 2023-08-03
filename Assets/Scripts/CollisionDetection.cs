using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        var x = other.GetComponent<Enemy>();
        if (x)
        {
            x.decreaseHpEnemy();
        }
    }
}
