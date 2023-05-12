using System;

namespace SkillsTree
{
    public class LeafSkill : IComponent
    {
        public LeafSkill(string name, string description, bool explored)
        {
            Name = name;
            Description = description;
            Explored = explored;
        }
        
        public bool Explored { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        
        public void Add(IComponent component)
        {
            
        }
        
        public void Research()
        {
            if (Explored)
            {
                Console.WriteLine("Скилл уже изучен");
                return;
            }
            
            Explored = true;
            Console.WriteLine("Скилл изучен");
        }

        public void Print()
        {
            Console.WriteLine($"--------------------------------------\n" +
                              $"| Скилл: {Name} |\n" +
                              $"| Описание: {Description} |\n" +
                              $"| Состояние: {Explored} |\n" +
                              $"--------------------------------------\n");
        }
    }
}