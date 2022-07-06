using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public GameObject MapView;
    [SerializeField] public GameObject MiniMap;
    public bool ARActive = true;
    private void Awake()
    {
        
        {
            if (instance == null)
            {
                instance = GetComponent<GameManager>();
            }
        }
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void SwitchView()
    {
        if (ARActive == true)
        {
            MapView.SetActive(false);
            MiniMap.SetActive(true);
        }
        else
        {
            MapView.SetActive(true);
            MiniMap.SetActive(false);
        }
    }

    //public IEnumerator ARSwitch()
    //{

    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
