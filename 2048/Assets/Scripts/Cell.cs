using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    
    public RectTransform RectTransform => transform as RectTransform;

    public void SetNumber(int value)
    {
        _text.text = value.ToString();
    }
}
