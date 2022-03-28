using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z-25f);
        //transform.rotation = Quaternion.EulerRotation(pivot.rotation.x, pivot.rotation.y, transform.rotation.z);
    }
}
