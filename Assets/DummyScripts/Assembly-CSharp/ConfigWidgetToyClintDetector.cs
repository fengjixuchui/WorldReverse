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
public class ConfigWidgetToyClintDetector : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19204
{
	// Fields
	private SimpleSafeUInt32 gadgetIdRawNum; // 0x30
	private SimpleSafeUInt32 allowCityIdRawNum; // 0x34
	private SimpleSafeUInt32 hintGroupRawNum; // 0x38
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x3C
	private SimpleSafeFloat heightRawNum; // 0x40

	// Properties
	public uint gadgetId { /* [XID] */ /* 0x0000000189B6FBA0-0x0000000189B6FBC0 */ get => default; /* [XID] */ /* 0x0000000189B770B0-0x0000000189B770D0 */ private set {} } // 0x0000000183336570-0x0000000183336640 0x0000000183336420-0x0000000183336500
	public uint allowCityId { /* [XID] */ /* 0x0000000189B7E6E0-0x0000000189B7E700 */ get => default; /* [XID] */ /* 0x0000000189B86360-0x0000000189B86380 */ private set {} } // 0x0000000183337110-0x00000001833371E0 0x0000000183336120-0x0000000183336200
	public uint hintGroup { /* [XID] */ /* 0x0000000189B8D3D0-0x0000000189B8D3F0 */ get => default; /* [XID] */ /* 0x0000000189B94AB0-0x0000000189B94AD0 */ private set {} } // 0x0000000183335600-0x00000001833356D0 0x00000001833347B0-0x0000000183334890
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189B9C1A0-0x0000000189B9C1C0 */ get => default; /* [XID] */ /* 0x0000000189BA38F0-0x0000000189BA3910 */ private set {} } // 0x0000000183337980-0x0000000183337A60 0x0000000183337A60-0x0000000183337B40
	public float height { /* [XID] */ /* 0x0000000189BAAD20-0x0000000189BAAD40 */ get => default; /* [XID] */ /* 0x0000000189BB22F0-0x0000000189BB2310 */ private set {} } // 0x0000000183337740-0x0000000183337820 0x0000000183336FD0-0x00000001833370B0

	// Constructors
	public ConfigWidgetToyClintDetector() {} // 0x0000000183337BE0-0x0000000183337C40

	// Methods
	// [XID] // 0x0000000189BB9780-0x0000000189BB97A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183337820-0x0000000183337980
	// [XID] // 0x0000000189BC1620-0x0000000189BC1640
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001833371E0-0x0000000183337290
	// [XID] // 0x0000000189BC8CE0-0x0000000189BC8D00
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC535 */) => default; // 0x0000000183336C40-0x0000000183336D20
	// [XID] // 0x0000000189BD04F0-0x0000000189BD0510
	public override int GetHashNum() => default; // 0x0000000183335530-0x0000000183335600
	// [XID] // 0x0000000189BD7A30-0x0000000189BD7A50
	public override void InitEmpty() {} // 0x0000000183336640-0x0000000183336770
	[BlackList] // 0x0000000189BDF640-0x0000000189BDF680
	// [XID] // 0x0000000189BDF640-0x0000000189BDF680
	public override bool FromJson(JSONNode node) => default; // 0x0000000183335DA0-0x0000000183336120
	// [XID] // 0x00000001895EEF40-0x00000001895EEF60
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183334890-0x0000000183334F50
	[BlackList] // 0x00000001895F6920-0x00000001895F6960
	// [XID] // 0x00000001895F6920-0x00000001895F6960
	public static new ConfigWidgetToyClintDetector ParseFromJson(JSONNode node) => default; // 0x0000000183336D80-0x0000000183336FD0
	// [XID] // 0x0000000189600FC0-0x0000000189600FE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC536 */, bool useObjectPool = false /* Metadata: 0x00AFC53A */) => default; // 0x0000000183336940-0x0000000183336C40
	// [XID] // 0x0000000189608950-0x0000000189608970
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC53B */, bool useObjectPool = false /* Metadata: 0x00AFC53F */) => default; // 0x00000001833357B0-0x0000000183335CA0
	// [XID] // 0x0000000189610090-0x00000001896100B0
	public static new ConfigWidgetToyClintDetector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC540 */, bool useObjectPool = false /* Metadata: 0x00AFC544 */) => default; // 0x0000000183336200-0x0000000183336420
	[BlackList] // 0x0000000189617370-0x00000001896173B0
	// [XID] // 0x0000000189617370-0x00000001896173B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183334F50-0x0000000183335220
	// [XID] // 0x0000000189621C00-0x0000000189621C20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183337290-0x0000000183337740
	[BlackList] // 0x0000000189629590-0x00000001896295D0
	// [XID] // 0x0000000189629590-0x00000001896295D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183336850-0x0000000183336940
	[BlackList] // 0x0000000189633E30-0x0000000189633E70
	// [XID] // 0x0000000189633E30-0x0000000189633E70
	public override void AutoAllocTypeFields() {} // 0x0000000183335220-0x00000001833352C0
	[BlackList] // 0x000000018963E540-0x000000018963E580
	// [XID] // 0x000000018963E540-0x000000018963E580
	public override void AutoRecycleTypeFields() {} // 0x00000001833352C0-0x0000000183335410
	[BlackList] // 0x0000000189648D60-0x0000000189648DA0
	// [XID] // 0x0000000189648D60-0x0000000189648DA0
	public override void ReturnToObjectPool() {} // 0x0000000183337B40-0x0000000183337BE0
}

