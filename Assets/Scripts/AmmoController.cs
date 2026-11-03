using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class AmmoController : MonoBehaviour
{
    public bool isCharged = false;
    public bool ammoLeft = false;

    public int Ammo;

    public XRSocketInteractor socket;
    //Referencia válida para cualquier objeto XR Interactable de la escena
    public XRBaseInteractable interactableAmmo;

    public InputActionProperty actionButton;
    
    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        isCharged=true;

        //Asigna el objeto que se ha introducido en el socket (Cargador) y lo reconoce como XRBaseInteractable
        interactableAmmo = args.interactableObject as XRBaseInteractable;
    }

    public void OnSelectExit(SelectExitEventArgs args)
    {
        isCharged = false;
        interactableAmmo = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(isCharged && interactableAmmo != null)
        {
            Ammo = interactableAmmo.GetComponent<Ammo>().ammoRemaining;
            if(Ammo > 0)
            {
                ammoLeft = true;
            }
            else
            {
                ammoLeft = false;
            }

            //Soltar el cargador al pulsar un botón
            if (actionButton.action.WasPressedThisFrame())
            {
                if (socket.hasSelection)
                {
                    var interactable = socket.firstInteractableSelected;
                    socket.interactionManager.SelectExit(socket, interactable);
                    socket.enabled = false;
                    Invoke("ActivateSocket", 0.5f);
                }
            }
        }
    }

    public void ActivateSocket()
    {
        socket.enabled = true;
    }

    public void ReduceAmmo()
    {
        if(interactableAmmo != null)
        {
            interactableAmmo.GetComponent<Ammo>().ReduceAmmo();
        }
    }
}
