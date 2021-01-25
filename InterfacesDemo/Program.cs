using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
            new Manager(),
            new Worker(),
            new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2] {
                new Worker(),
                new Manager
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    interface IWorker
    {
        void Work();
        void Eat();
        void GetSalary();
    }

    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    interface IWork
    {
        void Work();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWork
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
