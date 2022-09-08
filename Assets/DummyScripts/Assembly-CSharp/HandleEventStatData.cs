/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct HandleEventStatData // TypeDefIndex: 27842
{
	// Fields
	public double milliseconds; // 0x00
	public uint count; // 0x08
	public double totalMilliseconds; // 0x10
	public uint totalCount; // 0x18

	// Methods
	// [XID] // 0x0000000189B84A60-0x0000000189B84A80
	public void ResetStatValue(bool bClearHistroyStat) {} // 0x0000000182039300-0x00000001820393C0
	// [XID] // 0x000000018966BFC0-0x000000018966BFE0
	public void AccumulateInclusiveStat(ref HandleEventStatData other) {} // 0x0000000182039230-0x0000000182039300
	// [XID] // 0x0000000189B92F40-0x0000000189B92F60
	public void AccumulateExclusiveStat() {} // 0x00000001820393C0-0x00000001820393D0
}

