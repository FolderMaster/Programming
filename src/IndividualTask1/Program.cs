using IndividualTask1;

List<Armour> equipment = new List<Armour>()
{
    new Armour("Шлем", ArmourType.Helmet, 10),
    new Armour("Поножи", ArmourType.LegArmor, 30),
    new Armour("Перчатки", ArmourType.Gloves, 5),
    new Armour("Кольчуга", ArmourType.LegArmor, 15)
};

Warior warior = new Warior("Олег", 20, 5, equipment);
warior.ShowInfo();