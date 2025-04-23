using UnityEngine;

public class BobbleEffect : MonoBehaviour
{
    public float amplitude = 0.1f; // how high it bobs
    public float frequency = 1f;   // how fast it bobs

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.localPosition = startPos + new Vector3(0, y, 0);
    }
}
