internal class ShooterModelFactory //create factory
{
    private ShooterModelFactory()
    {
        //store _fireTeam
        _fireTeam = new Dictionary<string, ShooterModel>();
    }

    private static readonly ShooterModelFactory UniqueInstance = new ShooterModelFactory();

    public static ShooterModelFactory Instance { get { return UniqueInstance; } }

    Dictionary<string, ShooterModel> _fireTeam;

    //get shooter model by name
    internal IShooterModel GetShooterModel(string modelName)
    {
        if (!_fireTeam.ContainsKey(modelName))
            _fireTeam.Add(modelName, new ShooterModel(modelName));
        return _fireTeam[modelName];
    }

    //shootermodel implements ishootermodel
    private class ShooterModel : IShooterModel
    {
        public string Skin { get; }
        public string Mesh { get; }
        public string Strength { get; }
        public string Accuracy { get; }
        public string Damage { get; }

        public ShooterModel(string modelName)
        {
            //display output if modelname = spaceranger, commando, samurai
            if (modelName == "SpaceRanger")
            {
                Skin = "SpaceRanger_Skin";
                Mesh = "SpaceRanger_Mesh";
                Strength = "SpaceRanger_Strength";
                Accuracy = "SpaceRanger_Accuracy";
                Damage = "SpaceRanger_Damage";
            }

            else if (modelName == "Commando")
            {
                Skin = "Commando_Skin";
                Mesh = "Commando_Mesh";
                Strength = "Commando_Strength";
                Accuracy = "Commando_Accuracy";
                Damage = "Commando_Damage";
            }

            else if (modelName == "Samurai")
            {
                Skin = "Samurai_Skin";
                Mesh = "Samurai_Mesh";
                Strength = "Samurai_Strength";
                Accuracy = "Samurai_Accuracy";
                Damage = "Samurai_Damage";
            }

            else
            {
                Skin = "SpaceRanger_Skin";
                Mesh = "SpaceRanger_Mesh";
                Strength = "SpaceRanger_Strength";
                Accuracy = "SpaceRanger_Accuracy";
                Damage = "SpaceRanger_Damage";
            }
        }
    }
}
