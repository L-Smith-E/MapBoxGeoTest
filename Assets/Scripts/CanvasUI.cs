using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasUI : MonoBehaviour
{

    public void ARFBtn()
    {
        GameManager.instance.ChangeScene("ARFoundations_Scene");
        Debug.Log("ARF Pressed");
    }
    public void TrackBtn()
    {
        GameManager.instance.ChangeScene("Tracking_Scene");
        Debug.Log("Track Pressed");
    }

    public void WorldBtn()
    {
        GameManager.instance.ChangeScene("World_Scene");
        Debug.Log("Mapbox Pressed");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
