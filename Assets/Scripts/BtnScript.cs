using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnScript : MonoBehaviour
{
    GameManager GM;
    [SerializeField] private GameObject Camera;

    public void OnPress()
    {
        GM.ARActive = false;
    }
}
