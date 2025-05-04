using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
   public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
