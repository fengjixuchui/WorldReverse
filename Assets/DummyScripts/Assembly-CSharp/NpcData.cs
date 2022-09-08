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
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class NpcData // TypeDefIndex: 19547
{
	// Fields
	private static Dictionary<ulong, ConfigEntity> _npcConfigs; // 0x00
	private static ConfigLCBaseInteeData _npcInteeConfig; // 0x08
	private static Dictionary<ulong, ConfigLCGadgetIntee> _gadgetInteeConfigDic; // 0x10

	// Properties
	private static string NPC_LCBASEINTEE_CONFIG_PATH { /* [XID] */ /* 0x0000000189890060-0x0000000189890080 */ get; } // 0x00000001829C1520-0x00000001829C15C0 
	private static string GADGET_LCGADGETINTEE_CONFIG_PATH { /* [XID] */ /* 0x0000000189897560-0x0000000189897580 */ get; } // 0x00000001829C15C0-0x00000001829C1660 

	// Constructors
	static NpcData() {} // 0x00000001829C2300-0x00000001829C23C0

	// Methods
	// [XID] // 0x000000018989EA80-0x000000018989EAA0
	public static void ReloadFromFile() {} // 0x00000001829C1770-0x00000001829C2030
	[DebuggerHidden] // 0x00000001898A6520-0x00000001898A6560
	// [XID] // 0x00000001898A6520-0x00000001898A6560
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCAC1 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001829C21C0-0x00000001829C2300
	// [XID] // 0x00000001898B0C40-0x00000001898B0C60
	public static ConfigNpc GetNpcConfig(ulong configPathHash) => default; // 0x00000001829C2030-0x00000001829C21C0
	// [XID] // 0x00000001897BA8B0-0x00000001897BA8D0
	public static ConfigLCBaseIntee GetBaseInteeConfig(string configPath) => default; // 0x00000001829C13D0-0x00000001829C1520
	// [XID] // 0x00000001898BFAE0-0x00000001898BFB00
	public static ConfigLCGadgetIntee GetGadgetInteeConfig(ulong configPathHash) => default; // 0x00000001829C1660-0x00000001829C1770
}

