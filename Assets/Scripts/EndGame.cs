using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject thxMessage;
    
    public void ActivateEndGame()
    {
        thxMessage.SetActive(true);

        StartCoroutine(GoToMainMenuCO());
    }

    IEnumerator GoToMainMenuCO()
    {
        yield return new WaitForSeconds(8);

        SceneManager.LoadScene("MainMenu");
    }
}
