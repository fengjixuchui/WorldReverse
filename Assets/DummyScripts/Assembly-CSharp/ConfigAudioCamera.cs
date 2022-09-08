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
public class ConfigAudioCamera : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17562
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _cameraPitchRtpcKey; // 0x10

	// Properties
	public ConfigWwiseString cameraPitchRtpcKey { /* [XID] */ /* 0x00000001897EB090-0x00000001897EB0B0 */ get => default; /* [XID] */ /* 0x000000018966E6E0-0x000000018966E700 */ private set {} } // 0x0000000180F8E0C0-0x0000000180F8E160 0x0000000180F8E010-0x0000000180F8E0C0

	// Constructors
	public ConfigAudioCamera() {} // 0x0000000180F8ED50-0x0000000180F8EDB0

	// Methods
	// [XID] // 0x0000000189676300-0x0000000189676320
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F8EA90-0x0000000180F8EB70
	// [XID] // 0x000000018967DB00-0x000000018967DB20
	public void InitEmpty() {} // 0x0000000180F8E4E0-0x0000000180F8E5B0
	[BlackList] // 0x00000001896851C0-0x0000000189685200
	// [XID] // 0x00000001896851C0-0x0000000189685200
	public bool FromJson(JSONNode node) => default; // 0x0000000180F8E160-0x0000000180F8E4E0
	// [XID] // 0x0000000189690040-0x0000000189690060
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180F8D730-0x0000000180F8D930
	// [XID] // 0x0000000189697980-0x00000001896979A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72FD */, bool useObjectPool = false /* Metadata: 0x00AF7301 */) => default; // 0x0000000180F8E5B0-0x0000000180F8E8B0
	// [XID] // 0x000000018969EDF0-0x000000018969EE10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7302 */, bool useObjectPool = false /* Metadata: 0x00AF7306 */) => default; // 0x0000000180F8DDC0-0x0000000180F8E010
	[BlackList] // 0x00000001896A6130-0x00000001896A6170
	// [XID] // 0x00000001896A6130-0x00000001896A6170
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F8D930-0x0000000180F8DC00
	// [XID] // 0x00000001896B0370-0x00000001896B0390
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F8E8B0-0x0000000180F8EA90
	[BlackList] // 0x00000001896B7CF0-0x00000001896B7D30
	// [XID] // 0x00000001896B7CF0-0x00000001896B7D30
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F8DC00-0x0000000180F8DCA0
	[BlackList] // 0x00000001896C1C00-0x00000001896C1C40
	// [XID] // 0x00000001896C1C00-0x00000001896C1C40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F8DCA0-0x0000000180F8DDC0
	[BlackList] // 0x00000001896CC3B0-0x00000001896CC3F0
	// [XID] // 0x00000001896CC3B0-0x00000001896CC3F0
	public virtual void ReturnToObjectPool() {} // 0x0000000180F8ECB0-0x0000000180F8ED50
	[BlackList] // 0x00000001896D69E0-0x00000001896D6A20
	// [XID] // 0x00000001896D69E0-0x00000001896D6A20
	public virtual void OnPoolAllocated() {} // 0x0000000180F8EC10-0x0000000180F8ECB0
	[BlackList] // 0x00000001896E11D0-0x00000001896E1210
	// [XID] // 0x00000001896E11D0-0x00000001896E1210
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F8EB70-0x0000000180F8EC10
}

