namespace SessionManager.Dto
{
   public class Skill
   {
      public string Name { get; set; }
      public Characteristic Characteristic { get; set; }
      public bool Career { get; set; }
      public int Rank { get; set; }

      public string CharacteristicName => Utility.GetSkillCharacteristicName(Characteristic);
   }
}