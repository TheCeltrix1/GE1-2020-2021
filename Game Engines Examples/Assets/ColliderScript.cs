using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    public GameObject ekusplosion;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(ekusplosion,this.transform.position, Quaternion.Euler(0,0,0));
            Destroy(this.gameObject);
        }
    }
}
