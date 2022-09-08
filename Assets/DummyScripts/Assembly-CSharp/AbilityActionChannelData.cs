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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilityActionChannelData // TypeDefIndex: 19252
{
	// Fields
	private static ConfigPlatformActionTokenChannel _platformData; // 0x00
	private static bool _forceUseDefaultCfg; // 0x08

	// Properties
	private static string _channelPlatformDataPath { /* [XID] */ /* 0x00000001895FAED0-0x00000001895FAEF0 */ get => default; } // 0x00000001832736E0-0x0000000183273780 
	public static bool forceUseDefaultCfg { /* [XID] */ /* 0x0000000189602710-0x0000000189602730 */ get => default; } // 0x0000000183272DE0-0x0000000183272EB0 

	// Constructors
	public AbilityActionChannelData() {} // 0x0000000183273D10-0x0000000183273D70
	static AbilityActionChannelData() {} // 0x0000000183273CA0-0x0000000183273D10

	// Methods
	// [XID] // 0x000000018960A0D0-0x000000018960A0F0
	public static Dictionary<SimpleSafeInt32, ConfigActionTokenChannel> GetTokenChannelDic() => default; // 0x0000000183273780-0x0000000183273930
	// [XID] // 0x0000000189611880-0x00000001896118A0
	public static Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> GetEntityTypeToken() => default; // 0x0000000183273AE0-0x0000000183273BC0
	// [XID] // 0x0000000189619100-0x0000000189619120
	public static float GetLowLevelDist() => default; // 0x0000000183272C70-0x0000000183272DE0
	// [XID] // 0x0000000189620680-0x00000001896206A0
	public static Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup> GetLowLevelDistToken() => default; // 0x0000000183273930-0x0000000183273AE0
	// [XID] // 0x0000000189627B90-0x0000000189627BB0
	public static Dictionary<ActionTokenSourceType, Dictionary<EntityTokenActionType, ConfigEntityActionTokenGroup>> GetActionSourceToken() => default; // 0x0000000183273040-0x00000001832731F0
	// [XID] // 0x000000018962F500-0x000000018962F520
	public static void ForceUseDefaultCfg(bool enable) {} // 0x0000000183272F70-0x0000000183273040
	// [XID] // 0x0000000189637000-0x0000000189637020
	public static EntityType[] GetHighEntityType() => default; // 0x0000000183273BC0-0x0000000183273CA0
	// [XID] // 0x000000018963E520-0x000000018963E540
	public static void ReloadFromFile() {} // 0x0000000183272EB0-0x0000000183272F70
	[DebuggerHidden] // 0x0000000189645CE0-0x0000000189645D20
	// [XID] // 0x0000000189645CE0-0x0000000189645D20
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC652 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001832735A0-0x00000001832736E0
	// [XID] // 0x0000000189650350-0x0000000189650370
	private static void LoadAbilityActionChannelData() {} // 0x0000000183273360-0x00000001832735A0
	// [XID] // 0x0000000189657C30-0x0000000189657C50
	private static ConfigActionTokenChannelGroupInfo GetPlatformCfg() => default; // 0x00000001832729E0-0x0000000183272C70
	// [XID] // 0x000000018965F340-0x000000018965F360
	private static string GetActionTokenGroupKey() => default; // 0x00000001832731F0-0x0000000183273360
}

