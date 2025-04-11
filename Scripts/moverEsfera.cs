using UnityEngine;

public class moverEsfera : MonoBehaviour
{
    public Transform[] patrulhaPontos;
    public float velocidade = 3f;
    public float distancia = 0.2f;

    private int currentPointIndex = 0;

    void Update()
    {
        if (patrulhaPontos.Length == 0) return;

        Transform targetPoint = patrulhaPontos[currentPointIndex];


        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, velocidade * Time.deltaTime);


        if (Vector3.Distance(transform.position, targetPoint.position) < distancia)
        {
            currentPointIndex++;
            if (currentPointIndex >= patrulhaPontos.Length)
            {
                currentPointIndex = 0;
            }
        }


        Vector3 direction = (targetPoint.position - transform.position).normalized;
        if (direction != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 5f);
        }
    }
}