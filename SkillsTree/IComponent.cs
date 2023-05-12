namespace SkillsTree
{
    public interface IComponent
    {
        bool Explored { get; set; }
        string Description { get; set; }
        string Name { get; set; }

        void Add(IComponent component);
        void Research();
        void Print();
    }
}