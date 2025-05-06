using UnityEngine;

public class приколысдеревом : MonoBehaviour
{

    public float offset = 0;
    private int sortingOrderBase = 0; 
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);
    }
}
