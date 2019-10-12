using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    //Public variables are found in the inspector of unity if they are MonoBehaviours
    public bool isNextSceneChanger;

    //You could convert this to a public and have it preloaded to remove the need
    //to find the object in the start function
    private GameObject sceneStateGO;

    // Start is called before the first frame update
    void Start()
    {
        //Find a local "invisible" game object to point to it later
        sceneStateGO = GameObject.Find("SceneStateGO");

        //Add an event listener for the onClick action of the Button
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (sceneStateGO != null)
        {
            //next and previous scene are public inspector loaded values per scene
            if (isNextSceneChanger)
                SceneManager.LoadScene(sceneStateGO.GetComponent<SceneState>().nextScene);
            else
                SceneManager.LoadScene(sceneStateGO.GetComponent<SceneState>().previousScene);
        }
    }
}
