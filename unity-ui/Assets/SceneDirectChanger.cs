using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SceneDirectChanger : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        //Add an event listener for the onClick action of the Button
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        dropdown.GetComponent<SceneOptions>().gotoChosenScene();
    }

}
