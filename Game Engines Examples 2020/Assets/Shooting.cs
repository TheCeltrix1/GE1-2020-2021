using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab; 

    public float fireRate = 3;

    private bool _var;

    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(ShootingCoroutine());
        //StartCoroutine(PenisSauce());
    }

    void Shoot()
    {
        GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
        bullet.transform.position = spawnPoint.position;
        bullet.transform.rotation = this.transform.rotation;
    }

    bool shooting = false;

    System.Collections.IEnumerator ShootingCoroutine()
    {
        while(true)
        {
            if (Input.GetButton("Fire1"))
            {
                Shoot();
                yield return new WaitForSeconds(1.0f / fireRate);
            }
            yield return null;
        }
    }

    IEnumerator PenisSauce()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(1 / (float)fireRate);
        }
    }
}
