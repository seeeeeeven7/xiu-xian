using UnityEngine;
using Random = UnityEngine.Random;

public class MapManager : MonoBehaviour {

    public GameObject dirt;
    private Transform mapHolder;

    // Use this for initialization
    void Start () {
        mapHolder = new GameObject("MapHolder").transform;

        for (int i = -50, k = 0; i <= 50; i++)
        {
            for (int j = k; j >= -20; j--)
            {
                Debug.Log(i + ' ' + j);
                GameObject instance = Instantiate(dirt, new Vector3(i, j, 0), Quaternion.identity) as GameObject;
                instance.transform.SetParent(mapHolder);
            }
            int r = Random.Range(0, 10);
            if (r == 0) k++;
            if (r == 1) k--;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
