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

public class MemoryCompareTCA // TypeDefIndex: 27854
{
	// Fields
	public string statName; // 0x10
	public FloatLogList total; // 0x18
	public IntLogList count; // 0x20
	public FloatLogList average; // 0x28

	// Constructors
	public MemoryCompareTCA() {} // 0x0000000181470CA0-0x0000000181470D70

	// Methods
	// [XID] // 0x000000018978D5F0-0x000000018978D610
	public static MemoryCompareTCA CreateEmptyNode(MemoryTCA inTCA, int appendZeroCount) => default; // 0x0000000181470B90-0x0000000181470CA0
	// [XID] // 0x00000001897949F0-0x0000000189794A10
	public void AppendZero(int targetCount) {} // 0x0000000181470960-0x0000000181470B90
	// [XID] // 0x000000018979CE20-0x000000018979CE40
	public bool Merge(MemoryTCA inTCA) => default; // 0x00000001814706E0-0x0000000181470870
	// [XID] // 0x00000001897A4280-0x00000001897A42A0
	public void OnFinishCompare() {} // 0x0000000181470870-0x0000000181470960
}

