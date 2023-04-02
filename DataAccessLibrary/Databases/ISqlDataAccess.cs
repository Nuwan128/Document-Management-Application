namespace DataAccessLibrary.Databases
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatment, U parameter, string connectionStringName, bool isStoredProceduer = false);
        void SaveData<T>(string sqlStatment, T parameter, string connectionStringName, bool isStoredProceduer = false);
    }
}