using UnityEngine;

public class MovimientoAceleradoComando : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;

    public MovimientoAceleradoComando(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }

    public void Execute()
    {
        playerMovement.SetMovementStrategy(new MovimientoAcelerado());
        playerMovement.MoverJugador(input); 
    }
}
