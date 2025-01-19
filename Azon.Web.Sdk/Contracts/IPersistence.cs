using Azon.Web.Sdk.Components;

namespace Azon.Web.Sdk.Contracts
{
    /*
    public interface IPersistence<T>    // generic yapmak için T görülen yerlere seçilen tip gelir. // BU T türü için ksıst olabilir. (generic constraints)
                                        // where T : class, new()          // T bir sınıf olmalı ve default constructor içermeli.        
        where T : Control
    {
        void Save(List<T> controls);
    }
    */

    public interface IPersistence
    {
        void Save(List<Control> controls);
    }
}
