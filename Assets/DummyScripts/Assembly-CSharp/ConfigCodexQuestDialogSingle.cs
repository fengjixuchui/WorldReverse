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
public class ConfigCodexQuestDialogSingle : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17662
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCodexQuestText _text; // 0x10
	private SimpleSafeUInt32 soundIdRawNum; // 0x18
	private SimpleSafeUInt32 nextItemIdRawNum; // 0x1C

	// Properties
	public ConfigCodexQuestText text { /* [XID] */ /* 0x0000000189A8C410-0x0000000189A8C430 */ get => default; /* [XID] */ /* 0x0000000189A93890-0x0000000189A938B0 */ private set {} } // 0x0000000182074380-0x0000000182074420 0x00000001820733C0-0x0000000182073470
	public uint soundId { /* [XID] */ /* 0x0000000189A9B4A0-0x0000000189A9B4C0 */ get => default; /* [XID] */ /* 0x0000000189AA27C0-0x0000000189AA27E0 */ private set {} } // 0x0000000182073470-0x0000000182073540 0x0000000182072F60-0x0000000182073040
	public uint nextItemId { /* [XID] */ /* 0x0000000189AA9D80-0x0000000189AA9DA0 */ get => default; /* [XID] */ /* 0x0000000189AB1C80-0x0000000189AB1CA0 */ private set {} } // 0x0000000182072E90-0x0000000182072F60 0x00000001820738C0-0x00000001820739A0

	// Constructors
	public ConfigCodexQuestDialogSingle() {} // 0x00000001820744C0-0x0000000182074520

	// Methods
	// [XID] // 0x0000000189AB8F70-0x0000000189AB8F90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182074100-0x0000000182074240
	// [XID] // 0x0000000189AC0AD0-0x0000000189AC0AF0
	public void InitEmpty() {} // 0x00000001820739A0-0x0000000182073AB0
	[BlackList] // 0x0000000189AC8490-0x0000000189AC84D0
	// [XID] // 0x0000000189AC8490-0x0000000189AC84D0
	public bool FromJson(JSONNode node) => default; // 0x0000000182073540-0x00000001820738C0
	// [XID] // 0x0000000189AD2EE0-0x0000000189AD2F00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182072590-0x00000001820729B0
	// [XID] // 0x0000000189ADA900-0x0000000189ADA920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76C1 */, bool useObjectPool = false /* Metadata: 0x00AF76C5 */) => default; // 0x0000000182073AB0-0x0000000182073DB0
	// [XID] // 0x0000000189AE2160-0x0000000189AE2180
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF76C6 */, bool useObjectPool = false /* Metadata: 0x00AF76CA */) => default; // 0x0000000182073040-0x00000001820733C0
	[BlackList] // 0x0000000189AE99F0-0x0000000189AE9A30
	// [XID] // 0x0000000189AE99F0-0x0000000189AE9A30
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001820729B0-0x0000000182072C80
	// [XID] // 0x0000000189AF4510-0x0000000189AF4530
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182073DB0-0x0000000182074100
	[BlackList] // 0x0000000189AFBB80-0x0000000189AFBBC0
	// [XID] // 0x0000000189AFBB80-0x0000000189AFBBC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182072C80-0x0000000182072D20
	[BlackList] // 0x0000000189B063C0-0x0000000189B06400
	// [XID] // 0x0000000189B063C0-0x0000000189B06400
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182072D20-0x0000000182072E90
	[BlackList] // 0x0000000189B10BD0-0x0000000189B10C10
	// [XID] // 0x0000000189B10BD0-0x0000000189B10C10
	public virtual void ReturnToObjectPool() {} // 0x0000000182074420-0x00000001820744C0
	[BlackList] // 0x0000000189B1AE40-0x0000000189B1AE80
	// [XID] // 0x0000000189B1AE40-0x0000000189B1AE80
	public virtual void OnPoolAllocated() {} // 0x00000001820742E0-0x0000000182074380
	[BlackList] // 0x0000000189B25420-0x0000000189B25460
	// [XID] // 0x0000000189B25420-0x0000000189B25460
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182074240-0x00000001820742E0
}

