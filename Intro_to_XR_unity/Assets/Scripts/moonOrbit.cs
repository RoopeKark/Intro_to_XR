using UnityEngine;

public class moonOrbit : MonoBehaviour
{
    public float degreesPerSecond = 3.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
    }
}
