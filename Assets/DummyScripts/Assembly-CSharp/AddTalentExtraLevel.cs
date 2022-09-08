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
public class AddTalentExtraLevel : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19056
{
	// Fields
	private TalentType _talentType; // 0x10
	private SimpleSafeUInt32 talentIndexRawNum; // 0x14
	private SimpleSafeUInt32 extraLevelRawNum; // 0x18

	// Properties
	public TalentType talentType { /* [XID] */ /* 0x0000000189981980-0x00000001899819A0 */ get => default; /* [XID] */ /* 0x00000001899892A0-0x00000001899892C0 */ private set {} } // 0x0000000183C04BC0-0x0000000183C04C60 0x0000000183C05040-0x0000000183C050F0
	public uint talentIndex { /* [XID] */ /* 0x0000000189990A50-0x0000000189990A70 */ get => default; /* [XID] */ /* 0x00000001899984F0-0x0000000189998510 */ private set {} } // 0x0000000183C06300-0x0000000183C063D0 0x0000000183C06A10-0x0000000183C06AF0
	public uint extraLevel { /* [XID] */ /* 0x000000018999FD70-0x000000018999FD90 */ get => default; /* [XID] */ /* 0x00000001899A7A60-0x00000001899A7A80 */ private set {} } // 0x0000000183C055F0-0x0000000183C056C0 0x0000000183C065D0-0x0000000183C066B0

	// Constructors
	public AddTalentExtraLevel() {} // 0x0000000183C07030-0x0000000183C07090

	// Methods
	// [XID] // 0x00000001899AF250-0x00000001899AF270
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C06E60-0x0000000183C06F90
	// [XID] // 0x00000001899B6530-0x00000001899B6550
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183C06960-0x0000000183C06A10
	// [XID] // 0x00000001899BE170-0x00000001899BE190
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB8E9 */) => default; // 0x0000000183C06490-0x0000000183C06570
	// [XID] // 0x00000001899C5930-0x00000001899C5950
	public override int GetHashNum() => default; // 0x0000000183C04F10-0x0000000183C04FE0
	// [XID] // 0x00000001899CCF70-0x00000001899CCF90
	public override void InitEmpty() {} // 0x0000000183C05D50-0x0000000183C05E30
	[BlackList] // 0x00000001899D4510-0x00000001899D4550
	// [XID] // 0x00000001899D4510-0x00000001899D4550
	public override bool FromJson(JSONNode node) => default; // 0x0000000183C056C0-0x0000000183C05A40
	// [XID] // 0x00000001899DE910-0x00000001899DE930
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183C04490-0x0000000183C048F0
	[BlackList] // 0x00000001899E6610-0x00000001899E6650
	// [XID] // 0x00000001899E6610-0x00000001899E6650
	public static new AddTalentExtraLevel ParseFromJson(JSONNode node) => default; // 0x0000000183C066B0-0x0000000183C06900
	// [XID] // 0x00000001899F0AD0-0x00000001899F0AF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8EA */, bool useObjectPool = false /* Metadata: 0x00AFB8EE */) => default; // 0x0000000183C06000-0x0000000183C06300
	// [XID] // 0x00000001899F8350-0x00000001899F8370
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8EF */, bool useObjectPool = false /* Metadata: 0x00AFB8F3 */) => default; // 0x0000000183C05170-0x0000000183C054F0
	// [XID] // 0x00000001899FF900-0x00000001899FF920
	public static new AddTalentExtraLevel ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB8F4 */, bool useObjectPool = false /* Metadata: 0x00AFB8F8 */) => default; // 0x0000000183C05A40-0x0000000183C05C60
	[BlackList] // 0x0000000189A07150-0x0000000189A07190
	// [XID] // 0x0000000189A07150-0x0000000189A07190
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C048F0-0x0000000183C04BC0
	// [XID] // 0x0000000189A11980-0x0000000189A119A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C06AF0-0x0000000183C06E60
	[BlackList] // 0x0000000189A18B70-0x0000000189A18BB0
	// [XID] // 0x0000000189A18B70-0x0000000189A18BB0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183C05F10-0x0000000183C06000
	// [XID] // 0x0000000189A233C0-0x0000000189A233E0
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x0000000183C063D0-0x0000000183C06490
	[BlackList] // 0x0000000189A2A660-0x0000000189A2A6A0
	// [XID] // 0x0000000189A2A660-0x0000000189A2A6A0
	public override void AutoAllocTypeFields() {} // 0x0000000183C04C60-0x0000000183C04D00
	[BlackList] // 0x0000000189A34ED0-0x0000000189A34F10
	// [XID] // 0x0000000189A34ED0-0x0000000189A34F10
	public override void AutoRecycleTypeFields() {} // 0x0000000183C04D00-0x0000000183C04DF0
	[BlackList] // 0x0000000189A3F660-0x0000000189A3F6A0
	// [XID] // 0x0000000189A3F660-0x0000000189A3F6A0
	public override void ReturnToObjectPool() {} // 0x0000000183C06F90-0x0000000183C07030
}

