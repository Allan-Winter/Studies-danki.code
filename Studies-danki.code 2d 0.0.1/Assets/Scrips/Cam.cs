using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private Transform player;

    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        if(player.position.x >= -1f)
        {
            Vector3 following = new Vector3(player.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, following, smooth * Time.deltaTime);
        }
       
        //if(player.position.x <= 30f)
        //{
        //Vector3 following = new Vector3(player.position.x, transform.position.y, transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, following, smooth * Time.deltaTime);
        //}
    }
}