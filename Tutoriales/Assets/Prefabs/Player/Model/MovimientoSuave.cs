using UnityEngine;

//Estrategia de movimiento lateral suave para el jugador
public class MovimientoSuave : IMovementStrategy
{
    //Metodo q implementa el movimiento suave
    public void Move(Transform transform, Player player)
    {
        //Se detecta las teclas A/D
        float moverEnX = Input.GetAxis("Horizontal") * player.Velocidad * Time.deltaTime;
        //Se traslada el transform en el eje X, generando un movimiento lineal sin acelracion
        transform.Translate(moverEnX, 0 , 0);
    }
}
