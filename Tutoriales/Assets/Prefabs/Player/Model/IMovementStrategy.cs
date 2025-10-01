using UnityEngine;

public interface IMovementStrategy
{
    //M�todo que cada estrategia debe implementar
    public void Move(Transform transform, Player player, float direccion);
}
