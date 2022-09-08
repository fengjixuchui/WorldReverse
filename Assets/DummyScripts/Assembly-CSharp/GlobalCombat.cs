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
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GlobalCombat // TypeDefIndex: 19473
{
	// Fields
	public static ConfigGlobalCombat config; // 0x00
	public static ConfigEntityAbilitySystem levelAbilitySystemConfig; // 0x08
	public static Dictionary<uint, ConfigEntityReuse> entityReuseMap; // 0x10
	private static readonly AbilityState[] _abilityStateValues; // 0x18
	private static List<ElementReactionType> _rejectElemReactList; // 0x20
	private static List<AbilityState> abilityStateList; // 0x28
	private static AbilityState _lastState; // 0x30
	private static Dictionary<string, ConfigGadgetCreationLimit> _gadgetCreationLimit; // 0x38
	private static Dictionary<uint, string> _gadgetTags; // 0x40
	private const int MAX_LEVEL_CLAMP = 80; // Metadata: 0x00AFC8CC
	private static string elementDecrateGroupDefault; // 0x48
	private static Dictionary<string, Dictionary<int, Tuple<float, float>>> _elementDecrateGroupDict; // 0x50
	private static Dictionary<int, string> _hitEffects; // 0x58
	private static float[] _visionLevelDist; // 0x60
	private const float VISON_DISTANCE_ADD = 50f; // Metadata: 0x00AFC8D0

	// Properties
	private static string _levelConfigPath { /* [XID] */ /* 0x0000000189BB7E80-0x0000000189BB7EA0 */ get => default; } // 0x000000018125A250-0x000000018125A2F0 

	// Constructors
	static GlobalCombat() {} // 0x000000018125AE20-0x000000018125AFB0
	public GlobalCombat() {} // 0x000000018125AFB0-0x000000018125B010

	// Methods
	// [XID] // 0x0000000189BBF5F0-0x0000000189BBF610
	public static void ReloadFromFile() {} // 0x0000000181258580-0x0000000181258650
	// [XID] // 0x0000000189BC7240-0x0000000189BC7260
	private static void LoadGlobalAbilitySystemConfig() {} // 0x000000018125A010-0x000000018125A250
	// [XID] // 0x0000000189BCEF00-0x0000000189BCEF20
	private static void LoadEntityReuseConfig() {} // 0x0000000181256B00-0x0000000181256F50
	// [XID] // 0x0000000189BD62C0-0x0000000189BD62E0
	public static void LoadCombatDataConfig() {} // 0x000000018125A2F0-0x000000018125AE20
	// [XID] // 0x0000000189BDDDA0-0x0000000189BDDDC0
	public static void InitGlobalSliceFrameWatches(ConfigGlobalCombat inConfig) {} // 0x00000001812594E0-0x00000001812599E0
	// [XID] // 0x00000001895EAA70-0x00000001895EAA90
	public static void OverrideByLuaPatch(string jsonText) {} // 0x0000000181257AE0-0x0000000181257C80
	// [XID] // 0x00000001895F1E90-0x00000001895F1EB0
	public static float GetElementReactionDamage(ElementReactionType reactType, ElementType elemType) => default; // 0x0000000181258650-0x0000000181258850
	// [XID] // 0x00000001895F9840-0x00000001895F9860
	public static float GetElementAmplifyDamage(ElementReactionType reactType, ElementType elemType) => default; // 0x0000000181258310-0x0000000181258580
	[DebuggerHidden] // 0x0000000189600F80-0x0000000189600FC0
	// [XID] // 0x0000000189600F80-0x0000000189600FC0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC8C8 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000181258920-0x0000000181258A20
	// [XID] // 0x000000018960B9C0-0x000000018960B9E0
	public static bool IsRejectElementReaction(AbilityState state, ElementReactionType type) => default; // 0x0000000181257C80-0x0000000181257E60
	// [XID] // 0x0000000189A005C0-0x0000000189A005E0
	private static void UpdateRejectElementReactionList(AbilityState state) {} // 0x0000000181256420-0x00000001812568A0
	// [XID] // 0x0000000189B96F10-0x0000000189B96F30
	public static ConfigGadgetCreationLimit GetGadgetCreationLimit(string tag) => default; // 0x00000001812599E0-0x0000000181259B50
	// [XID] // 0x0000000189A65C80-0x0000000189A65CA0
	public static string GetGadgetTags(uint gadgetID) => default; // 0x0000000181257E60-0x0000000181258000
	// [XID] // 0x0000000189629550-0x0000000189629570
	public static int GetLevelDiff(int levelA, int levelB) => default; // 0x0000000181258850-0x0000000181258920
	// [XID] // 0x0000000189630E80-0x0000000189630EA0
	public static ConfigAttackAttenuation GetAttackAttenuation(string group) => default; // 0x00000001812574D0-0x0000000181257770
	// [XID] // 0x0000000189BD42B0-0x0000000189BD42D0
	private static int ElementTypeTuple(ElementType elem1, ElementType elem2) => default; // 0x0000000181258000-0x00000001812580B0
	// [XID] // 0x000000018963FD10-0x000000018963FD30
	private static void InitElementDecrate() {} // 0x0000000181258C40-0x0000000181259170
	// [XID] // 0x0000000189BCCC60-0x0000000189BCCC80
	public static void GetElementDecrate(ElementType elem1, ElementType elem2, ref float ratio1, ref float ratio2, string group = null) {} // 0x0000000181257080-0x0000000181257350
	// [XID] // 0x000000018964EC20-0x000000018964EC40
	public static EquipSizeData[] GetAvatarEquipSizeDatas(int bodyType) => default; // 0x00000001812568A0-0x0000000181256B00
	// [XID] // 0x00000001898D2750-0x00000001898D2770
	public static EquipSizeData[] GetManekinEquipSizeDatas(int bodyType) => default; // 0x00000001812580B0-0x0000000181258310
	// [XID] // 0x000000018975ED50-0x000000018975ED70
	public static bool EnableRemoteMoveIK() => default; // 0x0000000181259CA0-0x000000018125A010
	// [XID] // 0x000000018987C710-0x000000018987C730
	public static bool EnableRemoteClimbIK() => default; // 0x0000000181257770-0x0000000181257AE0
	// [XID] // 0x000000018966CA20-0x000000018966CA40
	private static void InitHitEffect() {} // 0x0000000181259170-0x00000001812594E0
	// [XID] // 0x0000000189B12C00-0x0000000189B12C20
	public static string GetHitEffects(ElementType elementType, StrikeType strikeType) => default; // 0x0000000181257350-0x00000001812574D0
	// [XID] // 0x000000018967C140-0x000000018967C160
	private static int HitEffectKey(int elementType, int strikeType) => default; // 0x0000000181256370-0x0000000181256420
	// [XID] // 0x0000000189683690-0x00000001896836B0
	public static float GetVisionLevelDest(VisionLevelType type) => default; // 0x0000000181259B50-0x0000000181259CA0
	// [XID] // 0x000000018968B370-0x000000018968B390
	public static ConfigEntityReuse GetEntityReuseConfig(uint configId) => default; // 0x0000000181256F50-0x0000000181257080
	// [XID] // 0x0000000189693060-0x0000000189693080
	public static ConfigTDPlayTowerData GetTDPlayData(TDPlayTowerType tdType) => default; // 0x0000000181258A20-0x0000000181258C40
}

