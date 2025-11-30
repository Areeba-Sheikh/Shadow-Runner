using UnityEngine;

public class CollectableRotate : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 80f;

    void Update()
    {
        // Rotate the coin around the Y-axis every frame
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f, Space.World);
    }
}
