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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigRecordRagdollParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18875
{
	// Fields
	private ulong _prefabHash; // 0x10
	private MoleMole.Config.Vector _velocityOnRoot; // 0x18
	private MoleMole.Config.Vector _explosionForce; // 0x24

	// Properties
	public ulong prefabHash { /* [XID] */ /* 0x0000000189AA8240-0x0000000189AA8260 */ get => default; /* [XID] */ /* 0x0000000189AAFF50-0x0000000189AAFF70 */ private set {} } // 0x000000018257AFF0-0x000000018257B090 0x000000018257A480-0x000000018257A530
	public MoleMole.Config.Vector velocityOnRoot { /* [XID] */ /* 0x0000000189AB7670-0x0000000189AB7690 */ get => default; /* [XID] */ /* 0x0000000189ABF0F0-0x0000000189ABF110 */ private set {} } // 0x000000018257A2B0-0x000000018257A390 0x0000000182579E60-0x0000000182579F30
	public MoleMole.Config.Vector explosionForce { /* [XID] */ /* 0x0000000189AC6BA0-0x0000000189AC6BC0 */ get => default; /* [XID] */ /* 0x0000000189ACE390-0x0000000189ACE3B0 */ private set {} } // 0x000000018257A900-0x000000018257A9E0 0x000000018257A830-0x000000018257A900

	// Constructors
	public ConfigRecordRagdollParameters() {} // 0x000000018257B130-0x000000018257B190

	// Methods
	// [XID] // 0x0000000189AD6160-0x0000000189AD6180
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018257AD40-0x000000018257AEB0
	// [XID] // 0x0000000189ADDA70-0x0000000189ADDA90
	public void InitEmpty() {} // 0x000000018257A390-0x000000018257A480
	[BlackList] // 0x0000000189AE5340-0x0000000189AE5380
	// [XID] // 0x0000000189AE5340-0x0000000189AE5380
	public bool FromJson(JSONNode node) => default; // 0x0000000182579F30-0x000000018257A2B0
	// [XID] // 0x0000000189AEFDE0-0x0000000189AEFE00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182579390-0x0000000182579710
	// [XID] // 0x0000000189AF7320-0x0000000189AF7340
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1F3 */, bool useObjectPool = false /* Metadata: 0x00AFB1F7 */) => default; // 0x000000018257A530-0x000000018257A830
	// [XID] // 0x0000000189AFE9F0-0x0000000189AFEA10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1F8 */, bool useObjectPool = false /* Metadata: 0x00AFB1FC */) => default; // 0x0000000182579B40-0x0000000182579E60
	[BlackList] // 0x0000000189B061C0-0x0000000189B06200
	// [XID] // 0x0000000189B061C0-0x0000000189B06200
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182579710-0x00000001825799E0
	// [XID] // 0x0000000189B109D0-0x0000000189B109F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018257A9E0-0x000000018257AD40
	[BlackList] // 0x0000000189B17A80-0x0000000189B17AC0
	// [XID] // 0x0000000189B17A80-0x0000000189B17AC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001825799E0-0x0000000182579A80
	[BlackList] // 0x0000000189B22230-0x0000000189B22270
	// [XID] // 0x0000000189B22230-0x0000000189B22270
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182579A80-0x0000000182579B40
	[BlackList] // 0x0000000189B2C750-0x0000000189B2C790
	// [XID] // 0x0000000189B2C750-0x0000000189B2C790
	public virtual void ReturnToObjectPool() {} // 0x000000018257B090-0x000000018257B130
	[BlackList] // 0x0000000189B36CF0-0x0000000189B36D30
	// [XID] // 0x0000000189B36CF0-0x0000000189B36D30
	public virtual void OnPoolAllocated() {} // 0x000000018257AF50-0x000000018257AFF0
	[BlackList] // 0x0000000189B417B0-0x0000000189B417F0
	// [XID] // 0x0000000189B417B0-0x0000000189B417F0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018257AEB0-0x000000018257AF50
}

