﻿using System;
using System.Collections.Generic;

namespace SessionManager.Data.Model
{
   public class Character
   {
      // General Info
      public string Name { get; set;}
      public string Species { get; set;}
      public string Specializations { get; set;}
      public string PlayerName { get; set;}
      public string Career { get; set;}
      public string Gender { get; set;}
      public string Campaign { get; set;}

      // Characteristics
      public int Brawn { get; set; }
      public int Agility { get; set; }
      public int Intellect { get; set; }
      public int Cunning { get; set; }
      public int Willpower { get; set; }
      public int Presence { get; set; }

      // Attributes
      public int Soak { get; set; }
      public int WoundsThreshold { get; set; }
      public int Wounds { get; set; }
      public int StrainThreshold { get; set; }
      public int Strain { get; set; }
      public int RangedDefense { get; set; }
      public int MeleeDefense { get; set; }
      public int ForceRating { get; set; }

      // Obligation, Duty, Morality

      // Skills
      public List<Skill> GeneralSkills { get; set; }
      public List<Skill> CombatSkills { get; set; }
      public List<Skill> KnowledgeSkills { get; set; }
      
      // Talents

      // Inventory

      // FileInfo
      public string FileName { get; set; }
      public Guid Id { get; set; }
      public DateTime LastModified { get; set; }
   }
}
