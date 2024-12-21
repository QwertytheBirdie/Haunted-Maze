using UnityEngine;
using UnityEngine.SceneManagement;
public class Ender : MonoBehaviour
{
    [SerializeField] private string Startscreen = "StartMenu";

    public void StartButton()
    {
        SceneManager.LoadScene(Startscreen);
    }
}
