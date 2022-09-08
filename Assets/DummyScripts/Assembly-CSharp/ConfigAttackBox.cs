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
public class ConfigAttackBox : ConfigSimpleAttackPattern, IAutoAllocRecycle // TypeDefIndex: 17540
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloatVector _size; // 0x40
	private bool _muteHitBehindScene; // 0x48

	// Properties
	public DynamicFloatVector size { /* [XID] */ /* 0x00000001899E0540-0x00000001899E0560 */ get => default; /* [XID] */ /* 0x00000001899E8100-0x00000001899E8120 */ private set {} } // 0x0000000184654960-0x0000000184654A00 0x0000000184653D80-0x0000000184653E30
	public bool muteHitBehindScene { /* [XID] */ /* 0x00000001899EF5B0-0x00000001899EF5D0 */ get => default; /* [XID] */ /* 0x00000001899F6E70-0x00000001899F6E90 */ private set {} } // 0x00000001846539D0-0x0000000184653A70 0x00000001846548B0-0x0000000184654960

	// Constructors
	public ConfigAttackBox() {} // 0x0000000184654BC0-0x0000000184654C30

	// Methods
	// [XID] // 0x00000001899FE690-0x00000001899FE6B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184654A00-0x0000000184654B20
	// [XID] // 0x0000000189A05EB0-0x0000000189A05ED0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184654520-0x0000000184654600
	// [XID] // 0x0000000189A0D2A0-0x0000000189A0D2C0
	public override ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF7239 */) => default; // 0x0000000184654130-0x0000000184654210
	// [XID] // 0x0000000189A14B00-0x0000000189A14B20
	public override int GetHashNum() => default; // 0x0000000184652E70-0x0000000184652F40
	// [XID] // 0x0000000189A1BD90-0x0000000189A1BDB0
	public override void InitEmpty() {} // 0x0000000184653AE0-0x0000000184653BB0
	[BlackList] // 0x0000000189A23560-0x0000000189A235A0
	// [XID] // 0x0000000189A23560-0x0000000189A235A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184653430-0x00000001846537B0
	// [XID] // 0x0000000189A2D650-0x0000000189A2D670
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001846525A0-0x00000001846528B0
	[BlackList] // 0x0000000189A35130-0x0000000189A35170
	// [XID] // 0x0000000189A35130-0x0000000189A35170
	public static new ConfigAttackBox ParseFromJson(JSONNode node) => default; // 0x0000000184654270-0x00000001846544C0
	// [XID] // 0x0000000189A3F8A0-0x0000000189A3F8C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF723A */, bool useObjectPool = false /* Metadata: 0x00AF723E */) => default; // 0x0000000184653E30-0x0000000184654130
	// [XID] // 0x0000000189A46F70-0x0000000189A46F90
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF723F */, bool useObjectPool = false /* Metadata: 0x00AF7243 */) => default; // 0x0000000184653020-0x0000000184653330
	// [XID] // 0x0000000189A4E890-0x0000000189A4E8B0
	public static new ConfigAttackBox ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7244 */, bool useObjectPool = false /* Metadata: 0x00AF7248 */) => default; // 0x00000001846537B0-0x00000001846539D0
	[BlackList] // 0x0000000189A55FA0-0x0000000189A55FE0
	// [XID] // 0x0000000189A55FA0-0x0000000189A55FE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001846528B0-0x0000000184652B80
	// [XID] // 0x0000000189A60740-0x0000000189A60760
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184654600-0x00000001846548B0
	[BlackList] // 0x0000000189A68590-0x0000000189A685D0
	// [XID] // 0x0000000189A68590-0x0000000189A685D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184653C90-0x0000000184653D80
	[BlackList] // 0x0000000189A72AA0-0x0000000189A72AE0
	// [XID] // 0x0000000189A72AA0-0x0000000189A72AE0
	public override void AutoAllocTypeFields() {} // 0x0000000184652B80-0x0000000184652C20
	[BlackList] // 0x0000000189A7D390-0x0000000189A7D3D0
	// [XID] // 0x0000000189A7D390-0x0000000189A7D3D0
	public override void AutoRecycleTypeFields() {} // 0x0000000184652C20-0x0000000184652D50
	[BlackList] // 0x0000000189A87CC0-0x0000000189A87D00
	// [XID] // 0x0000000189A87CC0-0x0000000189A87D00
	public override void ReturnToObjectPool() {} // 0x0000000184654B20-0x0000000184654BC0
}

