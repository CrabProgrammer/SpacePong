using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;
public class RadioButtonSystem : MonoBehaviour
{
    // Start is called before the first frame update
    ToggleGroup toggleGroup;
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
    }

    // Update is called once per frame
    public void ChangeSpeed()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if(toggle.name=="Normal")
        {
            Global.speed = 70;
        }
        else if (toggle.name == "Fast")
        {
            Global.speed = 100;
        }
        else if (toggle.name == "SuperFast")
        {
            Global.speed = 130;
        }
    }
}
