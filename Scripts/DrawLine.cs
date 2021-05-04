using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawLine : MonoBehaviour
{
    public LineRenderer Line;
    public float lineWidth = 1f;
    public float minimumVertexDistance = 0.1f;
    public GameObject drawLocation;
    public TextMeshProUGUI text;

    private bool isLineStarted;

    void Start()
    {
        // set the color of the line
        Line.startColor = Color.red;
        Line.endColor = Color.red;

        // set width of the renderer
        Line.startWidth = lineWidth;
        Line.endWidth = lineWidth;

        isLineStarted = false;
        Line.positionCount = 0;
    }

    void Update()
    {
        /*if (Input.GetButtonDown("XRI_Right_Primary2DAxis_Vertical"))
        {
            text.text = "1";
            
        }
        if (Input.GetButtonDown("XRI_Right_Primary2DAxis_Horizontal"))
        {
            text.text = "2";

        }
        if (Input.GetButtonDown("XRI_Right_Secondary2DAxis_Vertical"))
        {
            text.text = "3";

        }
        if (Input.GetButtonDown("XRI_Right_Trigger"))
        {
            text.text = "4";

        }
        if (Input.GetButtonDown("XRI_Right_Grip"))
        {
            text.text = "5";

        }
        if (Input.GetButtonDown("XRI_Right_IndexTouch"))
        {
            text.text = "6";

        }
        if (Input.GetButtonDown("XRI_Right_ThumbTouch"))
        {
            text.text = "7";

        }
        if (Input.GetButtonDown("XRI_Right_PrimaryButton"))
        {
            text.text = "8";

        }
        if (Input.GetButtonDown("XRI_Right_SecondaryButton"))
        {
            text.text = "9";

        }
        if (Input.GetButtonDown("XRI_Right_PrimaryTouch"))
        {
            text.text = "11";

        }
        if (Input.GetButtonDown("XRI_Right_SecondaryTouch"))
        {
            text.text = "12";

        }
        if (Input.GetButtonDown("XRI_Right_GripButton"))
        {
            text.text = "13";

        }
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            text.text = "14";

        }
        if (Input.GetButtonDown("XRI_Right_MenuButton"))
        {
            text.text = "15";

        }
        if (Input.GetButtonDown("XRI_Right_Primary2DAxisClick"))
        {
            text.text = "16";

        }
        if (Input.GetButtonDown("XRI_Right_Primary2DAxisTouch"))
        {
            text.text = "17";

        }*/


        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            text.text = "Down";
            Line.positionCount = 0;
            Vector3 mousePos = GetWorldCoordinate(drawLocation.transform.position);

            Line.positionCount = 2;
            Line.SetPosition(0, mousePos);
            Line.SetPosition(1, mousePos);
            isLineStarted = true;
        }

        if (Input.GetButton("XRI_Right_TriggerButton") && isLineStarted)
        {
            text.text = "Down";
            Vector3 currentPos = GetWorldCoordinate(drawLocation.transform.position);
            float distance = Vector3.Distance(currentPos, Line.GetPosition(Line.positionCount - 1));
            if (distance > minimumVertexDistance)
            {
                Debug.Log(distance);
                UpdateLine();
            }
        }

        if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            text.text = "Up";
            isLineStarted = false;
        }
    }

    private void UpdateLine()
    {
        Line.positionCount++;
        Line.SetPosition(Line.positionCount - 1, GetWorldCoordinate(drawLocation.transform.position));
    }

    private Vector3 GetWorldCoordinate(Vector3 mousePosition)
    {
        Vector3 mousePos = new Vector3(mousePosition.x, mousePosition.y, mousePosition.z);
        return (mousePos);
    }
}
