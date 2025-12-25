using UnityEngine;

public class DishInteractable : MonoBehaviour
{
    public string npcTitle;
    public string npcMessage;
    public SpriteRenderer numberRenderer;
    public Sprite tickSprite;
    public NPCController npcController;

    private bool tickSet = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // ✅ Set tick only once
                if (!tickSet && numberRenderer != null && tickSprite != null)
                {
                    numberRenderer.sprite = tickSprite;
                    tickSet = true;
                }

                // ✅ Always show NPC message
                if (npcController != null)
                {
                    npcController.ShowNPC(npcMessage, npcTitle);
                }
            }
        }
    }
}
