using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length;

        if(numScenePersists > 1) 
        {
            Destroy(gameObject);
        }
        else {
            DontDestroyOnLoad(gameObject);
        }

    }

    public void ResetScenePersistent(){
        Destroy(gameObject);
    }

}
