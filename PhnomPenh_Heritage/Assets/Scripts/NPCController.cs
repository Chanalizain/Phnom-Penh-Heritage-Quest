using UnityEngine;
using TMPro;

public class NPCController : MonoBehaviour
{
    public GameObject npcPanel;
    public TextMeshProUGUI messageTextTitle;
    public TextMeshProUGUI messageText;
    public HorizontalRoomScroll roomScroll;

    public void ShowNPC(string message, string title)
    {
        if (roomScroll != null)
            roomScroll.enabled = false;

        npcPanel.SetActive(true);
        messageText.text = message;
        messageTextTitle.text = title;
    }

    public void CloseNPC()
    {
        npcPanel.SetActive(false);

        if (roomScroll != null)
            roomScroll.enabled = true;
    }
}
