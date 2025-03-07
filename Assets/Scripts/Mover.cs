using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0;
    [SerializeField] float yValue = 0.001f;
    float zValue = 0;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);
    }
}
