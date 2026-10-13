using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCanvas;
    public InputActionProperty menuButton;

    // Update is called once per frame
    void Update()
    {
        if (menuButton.action.WasPressedThisFrame())
        {
            //Si está activo, lo desactivamos y viceversa
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
