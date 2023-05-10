using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float bulletSpeed = 50f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    //Instanciar tiro (GameObject 3D) na posição do player
    public void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.SetParent(transform.parent);
        bullet.transform.position = transform.position + new Vector3(0, 0, 2);

        bullet.SetActive(true);
        
        FindObjectOfType<FirstPhaseManager>().PlaySoundShot();

        bullet.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);
        Destroy(bullet, 1.5f);
    }

}
