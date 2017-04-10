using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;
    private Transform gameHolder;

    // Use this for initialization
    void Start ()
    {
        gameHolder = new GameObject("GameHolder").transform;

        GameObject instance = Instantiate(player, new Vector3(0, 20, 0), Quaternion.identity) as GameObject;

        instance.transform.SetParent(gameHolder);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
