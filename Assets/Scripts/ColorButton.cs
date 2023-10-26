using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public LineRenderer line;

    public GameObject red;
    public GameObject blue;
    public GameObject yellow;

    private void OnMouseDown()
    {
        if (red)
        {
            line.material.color = Color.red;
        }
        if (blue)
        {
            line.material.color = Color.blue;
        }
        if (yellow)
        {
            line.startColor = Color.yellow;
        }
    }
}
