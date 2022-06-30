using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARF_BScript : MonoBehaviour
{
    public void ARFBtn()
    {
        GameManager.instance.ChangeScene("ARFoundations_Scene");
        Debug.Log("ARF Pressed");
    }
}
