using UnityEngine;

abstract public class OncomingVehicles : MonoBehaviour
{
    public virtual float Speed { get; }

    protected void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector3.back);
    }
}
