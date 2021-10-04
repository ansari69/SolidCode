using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IDatabaseManager
    {
        void Add();
        void Remove(int id);
        void Persisit();
    }

    public interface IDbBatchOperations : IDatabaseManager
    {
        void RemoveBatch(params int[] ids);
    }

    class Test1 : IDatabaseManager
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Persisit()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }


    class Test2 : IDbBatchOperations
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Persisit()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveBatch(params int[] ids)
        {
            throw new NotImplementedException();
        }
    }


}
