using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneTextID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This is the current component, so the parent in this case is the GameObject
        //Get the TMP_Text component as part of the attached game object and update it's text.
        this.GetComponentInParent<TMP_Text>().text = "Scene = " + SceneManager.GetActiveScene().buildIndex;
    }
}
