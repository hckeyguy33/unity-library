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
        this.GetComponentInParent<TMP_Text>().text = "Scene = " + SceneManager.GetActiveScene().buildIndex;
    }
}
