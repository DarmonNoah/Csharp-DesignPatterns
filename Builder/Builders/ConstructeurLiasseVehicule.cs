// Builders/ConstructeurLiasseVehicule.cs
public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public abstract void ConstruitBonDeCommande(string nomClient);
    public abstract void ConstruitDemandeImmatriculation(string nomClient);

    public Liasse ObtenirLiasse()
    {
        return liasse;
    }
}