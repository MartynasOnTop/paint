using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painter : MonoBehaviour
{
    public GameObject lineObject;
    LineRenderer line;

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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name.Equals("Blue"))
                {
                    CreateNewLine(Color.blue);
                }
                else if (hit.collider.gameObject.name.Equals("Red"))
                {
                    CreateNewLine(Color.red);
                }
                else if (hit.collider.gameObject.name.Equals("Yellow"))
                {
                    CreateNewLine(Color.yellow);
                }
            }
        }
    }
    void AddPoint()
    {
        line.positionCount++;

        var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;

        line.SetPosition(line.positionCount - 1, worldPos);
    }
    void CreateNewLine(Color color)
    {
        GameObject newLineObject = new GameObject("LineRenderer");
        line = newLineObject.AddComponent<LineRenderer>();
        line.material = new Material(Shader.Find("Sprites/Default"));
        line.startColor = color;
        line.endColor = color;
        line.startWidth = 0.3f;
        line.endWidth = 0.3f;
    }
}
