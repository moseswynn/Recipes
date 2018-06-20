namespace Recipes.Models
{
    public class Instruction
    {
        //PK for instruction table
        public int InstructionId { get; set; }
        //Instruction index in recipe
        public int InstructionIndex { get; set; }
        //Instruction text
        public string InstructionText { get; set; }

    }
}