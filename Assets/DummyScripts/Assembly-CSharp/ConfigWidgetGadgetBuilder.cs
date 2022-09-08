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
public class ConfigWidgetGadgetBuilder : ConfigBaseWidget, IAutoAllocRecycle // TypeDefIndex: 19145
{
	// Fields
	private SimpleSafeUInt32 lastingTimeRawNum; // 0x30
	private SimpleSafeUInt32 maxCountInSceneRawNum; // 0x34
	private SimpleSafeUInt32 maxCountByPlayerRawNum; // 0x38
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x3C
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x40
	private SimpleSafeFloat heightToAvatarRawNum; // 0x44
	private SimpleSafeFloat radiusRawNum; // 0x48
	private bool _checkCollision; // 0x4C

	// Properties
	public uint lastingTime { /* [XID] */ /* 0x0000000189BD0530-0x0000000189BD0550 */ get => default; /* [XID] */ /* 0x0000000189BD7A70-0x0000000189BD7A90 */ private set {} } // 0x0000000183BC6FD0-0x0000000183BC70A0 0x0000000183BC7FB0-0x0000000183BC8090
	public uint maxCountInScene { /* [XID] */ /* 0x0000000189BDF6A0-0x0000000189BDF6C0 */ get => default; /* [XID] */ /* 0x00000001895EC150-0x00000001895EC170 */ private set {} } // 0x0000000183BC92C0-0x0000000183BC9390 0x0000000183BC6700-0x0000000183BC67E0
	public uint maxCountByPlayer { /* [XID] */ /* 0x00000001895F3630-0x00000001895F3650 */ get => default; /* [XID] */ /* 0x00000001895FAF50-0x00000001895FAF70 */ private set {} } // 0x0000000183BC7280-0x0000000183BC7350 0x0000000183BC7120-0x0000000183BC7200
	public uint gadgetId { /* [XID] */ /* 0x0000000189602770-0x0000000189602790 */ get => default; /* [XID] */ /* 0x000000018960A0F0-0x000000018960A110 */ private set {} } // 0x0000000183BC7B20-0x0000000183BC7BF0 0x0000000183BC79D0-0x0000000183BC7AB0
	public float distanceToAvatar { /* [XID] */ /* 0x00000001896118A0-0x00000001896118C0 */ get => default; /* [XID] */ /* 0x0000000189619160-0x0000000189619180 */ private set {} } // 0x0000000183BC91E0-0x0000000183BC92C0 0x0000000183BC9390-0x0000000183BC9470
	public float heightToAvatar { /* [XID] */ /* 0x00000001896206A0-0x00000001896206C0 */ get => default; /* [XID] */ /* 0x0000000189627BB0-0x0000000189627BD0 */ private set {} } // 0x0000000183BC6840-0x0000000183BC6920 0x0000000183BC78F0-0x0000000183BC79D0
	public float radius { /* [XID] */ /* 0x000000018962F520-0x000000018962F540 */ get => default; /* [XID] */ /* 0x0000000189637020-0x0000000189637040 */ private set {} } // 0x0000000183BC8830-0x0000000183BC8910 0x0000000183BC9470-0x0000000183BC9550
	public bool checkCollision { /* [XID] */ /* 0x000000018963E580-0x000000018963E5A0 */ get => default; /* [XID] */ /* 0x0000000189645D20-0x0000000189645D40 */ private set {} } // 0x0000000183BC7F10-0x0000000183BC7FB0 0x0000000183BC8F80-0x0000000183BC9030

	// Constructors
	public ConfigWidgetGadgetBuilder() {} // 0x0000000183BC95F0-0x0000000183BC96B0

	// Methods
	// [XID] // 0x000000018964D600-0x000000018964D620
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183BC9030-0x0000000183BC91E0
	// [XID] // 0x0000000189654E60-0x0000000189654E80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183BC8780-0x0000000183BC8830
	// [XID] // 0x000000018965C580-0x000000018965C5A0
	public override ConfigBaseWidget Clone(bool useObjectPool = false /* Metadata: 0x00AFC34D */) => default; // 0x0000000183BC8390-0x0000000183BC8470
	// [XID] // 0x0000000189663B80-0x0000000189663BA0
	public override int GetHashNum() => default; // 0x0000000183BC6630-0x0000000183BC6700
	// [XID] // 0x000000018966B3E0-0x000000018966B400
	public override void InitEmpty() {} // 0x0000000183BC7BF0-0x0000000183BC7D40
	[BlackList] // 0x00000001896730A0-0x00000001896730E0
	// [XID] // 0x00000001896730A0-0x00000001896730E0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183BC7350-0x0000000183BC76D0
	// [XID] // 0x000000018967D940-0x000000018967D960
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183BC5700-0x0000000183BC6030
	[BlackList] // 0x0000000189684F20-0x0000000189684F60
	// [XID] // 0x0000000189684F20-0x0000000189684F60
	public static new ConfigWidgetGadgetBuilder ParseFromJson(JSONNode node) => default; // 0x0000000183BC84D0-0x0000000183BC8720
	// [XID] // 0x000000018968FDA0-0x000000018968FDC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC34E */, bool useObjectPool = false /* Metadata: 0x00AFC352 */) => default; // 0x0000000183BC8090-0x0000000183BC8390
	// [XID] // 0x0000000189697740-0x0000000189697760
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC353 */, bool useObjectPool = false /* Metadata: 0x00AFC357 */) => default; // 0x0000000183BC69A0-0x0000000183BC6FD0
	// [XID] // 0x000000018969EBF0-0x000000018969EC10
	public static new ConfigWidgetGadgetBuilder ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC358 */, bool useObjectPool = false /* Metadata: 0x00AFC35C */) => default; // 0x0000000183BC76D0-0x0000000183BC78F0
	[BlackList] // 0x00000001896A5ED0-0x00000001896A5F10
	// [XID] // 0x00000001896A5ED0-0x00000001896A5F10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183BC6030-0x0000000183BC6300
	// [XID] // 0x00000001896B0150-0x00000001896B0170
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183BC8910-0x0000000183BC8F80
	[BlackList] // 0x00000001896B79F0-0x00000001896B7A30
	// [XID] // 0x00000001896B79F0-0x00000001896B7A30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183BC7E20-0x0000000183BC7F10
	[BlackList] // 0x00000001896C18E0-0x00000001896C1920
	// [XID] // 0x00000001896C18E0-0x00000001896C1920
	public override void AutoAllocTypeFields() {} // 0x0000000183BC6300-0x0000000183BC63A0
	[BlackList] // 0x00000001896CBFD0-0x00000001896CC010
	// [XID] // 0x00000001896CBFD0-0x00000001896CC010
	public override void AutoRecycleTypeFields() {} // 0x0000000183BC63A0-0x0000000183BC6510
	[BlackList] // 0x00000001896D66C0-0x00000001896D6700
	// [XID] // 0x00000001896D66C0-0x00000001896D6700
	public override void ReturnToObjectPool() {} // 0x0000000183BC9550-0x0000000183BC95F0
}

