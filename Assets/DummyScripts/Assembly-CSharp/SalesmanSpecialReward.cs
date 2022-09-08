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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class SalesmanSpecialReward : IAutoAllocRecycle // TypeDefIndex: 15168
{
	// Fields
	protected SalesmanSpecialRewardType _rewardType; // 0x10
	protected SalesmanSpecialRewardObtainMethod _obtainMethod; // 0x14
	protected string _obtainParam; // 0x18
	protected SimpleSafeUInt32 idRawNum; // 0x20
	protected SimpleSafeUInt32 previewIdRawNum; // 0x24

	// Properties
	public SalesmanSpecialRewardType rewardType { /* [XID] */ /* 0x0000000189861510-0x0000000189861530 */ get => default; /* [XID] */ /* 0x0000000189868D10-0x0000000189868D30 */ protected set {} } // 0x00000001835F6B70-0x00000001835F6C10 0x00000001835F6340-0x00000001835F63F0
	public SalesmanSpecialRewardObtainMethod obtainMethod { /* [XID] */ /* 0x00000001898700E0-0x0000000189870100 */ get => default; /* [XID] */ /* 0x0000000189877750-0x0000000189877770 */ protected set {} } // 0x00000001835F64D0-0x00000001835F6570 0x00000001835F6AC0-0x00000001835F6B70
	public string obtainParam { /* [XID] */ /* 0x000000018987EFE0-0x000000018987F000 */ get => default; /* [XID] */ /* 0x00000001898865A0-0x00000001898865C0 */ protected set {} } // 0x00000001835F6ED0-0x00000001835F6F70 0x00000001835F6C10-0x00000001835F6CC0
	public uint id { /* [XID] */ /* 0x000000018988D780-0x000000018988D7A0 */ get => default; /* [XID] */ /* 0x0000000189894E90-0x0000000189894EB0 */ protected set {} } // 0x00000001835F6E00-0x00000001835F6ED0 0x00000001835F63F0-0x00000001835F64D0
	public uint previewId { /* [XID] */ /* 0x000000018989C5A0-0x000000018989C5C0 */ get => default; /* [XID] */ /* 0x00000001898A3D40-0x00000001898A3D60 */ protected set {} } // 0x00000001835F6270-0x00000001835F6340 0x00000001835F5DD0-0x00000001835F5EB0

	// Constructors
	public SalesmanSpecialReward() {} // 0x00000001835F7010-0x00000001835F7070

	// Methods
	// [XID] // 0x00000001898AAF80-0x00000001898AAFA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835F5EB0-0x00000001835F6270
	// [XID] // 0x00000001898B2890-0x00000001898B28B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF02B8 */, bool useObjectPool = false /* Metadata: 0x00AF02BC */) => default; // 0x00000001835F6570-0x00000001835F6AC0
	[BlackList] // 0x00000001898BA6C0-0x00000001898BA700
	// [XID] // 0x00000001898BA6C0-0x00000001898BA700
	public virtual void AutoAllocTypeFields() {} // 0x00000001835F5C40-0x00000001835F5CE0
	[BlackList] // 0x00000001898C4B80-0x00000001898C4BC0
	// [XID] // 0x00000001898C4B80-0x00000001898C4BC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835F5CE0-0x00000001835F5DD0
	[BlackList] // 0x00000001898CF2B0-0x00000001898CF2F0
	// [XID] // 0x00000001898CF2B0-0x00000001898CF2F0
	public virtual void ReturnToObjectPool() {} // 0x00000001835F6F70-0x00000001835F7010
	[BlackList] // 0x00000001898D9AD0-0x00000001898D9B10
	// [XID] // 0x00000001898D9AD0-0x00000001898D9B10
	public virtual void OnPoolAllocated() {} // 0x00000001835F6D60-0x00000001835F6E00
	[BlackList] // 0x00000001898E45C0-0x00000001898E4600
	// [XID] // 0x00000001898E45C0-0x00000001898E4600
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835F6CC0-0x00000001835F6D60
}

