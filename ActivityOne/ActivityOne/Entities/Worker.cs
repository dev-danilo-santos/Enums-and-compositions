using ActivityOne.Entities.Enums;

namespace ActivityOne.Entities
{
    class Worker
    {
        public string Name { get; private set;}
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level} and Base Salary {BaseSalary}";
        }




    }
}
