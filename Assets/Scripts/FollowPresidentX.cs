using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPresidentX : MonoBehaviour
{
      Transform presidentTransfrom;
    public float distance;
    public float loopTime;

    // Start is called before the first frame update
    void Start()
    {
        presidentTransfrom = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Mathf.Lerp(transform.position.x, presidentTransfrom.position.x-distance, loopTime * Time.deltaTime), transform.position.y,Mathf.Lerp(transform.position.z,presidentTransfrom.position.z,loopTime*Time.deltaTime )), 1f);

    }
}
