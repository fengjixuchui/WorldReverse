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
public class SECTR_BakeConfig : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18975
{
	// Fields
	private SECTR_ObjectType _objType; // 0x10
	private string _name; // 0x18
	private SimpleSafeUInt32 idRawNum; // 0x20

	// Properties
	public SECTR_ObjectType objType { /* [XID] */ /* 0x0000000189AC0810-0x0000000189AC0830 */ get => default; /* [XID] */ /* 0x0000000189AC8210-0x0000000189AC8230 */ private set {} } // 0x000000018128E850-0x000000018128E8F0 0x000000018128DE90-0x000000018128DF40
	public string name { /* [XID] */ /* 0x0000000189ACF9D0-0x0000000189ACF9F0 */ get => default; /* [XID] */ /* 0x0000000189AD76A0-0x0000000189AD76C0 */ private set {} } // 0x000000018128EF10-0x000000018128EFB0 0x000000018128E2C0-0x000000018128E370
	public uint id { /* [XID] */ /* 0x0000000189ADF150-0x0000000189ADF170 */ get => default; /* [XID] */ /* 0x0000000189AE6A00-0x0000000189AE6A20 */ private set {} } // 0x000000018128EE40-0x000000018128EF10 0x000000018128E470-0x000000018128E550

	// Constructors
	public SECTR_BakeConfig() {} // 0x000000018128F050-0x000000018128F0B0

	// Methods
	// [XID] // 0x0000000189AEE440-0x0000000189AEE460
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018128EBE0-0x000000018128ED00
	// [XID] // 0x0000000189AF5A50-0x0000000189AF5A70
	public void InitEmpty() {} // 0x000000018128E370-0x000000018128E470
	[BlackList] // 0x0000000189AFCED0-0x0000000189AFCF10
	// [XID] // 0x0000000189AFCED0-0x0000000189AFCF10
	public bool FromJson(JSONNode node) => default; // 0x000000018128DF40-0x000000018128E2C0
	// [XID] // 0x0000000189B076F0-0x0000000189B07710
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018128D340-0x000000018128D710
	// [XID] // 0x0000000189B0EF10-0x0000000189B0EF30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB611 */, bool useObjectPool = false /* Metadata: 0x00AFB615 */) => default; // 0x000000018128E550-0x000000018128E850
	// [XID] // 0x0000000189B16230-0x0000000189B16250
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB616 */, bool useObjectPool = false /* Metadata: 0x00AFB61A */) => default; // 0x000000018128DB60-0x000000018128DE90
	[BlackList] // 0x0000000189B1D930-0x0000000189B1D970
	// [XID] // 0x0000000189B1D930-0x0000000189B1D970
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018128D710-0x000000018128D9E0
	// [XID] // 0x0000000189B28010-0x0000000189B28030
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018128E8F0-0x000000018128EBE0
	[BlackList] // 0x0000000189B2F3D0-0x0000000189B2F410
	// [XID] // 0x0000000189B2F3D0-0x0000000189B2F410
	public virtual void AutoAllocTypeFields() {} // 0x000000018128D9E0-0x000000018128DA80
	[BlackList] // 0x0000000189B39E30-0x0000000189B39E70
	// [XID] // 0x0000000189B39E30-0x0000000189B39E70
	public virtual void AutoRecycleTypeFields() {} // 0x000000018128DA80-0x000000018128DB60
	[BlackList] // 0x0000000189B44850-0x0000000189B44890
	// [XID] // 0x0000000189B44850-0x0000000189B44890
	public virtual void ReturnToObjectPool() {} // 0x000000018128EFB0-0x000000018128F050
	[BlackList] // 0x0000000189B4EE30-0x0000000189B4EE70
	// [XID] // 0x0000000189B4EE30-0x0000000189B4EE70
	public virtual void OnPoolAllocated() {} // 0x000000018128EDA0-0x000000018128EE40
	[BlackList] // 0x0000000189B597A0-0x0000000189B597E0
	// [XID] // 0x0000000189B597A0-0x0000000189B597E0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018128ED00-0x000000018128EDA0
}

