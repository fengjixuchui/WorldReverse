/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigCoopInteractionGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17760
{
	// Fields
	private uint _id; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<uint, ConfigCoopBaseNode> _coopMap; // 0x18
	private uint _startNodeId; // 0x20
	private uint _failNodeId; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x00000001895EB6B0-0x00000001895EB6D0 */ get => default; /* [XID] */ /* 0x0000000189963AA0-0x0000000189963AC0 */ private set {} } // 0x00000001823D7930-0x00000001823D79D0 0x00000001823D6DA0-0x00000001823D6E50
	public Dictionary<uint, ConfigCoopBaseNode> coopMap { /* [XID] */ /* 0x0000000189986AD0-0x0000000189986AF0 */ get => default; /* [XID] */ /* 0x0000000189972AF0-0x0000000189972B10 */ private set {} } // 0x00000001823D72A0-0x00000001823D7340 0x00000001823D5F90-0x00000001823D6040
	public uint startNodeId { /* [XID] */ /* 0x00000001898F0EA0-0x00000001898F0EC0 */ get => default; /* [XID] */ /* 0x0000000189981B40-0x0000000189981B60 */ private set {} } // 0x00000001823D7200-0x00000001823D72A0 0x00000001823D7150-0x00000001823D7200
	public uint failNodeId { /* [XID] */ /* 0x00000001899894E0-0x0000000189989500 */ get => default; /* [XID] */ /* 0x0000000189990D10-0x0000000189990D30 */ private set {} } // 0x00000001823D68B0-0x00000001823D6950 0x00000001823D6800-0x00000001823D68B0

	// Constructors
	public ConfigCoopInteractionGroup() {} // 0x00000001823D7A70-0x00000001823D7AD0

	// Methods
	// [XID] // 0x0000000189998810-0x0000000189998830
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001823D76B0-0x00000001823D77F0
	// [XID] // 0x00000001899A00F0-0x00000001899A0110
	public void InitEmpty() {} // 0x00000001823D6CD0-0x00000001823D6DA0
	[BlackList] // 0x00000001899A7C40-0x00000001899A7C80
	// [XID] // 0x00000001899A7C40-0x00000001899A7C80
	public bool FromJson(JSONNode node) => default; // 0x00000001823D6950-0x00000001823D6CD0
	// [XID] // 0x00000001899B24D0-0x00000001899B24F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001823D5B80-0x00000001823D5F90
	// [XID] // 0x00000001899B97F0-0x00000001899B9810
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B39 */, bool useObjectPool = false /* Metadata: 0x00AF7B3D */) => default; // 0x00000001823D6E50-0x00000001823D7150
	// [XID] // 0x00000001899C1310-0x00000001899C1330
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B3E */, bool useObjectPool = false /* Metadata: 0x00AF7B42 */) => default; // 0x00000001823D6480-0x00000001823D6800
	[BlackList] // 0x00000001899C8920-0x00000001899C8960
	// [XID] // 0x00000001899C8920-0x00000001899C8960
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001823D6040-0x00000001823D6310
	// [XID] // 0x00000001899D30F0-0x00000001899D3110
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823D7340-0x00000001823D76B0
	[BlackList] // 0x00000001899DA6A0-0x00000001899DA6E0
	// [XID] // 0x00000001899DA6A0-0x00000001899DA6E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001823D6310-0x00000001823D63B0
	[BlackList] // 0x00000001899E5280-0x00000001899E52C0
	// [XID] // 0x00000001899E5280-0x00000001899E52C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823D63B0-0x00000001823D6480
	[BlackList] // 0x00000001899EF510-0x00000001899EF550
	// [XID] // 0x00000001899EF510-0x00000001899EF550
	public virtual void ReturnToObjectPool() {} // 0x00000001823D79D0-0x00000001823D7A70
	[BlackList] // 0x00000001899F9D10-0x00000001899F9D50
	// [XID] // 0x00000001899F9D10-0x00000001899F9D50
	public virtual void OnPoolAllocated() {} // 0x00000001823D7890-0x00000001823D7930
	[BlackList] // 0x0000000189A04230-0x0000000189A04270
	// [XID] // 0x0000000189A04230-0x0000000189A04270
	public virtual void OnBeforePoolRecycled() {} // 0x00000001823D77F0-0x00000001823D7890
}

