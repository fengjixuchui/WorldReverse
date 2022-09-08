/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class CrowdGroupInfo // TypeDefIndex: 20376
	{
		// Fields
		public int crowdGroupID; // 0x10
		public Bounds groupBound; // 0x14
		public int cutsceneID; // 0x2C
		public bool spawnByDefault; // 0x30
		public bool ignoreLowPerfMode; // 0x31
		protected ConfigCrowdRestrictionGroup[] restrictionConfigs; // 0x38
	
		// Constructors
		public CrowdGroupInfo() {} // Dummy constructor
		public CrowdGroupInfo(ConfigCrowdGroupInfo initConfig) {} // 0x0000000184D780E0-0x0000000184D78280
	
		// Methods
		// [XID] // 0x00000001896AA550-0x00000001896AA570
		protected bool IsMeetQuestRestriction(ConfigCrowdQuestRestriction[] questRestrictions) => default; // 0x0000000184D77CD0-0x0000000184D77ED0
		// [XID] // 0x00000001896B1450-0x00000001896B1470
		protected bool IsMeetActivityRestriction(ConfigCrowdActivityRestriction[] activityRestrictions) => default; // 0x0000000184D77ED0-0x0000000184D780E0
		// [XID] // 0x00000001896B8EF0-0x00000001896B8F10
		protected bool IsMeetTimeRestriction(ConfigCrowdTimeRestriction[] timeRestrictions) => default; // 0x0000000184D778C0-0x0000000184D77AF0
		// [XID] // 0x00000001896C0230-0x00000001896C0250
		protected bool IsMeetSceneTagRestriction(ConfigCrowdSceneTagRestriction[] sceneTagRestrictions) => default; // 0x0000000184D77680-0x0000000184D778C0
		// [XID] // 0x00000001896C79F0-0x00000001896C7A10
		public bool IsMeetSpawnRestriction(bool lowPerfMode) => default; // 0x0000000184D77AF0-0x0000000184D77CD0
	}
}
