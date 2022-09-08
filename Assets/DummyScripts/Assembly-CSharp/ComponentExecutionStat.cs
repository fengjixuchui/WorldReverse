/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ComponentExecutionStat // TypeDefIndex: 27821
{
	// Fields
	private const int SC_Ctor = 0; // Metadata: 0x00B0CFB9
	private const int SC_Init = 1; // Metadata: 0x00B0CFBD
	private const int SC_Tick = 2; // Metadata: 0x00B0CFC1
	private const int SC_LateTick = 3; // Metadata: 0x00B0CFC5
	private const int SC_Total = 4; // Metadata: 0x00B0CFC9
	private static string[] allStatNames; // 0x00
	private string fullName; // 0x10
	private string displayName; // 0x18
	private Dictionary<EntityManager.TickType, StatMMAWithDeltaFrame> _tickTypeStats; // 0x20
	private static Dictionary<EntityManager.TickType, Func<BaseComponent, int>> _tickTypeDeltaFrameFunMap; // 0x08

	// Constructors
	public ComponentExecutionStat() {} // Dummy constructor
	public ComponentExecutionStat(string inFullName) {} // 0x0000000182D71410-0x0000000182D71550
	static ComponentExecutionStat() {} // 0x0000000182D71150-0x0000000182D71410

	// Methods
	// [XID] // 0x00000001896E7770-0x00000001896E7790
	public static string GetStatCategoryName(EntityManager.TickType inTickType) => default; // 0x0000000182D70760-0x0000000182D70870
	// [XID] // 0x00000001898CB6C0-0x00000001898CB6E0
	public static int TickTypeEnumToSCCategory(EntityManager.TickType inTickType) => default; // 0x0000000182D70870-0x0000000182D70930
	// [XID] // 0x0000000189988400-0x0000000189988420
	public static bool IsValidTickType(EntityManager.TickType inType) => default; // 0x0000000182D71080-0x0000000182D71150
	// [XID] // 0x0000000189A04E20-0x0000000189A04E40
	private StatMMAWithDeltaFrame GetStatByTickType(EntityManager.TickType tickType) => default; // 0x0000000182D70D50-0x0000000182D70F60
	// [XID] // 0x00000001898E2470-0x00000001898E2490
	public static string ToCSVTitleSingle() => default; // 0x0000000182D70AB0-0x0000000182D70BA0
	// [XID] // 0x00000001898EA000-0x00000001898EA020
	public string ToCSVTStringSingle(EntityManager.TickType tickType) => default; // 0x0000000182D70C30-0x0000000182D70D50
	// [XID] // 0x0000000189A0C4D0-0x0000000189A0C4F0
	public static string ToEmptyCSVString(string inCompName, string categoryName) => default; // 0x0000000182D70F60-0x0000000182D71080
	// [XID] // 0x00000001898F8F60-0x00000001898F8F80
	public void StatComponent(BaseComponent inComp, float elapsedTime, EntityManager.TickType tickType) {} // 0x0000000182D709C0-0x0000000182D70AB0
}

