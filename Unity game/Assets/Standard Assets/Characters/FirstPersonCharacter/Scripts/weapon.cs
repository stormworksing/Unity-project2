using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon : MonoBehaviour

{
    public GameObject bullet;
    public Transform muzzle;
    public int CurAmmo;
    public int maxAmmo;
    public bool infAmmo;
    public float bulletspeed;
    public float shootRate;
    private float lastShotTime;
    public bool isPlayer;

    private void Awake()
    {
        if(GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        }
    }

    public bool CanShoot()
    {
        if (Time.time - lastShotTime >= shootRate)
        {
            if (CurAmmo > 0 || infAmmo ==true)
            {
                return true;
            }
    
        }
        return false;
    }

    public void Shoot()
    {
        lastShotTime = Time.time;
        CurAmmo--;
        GameObject bulletobj = Instantiate(bullet, muzzle.position, muzzle.rotation);
        bulletobj.GetComponent<Rigidbody>().velocity = muzzle.forward * bulletspeed;
    }

 
}
