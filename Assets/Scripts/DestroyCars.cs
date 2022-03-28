using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCars : MonoBehaviour
{
    public GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            particle.transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
            particle.gameObject.SetActive(true);
            Destroy(gameObject);
            
        }
        else
        {
            particle.gameObject.SetActive(false);
        }
    }
}
