namespace Azon.Web.Sdk.Contracts
{
    public interface IDataBasePersistence
        : IPersistence
    {
        string ConnectionString { get; set; }
        string UserName { get; set; }
    }
}
