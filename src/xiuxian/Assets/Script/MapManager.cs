using UnityEngine;
using Random = UnityEngine.Random;

public class MapManager : MonoBehaviour {

    public GameObject dirt;
    private Transform mapHolder;

    // Use this for initialization
    void Start () {
        mapHolder = new GameObject("MapHolder").transform;

        for (int x = -10; x <= 10; x++)
            for (int y = -10; y <= 10; y++)
            {
                GameObject instance = Instantiate(dirt, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                instance.transform.SetParent(mapHolder);
            }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
