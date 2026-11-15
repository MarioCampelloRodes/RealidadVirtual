using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using static UnityEngine.Rendering.DebugUI;

public class HandCanvas : MonoBehaviour
{
    [Header("XR")]
    [SerializeField] Transform cameraOffset;
    [SerializeField] private Transform minHeight, maxHeight;

    [Header("Altura del jugador")]
    [SerializeField] private Slider heightSlider;

    [Header("Rotación")]
    [SerializeField] private Toggle snapTurnToggle;
    [SerializeField] ControllerInputActionManager controllerInputActionManager;

    [Header("Menú")]
    [SerializeField] private string menuSceneName = "MainMenu";

    private void Start()
    {
        // Configurar altura inicial
        ChangePlayerHeight();

        // Configurar modo de rotación inicial
        ChangeRotationMode();
    }

    // Volver al menú principal
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    // Modificar altura del jugador
    public void ChangePlayerHeight()
    {
        Vector3 posicion = cameraOffset.localPosition;

        posicion.y = Mathf.Lerp(minHeight.localPosition.y, maxHeight.localPosition.y, heightSlider.value);

        cameraOffset.localPosition = posicion;
    }

    // Cambiar entre Snap y Continuous
    public void ChangeRotationMode()
    {
        controllerInputActionManager.smoothTurnEnabled = snapTurnToggle.isOn;
    }
}
