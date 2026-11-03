using UnityEngine;
using TMPro;
public class Ammo : MonoBehaviour
{
    public int ammoRemaining = 6;
    public TMP_Text canvasAmmo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasAmmo.text = ammoRemaining.ToString();
    }

    public void ReduceAmmo()
    {
        ammoRemaining--;
        canvasAmmo.text = ammoRemaining.ToString();
    }
}
