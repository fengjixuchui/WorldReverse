/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MonsterData // TypeDefIndex: 19543
{
	// Fields
	public static int MONSTER_IDLE_TAG; // 0x00
	public static int MONSTER_MOVE_TAG; // 0x04
	public static int MONSTER_WALK_TAG; // 0x08
	public static int MONSTER_HIT_AIR_TAG; // 0x0C
	public static int MONSTER_HIT_H_TAG; // 0x10
	public static int MONSTER_HIT_L_TAG; // 0x14
	public static int MONSTER_SKILL_TAG; // 0x18
	public static int MONSTER_ATTACK_TAG; // 0x1C
	public static int MONSTER_MOVE_ATTACK_TAG; // 0x20
	public static int MONSTER_DIE_TAG; // 0x24
	public static HashSet<int>[] MONSTER_TAG_GROUPS; // 0x28
	private static Dictionary<ulong, ConfigEntity> _monsterConfigs; // 0x30
	private static Dictionary<ulong, MonsterConfigPage> _monsterConfigPages; // 0x38

	// Nested types
	public enum MonsterTagGroup // TypeDefIndex: 19544
	{
		NormalMove = 0,
		Hit = 1,
		Skill = 2,
		Die = 3
	}

	public class MonsterConfigPage : EntityConfigPageBase // TypeDefIndex: 19545
	{
		// Fields
		private static SerializeBinHandler _serializeBin; // 0x00
		private static SerializeJsonHandler _serializeJson; // 0x08
		private Action<object, ulong> _onSerializedAsync; // 0x58

		// Constructors
		public MonsterConfigPage() {} // 0x00000001815F5B30-0x00000001815F5BE0
		static MonsterConfigPage() {} // 0x00000001815F5A00-0x00000001815F5B30

		// Methods
		// [XID] // 0x0000000189803CF0-0x0000000189803D10
		protected static ConfigMetaConfig.PathHash[] GetMosnterRegistryPathes() => default; // 0x00000001815F4E90-0x00000001815F4F70
		// [XID] // 0x00000001897CD130-0x00000001897CD150
		public ConfigMonster GetMonsterConfig() => default; // 0x00000001815F4F70-0x00000001815F5160
		// [XID] // 0x0000000189812800-0x0000000189812820
		protected override void LoadEntityConfig(ulong configHash) {} // 0x00000001815F5160-0x00000001815F5210
		// [XID] // 0x000000018981A4A0-0x000000018981A4C0
		public override ulong GetConfigHash() => default; // 0x00000001815F5650-0x00000001815F5730
		// [XID] // 0x0000000189821B50-0x0000000189821B70
		private void LoadMonsterConfig(ulong configHash) {} // 0x00000001815F5730-0x00000001815F5A00
		// [XID] // 0x00000001898290C0-0x00000001898290E0
		private static object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFCABD */) => default; // 0x00000001815F53A0-0x00000001815F54F0
		// [XID] // 0x00000001898306A0-0x00000001898306C0
		private static object SerializeJson(JSONNode node) => default; // 0x00000001815F4D90-0x00000001815F4E90
		// [XID] // 0x0000000189837C60-0x0000000189837C80
		private void OnSerialized(object obj, ulong path) {} // 0x00000001815F5210-0x00000001815F53A0
		// [XID] // 0x000000018983F430-0x000000018983F450
		private void OnSerializedAsync(object obj, ulong path) {} // 0x00000001815F4C40-0x00000001815F4D90
		// [XID] // 0x0000000189846AD0-0x0000000189846AF0
		public override AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish) => default; // 0x00000001815F54F0-0x00000001815F5650
	}

	// Constructors
	static MonsterData() {} // 0x00000001815D7060-0x00000001815D7120

	// Methods
	// [XID] // 0x00000001897AD5F0-0x00000001897AD610
	public static void Init() {} // 0x00000001815D6220-0x00000001815D6760
	// [XID] // 0x00000001897B5730-0x00000001897B5750
	public static void CheckClear() {} // 0x00000001815D54A0-0x00000001815D5920
	// [XID] // 0x00000001897BD3E0-0x00000001897BD400
	public static void ReloadFromFile() {} // 0x00000001815D6760-0x00000001815D6860
	[DebuggerHidden] // 0x00000001897C4700-0x00000001897C4740
	// [XID] // 0x00000001897C4700-0x00000001897C4740
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCAA9 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001815D6F20-0x00000001815D7060
	// [XID] // 0x00000001897CF050-0x00000001897CF070
	public static ConfigMonster GetMonsterConfig(ulong configPathHash) => default; // 0x00000001815D6860-0x00000001815D6B50
	// [XID] // 0x00000001897B65B0-0x00000001897B65D0
	public static void PreloadMonsterConfig(BaseEntity entity, ulong configPathHash) {} // 0x00000001815D5FF0-0x00000001815D6220
	// [XID] // 0x00000001897DDFF0-0x00000001897DE010
	public static AsyncJob PreloadMonsterConfigAsyncWithJob(BaseEntity entity, ulong configPathHash, Action preloadedCallback) => default; // 0x00000001815D5C40-0x00000001815D5FF0
	// [XID] // 0x00000001897E5A40-0x00000001897E5A60
	public static void ReleasePreloadMonsterConfig(BaseEntity entity, ulong configPathHash) {} // 0x00000001815D5920-0x00000001815D5C40
	// [XID] // 0x00000001897ED530-0x00000001897ED550
	public static string Dump() => default; // 0x00000001815D6B50-0x00000001815D6F20
}

