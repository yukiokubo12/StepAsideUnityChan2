using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBack : MonoBehaviour
{
    private GameObject unitychan;
    private GameObject cameraBack;

    public GameObject coinPrefab;
    public GameObject conePrefab;
    public GameObject carPrefab;

    private float difference;

    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
        this.cameraBack = GameObject.Find("CameraBack");
        this.difference = this.unitychan.transform.position.z - this.transform.position.z;
    }

    void Update()
    {
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - this.difference);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}
