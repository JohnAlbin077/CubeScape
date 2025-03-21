using UnityEngine;

public class AnimationController : MonoBehaviour
{



    Vector3 target;
    float speed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetNewTarget(new Vector3(
            transform.position.x + 10,
            transform.position.y,
            transform.position.z + 10
        ));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    void SetNewTarget(Vector3 newTarget)
    {
        target = newTarget;
        transform.LookAt(target);
    }
}
