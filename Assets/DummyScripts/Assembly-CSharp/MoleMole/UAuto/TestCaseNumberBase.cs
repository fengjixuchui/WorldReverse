/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.UAuto
{
	public sealed class TestCaseNumberBase : TestCaseBase // TypeDefIndex: 28264
	{
		// Fields
		private static HashSet<string> logHash; // 0x00
		private static StringBuilder affixLog; // 0x08
		private static Application.LogCallback logCallback; // 0x10
		public static ActionAttackResult resultAction; // 0x18
		public static ActionHpResult hpAction; // 0x20
		public const string COMBAT_URL = "http://hk4e-uspider.mihoyo.com:58790/"; // Metadata: 0x00B0D54D
		private CombatCaseInfo _combatCaseInfo; // 0x198
		private float hpBase; // 0x1A0
		public Dictionary<EquipType, ReliquaryItem> equipedReliquery; // 0x1A8
		private Dictionary<FightPropType, float> reliquerySetDic; // 0x1B0
		private Dictionary<FightPropType, float> reliqueryOldSetDic; // 0x1B8
	
		// Nested types
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionAttackResult(AttackResult ret); // TypeDefIndex: 28265; 0x0000000181CC0890-0x0000000181CC0AF0
	
		[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
		public delegate void ActionHpResult(EvtCure ret); // TypeDefIndex: 28266; 0x0000000181CC0C80-0x0000000181CC0EE0
	
		public class CombatData // TypeDefIndex: 28267
		{
			// Fields
			public int element; // 0x10
			public int breakLv; // 0x14
			public int talentLv; // 0x18
			public string paramName; // 0x20
			public float paramValue; // 0x28
	
			// Constructors
			public CombatData() {} // 0x0000000181CC0FF0-0x0000000181CC1050
		}
	
		public class CombatCaseInfo // TypeDefIndex: 28268
		{
			// Fields
			public int testType; // 0x10
			public int testId; // 0x14
			public string branch; // 0x18
			public string description; // 0x20
			public string combatLogUrl; // 0x28
			public int time; // 0x30
			public int result; // 0x34
			public List<CombatData> combatData; // 0x38
			public string gameVersion; // 0x40
	
			// Constructors
			public CombatCaseInfo() {} // 0x0000000181CC0F60-0x0000000181CC0FF0
		}
	
		// Constructors
		public TestCaseNumberBase() {} // 0x0000000181CCC190-0x0000000181CCC2A0
		static TestCaseNumberBase() {} // 0x0000000181CCC0A0-0x0000000181CCC190
	
		// Methods
		public float GetAvatarWeaponData(FightPropType type, uint runtimeID = 0 /* Metadata: 0x00B0D505 */) => default; // 0x0000000181CC8950-0x0000000181CC8B00
		public BaseEntity GetEntity(uint runtimeID) => default; // 0x0000000181CC8D10-0x0000000181CC8DF0
		public int GetIntPropertyValue(string name, uint runtimeID = 0 /* Metadata: 0x00B0D509 */) => default; // 0x0000000181CC9350-0x0000000181CC9420
		public float GetFloatPropertyValue(string name, uint runtimeID = 0 /* Metadata: 0x00B0D50D */) => default; // 0x0000000181CC9270-0x0000000181CC9350
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitIntProperty(string name, int value, uint runtimeID = 0 /* Metadata: 0x00B0D511 */) => default; // 0x0000000181CCBFB0-0x0000000181CCC0A0
		public void CheckAvatarMaxHPByLevel(int promoteLevel, int level, float checkValue, uint runtimeID = 0 /* Metadata: 0x00B0D515 */, uint proudId = 0 /* Metadata: 0x00B0D519 */) {} // 0x0000000181CC2BB0-0x0000000181CC3320
		public bool CheckAvatarAttackByLevel(int promoteLevel, int level, float checkValue, uint runtimeID = 0 /* Metadata: 0x00B0D51D */, uint proudId = 0 /* Metadata: 0x00B0D521 */) => default; // 0x0000000181CC1B80-0x0000000181CC22F0
		public bool CheckAvatarDefenseByLevel(int promoteLevel, int level, float checkValue, uint runtimeID = 0 /* Metadata: 0x00B0D525 */) => default; // 0x0000000181CC24D0-0x0000000181CC2BB0
		public bool CheckAvatarWeaponByLevel(int promoteLevel, int level, float checkValue, uint weaponId, FightPropType type) => default; // 0x0000000181CC36F0-0x0000000181CC3FD0
		public WeaponProperty GetWeaponProperty(WeaponExcelConfig config, FightPropType type) => default; // 0x0000000181CCAC00-0x0000000181CCACF0
		public CombatProperty GetAvatarCombatProperty() => default; // 0x0000000181CC8750-0x0000000181CC8820
		public CombatProperty GetMonsterCombatProperty(BaseEntity monster) => default; // 0x0000000181CC9420-0x0000000181CC94B0
		public float GetAvatarAbilityStateValue(string key) => default; // 0x0000000181CC8590-0x0000000181CC8750
		public uint GetWeaponUnlockMaxLevel(uint weaponId, uint promoteLevel) => default; // 0x0000000181CCACF0-0x0000000181CCADC0
		public void StartAbilityLog() {} // 0x0000000181CCBA00-0x0000000181CCBB20
		public static void LogMultiThreadCallback(string condition, string stackTrace, LogType type) {} // 0x0000000181CCB090-0x0000000181CCB210
		private static void DoBattleRecordAction(BaseEvent evt, int step) {} // 0x0000000181CC8000-0x0000000181CC8590
		public void RegistBattleResult(ActionAttackResult action, ActionHpResult hpAction = null) {} // 0x0000000181CCB2E0-0x0000000181CCB5A0
		public void UnRegistBattleResult() {} // 0x0000000181CCBC10-0x0000000181CCBDC0
		private static void LogStaticCheckAbility(string log) {} // 0x0000000181CCB210-0x0000000181CCB2E0
		public void LogCheckAbility(string log) {} // 0x0000000181CCAFC0-0x0000000181CCB090
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator UploadAbilityLog(string fileName) => default; // 0x0000000181CCBDC0-0x0000000181CCBE90
		public EquipAffixExcelConfig GetWeaponAffixItem(uint weaponId, uint lv) => default; // 0x0000000181CCA570-0x0000000181CCA680
		public List<uint> GetWeaponId(uint avatarId) => default; // 0x0000000181CCA680-0x0000000181CCA990
		public WeaponItem GetAvatarWeapon() => default; // 0x0000000181CC8B00-0x0000000181CC8C50
		public bool CheckAvatarWeapon() => default; // 0x0000000181CC4230-0x0000000181CC43E0
		public bool CheckAbilityName(uint weaponId, uint lv) => default; // 0x0000000181CC1260-0x0000000181CC1B80
		public void InitCombatDataCollect(int testType, int testId) {} // 0x0000000181CCADC0-0x0000000181CCAFC0
		public void AppendCombatData(ElementType element, string paramName, float paramValue, int talentLv = 0 /* Metadata: 0x00B0D529 */, int breakLv = 0 /* Metadata: 0x00B0D52D */) {} // 0x0000000181CC11A0-0x0000000181CC1260
		public void AppendCombatData(int element, string paramName, float paramValue, int talentLv, int breakLv) {} // 0x0000000181CC1050-0x0000000181CC11A0
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator SubmitCombatData(string url, bool result) => default; // 0x0000000181CCBB20-0x0000000181CCBC10
		public float GetWeaponPromoteValue(uint promoteId, int promoteLevel, FightPropType type) => default; // 0x0000000181CCAAD0-0x0000000181CCAC00
		public float GetAvatarPromoteValue(int promoteLevel, FightPropType type, uint promoteId) => default; // 0x0000000181CC8820-0x0000000181CC8950
		public Dictionary<FightPropType, float> GetReliquaryAppendProp(EquipType type, uint runtimeID = 0 /* Metadata: 0x00B0D531 */) => default; // 0x0000000181CC99B0-0x0000000181CC9B60
		public void SetAvatarHpBase(float baseHP) {} // 0x0000000181CCB5A0-0x0000000181CCB670
		public Dictionary<FightPropType, float> GetReliquaryMainProp(EquipType type, uint runtimeID = 0 /* Metadata: 0x00B0D535 */) => default; // 0x0000000181CC9B60-0x0000000181CC9D60
		public void SetUpEquipedReliquery() {} // 0x0000000181CCB670-0x0000000181CCBA00
		public CombatProperty GetEntityCombatProperty(uint runtimeID) => default; // 0x0000000181CC8C50-0x0000000181CC8D10
		public bool CheckReliqueryMainProp(ReliquaryItem reliquary) => default; // 0x0000000181CC72E0-0x0000000181CC7AA0
		public bool CheckReliqueryAppendProp(ReliquaryItem reliquary) => default; // 0x0000000181CC5EA0-0x0000000181CC72E0
		public bool CheckAvatarReliqueryProp(CombatProperty oldProperty, int typeIndex, uint runtimeID = 0 /* Metadata: 0x00B0D539 */) => default; // 0x0000000181CC3320-0x0000000181CC35F0
		public int GetWeaponMaxAwakenLevel(uint weaponId) => default; // 0x0000000181CCA990-0x0000000181CCAAD0
		public bool CheckWeaponAffix(uint weaponId) => default; // 0x0000000181CC7AA0-0x0000000181CC7C60
		public bool CheckAvatarCombatProperty(CombatProperty oldProperty, ReliquaryItem reliquary, uint runtimeID = 0 /* Metadata: 0x00B0D53D */) => default; // 0x0000000181CC22F0-0x0000000181CC24D0
		public bool CheckAvatarWeaponFightPropType(int propType, float value) => default; // 0x0000000181CC3FD0-0x0000000181CC4230
		private Dictionary<FightPropType, float> GetEquipedReliquerySet() => default; // 0x0000000181CC8DF0-0x0000000181CC9270
		private Dictionary<FightPropType, float> GetReliquerySet() => default; // 0x0000000181CC9D60-0x0000000181CC9FC0
		private float GetPercentage(ReliquaryItem reliquary, FightPropType type) => default; // 0x0000000181CC94B0-0x0000000181CC97E0
		private void CheckByType(CombatProperty oldProperty, CombatProperty newProperty, ReliquaryItem reliquary, FightPropType type) {} // 0x0000000181CC43E0-0x0000000181CC5EA0
		public float ComputeGrowValueByCurve(float base_value, AvatarCurveExcelConfig curveData, GrowCurveType curveType) => default; // 0x0000000181CC7C60-0x0000000181CC7DC0
		public float ComputeWeaponValueByCurve(float base_value, WeaponCurveExcelConfig curveData, GrowCurveType curveType) => default; // 0x0000000181CC7EA0-0x0000000181CC8000
		private float ComputeValue(float src, GrowCurveInfo info) => default; // 0x0000000181CC7DC0-0x0000000181CC7EA0
		public Dictionary<FightPropType, float> GetProudConfigValue(uint talentID, uint runtimeID = 0 /* Metadata: 0x00B0D541 */) => default; // 0x0000000181CC97E0-0x0000000181CC99B0
		public Dictionary<FightPropType, float> GetTalentConfigValue(uint talentID, uint runtimeID = 0 /* Metadata: 0x00B0D545 */) => default; // 0x0000000181CC9FC0-0x0000000181CCA170
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator CheckAvatarTalent(CombatProperty oldCombatProperty, uint talentID, uint runtimeID = 0 /* Metadata: 0x00B0D549 */) => default; // 0x0000000181CC35F0-0x0000000181CC36F0
		private float GetValueByType(CombatProperty property, FightPropType type) => default; // 0x0000000181CCA170-0x0000000181CCA570
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		public IEnumerator WaitCheckByType(CombatProperty oldProperty, uint runtimeID, FightPropType type, float changeValue, uint talentID) => default; // 0x0000000181CCBE90-0x0000000181CCBFB0
	}
}
