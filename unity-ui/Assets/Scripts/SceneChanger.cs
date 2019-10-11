using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public bool isNextSceneChanger;
    private GameObject sceneStateGO;

    // Start is called before the first frame update
    void Start()
    {
        sceneStateGO = GameObject.Find("SceneStateGO");
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (sceneStateGO != null)
        {
            if (isNextSceneChanger)
                SceneManager.LoadScene(sceneStateGO.GetComponent<SceneState>().nextScene);
            else
                SceneManager.LoadScene(sceneStateGO.GetComponent<SceneState>().previousScene);
        }
    }
}
