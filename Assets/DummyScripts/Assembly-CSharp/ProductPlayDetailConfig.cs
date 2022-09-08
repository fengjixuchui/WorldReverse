/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ProductPlayDetailConfig : ProductDetailConfig, IAutoAllocRecycle // TypeDefIndex: 16142
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected ProductPlayType _play_type; // 0x28
	protected uint _itemNameTextMapHash; // 0x2C

	// Properties
	public ProductPlayType play_type { /* [XID] */ /* 0x0000000189972D70-0x0000000189972D90 */ get => default; /* [XID] */ /* 0x000000018997A650-0x000000018997A670 */ protected set {} } // 0x00000001829A2380-0x00000001829A2420 0x00000001829A2560-0x00000001829A2610
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint itemNameTextMapHash { /* [XID] */ /* 0x0000000189981FC0-0x0000000189981FE0 */ get => default; /* [XID] */ /* 0x0000000189989840-0x0000000189989860 */ protected set {} } // 0x00000001829A2D40-0x00000001829A2DE0 0x00000001829A2420-0x00000001829A24D0
	public string itemName { /* [XID] */ /* 0x0000000189991090-0x00000001899910B0 */ get => default; } // 0x00000001829A2BC0-0x00000001829A2D40 

	// Constructors
	public ProductPlayDetailConfig() {} // 0x00000001829A2EE0-0x00000001829A2F40

	// Methods
	// [IDTag] // 0x0000000189998B70-0x0000000189998BB0
	// [XID] // 0x0000000189998B70-0x0000000189998BB0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001829A1BD0-0x00000001829A1FC0
	// [IDTag] // 0x00000001899A3350-0x00000001899A3390
	// [XID] // 0x00000001899A3350-0x00000001899A3390
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829A1FC0-0x00000001829A2380
	// [XID] // 0x00000001899ADDE0-0x00000001899ADE00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3254 */, bool useObjectPool = false /* Metadata: 0x00AF3258 */) => default; // 0x00000001829A2670-0x00000001829A2BC0
	[BlackList] // 0x00000001899B5580-0x00000001899B55C0
	// [XID] // 0x00000001899B5580-0x00000001899B55C0
	public override void AutoAllocTypeFields() {} // 0x00000001829A1980-0x00000001829A1A20
	[BlackList] // 0x00000001899BFD70-0x00000001899BFDB0
	// [XID] // 0x00000001899BFD70-0x00000001899BFDB0
	public override void AutoRecycleTypeFields() {} // 0x00000001829A1A20-0x00000001829A1AD0
	[BlackList] // 0x00000001899CA3A0-0x00000001899CA3E0
	// [XID] // 0x00000001899CA3A0-0x00000001899CA3E0
	public override void ReturnToObjectPool() {} // 0x00000001829A2E40-0x00000001829A2EE0
}

