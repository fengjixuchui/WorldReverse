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

public class EntityAttachMapData // TypeDefIndex: 19469
{
	// Fields
	private static Dictionary<string, ConfigAttachment> entityAttachDic; // 0x00

	// Properties
	private static string _configPath { /* [XID] */ /* 0x0000000189AE1F40-0x0000000189AE1F60 */ get => default; } // 0x0000000184920CA0-0x0000000184920D40 

	// Constructors
	public EntityAttachMapData() {} // 0x0000000184920DD0-0x0000000184920E30
	static EntityAttachMapData() {} // 0x0000000184920D40-0x0000000184920DD0

	// Methods
	// [XID] // 0x0000000189AE96F0-0x0000000189AE9710
	public static void ReloadFromFile() {} // 0x0000000184920700-0x00000001849207C0
	[DebuggerHidden] // 0x0000000189AF1550-0x0000000189AF1590
	// [XID] // 0x0000000189AF1550-0x0000000189AF1590
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC8C0 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000184920B60-0x0000000184920CA0
	// [XID] // 0x0000000189AFBA60-0x0000000189AFBA80
	private static void LoadAttachDataConfig() {} // 0x00000001849208D0-0x0000000184920B60
	// [XID] // 0x0000000189B03110-0x0000000189B03130
	public static ConfigAttachment Get(string attachName) => default; // 0x00000001849207C0-0x00000001849208D0
}

