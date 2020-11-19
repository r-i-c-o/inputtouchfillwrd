using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CellManager : ScriptableObject
{
    private List<Cell> cells = new List<Cell>();
    private float halfSize = 0f;

    private void OnEnable()
    {
        Reset();
    }

    void Reset()
    {
        cells = new List<Cell>();
    }
    public void OnTouch(Vector2 position)
    {
        foreach(Cell cell in cells) {
            Vector2 difference = cell.position - position;
            float x = difference.x;
            float y = difference.y;
            if (x < 0) x = -x;
            if (y < 0) y = -y;
            //Debug.Log(difference);
            //Debug.Log((Mathf.Abs(difference.x) <= cell.halfSize) + " " + (Mathf.Abs(difference.y) <= cell.halfSize));
            if (x <= halfSize && y <= halfSize)
            {
                if (cell.Selected == false)
                    cell.SetSelected();
            }
        }
    }

    public void AddCell(Cell cell)
    {
        cells.Add(cell);
        if (cells.Count == 1)
            halfSize = cell.halfSize;
    }
}
