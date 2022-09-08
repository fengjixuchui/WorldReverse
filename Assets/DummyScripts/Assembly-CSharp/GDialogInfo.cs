/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GDialogInfo // TypeDefIndex: 21675
{
	// Fields
	private static Dictionary<uint, DialogLoadRet> _globalDialogDic; // 0x00
	private static Dictionary<uint, ConfigDialogScheme> _globalDialogUnloadDic; // 0x08
	private static Dictionary<uint, DialogLoadRet> _coopDialogDic; // 0x10
	private static SimpleObjectPool<DialogLoadRet> _globalDialogLoadRetPool; // 0x18
	private static Dictionary<uint, ConfigNarratorDialogGroup> _globalNarratorDic; // 0x20

	// Nested types
	private class DialogLoadRet : ISimplePoolObject // TypeDefIndex: 21676
	{
		// Fields
		public ConfigDialogScheme dialogConfig; // 0x10
		public HashSet<uint> talkSet; // 0x18

		// Constructors
		public DialogLoadRet() {} // 0x00000001830BEDB0-0x00000001830BEEB0

		// Methods
		// [XID] // 0x00000001899EEF70-0x00000001899EEF90
		public void ResetObject() {} // 0x00000001830BECF0-0x00000001830BEDB0
	}

	// Constructors
	public GDialogInfo() {} // 0x00000001830A9370-0x00000001830A93D0
	static GDialogInfo() {} // 0x00000001830A9220-0x00000001830A9370

	// Methods
	// [XID] // 0x0000000189995150-0x0000000189995170
	public static ConfigDialogScheme GetDialogScheme(uint dialogId) => default; // 0x00000001830A8390-0x00000001830A8570
	// [XID] // 0x000000018999CC90-0x000000018999CCB0
	public static bool HasDialogConfig(uint dialogId) => default; // 0x00000001830A8570-0x00000001830A8710
	// [XID] // 0x0000000189774F60-0x0000000189774F80
	public static void AddDialogConfig(uint talkId, ConfigDialogScheme dialogConfig) {} // 0x00000001830A7FB0-0x00000001830A81A0
	// [XID] // 0x00000001899ABF10-0x00000001899ABF30
	public static void AddDialogUnloadConfig(ConfigDialogScheme dialogConfig) {} // 0x00000001830A8710-0x00000001830A8870
	// [XID] // 0x00000001899B3780-0x00000001899B37A0
	public static void RemoveDialogConfigByTalk(uint talkId, uint dialogId) {} // 0x00000001830A8D90-0x00000001830A8F90
	// [XID] // 0x00000001899BAB80-0x00000001899BABA0
	public static void ClearDialogConfig() {} // 0x00000001830A90F0-0x00000001830A9220
	// [XID] // 0x00000001899C2570-0x00000001899C2590
	public static void AddCoopDialogConfig(uint coopInteractionId, ConfigDialogScheme dialogConfig) {} // 0x00000001830A81A0-0x00000001830A8390
	// [XID] // 0x00000001899C9C60-0x00000001899C9C80
	public static void RemoveCoopDialogConfigByTalk(uint coopInteractionId, uint dialogId) {} // 0x00000001830A8870-0x00000001830A8A70
	// [XID] // 0x00000001899D14C0-0x00000001899D14E0
	public static ConfigNarratorDialogGroup GetNarratorDialogGroup(uint narratorId) => default; // 0x00000001830A8A70-0x00000001830A8B70
	// [XID] // 0x00000001899D89D0-0x00000001899D89F0
	public static void AddNarratorDialogGroup(ConfigNarratorDialogGroup narratorGroup) {} // 0x00000001830A8F90-0x00000001830A90F0
	// [XID] // 0x00000001899E00E0-0x00000001899E0100
	public static void RemoveNarratorDialogGroup(uint narratorId) {} // 0x00000001830A8B70-0x00000001830A8CB0
	// [XID] // 0x00000001899E7BE0-0x00000001899E7C00
	public static void ClearNarratorDialogGroup() {} // 0x00000001830A8CB0-0x00000001830A8D90
}

