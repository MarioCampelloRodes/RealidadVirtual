using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatedHandInput : MonoBehaviour
{
    public InputActionProperty triggerInput;
    public InputActionProperty gripInput;
    public Animator handAnimator;

    // Update is called once per frame
    void Update()
    {
        float triggerValue = triggerInput.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripInput.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
