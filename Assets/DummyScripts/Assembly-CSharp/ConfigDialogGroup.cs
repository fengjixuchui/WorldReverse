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
public class ConfigDialogGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19062
{
	// Fields
	private SimpleSafeUInt32 talkIdRawNum; // 0x10
	private DialogGroupSchemeType _type; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigDialogScheme[] _dialogList; // 0x18

	// Properties
	public uint talkId { /* [XID] */ /* 0x0000000189734130-0x0000000189734150 */ get => default; /* [XID] */ /* 0x000000018973B890-0x000000018973B8B0 */ private set {} } // 0x0000000181713400-0x00000001817134D0 0x00000001817119B0-0x0000000181711A90
	public DialogGroupSchemeType type { /* [XID] */ /* 0x00000001897433B0-0x00000001897433D0 */ get => default; /* [XID] */ /* 0x000000018974AF40-0x000000018974AF60 */ private set {} } // 0x00000001817134D0-0x0000000181713570 0x0000000181712DD0-0x0000000181712E80
	public ConfigDialogScheme[] dialogList { /* [XID] */ /* 0x0000000189752050-0x0000000189752070 */ get => default; /* [XID] */ /* 0x0000000189759640-0x0000000189759660 */ private set {} } // 0x0000000181711E90-0x0000000181711F30 0x0000000181712D20-0x0000000181712DD0

	// Constructors
	public ConfigDialogGroup() {} // 0x0000000181713610-0x0000000181713670

	// Methods
	// [XID] // 0x00000001897611F0-0x0000000189761210
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817131A0-0x00000001817132C0
	// [XID] // 0x0000000189768580-0x00000001897685A0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181712C50-0x0000000181712D20
	// [XID] // 0x000000018976FC30-0x000000018976FC50
	public virtual ConfigDialogGroup Clone(bool useObjectPool = false /* Metadata: 0x00AFB943 */) => default; // 0x0000000181712970-0x0000000181712A50
	// [XID] // 0x0000000189777410-0x0000000189777430
	public virtual int GetHashNum() => default; // 0x0000000181711A90-0x0000000181711B60
	// [XID] // 0x000000018977EBC0-0x000000018977EBE0
	public virtual void InitEmpty() {} // 0x0000000181712480-0x0000000181712580
	[BlackList] // 0x0000000189786460-0x00000001897864A0
	// [XID] // 0x0000000189786460-0x00000001897864A0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000181711F30-0x00000001817122B0
	// [XID] // 0x0000000189A97670-0x0000000189A97690
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181711160-0x0000000181711560
	[BlackList] // 0x0000000189798340-0x0000000189798380
	// [XID] // 0x0000000189798340-0x0000000189798380
	public static ConfigDialogGroup ParseFromJson(JSONNode node) => default; // 0x0000000181712A50-0x0000000181712C50
	// [XID] // 0x00000001897A2F20-0x00000001897A2F40
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB944 */, bool useObjectPool = false /* Metadata: 0x00AFB948 */) => default; // 0x0000000181712670-0x0000000181712970
	// [XID] // 0x0000000189A9EA10-0x0000000189A9EA30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB949 */, bool useObjectPool = false /* Metadata: 0x00AFB94D */) => default; // 0x0000000181711B60-0x0000000181711E90
	// [XID] // 0x00000001897B1F30-0x00000001897B1F50
	public static ConfigDialogGroup ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB94E */, bool useObjectPool = false /* Metadata: 0x00AFB952 */) => default; // 0x00000001817122B0-0x0000000181712480
	[BlackList] // 0x00000001897B9990-0x00000001897B99D0
	// [XID] // 0x00000001897B9990-0x00000001897B99D0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000181711560-0x0000000181711830
	// [XID] // 0x00000001897C47A0-0x00000001897C47C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181712E80-0x00000001817131A0
	[BlackList] // 0x00000001897CBF70-0x00000001897CBFB0
	// [XID] // 0x00000001897CBF70-0x00000001897CBFB0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181712580-0x0000000181712670
	[BlackList] // 0x00000001897D68E0-0x00000001897D6920
	// [XID] // 0x00000001897D68E0-0x00000001897D6920
	public virtual void AutoAllocTypeFields() {} // 0x0000000181711830-0x00000001817118D0
	[BlackList] // 0x00000001897E1200-0x00000001897E1240
	// [XID] // 0x00000001897E1200-0x00000001897E1240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817118D0-0x00000001817119B0
	[BlackList] // 0x00000001897EBDC0-0x00000001897EBE00
	// [XID] // 0x00000001897EBDC0-0x00000001897EBE00
	public virtual void ReturnToObjectPool() {} // 0x0000000181713570-0x0000000181713610
	[BlackList] // 0x00000001897F63E0-0x00000001897F6420
	// [XID] // 0x00000001897F63E0-0x00000001897F6420
	public virtual void OnPoolAllocated() {} // 0x0000000181713360-0x0000000181713400
	[BlackList] // 0x0000000189800C40-0x0000000189800C80
	// [XID] // 0x0000000189800C40-0x0000000189800C80
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817132C0-0x0000000181713360
}

