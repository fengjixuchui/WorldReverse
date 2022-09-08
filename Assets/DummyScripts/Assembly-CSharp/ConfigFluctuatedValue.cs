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
public class ConfigFluctuatedValue : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17516
{
	// Fields
	private SimpleSafeFloat upperRawNum; // 0x10
	private SimpleSafeFloat lowerRawNum; // 0x14

	// Properties
	public float upper { /* [XID] */ /* 0x000000018978AEE0-0x000000018978AF00 */ get => default; /* [XID] */ /* 0x0000000189792460-0x0000000189792480 */ private set {} } // 0x0000000183E70D70-0x0000000183E70E50 0x0000000183E71DB0-0x0000000183E71E90
	public float lower { /* [XID] */ /* 0x0000000189799A10-0x0000000189799A30 */ get => default; /* [XID] */ /* 0x00000001897A1920-0x00000001897A1940 */ private set {} } // 0x0000000183E72330-0x0000000183E72410 0x0000000183E71570-0x0000000183E71650

	// Constructors
	public ConfigFluctuatedValue() {} // 0x0000000183E724B0-0x0000000183E72510

	// Methods
	// [XID] // 0x00000001897A91A0-0x00000001897A91C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E720E0-0x0000000183E721F0
	// [XID] // 0x00000001897B0A20-0x00000001897B0A40
	public void InitEmpty() {} // 0x0000000183E719D0-0x0000000183E71AB0
	[BlackList] // 0x00000001897B8720-0x00000001897B8760
	// [XID] // 0x00000001897B8720-0x00000001897B8760
	public bool FromJson(JSONNode node) => default; // 0x0000000183E71650-0x0000000183E719D0
	// [XID] // 0x00000001897C3530-0x00000001897C3550
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183E70A20-0x0000000183E70D70
	// [XID] // 0x00000001897CAD10-0x00000001897CAD30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7175 */, bool useObjectPool = false /* Metadata: 0x00AF7179 */) => default; // 0x0000000183E71AB0-0x0000000183E71DB0
	// [XID] // 0x00000001897D2370-0x00000001897D2390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF717A */, bool useObjectPool = false /* Metadata: 0x00AF717E */) => default; // 0x0000000183E712A0-0x0000000183E71570
	[BlackList] // 0x00000001897DA0F0-0x00000001897DA130
	// [XID] // 0x00000001897DA0F0-0x00000001897DA130
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E70E50-0x0000000183E71120
	// [XID] // 0x00000001897E4550-0x00000001897E4570
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E71E90-0x0000000183E720E0
	[BlackList] // 0x00000001897EC020-0x00000001897EC060
	// [XID] // 0x00000001897EC020-0x00000001897EC060
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E71120-0x0000000183E711C0
	[BlackList] // 0x00000001897F6620-0x00000001897F6660
	// [XID] // 0x00000001897F6620-0x00000001897F6660
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E711C0-0x0000000183E712A0
	[BlackList] // 0x0000000189800E60-0x0000000189800EA0
	// [XID] // 0x0000000189800E60-0x0000000189800EA0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E72410-0x0000000183E724B0
	[BlackList] // 0x000000018980B3E0-0x000000018980B420
	// [XID] // 0x000000018980B3E0-0x000000018980B420
	public virtual void OnPoolAllocated() {} // 0x0000000183E72290-0x0000000183E72330
	[BlackList] // 0x0000000189815D30-0x0000000189815D70
	// [XID] // 0x0000000189815D30-0x0000000189815D70
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E721F0-0x0000000183E72290
}

