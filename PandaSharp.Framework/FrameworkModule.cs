using PandaSharp.Framework.IoC.Contract;
using PandaSharp.Framework.Rest.Common;
using PandaSharp.Framework.Rest.Contract;
using PandaSharp.Framework.Services.Aspect;
using RestSharp.Serializers;

namespace PandaSharp.Framework
{
    internal sealed class FrameworkModule : IPandaContainerModule
    {
        public void RegisterModule(IPandaContainer container)
        {
            container.RegisterType<IRequestParameterAspectFactory, RequestParameterAspectFactory>();            
            container.RegisterSingletonType<IRestSerializer>(() => JsonRestSerializer.Default);
            container.RegisterSingletonType<IRestFactory, RestFactory>();
            container.RegisterSingletonType<IRestResponseConverterFactory, RestResponseConverterFactory>();
        }
    }
}
