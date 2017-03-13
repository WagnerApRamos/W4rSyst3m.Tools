#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using SimpleInjector;
using System.Collections.Generic;
using W4rSyst3m.Tools.TestUtilities.Common;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Integration.Context
{
    [TestClass]
    public abstract class IntegrationTestBuilder<T, C> : IntegrationTestBuilder<T>
        where T : class
        where C : DbContext
    {
        [TestCleanup]
        public override void Cleanup()
        {
            ContextManager.Restore();
            base.Cleanup();
        }

        protected override void Register(Container container, Lifestyle lifeStyle)
        {
            base.Register(container, lifeStyle);
            container.Register<DbContextManager<C>>(lifeStyle);
            container.Register<C>(lifeStyle);
        }

        public void AddToContext<TEntity>(TEntity entity)
            where TEntity : class
        {
            ContextManager.Add(entity);
            SaveAllChanges();
        }

        public void AddToContext<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : class
        {
            ContextManager.Add(entities);
            SaveAllChanges();
        }

        public void SaveAllChanges()
        {
            ContextManager.SaveContext();
        }

        protected DbContextManager<C> ContextManager { get { return GetInstance<DbContextManager<C>>(); } }

    }
}
