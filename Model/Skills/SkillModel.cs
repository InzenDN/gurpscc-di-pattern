using System;
using System.Collections.Generic;

namespace GurpsCC.Model.Skills
{
    public class SkillModel : IModel
    {
        public string Name { get; }
        public EDifficulty Difficulty { get; }
        public EStatAttribute Attribute { get; }
        public List<SkillModel> Prerequisite { get; }
        public string Description { get; }
        public int BaseModifier { get; }

        public SkillModel(
            string name,
            EStatAttribute attributeType,
            EDifficulty difficulty,
            string description,
            List<SkillModel> prerequisite = null)
        {
            this.Name = name;
            this.Difficulty = difficulty;
            this.Attribute = attributeType;
            this.Prerequisite = prerequisite;
            this.Description = description;
            this.BaseModifier = SetModifier(difficulty);
        }        

        private int SetModifier(EDifficulty difficulty)
        {
            switch (difficulty)
            {
                case EDifficulty.Easy:
                    return -1;
                case EDifficulty.Average:
                    return -2;
                case EDifficulty.Hard:
                    return -3;
                default:
                    throw new ArgumentException("Invalid difficulty");
            }
        }
    }
}
