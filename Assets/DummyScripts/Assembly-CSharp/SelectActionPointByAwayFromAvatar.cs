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
public class SelectActionPointByAwayFromAvatar : ConfigActionPointSelectType, IAutoAllocRecycle // TypeDefIndex: 17889
{
	// Fields
	private SimpleSafeFloat distanceRawNum; // 0x10

	// Properties
	public float distance { /* [XID] */ /* 0x00000001896A7A00-0x00000001896A7A20 */ get => default; /* [XID] */ /* 0x00000001896AEE10-0x00000001896AEE30 */ private set {} } // 0x00000001827ACC30-0x00000001827ACD10 0x00000001827AEC50-0x00000001827AED30

	// Constructors
	public SelectActionPointByAwayFromAvatar() {} // 0x00000001827AF420-0x00000001827AF4D0

	// Methods
	// [XID] // 0x00000001896B64C0-0x00000001896B64E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001827AF280-0x00000001827AF380
	// [XID] // 0x00000001896BD760-0x00000001896BD780
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001827AEFE0-0x00000001827AF090
	// [XID] // 0x00000001896C4E70-0x00000001896C4E90
	public override ConfigActionPointSelectType Clone(bool useObjectPool = false /* Metadata: 0x00AF8049 */) => default; // 0x00000001827AEB10-0x00000001827AEBF0
	// [XID] // 0x00000001896CC2D0-0x00000001896CC2F0
	public override int GetHashNum() => default; // 0x00000001827AD4C0-0x00000001827AD590
	// [XID] // 0x00000001896D34E0-0x00000001896D3500
	public override void InitEmpty() {} // 0x00000001827AE570-0x00000001827AE640
	[BlackList] // 0x00000001896DB0C0-0x00000001896DB100
	// [XID] // 0x00000001896DB0C0-0x00000001896DB100
	public override bool FromJson(JSONNode node) => default; // 0x00000001827AD9A0-0x00000001827ADD20
	// [XID] // 0x00000001896E5530-0x00000001896E5550
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001827ACD10-0x00000001827ACF60
	[BlackList] // 0x00000001896ECB60-0x00000001896ECBA0
	// [XID] // 0x00000001896ECB60-0x00000001896ECBA0
	public static new SelectActionPointByAwayFromAvatar ParseFromJson(JSONNode node) => default; // 0x00000001827AED30-0x00000001827AEF80
	// [XID] // 0x00000001896F73B0-0x00000001896F73D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF804A */, bool useObjectPool = false /* Metadata: 0x00AF804E */) => default; // 0x00000001827AE810-0x00000001827AEB10
	// [XID] // 0x00000001896FED10-0x00000001896FED30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF804F */, bool useObjectPool = false /* Metadata: 0x00AF8053 */) => default; // 0x00000001827AD670-0x00000001827AD8A0
	// [XID] // 0x0000000189705EE0-0x0000000189705F00
	public static new SelectActionPointByAwayFromAvatar ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8054 */, bool useObjectPool = false /* Metadata: 0x00AF8058 */) => default; // 0x00000001827AE250-0x00000001827AE470
	[BlackList] // 0x000000018970D810-0x000000018970D850
	// [XID] // 0x000000018970D810-0x000000018970D850
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001827ACF60-0x00000001827AD230
	// [XID] // 0x0000000189717DF0-0x0000000189717E10
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001827AF090-0x00000001827AF280
	[BlackList] // 0x000000018971F7F0-0x000000018971F830
	// [XID] // 0x000000018971F7F0-0x000000018971F830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001827AE720-0x00000001827AE810
	// [XID] // 0x0000000189729C00-0x0000000189729C20
	public override LevelActionPoint GetActionPoint(ActionPointType actionPointType, BaseEntity targetEntity, BaseEntity selfEntity) => default; // 0x00000001827ADD20-0x00000001827AE250
	[BlackList] // 0x00000001897312A0-0x00000001897312E0
	// [XID] // 0x00000001897312A0-0x00000001897312E0
	public override void AutoAllocTypeFields() {} // 0x00000001827AD230-0x00000001827AD2D0
	[BlackList] // 0x000000018973BB30-0x000000018973BB70
	// [XID] // 0x000000018973BB30-0x000000018973BB70
	public override void AutoRecycleTypeFields() {} // 0x00000001827AD2D0-0x00000001827AD3A0
	[BlackList] // 0x0000000189746440-0x0000000189746480
	// [XID] // 0x0000000189746440-0x0000000189746480
	public override void ReturnToObjectPool() {} // 0x00000001827AF380-0x00000001827AF420
}

