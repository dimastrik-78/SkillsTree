using System;
using System.Collections.Generic;

namespace SkillsTree
{
    public class CompositeSkill : IComponent
    {
        private List<IComponent> _components = new List<IComponent>();

        public CompositeSkill(string name, string description, bool explored)
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
            _components.Add(component);
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
                              $"--------------------------------------");
            
            if (_components.Count > 0)
            {
                Console.WriteLine($"После '{Name}' идут скиллы: ");
                for (int i = 0; i < _components.Count; i++)
                {
                    Console.WriteLine(i + 1);
                    _components[i].Print();
                }
            }
        }
    }
}