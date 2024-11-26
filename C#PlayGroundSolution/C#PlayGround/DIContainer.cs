using Microsoft.Extensions.DependencyInjection;

namespace PlayGround
{
    public class DIContainer
    {
        private static DIContainer _instance = null;
        public static DIContainer Instance
        {
            get {
                if(_instance is null)
                {
                    _instance = new DIContainer();
                }
                return _instance;
            }
            private set {}
        }
        private DIContainer() { }

        public ServiceCollection GetDIContainer()
        {
            ServiceCollection myServiceCollection = new ServiceCollection();
            return myServiceCollection;
        }
    }
}