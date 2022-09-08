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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigBornByWorld : ConfigBornType, IAutoAllocRecycle // TypeDefIndex: 17866
{
	// Fields
	private MoleMole.Config.Vector _worldPos; // 0x38
	private MoleMole.Config.Vector _worldFwd; // 0x44

	// Properties
	public MoleMole.Config.Vector worldPos { /* [XID] */ /* 0x0000000189AA83E0-0x0000000189AA8400 */ get => default; /* [XID] */ /* 0x0000000189AB0100-0x0000000189AB0120 */ private set {} } // 0x0000000183B817D0-0x0000000183B818B0 0x0000000183B82D70-0x0000000183B82E40
	public MoleMole.Config.Vector worldFwd { /* [XID] */ /* 0x0000000189AFB120-0x0000000189AFB140 */ get => default; /* [XID] */ /* 0x0000000189ABF250-0x0000000189ABF270 */ private set {} } // 0x0000000183B80B20-0x0000000183B80C00 0x0000000183B81290-0x0000000183B81360

	// Constructors
	public ConfigBornByWorld() {} // 0x0000000183B82EE0-0x0000000183B82F40

	// Methods
	// [XID] // 0x0000000189AC6C60-0x0000000189AC6C80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B82C40-0x0000000183B82D70
	// [XID] // 0x0000000189ACE490-0x0000000189ACE4B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B82870-0x0000000183B82920
	// [XID] // 0x0000000189AD62E0-0x0000000189AD6300
	public override ConfigBornType Clone(bool useObjectPool = false /* Metadata: 0x00AF7F89 */) => default; // 0x0000000183B82480-0x0000000183B82560
	// [XID] // 0x0000000189ADDC40-0x0000000189ADDC60
	public override int GetHashNum() => default; // 0x0000000183B81160-0x0000000183B81230
	// [XID] // 0x0000000189AE55C0-0x0000000189AE55E0
	public override void InitEmpty() {} // 0x0000000183B81EC0-0x0000000183B81FB0
	[BlackList] // 0x0000000189AECA80-0x0000000189AECAC0
	// [XID] // 0x0000000189AECA80-0x0000000189AECAC0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B818B0-0x0000000183B81C30
	// [XID] // 0x0000000189AF74C0-0x0000000189AF74E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B80810-0x0000000183B80B20
	[BlackList] // 0x0000000189AFEBB0-0x0000000189AFEBF0
	// [XID] // 0x0000000189AFEBB0-0x0000000189AFEBF0
	public static new ConfigBornByWorld ParseFromJson(JSONNode node) => default; // 0x0000000183B825C0-0x0000000183B82810
	// [XID] // 0x0000000189B09130-0x0000000189B09150
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F8A */, bool useObjectPool = false /* Metadata: 0x00AF7F8E */) => default; // 0x0000000183B82180-0x0000000183B82480
	// [XID] // 0x0000000189B10B70-0x0000000189B10B90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F8F */, bool useObjectPool = false /* Metadata: 0x00AF7F93 */) => default; // 0x0000000183B813E0-0x0000000183B816D0
	// [XID] // 0x0000000189B17D20-0x0000000189B17D40
	public static new ConfigBornByWorld ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F94 */, bool useObjectPool = false /* Metadata: 0x00AF7F98 */) => default; // 0x0000000183B81C30-0x0000000183B81E50
	[BlackList] // 0x0000000189B1F580-0x0000000189B1F5C0
	// [XID] // 0x0000000189B1F580-0x0000000189B1F5C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B80C00-0x0000000183B80ED0
	// [XID] // 0x0000000189B29960-0x0000000189B29980
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B82920-0x0000000183B82C40
	[BlackList] // 0x0000000189B30F50-0x0000000189B30F90
	// [XID] // 0x0000000189B30F50-0x0000000189B30F90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B82090-0x0000000183B82180
	[BlackList] // 0x0000000189B3B630-0x0000000189B3B670
	// [XID] // 0x0000000189B3B630-0x0000000189B3B670
	public override void AutoAllocTypeFields() {} // 0x0000000183B80ED0-0x0000000183B80F70
	[BlackList] // 0x0000000189B46260-0x0000000189B462A0
	// [XID] // 0x0000000189B46260-0x0000000189B462A0
	public override void AutoRecycleTypeFields() {} // 0x0000000183B80F70-0x0000000183B81040
	[BlackList] // 0x0000000189B509E0-0x0000000189B50A20
	// [XID] // 0x0000000189B509E0-0x0000000189B50A20
	public override void ReturnToObjectPool() {} // 0x0000000183B82E40-0x0000000183B82EE0
}

