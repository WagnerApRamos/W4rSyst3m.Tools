#region Using

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Language.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

#endregion

namespace W4rSyst3m.Tools.TestUtilities
{
    [TestClass]
    public abstract class AutoMockBuilder<T>
        where T : class
    {
        protected T Sut { get; private set; }

        private Dictionary<Type, Mock> _container;

        [TestInitialize]
        public virtual void Setup()
        {
            BuildMocks();
        }

        protected void BuildMocks(params KeyValuePair<Type, Mock>[] mocks)
        {
            _container = new Dictionary<Type, Mock>();

            var constructor = MockBuilderUtility.CreateContainer<T>(_container, mocks);

            Sut = (T)constructor.Invoke(_container.Values.Select(v => v.Object).ToArray());
        }

        public void Verify<TMock>(Expression<Action<TMock>> setup, Times times)
            where TMock: class
        {
            GetMock<TMock>().Verify(setup, times);
        }

        public Mock<TMock> GetMock<TMock>()
            where TMock : class
        {
            return (Mock<TMock>)_container[typeof(TMock)];
        }

        public void Returns<TMock, TResult>(Expression<Func<TMock, TResult>> setup, TResult result)
            where TMock : class
        {
            Setup(setup).Returns(result);
        }
        protected ISetup<TMock, TResult> Setup<TMock, TResult>(Expression<Func<TMock, TResult>> setup)
            where TMock : class
        {
            return GetMock<TMock>().Setup(setup);
        }

    }
}
