using UnityEngine;

public class MovimientoSuave : IMovementStrategy
{
    public void Move(Transform transform, Player player)
    {
        float moverEnX = Input.GetAxis("Horizontal") * player.Velocidad * Time.deltaTime;
        transform.Translate(moverEnX, 0 , 0);
    }
}
