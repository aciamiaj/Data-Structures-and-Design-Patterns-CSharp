internal class Shooter
{
    private IShooterModel shooterModel;
    private int id;
    private int v1;
    private string v2;
    private string v3;
    private string v4;
    private string v5;
    private string v6;

    //initialize variables
    public Shooter(IShooterModel shooterModel, int id)
    {
        this.shooterModel = shooterModel;
        this.id = id;
    }

    public Shooter(int v1, string v2, string v3, string v4, string v5, string v6)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
        this.v5 = v5;
        this.v6 = v6;
    }

    //override string for the output
    public override string ToString()
    {
        return "ID: " + id + ", " + shooterModel.Skin + ", " + shooterModel.Mesh +
            ", " + shooterModel.Strength + ", " + shooterModel.Accuracy + ", " 
            + shooterModel.Damage;
    }
}