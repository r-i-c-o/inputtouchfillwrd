using UnityEngine;

public class Cell : MonoBehaviour
{
    public Vector2 position;
    public float halfSize;
    public bool Selected = false;
    public Sprite sprite;
    public Sprite selectedSprite;
    public SpriteRenderer SpriteRenderer;
    public CellManager cellManager;
    void Start()
    {
        position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        Vector2 diff = Camera.main.WorldToScreenPoint(SpriteRenderer.bounds.size) - Camera.main.WorldToScreenPoint(Vector2.zero);
        halfSize = diff.x * gameObject.transform.localScale.x;
        cellManager.AddCell(this);
        //print(position + " added, halfsize = " + halfSize);
    }

    void Update()
    {
        
    }

    public void SetSelected()
    {
        Selected = true;
        SpriteRenderer.sprite = selectedSprite;
    }

    public void Unselect()
    {
        Selected = false;
        SpriteRenderer.sprite = sprite;
    }
}
