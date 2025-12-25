using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void goHome()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void goToInstrumental()
    {
        SceneManager.LoadScene("InstrumentalScene");
    }

    public void backToArchitecture()
    {
        SceneManager.LoadScene("ArchitectureScene");
    }
}
