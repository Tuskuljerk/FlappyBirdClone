using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMover : MonoBehaviour
{
    public GameObject totalBack;
    public Transform backgroundPos;
    
    public float speed;
    void Start()
    {
        Instantiate(totalBack, new Vector3(0, 0, 1), Quaternion.identity);
        totalBack.GetComponent<Transform>();
        backgroundPos.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        totalBack.transform.Translate(-speed * Time.deltaTime, 0, 0);
        //BackGroundSpawner();

        if (backgroundPos.position.x < -12)
        {
            Instantiate(totalBack, new Vector3(0, 0, 1), Quaternion.identity);
            Destroy(totalBack);
        }
    }

    void BackGroundSpawner()
    {
        if(backgroundPos.position.x < -12)
        {
            Instantiate(totalBack, new Vector3(0,0,1), Quaternion.identity);
            Destroy(totalBack);
        }
    }


}
