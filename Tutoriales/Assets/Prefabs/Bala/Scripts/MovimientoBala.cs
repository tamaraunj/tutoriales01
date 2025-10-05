using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    private float limiteEnX = 15f;
    private float velocidadBala = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Mover la bala en el eje x con una velocidad determinada
        transform.Translate(velocidadBala * Time.deltaTime, 0 ,0);

        //Destruir la bala si se sale de la escena
        if (transform.position.x > limiteEnX || transform.position.x < -limiteEnX)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("La bala impactó al jugador");
            Destroy(gameObject);
            
        }
    }
}
