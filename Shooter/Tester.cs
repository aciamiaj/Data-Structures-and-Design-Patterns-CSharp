Console.WriteLine("Student Name: Jaimaica Daisy Eugenio");
Console.WriteLine("Humber ID: N01516797\n");

//create factory
ShooterModelFactory shooterModelFactory = ShooterModelFactory.Instance;
IShooterModel shooterModel1 = shooterModelFactory.GetShooterModel("SpaceRanger");
IShooterModel shooterModel2 = shooterModelFactory.GetShooterModel("Commando");
IShooterModel shooterModel3 = shooterModelFactory.GetShooterModel("Samurai");

//create 10 shooter model
Shooter shooter1 = new Shooter(shooterModel1, 001);
Shooter shooter2 = new Shooter(shooterModel2, 002);
Shooter shooter3 = new Shooter(shooterModel3, 003);
Shooter shooter4 = new Shooter(shooterModel1, 004);
Shooter shooter5 = new Shooter(shooterModel2, 005);
Shooter shooter6 = new Shooter(shooterModel3, 006);
Shooter shooter7 = new Shooter(shooterModel1, 007);
Shooter shooter8 = new Shooter(shooterModel2, 008);
Shooter shooter9 = new Shooter(shooterModel3, 009);
Shooter shooter10 = new Shooter(shooterModel1, 010);

//print id, shooter and skin and texture
Spawn();

void Spawn()
{
    Console.WriteLine(shooter1 + "\n" + shooter2 + "\n" + shooter3
        + "\n" + shooter4 + "\n" + shooter5 + "\n" + shooter6 + "\n" 
        + shooter7 + "\n" + shooter8 + "\n" + shooter9
        + "\n" + shooter10);
}