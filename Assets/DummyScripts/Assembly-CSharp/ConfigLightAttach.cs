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
public class ConfigLightAttach : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16386
{
	// Fields
	private string _attachPoint; // 0x10
	private SimpleSafeFloat localPosXRawNum; // 0x18
	private SimpleSafeFloat localPosYRawNum; // 0x1C
	private SimpleSafeFloat localPosZRawNum; // 0x20
	private SimpleSafeFloat localRotXRawNum; // 0x24
	private SimpleSafeFloat localRotYRawNum; // 0x28
	private SimpleSafeFloat localRotZRawNum; // 0x2C
	private SimpleSafeFloat localRotWRawNum; // 0x30

	// Properties
	public string attachPoint { /* [XID] */ /* 0x00000001898C5E90-0x00000001898C5EB0 */ get => default; /* [XID] */ /* 0x00000001898CD600-0x00000001898CD620 */ private set {} } // 0x00000001845BAA60-0x00000001845BAB00 0x00000001845BB2E0-0x00000001845BB390
	public float localPosX { /* [XID] */ /* 0x00000001898D5050-0x00000001898D5070 */ get => default; /* [XID] */ /* 0x00000001898DC990-0x00000001898DC9B0 */ private set {} } // 0x00000001845BC2C0-0x00000001845BC3A0 0x00000001845BA370-0x00000001845BA450
	public float localPosY { /* [XID] */ /* 0x00000001898E4440-0x00000001898E4460 */ get => default; /* [XID] */ /* 0x00000001898EBE90-0x00000001898EBEB0 */ private set {} } // 0x00000001845B9D10-0x00000001845B9DF0 0x00000001845BABE0-0x00000001845BACC0
	public float localPosZ { /* [XID] */ /* 0x00000001898F3780-0x00000001898F37A0 */ get => default; /* [XID] */ /* 0x00000001898FAE00-0x00000001898FAE20 */ private set {} } // 0x00000001845BA290-0x00000001845BA370 0x00000001845BB200-0x00000001845BB2E0
	public float localRotX { /* [XID] */ /* 0x00000001899029E0-0x0000000189902A00 */ get => default; /* [XID] */ /* 0x0000000189909F00-0x0000000189909F20 */ private set {} } // 0x00000001845B9390-0x00000001845B9470 0x00000001845BB040-0x00000001845BB120
	public float localRotY { /* [XID] */ /* 0x00000001899117A0-0x00000001899117C0 */ get => default; /* [XID] */ /* 0x0000000189919320-0x0000000189919340 */ private set {} } // 0x00000001845BB7C0-0x00000001845BB8A0 0x00000001845BA980-0x00000001845BAA60
	public float localRotZ { /* [XID] */ /* 0x00000001899208B0-0x00000001899208D0 */ get => default; /* [XID] */ /* 0x0000000189928270-0x0000000189928290 */ private set {} } // 0x00000001845BB120-0x00000001845BB200 0x00000001845BC1E0-0x00000001845BC2C0
	public float localRotW { /* [XID] */ /* 0x000000018992F7C0-0x000000018992F7E0 */ get => default; /* [XID] */ /* 0x0000000189936C70-0x0000000189936C90 */ private set {} } // 0x00000001845BB8A0-0x00000001845BB980 0x00000001845BAB00-0x00000001845BABE0

	// Constructors
	public ConfigLightAttach() {} // 0x00000001845BC440-0x00000001845BC540

	// Methods
	// [XID] // 0x000000018993E850-0x000000018993E870
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845BBEF0-0x00000001845BC0A0
	// [XID] // 0x0000000189945E40-0x0000000189945E60
	public void InitEmpty() {} // 0x00000001845BB390-0x00000001845BB4C0
	[BlackList] // 0x000000018994D370-0x000000018994D3B0
	// [XID] // 0x000000018994D370-0x000000018994D3B0
	public bool FromJson(JSONNode node) => default; // 0x00000001845BACC0-0x00000001845BB040
	// [XID] // 0x0000000189957C40-0x0000000189957C60
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001845B9470-0x00000001845B9D10
	// [XID] // 0x000000018995F530-0x000000018995F550
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39DC */, bool useObjectPool = false /* Metadata: 0x00AF39E0 */) => default; // 0x00000001845BB4C0-0x00000001845BB7C0
	// [XID] // 0x0000000189966D90-0x0000000189966DB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF39E1 */, bool useObjectPool = false /* Metadata: 0x00AF39E5 */) => default; // 0x00000001845BA450-0x00000001845BA980
	[BlackList] // 0x000000018996E0A0-0x000000018996E0E0
	// [XID] // 0x000000018996E0A0-0x000000018996E0E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001845B9DF0-0x00000001845BA0C0
	// [XID] // 0x0000000189979210-0x0000000189979230
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845BB980-0x00000001845BBEF0
	[BlackList] // 0x00000001899802E0-0x0000000189980320
	// [XID] // 0x00000001899802E0-0x0000000189980320
	public virtual void AutoAllocTypeFields() {} // 0x00000001845BA0C0-0x00000001845BA160
	[BlackList] // 0x000000018998AEE0-0x000000018998AF20
	// [XID] // 0x000000018998AEE0-0x000000018998AF20
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845BA160-0x00000001845BA290
	[BlackList] // 0x00000001899959D0-0x0000000189995A10
	// [XID] // 0x00000001899959D0-0x0000000189995A10
	public virtual void ReturnToObjectPool() {} // 0x00000001845BC3A0-0x00000001845BC440
	[BlackList] // 0x00000001899A0470-0x00000001899A04B0
	// [XID] // 0x00000001899A0470-0x00000001899A04B0
	public virtual void OnPoolAllocated() {} // 0x00000001845BC140-0x00000001845BC1E0
	[BlackList] // 0x00000001899AAE20-0x00000001899AAE60
	// [XID] // 0x00000001899AAE20-0x00000001899AAE60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845BC0A0-0x00000001845BC140
}

