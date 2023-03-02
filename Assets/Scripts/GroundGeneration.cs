using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    public GameObject NextGeneration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            NextGeneration=Instantiate(NextGeneration,new Vector3(NextGeneration.transform.position.x+ 20,NextGeneration.transform.position.y,NextGeneration.transform.position.z), Quaternion.identity);

        }
    }
}
