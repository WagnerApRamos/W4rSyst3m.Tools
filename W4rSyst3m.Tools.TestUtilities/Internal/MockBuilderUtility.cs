#region Using

using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using W4rSyst3m.Tools.Utilities;

#endregion

namespace W4rSyst3m.Tools.TestUtilities
{
    internal static class MockBuilderUtility
    {
        public static ConstructorInfo CreateContainer<T>(
            IDictionary<Type, Mock> container,
            params KeyValuePair<Type, Mock>[] mocks)
        {
            var constructor = GetConstructor<T>();

            BuildMocks(container, constructor.GetParameters(), mocks);

            return constructor;
        }

        public static void BuildMocks(IDictionary<Type, Mock> container, ParameterInfo[] parameters, KeyValuePair<Type, Mock>[] mocks)
        {
            foreach (var parameter in parameters)
            {
                container.Add(parameter.ParameterType, GetMock(parameter, mocks));
            }
        }

        private static Mock GetMock(ParameterInfo parameter, KeyValuePair<Type, Mock>[] mocks)
        {
            Mock mock;
            return (mock = mocks.FirstOrDefault(m => m.Key == parameter.ParameterType).Value).IsNull() ?
                BuildMock(parameter.ParameterType) : mock;
        }

        private static Mock BuildMock(Type parameterType)
        {
            return (Mock)Activator.CreateInstance(
                typeof(Mock<>).MakeGenericType(parameterType));
        }

        public static ConstructorInfo GetConstructor<T>()
        {
            var constructor = typeof(T).GetConstructors()
                .OrderBy(c => c.GetParameters().Count())
                .LastOrDefault();

            if (constructor.IsNull())
            {
                throw new InvalidOperationException("There is no constructor for {0}".FormatAs(typeof(T).Name));
            }

            return constructor;
        }
    }
}
