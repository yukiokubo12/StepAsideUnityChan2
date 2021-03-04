using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject conePrefab;
    public GameObject carPrefab;

    private GameObject unitychan;
    private float difference;

    private float time = 0f;
    private float interval;    
    // private int startPos = 80;
    // private int goalPos = 360;
    private float posRange = 3.4f;

    void Start()
    {
        this.interval = 0.8f;
        this.unitychan = GameObject.Find("unitychan");
    }
    //発展課題
    void Update()
    {
        // for(int i = startPos; i < goalPos; i += 15)
        // {
        time += Time.deltaTime;
        if(time > interval)
        {
            int num = Random.Range(1, 11);
            int offsetZ = Random.Range(40, 50);
            if(num <= 2)
            {
                for(float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, this.unitychan.transform.position.z + offsetZ);
                    this.time = 0;
                }
            }
            else
            {
                for(float j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    if(1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, this.unitychan.transform.position.z + offsetZ);
                        this.time = 0;
                    }
                    else if(7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, this.unitychan.transform.position.z + offsetZ);
                        this.time = 0;
                    }   
                }
            }
        // }
        }
    }
}
