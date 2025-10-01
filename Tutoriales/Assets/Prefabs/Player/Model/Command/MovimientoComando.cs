using UnityEngine;

public class MovimientoComando : ICommand
{
    private readonly PlayerMovement playerMovement;
    private readonly float input;
    
    public MovimientoComando(PlayerMovement playerMovement, float input)
    {
        this.playerMovement = playerMovement;
        this.input = input;
    }
    public void Execute()
    {
        playerMovement.SetMovementStrategy(new MovimientoSuave());
        playerMovement.MoverJugador(input);
    }
}
