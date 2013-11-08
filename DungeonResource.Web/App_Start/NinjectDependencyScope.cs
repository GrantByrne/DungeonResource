using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;
using System.Collections.Generic;

namespace DungeonResource.Web.App_Start
{
    /// <summary>
    /// Provides a Ninject implementation of the IDependencyScope, 
    /// which resolves services using the Ninject container
    /// </summary>
    public class NinjectDependencyScope : IDependencyScope
    {
        private IResolutionRoot _resolver;

        /// <summary>
        /// ctor
        /// </summary>
        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            _resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            if(_resolver == null)
            {
                throw new ObjectDisposedException("this", "This scope have been disposed");
            }
            return _resolver.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (_resolver == null)
            {
                throw new ObjectDisposedException("this", "This scope have been disposed");
            }

            return _resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            IDisposable disposable = _resolver as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            _resolver = null;
        }
    }
}