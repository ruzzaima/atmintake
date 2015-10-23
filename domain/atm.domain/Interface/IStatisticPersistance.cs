namespace SevenH.MMCSB.Atm.Domain
{
    public interface IStatisticPersistance
    {
        int Count(int acquisitionid, string[] birthstatecode, string gendercode, string highleveleducode, string racecode, string ethniccode, string religioncode);
    }
}
