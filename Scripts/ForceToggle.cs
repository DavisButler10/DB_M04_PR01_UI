using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ForceToggle : MonoBehaviour
{
    private Toggle toggleRed;
    private Toggle toggleBlue;
    private Toggle toggleGreen;
    public GameObject BalloonGun;
    public LineRenderer line;
    public Material Red;
    public Material Blue;
    public Material Green;
    public TextMeshProUGUI text;

    private void Start()
    {
        //line = BalloonGun.GetComponent<LineRenderer>();
        //toggleRed = GetComponent<Toggle>();
        //toggleBlue = GetComponent<Toggle>();
        //toggleGreen = GetComponent<Toggle>();
    }
    public void ToggleRed()
    {
        //toggleRed.isOn = true;
        //toggleBlue.isOn = false;
        //toggleGreen.isOn = false;
        line.material = Red;
        text.text = "Red";
    }

    public void ToggleBlue()
    {
        line.material = Blue;
        //toggleBlue.isOn = true;
        //toggleGreen.isOn = false;
        //toggleRed.isOn = false;
        text.text = "Blue";
    }

    public void ToggleGreen()
    {
        //toggleGreen.isOn = true;
        //toggleRed.isOn = false;
        //toggleBlue.isOn = false;
        line.material = Green;
        text.text = "Green";
    }

    private void Update()
    {
        /*if (toggleBlue)
        {
            line.material = Blue;
        }
        if (toggleRed)
        {
            line.material = Red;
        }
        if (toggleGreen)
        {
            line.material = Green;
        }*/
    }

}
