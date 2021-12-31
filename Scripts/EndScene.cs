using UnityEngine;

public class EndScene : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }

    public void YouTubePage()
    {
        Application.OpenURL("https://www.youtube.com/channel/UC6DAOimMnTUCpPQ2_-7RtZg");
    }
}
