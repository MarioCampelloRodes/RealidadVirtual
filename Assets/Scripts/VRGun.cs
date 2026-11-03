using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRGun : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed;
    public AmmoController ammoController;
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
        if (ammoController.ammoLeft)
        {
            GameObject spawnedBullet = Instantiate(bullet);

            spawnedBullet.transform.position = shootPoint.position;
            spawnedBullet.transform.rotation = shootPoint.rotation;

            spawnedBullet.GetComponent<Rigidbody>().linearVelocity = shootPoint.forward * bulletSpeed;

            ammoController.ReduceAmmo();

            Destroy(bullet, 5f);
        }
    }
}
