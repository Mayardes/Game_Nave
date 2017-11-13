using UnityEngine;
using System.Collections;

public class GenerateEnemies : MonoBehaviour {

    public float max, min;
    public GameObject enemy;
    public float repeatRate;

	// Use this for initialization
	void Start () {
        InvokeRepeating("InstantiateEnemies", 0f, repeatRate);
	}
	

    void InstantiateEnemies()
    {
        Object clone  = Instantiate(enemy, new Vector3(Random.Range(min,max),6,0), transform.rotation) as GameObject;
    }

	//// Update is called once per frame
	//void Update () {
	
	//}
}
