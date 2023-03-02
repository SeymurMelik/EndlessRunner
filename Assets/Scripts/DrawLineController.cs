using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineController : MonoBehaviour
{
    //arrow function
    private EdgeCollider2D _edgeCollider { get => GetComponent<EdgeCollider2D>(); }
    private LineRenderer _lineRenderer { get => GetComponent<LineRenderer>(); }

    public Vector2 StartPosition;
    public Vector2 MousePosition;

    List<Vector3> _linepositions = new List<Vector3>();
    List<Vector2> _edgepositions = new List<Vector2>();

    Vector3 _currentMousePosition;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Draw();
        }
    }

    public void Draw()
    {
        _currentMousePosition = Input.mousePosition;
        MousePosition = Camera.main.ScreenToWorldPoint(_currentMousePosition);
        _linepositions.Add(MousePosition);
        _lineRenderer.positionCount = _linepositions.Count;
        _lineRenderer.SetPositions(_linepositions.ToArray());
        _edgepositions.Add(MousePosition);
        _edgeCollider.points = _edgepositions.ToArray();

    }
}
