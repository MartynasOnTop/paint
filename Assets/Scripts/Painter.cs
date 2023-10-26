using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public GameObject lineObject;
    LineRenderer line;

    public GameObject Red;
    public GameObject Blue;
    public GameObject Yellow;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            line = Instantiate(lineObject).GetComponent<LineRenderer>();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            AddPoint();
        }
    }
    void AddPoint()
    {
        line.positionCount++;

        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;

        line.SetPosition(line.positionCount - 1, worldPos);
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "Red")
        {
            line.startColor = Color.red;
            line.endColor = Color.red;
        }
        if (gameObject.tag == "Blue")
        {
            line.startColor = Color.blue;
            line.endColor = Color.blue;
        }
        if (gameObject.tag == "Yellow")
        {
            line.startColor = Color.yellow;
            line.endColor = Color.yellow;
        }
    }
}
