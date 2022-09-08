/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MaterialItem : BagItem // TypeDefIndex: 20665
{
	// Properties
	public MaterialExcelConfig excelConfig { /* [XID] */ /* 0x00000001898E71D0-0x00000001898E71F0 */ get => default; } // 0x00000001834101F0-0x00000001834102D0 
	public override uint rankLevel { /* [XID] */ /* 0x00000001898F61C0-0x00000001898F61E0 */ get => default; } // 0x00000001834113F0-0x00000001834114B0 
	public override ulong cdTime { /* [XID] */ /* 0x00000001898FDA40-0x00000001898FDA60 */ get => default; } // 0x0000000183411620-0x0000000183411860 
	public bool hasDeleteConfig { /* [XID] */ /* 0x0000000189905260-0x0000000189905280 */ get => default; } // 0x0000000183410E30-0x0000000183410F20 

	// Constructors
	public MaterialItem() {} // 0x00000001834125C0-0x0000000183412620

	// Methods
	// [XID] // 0x00000001898EEA00-0x00000001898EEA20
	protected override void Recycle() {} // 0x0000000183410730-0x00000001834107D0
	// [XID] // 0x000000018990CA70-0x000000018990CA90
	public ItemDeleteType getDeleteType() => default; // 0x00000001834114B0-0x0000000183411620
	// [XID] // 0x0000000189914200-0x0000000189914220
	public bool OverDeleteTime() => default; // 0x0000000183410F20-0x0000000183411380
	// [XID] // 0x000000018991BCE0-0x000000018991BD00
	public string GetDeleteDesc() => default; // 0x0000000183411860-0x00000001834125C0
	// [XID] // 0x0000000189923320-0x0000000189923340
	public string GetCountDownDesc(uint second, uint count, bool mutipleItem, bool isConfigTime = false /* Metadata: 0x00AFDFA3 */) => default; // 0x00000001834107D0-0x0000000183410E30
	// [XID] // 0x000000018992AAE0-0x000000018992AB00
	public uint GetNearestCountDownSeconds() => default; // 0x00000001834102D0-0x0000000183410730
}

