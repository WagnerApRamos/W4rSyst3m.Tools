#region Using

using System;

#endregion

namespace W4rSyst3m.Tools.TestUtilities.Common.Creators
{
    public abstract class BaseCreator<T>
    {
        protected T _entity;
        public BaseCreator()
        {
            _entity = DataGenerator.Generate<T>();
        }

        public BaseCreator<T> With(Action<T> with)
        {
            with(_entity);
            return this;
        }

        public T Create()
        {
            return _entity;
        }
    }
}
