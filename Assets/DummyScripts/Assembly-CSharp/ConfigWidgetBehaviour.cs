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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigWidgetBehaviour : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19187
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWidgetPredict[] _predicts; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWidgetAction[] _successActionPass; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWidgetAction[] _failedActionPass; // 0x20

	// Properties
	public ConfigWidgetPredict[] predicts { /* [XID] */ /* 0x0000000189AE69C0-0x0000000189AE69E0 */ get => default; /* [XID] */ /* 0x0000000189AEE400-0x0000000189AEE420 */ private set {} } // 0x0000000181732C70-0x0000000181732D10 0x0000000181732B10-0x0000000181732BC0
	public ConfigWidgetAction[] successActionPass { /* [XID] */ /* 0x0000000189AF59D0-0x0000000189AF59F0 */ get => default; /* [XID] */ /* 0x0000000189AFCE70-0x0000000189AFCE90 */ private set {} } // 0x0000000181733130-0x00000001817331D0 0x0000000181732BC0-0x0000000181732C70
	public ConfigWidgetAction[] failedActionPass { /* [XID] */ /* 0x0000000189B04660-0x0000000189B04680 */ get => default; /* [XID] */ /* 0x0000000189B0BEF0-0x0000000189B0BF10 */ private set {} } // 0x0000000181732D10-0x0000000181732DB0 0x0000000181732700-0x00000001817327B0

	// Constructors
	public ConfigWidgetBehaviour() {} // 0x0000000181733C30-0x0000000181733C90

	// Methods
	// [XID] // 0x0000000189B13520-0x0000000189B13540
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181733930-0x0000000181733A50
	// [XID] // 0x0000000189B1AC80-0x0000000189B1ACA0
	public void InitEmpty() {} // 0x00000001817331D0-0x00000001817332D0
	[BlackList] // 0x0000000189B221B0-0x0000000189B221F0
	// [XID] // 0x0000000189B221B0-0x0000000189B221F0
	public bool FromJson(JSONNode node) => default; // 0x0000000181732DB0-0x0000000181733130
	// [XID] // 0x0000000189B2C730-0x0000000189B2C750
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181731F20-0x00000001817322D0
	// [XID] // 0x0000000189B33C80-0x0000000189B33CA0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4B7 */, bool useObjectPool = false /* Metadata: 0x00AFC4BB */) => default; // 0x00000001817332D0-0x00000001817335D0
	// [XID] // 0x0000000189B3B530-0x0000000189B3B550
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4BC */, bool useObjectPool = false /* Metadata: 0x00AFC4C0 */) => default; // 0x00000001817327B0-0x0000000181732B10
	[BlackList] // 0x0000000189B42F10-0x0000000189B42F50
	// [XID] // 0x0000000189B42F10-0x0000000189B42F50
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001817322D0-0x00000001817325A0
	// [XID] // 0x0000000189B4D670-0x0000000189B4D690
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817335D0-0x0000000181733930
	[BlackList] // 0x0000000189B54E10-0x0000000189B54E50
	// [XID] // 0x0000000189B54E10-0x0000000189B54E50
	public virtual void AutoAllocTypeFields() {} // 0x00000001817325A0-0x0000000181732640
	[BlackList] // 0x0000000189B5F960-0x0000000189B5F9A0
	// [XID] // 0x0000000189B5F960-0x0000000189B5F9A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181732640-0x0000000181732700
	[BlackList] // 0x0000000189B69F90-0x0000000189B69FD0
	// [XID] // 0x0000000189B69F90-0x0000000189B69FD0
	public virtual void ReturnToObjectPool() {} // 0x0000000181733B90-0x0000000181733C30
	[BlackList] // 0x0000000189B74290-0x0000000189B742D0
	// [XID] // 0x0000000189B74290-0x0000000189B742D0
	public virtual void OnPoolAllocated() {} // 0x0000000181733AF0-0x0000000181733B90
	[BlackList] // 0x0000000189B7E700-0x0000000189B7E740
	// [XID] // 0x0000000189B7E700-0x0000000189B7E740
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181733A50-0x0000000181733AF0
}

