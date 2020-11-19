using UnityEngine;

public class TouchController : MonoBehaviour
{
    public CellManager cellManager;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Vector2 pos = Input.GetTouch(0).position;
            cellManager.OnTouch(pos);
        }
    }
}
