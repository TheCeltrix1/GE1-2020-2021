using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    public void Fire()
    {
        this.GetComponent<Rigidbody>().velocity = this.transform.forward * 15;
    }
}
