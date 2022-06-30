using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ObjectFactory : Singleton<ObjectFactory> 
{
    [SerializeField] private GameObject[] availableObjects;
    [SerializeField] private UserScript user;
    [SerializeField] private float waitTime = 30.0f;
    [SerializeField] private int startingObjects = 5;
    [SerializeField] private float minRange = 5.0f;
    [SerializeField] private float maxRange = 5.0f;

    private void Awake()
    {
        Assert.IsNotNull(availableObjects);
        Assert.IsNotNull(user);
    }
     private void Start()
     {
        for (int i = 0; i < startingObjects; i++)
        {
            InstantiateObjects();
        }
        StartCoroutine(GenerateObjects());
     }
    private void InstantiateObjects()
    {
        int index = Random.Range(0, availableObjects.Length);
        float x = user.transform.position.x + GenerateRange();
        float y = user.transform.position.y;
        float z = user.transform.position.z + 15;
        Instantiate(availableObjects[index], new Vector3(x, y, z), Quaternion.identity);
        Debug.Log("Instantiated");
    }

    private float GenerateRange()
    {
        float randomNum = Random.Range(minRange, maxRange);
        bool isPositive = Random.Range(0, 10) < 5;
        return randomNum * (isPositive ? 1: -1);
    }

   
    private IEnumerator GenerateObjects()
    {
        while (true)
        {
            InstantiateObjects();
            yield return new WaitForSeconds(waitTime);
        }
    }

   
}

