using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneOptions : MonoBehaviour
{
    public TMP_Dropdown dropdown;


    // Start is called before the first frame update
    void Start()
    {
        dropdown.options.Clear();

        int sceneCount = SceneManager.sceneCountInBuildSettings;
        int origScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Scene Count: " + sceneCount);
        for (int i = 0; i < sceneCount; i++)
        {
            //Create a new TMP option to add to a TMP dropdown, don't get confused by Dropdown vs. TMP Dropdown
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();

            option.text = "Scene " + i;

            Debug.Log("Scene Index: " + option.text);
            dropdown.options.Add(option);

        }

    }

    public void gotoChosenScene()
    {
        SceneManager.LoadScene(dropdown.value);
    }

}
