using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject prefab;
    public Transform head;
	void Start () {
	}
	
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Instantiate(prefab, head.position, head.rotation);
        }
	}
}
