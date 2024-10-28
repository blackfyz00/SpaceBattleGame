namespace SpaceBattle.Lib;

public interface IMoving
{
    int[] Position { get; set; }
    int[] Velocity { get; }
}

public interface ICommand
{
    public void Execute();
}

public class MoveCommand : ICommand
{
    private readonly IMoving obj;
    public MoveCommand(IMoving obj)
    {
        this.obj = obj;
    }
    public void Execute()
    {
        obj.Position = new int[]{
            obj.Position[0] + obj.Velocity[0],
            obj.Position[1] + obj.Velocity[1],
        };
    }
}
