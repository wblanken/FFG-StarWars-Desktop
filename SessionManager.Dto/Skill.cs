﻿using System;

namespace SessionManager.Dto
{
   [Serializable]
   public class Skill
   {
      public string Name { get; set; }
      public string CharacteristicName { get; set; }
      public int CharacteristicValue { get; set; }
      public bool Career { get; set; }
      public int Rank { get; set; }
   }
}