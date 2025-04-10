using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody cilindro;
    public float velocidade = 2;
 

    void Update()
    {
       
        cilindro.linearVelocity = Vector3.right * Input.GetAxis("Horizontal") * velocidade;
        
    }
}
