using System.Collections;
using UnityEngine;

public class HayWall : MonoBehaviour
{
    public GameObject vfxFire;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arrow"))
        {
            Destroy(other.gameObject);

            StartCoroutine(HayBurnCO());
        }
    }

    IEnumerator HayBurnCO()
    {
        vfxFire.SetActive(true);

        yield return new WaitForSeconds(3);

        gameObject.SetActive(false);
    }
}
