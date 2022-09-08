/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StatCompareMMA // TypeDefIndex: 27856
{
	// Fields
	public string statName; // 0x10
	public DoubleLogList min; // 0x18
	public DoubleLogList max; // 0x20
	public DoubleLogList average; // 0x28

	// Constructors
	public StatCompareMMA() {} // 0x0000000184ABE250-0x0000000184ABE320

	// Methods
	// [XID] // 0x00000001897E0D50-0x00000001897E0D70
	public static StatCompareMMA CreateEmptyNode(StatMMA inMMA, int appendZeroCount) => default; // 0x0000000184ABE140-0x0000000184ABE250
	// [XID] // 0x00000001897E83D0-0x00000001897E83F0
	public bool Merge(StatMMA inMMA) => default; // 0x0000000184ABDCA0-0x0000000184ABDE20
	// [XID] // 0x00000001897F00F0-0x00000001897F0110
	public void AppendZero(int targetCount) {} // 0x0000000184ABDF10-0x0000000184ABE140
	// [XID] // 0x00000001897F7860-0x00000001897F7880
	public void OnFinishCompare() {} // 0x0000000184ABDE20-0x0000000184ABDF10
}

