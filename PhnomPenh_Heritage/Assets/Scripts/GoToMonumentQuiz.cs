using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ClickableSprite : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string sceneName = "RoyalPalaceScene";

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Sprite clicked! Loading scene...");
        SceneManager.LoadScene(sceneName);
    }
}
