using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform target;
    Transform xTarget;
    float zDifference;

    float x;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        x = Mathf.Lerp(transform.position.x, xTarget.position.x, 10f * Time.deltaTime);
        z = Mathf.Lerp(transform.position.z, target.position.z + zDifference, 50 * Time.deltaTime);
        // transform.position = Vector3.Lerp(transform.position, new Vector3(xTarget.position.x,target.position.y,target.position.z+zDifference+1f), 0.5f);
        transform.position = new Vector3(x, target.position.y, z);
    }

    public void SetPositions(float num,Transform x,float distance)
    {
        zDifference = (distance * num) + num;
        xTarget = x;
    }
}
