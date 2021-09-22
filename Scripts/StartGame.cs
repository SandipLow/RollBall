using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StartMyGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void YouTubePage()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC6DAOimMnTUCpPQ2_-7RtZg");
    }
}
