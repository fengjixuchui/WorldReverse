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
public class ConfigClimateInfo : ConfigClimateInfoBase, IAutoAllocRecycle // TypeDefIndex: 17654
{
	// Fields
	private JsonClimateType _climateType; // 0x10
	private string _climateDialogTitle; // 0x18
	private string _climateDialogDesc; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigClimateTemperatureOptions _temperatureOptions; // 0x28

	// Properties
	public JsonClimateType climateType { /* [XID] */ /* 0x00000001897806C0-0x00000001897806E0 */ get => default; /* [XID] */ /* 0x0000000189787EA0-0x0000000189787EC0 */ private set {} } // 0x000000018475C3F0-0x000000018475C490 0x000000018475C490-0x000000018475C540
	public string climateDialogTitle { /* [XID] */ /* 0x000000018978F440-0x000000018978F460 */ get => default; /* [XID] */ /* 0x0000000189796C10-0x0000000189796C30 */ private set {} } // 0x000000018475D0C0-0x000000018475D160 0x000000018475B650-0x000000018475B700
	public string climateDialogDesc { /* [XID] */ /* 0x000000018979ECD0-0x000000018979ECF0 */ get => default; /* [XID] */ /* 0x00000001897A6320-0x00000001897A6340 */ private set {} } // 0x000000018475D5B0-0x000000018475D650 0x000000018475C810-0x000000018475C8C0
	public ConfigClimateTemperatureOptions temperatureOptions { /* [XID] */ /* 0x00000001897AD850-0x00000001897AD870 */ get => default; /* [XID] */ /* 0x00000001897B5970-0x00000001897B5990 */ private set {} } // 0x000000018475D160-0x000000018475D200 0x000000018475BD30-0x000000018475BDE0

	// Constructors
	public ConfigClimateInfo() {} // 0x000000018475D850-0x000000018475D8B0

	// Methods
	// [XID] // 0x00000001897BD6A0-0x00000001897BD6C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018475D650-0x000000018475D7B0
	// [XID] // 0x00000001897C4A80-0x00000001897C4AA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018475CFB0-0x000000018475D0C0
	// [XID] // 0x00000001897CC330-0x00000001897CC350
	public override ConfigClimateInfoBase Clone(bool useObjectPool = false /* Metadata: 0x00AF763F */) => default; // 0x000000018475CBC0-0x000000018475CCA0
	// [XID] // 0x00000001897D3C20-0x00000001897D3C40
	public override int GetHashNum() => default; // 0x000000018475B580-0x000000018475B650
	// [XID] // 0x00000001897DB630-0x00000001897DB650
	public override void InitEmpty() {} // 0x000000018475C540-0x000000018475C640
	[BlackList] // 0x00000001897E2D80-0x00000001897E2DC0
	// [XID] // 0x00000001897E2D80-0x00000001897E2DC0
	public override bool FromJson(JSONNode node) => default; // 0x000000018475BDE0-0x000000018475C160
	// [XID] // 0x00000001897ED770-0x00000001897ED790
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018475AAE0-0x000000018475AFB0
	[BlackList] // 0x00000001897F4FF0-0x00000001897F5030
	// [XID] // 0x00000001897F4FF0-0x00000001897F5030
	public static new ConfigClimateInfo ParseFromJson(JSONNode node) => default; // 0x000000018475CD00-0x000000018475CF50
	// [XID] // 0x00000001897FF7F0-0x00000001897FF810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7640 */, bool useObjectPool = false /* Metadata: 0x00AF7644 */) => default; // 0x000000018475C8C0-0x000000018475CBC0
	// [XID] // 0x0000000189806F70-0x0000000189806F90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7645 */, bool useObjectPool = false /* Metadata: 0x00AF7649 */) => default; // 0x000000018475B7E0-0x000000018475BC30
	// [XID] // 0x000000018980E510-0x000000018980E530
	public static new ConfigClimateInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF764A */, bool useObjectPool = false /* Metadata: 0x00AF764E */) => default; // 0x000000018475C160-0x000000018475C380
	[BlackList] // 0x0000000189815C50-0x0000000189815C90
	// [XID] // 0x0000000189815C50-0x0000000189815C90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018475AFB0-0x000000018475B280
	// [XID] // 0x0000000189820790-0x00000001898207B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018475D200-0x000000018475D5B0
	[BlackList] // 0x0000000189827DA0-0x0000000189827DE0
	// [XID] // 0x0000000189827DA0-0x0000000189827DE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018475C720-0x000000018475C810
	[BlackList] // 0x00000001898320B0-0x00000001898320F0
	// [XID] // 0x00000001898320B0-0x00000001898320F0
	public override void AutoAllocTypeFields() {} // 0x000000018475B280-0x000000018475B320
	[BlackList] // 0x000000018983C770-0x000000018983C7B0
	// [XID] // 0x000000018983C770-0x000000018983C7B0
	public override void AutoRecycleTypeFields() {} // 0x000000018475B320-0x000000018475B460
	[BlackList] // 0x0000000189846D30-0x0000000189846D70
	// [XID] // 0x0000000189846D30-0x0000000189846D70
	public override void ReturnToObjectPool() {} // 0x000000018475D7B0-0x000000018475D850
}

