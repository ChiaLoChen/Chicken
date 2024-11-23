public class SpawnKey : Command
{
    private ChickenSpawn chickenSpawn;

    public SpawnKey(ChickenSpawn chicken)
    {
        chickenSpawn = chicken;
    }

    public override void Execute()
    {
        chickenSpawn.SpawnChicken();
    }
}
