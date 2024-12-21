using UnityEngine;
using UnityEngine.SceneManagement;
public class Starter : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "Level 1";
   
    public void StartButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
