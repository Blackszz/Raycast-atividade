using UnityEngine;

public class Raycast : MonoBehaviour
{
    Ray raio;
    RaycastHit hit;
    public Camera tela;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            raio = Camera.main.ScreenPointToRay(Input.mousePosition);
            hitou(raio);
        }

        void hitou (Ray ray)
        {
            if(Physics.Raycast(ray, out hit))
            {
                GameObject esfera = hit.transform.gameObject;
                Destroy(esfera);
            }
        }
    }
}
