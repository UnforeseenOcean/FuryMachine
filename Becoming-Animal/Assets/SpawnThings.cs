using UnityEngine;
using System.Collections;

public class SpawnThings : MonoBehaviour {

    public GameObject lobby;
    // Use this for initialization
    void Start()
    {

        Spawn(lobby);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Spawn(GameObject obj)
    {
        for (int i = 0; i <140;i++)
        {
            for(int j=0;j<140;j++)
            {
                if(Random.value < 0.5)
                {
                    GameObject tempObj = Instantiate(obj, new Vector3((float)(i - 70), -1.47f, (float)(j - 70)), Quaternion.identity) as GameObject;

                }
            }
        }
    }
}
