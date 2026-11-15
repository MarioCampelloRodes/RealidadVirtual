using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed;
    public bool canShoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        if (canShoot)
        {
            GameObject spawnedBullet = Instantiate(bullet);

            spawnedBullet.transform.position = shootPoint.position;
            spawnedBullet.transform.rotation = shootPoint.rotation;

            spawnedBullet.GetComponent<Rigidbody>().linearVelocity = shootPoint.forward * bulletSpeed;

            Destroy(bullet, 5f);
        }
    }

    public void SwitchShoot()
    {
        if (canShoot)
        {
            canShoot = false;
        }
        else
        {
            canShoot = true;
        }
    }
}
