using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject conePrefab;
    public GameObject carPrefab;

    private int startPos = 80;
    private int goalPos = 360;
    private float posRange = 3.4f;

    void Start()
    {
        for(int i = startPos; i < goalPos; i += 15)
        {
            int num = Random.Range(1, 11);
            if(num <= 2)
            {
                for(float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                    // //発展課題
                    // GameObject cone = (GameObject)Resources.Load("TrafficConePrefab");
                    // Instantiate(cone, new Vector3(4 * j, cone.transform.position.y, i), Quaternion.identity);
                }
            }
            else
            {
                for(float j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if(1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                        // //発展課題
                        // GameObject coin = (GameObject)Resources.Load("CoinPrefab");
                        // Instantiate(coin, new Vector3(posRange * j, coin.transform.position.y, i + offsetZ), Quaternion.identity);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                        // //発展課題
                        // GameObject car = (GameObject)Resources.Load("CarPrefab");
                        // Instantiate(car, new Vector3(posRange * j, car.transform.position.y, i + offsetZ), Quaternion.identity);
                    }   
                }
            }
        }
    }
}
