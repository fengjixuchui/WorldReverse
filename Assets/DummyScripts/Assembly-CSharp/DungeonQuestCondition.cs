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
public class DungeonQuestCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18895
{
	// Fields
	private SimpleSafeUInt32 dungeonIdRawNum; // 0x10
	private SimpleSafeUInt32[] _mainQuestIdList; // 0x18

	// Properties
	public uint dungeonId { /* [XID] */ /* 0x000000018974C620-0x000000018974C640 */ get => default; /* [XID] */ /* 0x00000001897538C0-0x00000001897538E0 */ private set {} } // 0x00000001836C5220-0x00000001836C52F0 0x00000001836C5880-0x00000001836C5960
	public SimpleSafeUInt32[] mainQuestIdList { /* [XID] */ /* 0x000000018975ADC0-0x000000018975ADE0 */ get => default; /* [XID] */ /* 0x0000000189762850-0x0000000189762870 */ private set {} } // 0x00000001836C52F0-0x00000001836C5390 0x00000001836C49F0-0x00000001836C4AA0

	// Constructors
	public DungeonQuestCondition() {} // 0x00000001836C5A00-0x00000001836C5A60

	// Methods
	// [XID] // 0x0000000189769E70-0x0000000189769E90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836C5630-0x00000001836C5740
	// [XID] // 0x0000000189771610-0x0000000189771630
	public void InitEmpty() {} // 0x00000001836C4E20-0x00000001836C4F20
	[BlackList] // 0x0000000189778DC0-0x0000000189778E00
	// [XID] // 0x0000000189778DC0-0x0000000189778E00
	public bool FromJson(JSONNode node) => default; // 0x00000001836C4AA0-0x00000001836C4E20
	// [XID] // 0x0000000189783550-0x0000000189783570
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836C3FD0-0x00000001836C42D0
	// [XID] // 0x000000018978AC00-0x000000018978AC20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB2BB */, bool useObjectPool = false /* Metadata: 0x00AFB2BF */) => default; // 0x00000001836C4F20-0x00000001836C5220
	// [XID] // 0x0000000189792220-0x0000000189792240
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB2C0 */, bool useObjectPool = false /* Metadata: 0x00AFB2C4 */) => default; // 0x00000001836C4720-0x00000001836C49F0
	[BlackList] // 0x00000001897997B0-0x00000001897997F0
	// [XID] // 0x00000001897997B0-0x00000001897997F0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836C42D0-0x00000001836C45A0
	// [XID] // 0x00000001897A47D0-0x00000001897A47F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836C5390-0x00000001836C5630
	[BlackList] // 0x00000001897ABD00-0x00000001897ABD40
	// [XID] // 0x00000001897ABD00-0x00000001897ABD40
	public virtual void AutoAllocTypeFields() {} // 0x00000001836C45A0-0x00000001836C4640
	[BlackList] // 0x00000001897B6ED0-0x00000001897B6F10
	// [XID] // 0x00000001897B6ED0-0x00000001897B6F10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836C4640-0x00000001836C4720
	[BlackList] // 0x00000001897C1AB0-0x00000001897C1AF0
	// [XID] // 0x00000001897C1AB0-0x00000001897C1AF0
	public virtual void ReturnToObjectPool() {} // 0x00000001836C5960-0x00000001836C5A00
	[BlackList] // 0x00000001897CBFD0-0x00000001897CC010
	// [XID] // 0x00000001897CBFD0-0x00000001897CC010
	public virtual void OnPoolAllocated() {} // 0x00000001836C57E0-0x00000001836C5880
	[BlackList] // 0x00000001897D6980-0x00000001897D69C0
	// [XID] // 0x00000001897D6980-0x00000001897D69C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836C5740-0x00000001836C57E0
}

