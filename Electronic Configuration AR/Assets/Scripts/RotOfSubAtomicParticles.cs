using UnityEngine;

public class RotOfSubAtomicParticles : MonoBehaviour
{
    public Vector3 rotSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotSpeed * Time.deltaTime);
    }
}
