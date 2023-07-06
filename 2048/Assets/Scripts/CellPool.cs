using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellPool : MonoBehaviour
{
    [SerializeField] private FieldGenerator _generator;
    [SerializeField] private Cell _cellPrefab;
    
    private Queue<Cell> _cells = new Queue<Cell>();

    private void Start()
    {
        for (int i = 0; i < _generator.ElementsCount + 1; i++)
        {
            var newCell = Instantiate(_cellPrefab, transform);
            _cells.Enqueue(newCell);
            newCell.gameObject.SetActive(false);
        }
    }

    public Cell Get()
    {
        return _cells.Dequeue();
    }

    public void Set(Cell cell)
    {
        _cells.Enqueue(cell);
    }
}
