#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;
using SimpleInjector.Extensions.LifetimeScoping;
using System;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Integration
{
    [TestClass]
    public abstract class IntegrationTestBuilder<T>
        where T : class
    {
        private Container _container;
        private Scope _scope;

        /// <summary>
        /// Subject under test
        /// </summary>
        protected T Sut { get; private set; }

        [TestInitialize]
        public virtual void Initialise()
        {
            _container = new Container();

            Register(_container, new LifetimeScopeLifestyle());

            _container.Verify();

            Sut = GetInstance<T>();
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            _scope.Dispose();
        }

        protected virtual void Register(Container container, Lifestyle lifeStyle)
        {
            _container.Register<T>(lifeStyle);
        }

        /// <summary>
        /// Get a new instance of TClass
        /// </summary>
        /// <typeparam name="TClass">a type that have to be a class</typeparam>
        /// <returns>returns a new instance of TClass</returns>
        protected TClass GetInstance<TClass>()
            where TClass : class
        {
            return _container.GetInstance<TClass>();
        }
    }
}
