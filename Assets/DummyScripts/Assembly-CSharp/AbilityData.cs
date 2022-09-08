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
using SimpleJSON;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AbilityData // TypeDefIndex: 19412
{
	// Fields
	private static string EMPTY_STR; // 0x00
	private static string DEFAULT_NAME_STR; // 0x08
	private static IDictionary<string, ulong> _abilityNameToHash; // 0x10
	private static Dictionary<ulong, AbilityConfigPage> _abilityHashToConfigPage; // 0x18
	private static SerializeBinHandler _serializeBin; // 0x20
	private static SerializeJsonHandler _serializeJson; // 0x28
	public static bool isAbilityProtoUseStrHash; // 0x30
	private static IDictionary<string, uint> _abilityStrHashDict; // 0x38
	private static IDictionary<uint, string> _abilityHashStrDict; // 0x40
	public const AbilityState ABILITY_STATE_DEBUFF = (AbilityState) 268501248; // Metadata: 0x00AFC883
	public const AbilityState ABILITY_STATE_BUFF = AbilityState.None; // Metadata: 0x00AFC88B
	public static AbilityState ABILITY_STATE_CONTROL_DEBUFFS_MASK; // 0x48
	public static AbilityState[][] ABILITY_STATE_PRECEDENCE_MAP; // 0x50
	public static Dictionary<EncryptedString, ConfigAbilityPropertyEntry> PROPERTIES; // 0x58
	private static Dictionary<string, string[]> _abilityGlobalPosNameCache; // 0x60
	private static Dictionary<int, string> _abilityElementReactionOverloadNameCache; // 0x68
	private static Dictionary<string, string> _abilityReactionDamageNameCache; // 0x70
	private static Dictionary<string, string> _abilityElementStrengthNameCache; // 0x78
	private static Dictionary<ulong, ConfigDynamicAbilityPreload> _dynamicAbilityPreloadMap; // 0x80

	// Properties
	private static string DYNAMIC_ABLITY_PRELOAD_STR { /* [XID] */ /* 0x000000018980C7D0-0x000000018980C7F0 */ get; } // 0x0000000182AFDF80-0x0000000182AFE020 

	// Nested types
	public class AbilityConfigPage : ConfigLoadBase // TypeDefIndex: 19413
	{
		// Fields
		private string _path; // 0x38
		private ulong _hash; // 0x40
		private bool _isPermanent; // 0x48
		private Dictionary<string, Dictionary<string, ConfigAbility>> _abilityNameToConfigs; // 0x50
		private IDictionary<BaseEntity, int> _refEntities; // 0x58

		// Constructors
		public AbilityConfigPage() {} // 0x0000000182AE52F0-0x0000000182AE53F0

		// Methods
		// [XID] // 0x000000018982E4F0-0x000000018982E510
		public void Init(string path, ulong hash) {} // 0x0000000182AE2650-0x0000000182AE2720
		// [XID] // 0x000000018983C570-0x000000018983C590
		public override void Clear() {} // 0x0000000182AE2720-0x0000000182AE2A60
		// [XID] // 0x0000000189843B00-0x0000000189843B20
		public void Preload(BaseEntity entity) {} // 0x0000000182AE2590-0x0000000182AE2650
		// [XID] // 0x000000018984AFF0-0x000000018984B010
		public AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish) => default; // 0x0000000182AE38C0-0x0000000182AE3A70
		// [XID] // 0x0000000189852280-0x00000001898522A0
		public void ReleasePreload(BaseEntity entity) {} // 0x0000000182AE24E0-0x0000000182AE2590
		// [XID] // 0x0000000189859C30-0x0000000189859C50
		public void PreloadPermanent() {} // 0x0000000182AE3810-0x0000000182AE38C0
		// [XID] // 0x0000000189672760-0x0000000189672780
		public ConfigAbility GetConfig(BaseEntity entity, string abilityName, string overrideName, bool ignoreSyncLoadAlert) => default; // 0x0000000182AE2150-0x0000000182AE23B0
		// [XID] // 0x0000000189868570-0x0000000189868590
		public Dictionary<string, Dictionary<string, ConfigAbility>> GetAllConfigs() => default; // 0x0000000182AE2AD0-0x0000000182AE2B80
		// [XID] // 0x000000018986F9A0-0x000000018986F9C0
		public void ReloadIfLoaded() {} // 0x0000000182AE3570-0x0000000182AE3630
		// [XID] // 0x0000000189877090-0x00000001898770B0
		private void OnSerialized(object obj, ulong hash) {} // 0x0000000182AE3630-0x0000000182AE3810
		// [XID] // 0x0000000189A71A50-0x0000000189A71A70
		private void OnSerializedAsync(object obj, ulong hash) {} // 0x0000000182AE2410-0x0000000182AE24E0
		// [XID] // 0x000000018999DB80-0x000000018999DBA0
		private void CheckConfig(bool forceReload = false /* Metadata: 0x00AFC893 */) {} // 0x0000000182AE4780-0x0000000182AE4C20
		// [XID] // 0x0000000189A34210-0x0000000189A34230
		public void LoadAbilityConfig(Dictionary<string, ConfigAbility>[] abilityConfigGroups) {} // 0x0000000182AE4C20-0x0000000182AE52F0
		// [IDTag] // 0x0000000189894810-0x0000000189894850
		// [XID] // 0x0000000189894810-0x0000000189894850
		public override void AddRefCount() {} // 0x0000000182AE3F10-0x0000000182AE3FB0
		// [IDTag] // 0x000000018989EAA0-0x000000018989EAE0
		// [XID] // 0x000000018989EAA0-0x000000018989EAE0
		public void AddRefCount(BaseEntity entity) {} // 0x0000000182AE3A70-0x0000000182AE3F10
		// [XID] // 0x00000001898A9430-0x00000001898A9450
		public void MinusRefCount(BaseEntity entity) {} // 0x0000000182AE3FB0-0x0000000182AE4720
		// [XID] // 0x00000001898B0C60-0x00000001898B0C80
		public override string Dump() => default; // 0x0000000182AE2B80-0x0000000182AE3570
	}

	// Constructors
	static AbilityData() {} // 0x0000000182B02660-0x0000000182B02A30

	// Methods
	// [XID] // 0x00000001896B4B50-0x00000001896B4B70
	public static void ReloadFromFile() {} // 0x0000000182AFE020-0x0000000182AFE0F0
	// [XID] // 0x00000001896BBE20-0x00000001896BBE40
	public static void CheckClear() {} // 0x0000000182AF9D40-0x0000000182AFA1C0
	[DebuggerHidden] // 0x00000001896C32E0-0x00000001896C3320
	// [XID] // 0x00000001896C32E0-0x00000001896C3320
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC876 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182AFFC10-0x0000000182AFFD50
	// [XID] // 0x0000000189826F80-0x0000000189826FA0
	public static AbilityConfigPage getPage(string path, ulong hash) => default; // 0x0000000182AFFB30-0x0000000182AFFC10
	// [XID] // 0x000000018981F8D0-0x000000018981F8F0
	public static void PreloadEntityAbilities(BaseEntity entity, string[] abilityPaths) {} // 0x0000000182AFE1B0-0x0000000182AFE460
	// [XID] // 0x00000001896DC5C0-0x00000001896DC5E0
	public static void PreloadEntityAbilitiesAsync(BaseEntity entity, string[] abilityPaths, Action preloadedCallback) {} // 0x0000000182B011C0-0x0000000182B01510
	// [XID] // 0x00000001896E3D70-0x00000001896E3D90
	public static AsyncJob PreloadEntityAbilitiesAsyncWithJob(BaseEntity entity, string abilityPath, Action preloadedCallback) => default; // 0x0000000182AFAC10-0x0000000182AFAF50
	// [XID] // 0x00000001896EB160-0x00000001896EB180
	public static void ReleasePreloadedEntityAbilities(BaseEntity entity, string[] abilityPaths) {} // 0x0000000182B017A0-0x0000000182B01AD0
	// [XID] // 0x00000001896F24F0-0x00000001896F2510
	private static void PreloadAllAbilities() {} // 0x0000000182AFA550-0x0000000182AFA8F0
	[DebuggerHidden] // 0x00000001896F9E90-0x00000001896F9ED0
	// [XID] // 0x00000001896F9E90-0x00000001896F9ED0
	private static IEnumerator PreloadAllAbilitiesAsync(float progressSpan, Action<float> moveOneStepCallback) => default; // 0x0000000182AF9550-0x0000000182AF9670
	// [XID] // 0x0000000189704630-0x0000000189704650
	private static void LoadPathData() {} // 0x0000000182AFE460-0x0000000182AFEAA0
	// [XID] // 0x000000018970BCF0-0x000000018970BD10
	public static string[] GetAllAbilityNames() => default; // 0x0000000182AFAF50-0x0000000182AFB0C0
	// [XID] // 0x0000000189713680-0x00000001897136A0
	public static bool CheckAbilityHashExist(ulong hash) => default; // 0x0000000182B01BD0-0x0000000182B01D00
	// [XID] // 0x000000018971AE40-0x000000018971AE60
	public static void ReloadAbilityConfigPageIfLoaded(string abilityName) {} // 0x0000000182AF9B60-0x0000000182AF9D40
	// [XID] // 0x00000001897221C0-0x00000001897221E0
	public static ConfigAbility GetAbilityConfig(BaseEntity entity, string abilityName, string overrideName = null, bool ignoreSyncLoadAlert = false /* Metadata: 0x00AFC87A */) => default; // 0x0000000182AFB440-0x0000000182AFBA10
	// [XID] // 0x00000001897298E0-0x0000000189729900
	public static void AddAbilityRefCount(ConfigAbility configAbility, BaseEntity entity) {} // 0x0000000182AFEBF0-0x0000000182AFEF30
	// [XID] // 0x0000000189731080-0x00000001897310A0
	public static void MinusAbilityRefCount(ConfigAbility configAbility, BaseEntity entity) {} // 0x0000000182B002C0-0x0000000182B00600
	// [XID] // 0x0000000189738950-0x0000000189738970
	private static object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFC87B */) => default; // 0x0000000182B00A60-0x0000000182B00D80
	// [XID] // 0x000000018995E4D0-0x000000018995E4F0
	private static object SerializeJson(JSONNode node) => default; // 0x0000000182AFAAE0-0x0000000182AFAC10
	// [XID] // 0x0000000189747A30-0x0000000189747A50
	private static void GenAbilityElementHashCode() {} // 0x0000000182B01510-0x0000000182B016D0
	// [XID] // 0x000000018974F1F0-0x000000018974F210
	private static void ParseElementAbility(object obj) {} // 0x0000000182AFA1C0-0x0000000182AFA350
	// [XID] // 0x0000000189756900-0x0000000189756920
	public static void ParseServerGlobalValueHashCode(ConfigEntity config) {} // 0x0000000182AFEAA0-0x0000000182AFEBF0
	// [XID] // 0x000000018975DD50-0x000000018975DD70
	private static void GenAbilityConfigHashCode(Dictionary<string, Dictionary<string, ConfigAbility>> abilityNameToConfigs) {} // 0x0000000182B01D00-0x0000000182B02000
	// [XID] // 0x00000001897653B0-0x00000001897653D0
	private static void ParseAbilityContentHashCode(ConfigAbility configAbility) {} // 0x0000000182AFD380-0x0000000182AFDF80
	// [XID] // 0x000000018976CE00-0x000000018976CE20
	private static void AddAbilityString(string str) {} // 0x0000000182AF9670-0x0000000182AF9B60
	// [XID] // 0x0000000189774210-0x0000000189774230
	public static string HashToStr(uint hash) => default; // 0x0000000182B00F50-0x0000000182B011C0
	// [XID] // 0x000000018977B9E0-0x000000018977BA00
	public static string TryHashToStr(uint hash) => default; // 0x0000000182AFA350-0x0000000182AFA550
	// [XID] // 0x0000000189823CE0-0x0000000189823D00
	public static string ToString(AbilityString abilityStr) => default; // 0x0000000182AFBD50-0x0000000182AFC230
	// [IDTag] // 0x000000018978AA80-0x000000018978AAC0
	// [XID] // 0x000000018978AA80-0x000000018978AAC0
	public static AbilityString ToAbilityString(string str) => default; // 0x0000000182B02000-0x0000000182B022B0
	// [IDTag] // 0x0000000189794FA0-0x0000000189794FE0
	// [XID] // 0x0000000189794FA0-0x0000000189794FE0
	public static AbilityString ToAbilityString(EncryptedString es) => default; // 0x0000000182B022B0-0x0000000182B02560
	// [XID] // 0x00000001897A0130-0x00000001897A0150
	public static bool GetAbilityStringValue(string key, ref uint hashValue) => default; // 0x0000000182B008C0-0x0000000182B00A60
	// [XID] // 0x000000018973AE10-0x000000018973AE30
	public static bool IsModifierDebuff(ConfigAbilityModifier config) => default; // 0x0000000182AFB370-0x0000000182AFB440
	// [XID] // 0x00000001897AF110-0x00000001897AF130
	public static bool IsModifierBuff(ConfigAbilityModifier config) => default; // 0x0000000182AF9480-0x0000000182AF9550
	// [XID] // 0x00000001897B6D90-0x00000001897B6DB0
	public static void GetStateIndiceInPrecedenceMap(AbilityState state, out AbilityState[] precedenceTrack, out int stateIx) {
		precedenceTrack = default;
		stateIx = default;
	} // 0x0000000182B00D80-0x0000000182B00F50
	// [XID] // 0x00000001897BED90-0x00000001897BEDB0
	public static void InitProperty() {} // 0x0000000182AFC3A0-0x0000000182AFD120
	// [XID] // 0x00000001897C6380-0x00000001897C63A0
	private static void DefineEntityProperty(string propertyName, float defaultValue, StackMethod valueType) {} // 0x0000000182B02560-0x0000000182B02660
	// [XID] // 0x00000001897CDBC0-0x00000001897CDBE0
	private static void DefineActorProperty(string propertyName, float defaultValue, StackMethod valueType) {} // 0x0000000182B01AD0-0x0000000182B01BD0
	// [XID] // 0x00000001897D5090-0x00000001897D50B0
	private static void DefineAbilityProperty(PropertyType type, string propertyName, float defaultValue, StackMethod valueType) {} // 0x0000000182B00600-0x0000000182B008C0
	// [XID] // 0x00000001897DC890-0x00000001897DC8B0
	public static string GetAbilityGlobalPosName(string key, int index) => default; // 0x0000000182AFB0C0-0x0000000182AFB370
	// [XID] // 0x00000001897E4290-0x00000001897E42B0
	public static string GetAbilityElementReactionOverloadName(ElementReactionType type) => default; // 0x0000000182AFD120-0x0000000182AFD380
	// [XID] // 0x00000001897EBDA0-0x00000001897EBDC0
	public static string GetAbilityReactionDamageName(string key) => default; // 0x0000000182AFBB60-0x0000000182AFBD50
	// [XID] // 0x000000018999F2D0-0x000000018999F2F0
	public static string GetAbilityElementStrengthName(string key) => default; // 0x0000000182AFA8F0-0x0000000182AFAAE0
	[Preserve] // 0x00000001897FB090-0x00000001897FB0D0
	// [XID] // 0x00000001897FB090-0x00000001897FB0D0
	public static string Dump() => default; // 0x0000000182AFEF30-0x0000000182AFFB30
	// [XID] // 0x00000001896A0F30-0x00000001896A0F50
	public static bool GetConfigDynamicAbilityPreload(string abilityName, out ConfigDynamicAbilityPreload preloadConfig) {
		preloadConfig = default;
		return default;
	} // 0x0000000182AFC230-0x0000000182AFC3A0
	// [XID] // 0x0000000189813FB0-0x0000000189813FD0
	private static void LoadDynamicAbilityPreloadData() {} // 0x0000000182AFFD50-0x0000000182B002C0
	[DebuggerHidden] // 0x000000018981BB20-0x000000018981BB60
	// [XID] // 0x000000018981BB20-0x000000018981BB60
	private static IEnumerator LoadDynamicAbilityPreloadDataAsync(float progressSpan = 0f /* Metadata: 0x00AFC87F */, Action<float> moveOneStepCallback = null) => default; // 0x0000000182B016D0-0x0000000182B017A0
	// [XID] // 0x0000000189825FD0-0x0000000189825FF0
	private static bool IsAbilityDyanmic(string abilityName) => default; // 0x0000000182AFBA10-0x0000000182AFBB60
	// [XID] // 0x000000018982D5E0-0x000000018982D600
	public static bool IsMultipleTypeStacking(ModifierStacking stacking) => default; // 0x0000000182AFE0F0-0x0000000182AFE1B0
}

