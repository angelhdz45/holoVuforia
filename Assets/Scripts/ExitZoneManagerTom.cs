using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitZoneManagerTom : MonoBehaviour {

    public Text exitText;
	public GameObject TomStudio;
	public GameObject KeyScene;
    public GazeGestureManager keySceneGaze;



    void Start()
    {
        //Debug.Log("Logging Collision script");
    }

    private void Update()
    {
       
    }

    public void OnSelect()
    {
        Debug.Log("Went through the exit");
        exitTomScene();

    }

    void OnTriggerEnter(Collider CollisionCube)
    {
        exitTomScene();
       

    }

    public void exitTomScene()
    {
        TomStudio.SetActive(false);
     
        KeyScene.SetActive(true);
        keySceneGaze.enabled = true;
    }

}
