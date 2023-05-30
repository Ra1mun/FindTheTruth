using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class korneliya : MonoBehaviour
{
    private void Start()
    {
        if (DataHolder.SpawnKornelia)
        {
            gameObject.SetActive(true);
        }
    }
    
}
