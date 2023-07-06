using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private FieldGenerator _fieldGenerator;
    [SerializeField] private CellPool _cellPool;

    private List<Cell> _activeCells = new List<Cell>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnElement();
        }
    }

    private void SpawnElement()
    {
        var newCell = _cellPool.Get();
        _activeCells.Add(newCell);

        var freeElements = _fieldGenerator.FieldCells.FindAll(x => x.IsFree);
        var rnd = Random.Range(0, freeElements.Count);
        
        newCell.RectTransform.position = freeElements[rnd].RectTransform.position;
        newCell.gameObject.SetActive(true);
        
        freeElements[rnd].IsFree = false;
    }
}
