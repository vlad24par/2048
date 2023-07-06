using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    [SerializeField] private int _elementsCount;
    [SerializeField] private FieldElement _fieldElement;

    public List<FieldElement> FieldCells = new List<FieldElement>();

    public int ElementsCount => _elementsCount;

    private void Start()
    {
        for (int x = 0; x < _elementsCount; x++)
        {
            var newElement = Instantiate(_fieldElement, transform);
            newElement.gameObject.SetActive(true);
            FieldCells.Add(newElement);
        }
    }
}
