using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bda2 : MonoBehaviour
{
    public GameObject urmom;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            urmom.SetActive(false);

        }

    }
}
