using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject particle,playerCar,losePanel;
    public int lifePoint=2;
    private void Start()
    {
        playerCar = transform.Find("Jeep3_LOD_combined").gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            lifePoint--;
            particle.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            particle.gameObject.SetActive(true);
            if (lifePoint==0)
            {
                particle.transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                particle.gameObject.SetActive(true);
                Destroy(playerCar.gameObject);
                losePanel.gameObject.SetActive(true);
                FindObjectOfType<SwerveInput1>().enabled = false;
            }
           

        }
        else
        {
            particle.gameObject.SetActive(false);
        }
    }
}
