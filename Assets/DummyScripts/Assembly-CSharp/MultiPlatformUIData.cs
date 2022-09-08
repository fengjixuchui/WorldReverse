/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MultiPlatformUIData // TypeDefIndex: 14799
{
	// Properties
	private static string _configPath { /* [XID] */ /* 0x00000001899A9CC0-0x00000001899A9CE0 */ get; } // 0x000000018306DD90-0x000000018306DE30 
	public static ConfigMutiPlatformUIData config { /* [XID] */ /* 0x0000000189A416B0-0x0000000189A416F0 */ get; /* [XID] */ /* 0x0000000189A4BC80-0x0000000189A4BCC0 */ private set; } // 0x000000018306DE30-0x000000018306DEC0 0x000000018306D0A0-0x000000018306D130
	public static bool isIPhoneXLikeScreen { /* [XID] */ /* 0x0000000189A56440-0x0000000189A56480 */ get; private set; } // 0x000000018306D5C0-0x000000018306D650 0x000000018306D010-0x000000018306D0A0
	public static bool isHighResolution { /* [XID] */ /* 0x0000000189A68A70-0x0000000189A68AB0 */ get; /* [XID] */ /* 0x0000000189A72F40-0x0000000189A72F80 */ private set; } // 0x000000018306D3E0-0x000000018306D470 0x000000018306D530-0x000000018306D5C0

	// Constructors
	static MultiPlatformUIData() {} // 0x000000018306E6C0-0x000000018306E730

	// Methods
	// [XID] // 0x000000018964CDF0-0x000000018964CE10
	public static void LoadFromFile() {} // 0x000000018306D650-0x000000018306D8D0
	// [XID] // 0x0000000189A85160-0x0000000189A85180
	public static bool IsWideScreen() => default; // 0x000000018306D260-0x000000018306D320
	// [XID] // 0x0000000189A8CA90-0x0000000189A8CAB0
	public static bool NeedFix() => default; // 0x000000018306D470-0x000000018306D530
	// [XID] // 0x0000000189A93E70-0x0000000189A93E90
	public static bool NeedPCFix() => default; // 0x000000018306D130-0x000000018306D260
	// [XID] // 0x0000000189ACD9A0-0x0000000189ACD9C0
	public static void SetHighResolutionFix(GameObject obj) {} // 0x000000018306D8D0-0x000000018306DA10
	// [XID] // 0x0000000189ABE760-0x0000000189ABE780
	public static bool NeedHighResolutionFix() => default; // 0x000000018306D320-0x000000018306D3E0
	// [XID] // 0x0000000189AAA2E0-0x0000000189AAA300
	private static bool IsIPhoneXLikeScreen() => default; // 0x000000018306DA10-0x000000018306DB40
	// [XID] // 0x0000000189AC6270-0x0000000189AC6290
	public static void ApplyFix(Transform trans, ConfigPlatformUIAction action) {} // 0x000000018306DB40-0x000000018306DD90
	// [XID] // 0x0000000189AB9390-0x0000000189AB93B0
	private static void ApplyAction(Transform childTrans, ConfigPlatformUIAction action) {} // 0x000000018306DEC0-0x000000018306E560
	// [XID] // 0x0000000189AC1010-0x0000000189AC1030
	private static void ApplyFixExt(RectTransform rectTrans, ConfigPlatformUIAction action) {} // 0x000000018306E560-0x000000018306E6C0
}

