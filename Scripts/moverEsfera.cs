using UnityEngine;

public class moverEsfera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 mover;
    void Start()
    {
        mover = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        mover.x = 0.2f;
        if (transform.position.x >= 6.60f || transform.position.x <= -2) {
            mover.x = -0.2f; 
        }
        transform.Translate(mover);
    }
}
