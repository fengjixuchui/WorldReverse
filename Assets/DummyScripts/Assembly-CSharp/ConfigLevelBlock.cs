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
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelBlock : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14969
{
	// Fields
	private MoleMole.Config.Vector _min; // 0x10
	private MoleMole.Config.Vector _max; // 0x1C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigLevelArea[] _levelAreas; // 0x28

	// Properties
	public MoleMole.Config.Vector min { /* [XID] */ /* 0x00000001897229C0-0x00000001897229E0 */ get => default; /* [XID] */ /* 0x000000018972A160-0x000000018972A180 */ private set {} } // 0x000000018382A780-0x000000018382A860 0x0000000183829ED0-0x0000000183829FA0
	public MoleMole.Config.Vector max { /* [XID] */ /* 0x00000001897317C0-0x00000001897317E0 */ get => default; /* [XID] */ /* 0x0000000189738FF0-0x0000000189739010 */ private set {} } // 0x000000018382B090-0x000000018382B170 0x000000018382AFC0-0x000000018382B090
	public ConfigLevelArea[] levelAreas { /* [XID] */ /* 0x0000000189740DA0-0x0000000189740DC0 */ get => default; /* [XID] */ /* 0x0000000189748300-0x0000000189748320 */ private set {} } // 0x000000018382AF20-0x000000018382AFC0 0x000000018382B750-0x000000018382B800

	// Constructors
	public ConfigLevelBlock() {} // 0x000000018382BED0-0x000000018382BF30

	// Methods
	// [XID] // 0x000000018971B720-0x000000018971B740
	public bool IsInBlock(Vector3 worldPosition) => default; // 0x000000018382B270-0x000000018382B450
	// [XID] // 0x000000018974FBD0-0x000000018974FBF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018382BB90-0x000000018382BCF0
	// [XID] // 0x0000000189757160-0x0000000189757180
	public void InitEmpty() {} // 0x000000018382B170-0x000000018382B270
	[BlackList] // 0x000000018975E730-0x000000018975E770
	// [XID] // 0x000000018975E730-0x000000018975E770
	public bool FromJson(JSONNode node) => default; // 0x000000018382ABA0-0x000000018382AF20
	// [XID] // 0x0000000189768D60-0x0000000189768D80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183829FA0-0x000000018382A340
	// [XID] // 0x00000001897703F0-0x0000000189770410
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCB0 */, bool useObjectPool = false /* Metadata: 0x00AEFCB4 */) => default; // 0x000000018382B450-0x000000018382B750
	// [XID] // 0x0000000189777A70-0x0000000189777A90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCB5 */, bool useObjectPool = false /* Metadata: 0x00AEFCB9 */) => default; // 0x000000018382A860-0x000000018382ABA0
	[BlackList] // 0x000000018977F140-0x000000018977F180
	// [XID] // 0x000000018977F140-0x000000018977F180
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018382A340-0x000000018382A610
	// [XID] // 0x0000000189789920-0x0000000189789940
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018382B800-0x000000018382BB90
	[BlackList] // 0x0000000189791110-0x0000000189791150
	// [XID] // 0x0000000189791110-0x0000000189791150
	public virtual void AutoAllocTypeFields() {} // 0x000000018382A610-0x000000018382A6B0
	[BlackList] // 0x000000018979C190-0x000000018979C1D0
	// [XID] // 0x000000018979C190-0x000000018979C1D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018382A6B0-0x000000018382A780
	[BlackList] // 0x00000001897A67A0-0x00000001897A67E0
	// [XID] // 0x00000001897A67A0-0x00000001897A67E0
	public virtual void ReturnToObjectPool() {} // 0x000000018382BE30-0x000000018382BED0
	[BlackList] // 0x00000001897B0E80-0x00000001897B0EC0
	// [XID] // 0x00000001897B0E80-0x00000001897B0EC0
	public virtual void OnPoolAllocated() {} // 0x000000018382BD90-0x000000018382BE30
	[BlackList] // 0x00000001897BC3B0-0x00000001897BC3F0
	// [XID] // 0x00000001897BC3B0-0x00000001897BC3F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018382BCF0-0x000000018382BD90
}

