using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingLineTest : MonoBehaviour
{

    private EdgeCollider2D _edgeCollider;
    private LineRenderer _lineRenderer;

    public Vector2 MousePosition;

    List<Vector3> _linePositions = new List<Vector3>();
    List<Vector2> _edgePositions = new List<Vector2>();


    Vector3 _currentMousePos;
    void Start()
    {
        _edgeCollider = GetComponent<EdgeCollider2D>();
        _lineRenderer = GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Drawing();
        }
    }

    public void Drawing()
    {
        _currentMousePos = Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _linePositions.Add(MousePosition);
        _lineRenderer.positionCount = _linePositions.Count;
        _lineRenderer.SetPositions(_linePositions.ToArray());
        _edgePositions.Add(MousePosition);
        _edgeCollider.points = _edgePositions.ToArray();
    }
}
