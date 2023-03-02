using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    private LineRenderer lineRenderer;
    public Vector2 Circle;
    public Vector2 Cubea;
    //int mouseClicked;

    //public GameObject cube;


    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //mouseClicked = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Circle = gameObject.transform.position;
        Cube();
    }

    public void Follower()
    {
        Vector2 circle = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = circle;
    }

    public void Clicked()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    mouseClicked++;
        //    if (mouseClicked == 1)
        //    {
        //        Vector2 circleOne = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //        lineRenderer.SetPosition(0, circleOne);
        //    }
        //    else if (mouseClicked == 2)
        //    {
        //        Vector2 circleTwo = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //        lineRenderer.SetPosition(1, circleTwo);
        //    }
        //}
    }

    public void Cube()
    {
        //transform.position = Vector2.Lerp(transform.position, cube.transform.position, Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cube")
        {
            lineRenderer.SetPosition(0, Circle);
            lineRenderer.SetPosition(1, Cubea);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Cube")
        {
            lineRenderer.SetPosition(0, Vector3.zero);
            lineRenderer.SetPosition(1, Vector3.zero);
        }
    }
}
