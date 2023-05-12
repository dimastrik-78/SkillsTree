using System;

namespace SkillsTree
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            IComponent skill1 = new CompositeSkill("Передвижение", "Позволяет игроку передвигаться", true);
            IComponent skill2 = new CompositeSkill("Второе оружие", "Позволяет игроку иметь два оружия", false);
            IComponent skill3 = new LeafSkill("Быстрая рука", "Позволяет наносить удары оружием ближнего боя, когда в руках основное/вторичное оружие", false);
            IComponent skill4 = new CompositeSkill("Паркур", "Прыжки меньше тратят энегрию", false);
            IComponent skill5 = new LeafSkill("Мастер на все руки", "Починка генератора проиходит тище", false);
            IComponent skill6 = new LeafSkill("Кошачий глаз", "Вы видите маньяка, когда он делает действие", false);
            
            skill1.Add(skill2);
            skill1.Add(skill4);
            skill2.Add(skill3);
            skill2.Add(skill5);
            skill4.Add(skill6);

            skill1.Print();
            Console.WriteLine("После изучений скиллов");
            skill2.Research();
            skill3.Research();
            skill1.Research();
            skill1.Print();
        }
    }
}