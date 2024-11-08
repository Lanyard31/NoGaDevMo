using UnityEngine;

public class RandomRotation : MonoBehaviour
{
    [Tooltip("Enable or disable random Y rotation on this enemy")]
    public bool enableRandomRotation = true;

    void Start()
    {
        if (enableRandomRotation)
        {
            float randomYRotation = Random.Range(0f, 360f);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, randomYRotation, transform.rotation.eulerAngles.z);
        }
    }
}
