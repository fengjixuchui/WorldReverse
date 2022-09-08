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
public class ConfigWidgetAttachAvatar : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19141
{
	// Fields
	private SimpleSafeUInt32 useGadgetIdRawNum; // 0x30

	// Properties
	public uint useGadgetId { /* [XID] */ /* 0x0000000189A4E540-0x0000000189A4E560 */ get => default; /* [XID] */ /* 0x0000000189A55D00-0x0000000189A55D20 */ private set {} } // 0x0000000184730390-0x0000000184730460 0x00000001847318A0-0x0000000184731980

	// Constructors
	public ConfigWidgetAttachAvatar() {} // 0x0000000184731D40-0x0000000184731DC0

	// Methods
	// [XID] // 0x0000000189A5D520-0x0000000189A5D540
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184731BB0-0x0000000184731CA0
	// [XID] // 0x0000000189A64E60-0x0000000189A64E80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847317F0-0x00000001847318A0
	// [XID] // 0x0000000189A6C5C0-0x0000000189A6C5E0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC32D */) => default; // 0x0000000184731400-0x00000001847314E0
	// [XID] // 0x0000000189A73DF0-0x0000000189A73E10
	public override int GetHashNum() => default; // 0x0000000184730260-0x0000000184730330
	// [XID] // 0x0000000189A7B8C0-0x0000000189A7B8E0
	public override void InitEmpty() {} // 0x0000000184730E60-0x0000000184730F30
	[BlackList] // 0x0000000189A830A0-0x0000000189A830E0
	// [XID] // 0x0000000189A830A0-0x0000000189A830E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184730850-0x0000000184730BD0
	// [XID] // 0x0000000189A8D990-0x0000000189A8D9B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018472FA90-0x000000018472FCF0
	[BlackList] // 0x0000000189A94EB0-0x0000000189A94EF0
	// [XID] // 0x0000000189A94EB0-0x0000000189A94EF0
	public static new ConfigWidgetAttachAvatar ParseFromJson(JSONNode node) => default; // 0x0000000184731540-0x0000000184731790
	// [XID] // 0x0000000189A9F610-0x0000000189A9F630
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC32E */, bool useObjectPool = false /* Metadata: 0x00AFC332 */) => default; // 0x0000000184731100-0x0000000184731400
	// [XID] // 0x0000000189AA6F20-0x0000000189AA6F40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC333 */, bool useObjectPool = false /* Metadata: 0x00AFC337 */) => default; // 0x00000001847304E0-0x0000000184730750
	// [XID] // 0x0000000189AAE660-0x0000000189AAE680
	public static new ConfigWidgetAttachAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC338 */, bool useObjectPool = false /* Metadata: 0x00AFC33C */) => default; // 0x0000000184730BD0-0x0000000184730DF0
	[BlackList] // 0x0000000189AB5E20-0x0000000189AB5E60
	// [XID] // 0x0000000189AB5E20-0x0000000189AB5E60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018472FCF0-0x000000018472FFC0
	// [XID] // 0x0000000189AC07D0-0x0000000189AC07F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184731980-0x0000000184731BB0
	[BlackList] // 0x0000000189AC81B0-0x0000000189AC81F0
	// [XID] // 0x0000000189AC81B0-0x0000000189AC81F0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184731010-0x0000000184731100
	[BlackList] // 0x0000000189AD2C80-0x0000000189AD2CC0
	// [XID] // 0x0000000189AD2C80-0x0000000189AD2CC0
	public override void AutoAllocTypeFields() {} // 0x000000018472FFC0-0x0000000184730060
	[BlackList] // 0x0000000189ADD9B0-0x0000000189ADD9F0
	// [XID] // 0x0000000189ADD9B0-0x0000000189ADD9F0
	public override void AutoRecycleTypeFields() {} // 0x0000000184730060-0x0000000184730140
	[BlackList] // 0x0000000189AE7F90-0x0000000189AE7FD0
	// [XID] // 0x0000000189AE7F90-0x0000000189AE7FD0
	public override void ReturnToObjectPool() {} // 0x0000000184731CA0-0x0000000184731D40
}

