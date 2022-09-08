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
public class ConfigBulletMoveAngleRotating : ConfigBulletMoveAngle, IAutoAllocRecycle // TypeDefIndex: 18601
{
	// Fields
	private MoleMole.Config.Vector _angularVelocity; // 0x10

	// Properties
	public MoleMole.Config.Vector angularVelocity { /* [XID] */ /* 0x00000001898B22D0-0x00000001898B22F0 */ get => default; /* [XID] */ /* 0x00000001898BA040-0x00000001898BA060 */ private set {} } // 0x0000000184153710-0x00000001841537F0 0x0000000184153850-0x0000000184153920

	// Constructors
	public ConfigBulletMoveAngleRotating() {} // 0x0000000184155130-0x0000000184155190

	// Methods
	// [XID] // 0x00000001898C1360-0x00000001898C1380
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184154FA0-0x0000000184155090
	// [XID] // 0x00000001898C8CC0-0x00000001898C8CE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184154C90-0x0000000184154D40
	// [XID] // 0x00000001898D05E0-0x00000001898D0600
	public override ConfigBulletMoveAngle Clone(bool useObjectPool = false /* Metadata: 0x00AFA56B */) => default; // 0x00000001841548A0-0x0000000184154980
	// [XID] // 0x00000001898D7CA0-0x00000001898D7CC0
	public override int GetHashNum() => default; // 0x0000000184153640-0x0000000184153710
	// [XID] // 0x00000001898DF900-0x00000001898DF920
	public override void InitEmpty() {} // 0x0000000184154300-0x00000001841543D0
	[BlackList] // 0x00000001898E73F0-0x00000001898E7430
	// [XID] // 0x00000001898E73F0-0x00000001898E7430
	public override bool FromJson(JSONNode node) => default; // 0x0000000184153CF0-0x0000000184154070
	// [XID] // 0x00000001898F1C70-0x00000001898F1C90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184152ED0-0x00000001841530F0
	[BlackList] // 0x00000001898F9450-0x00000001898F9490
	// [XID] // 0x00000001898F9450-0x00000001898F9490
	public static new ConfigBulletMoveAngleRotating ParseFromJson(JSONNode node) => default; // 0x00000001841549E0-0x0000000184154C30
	// [XID] // 0x0000000189903D70-0x0000000189903D90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA56C */, bool useObjectPool = false /* Metadata: 0x00AFA570 */) => default; // 0x00000001841545A0-0x00000001841548A0
	// [XID] // 0x000000018990B330-0x000000018990B350
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA571 */, bool useObjectPool = false /* Metadata: 0x00AFA575 */) => default; // 0x00000001841539A0-0x0000000184153BF0
	// [XID] // 0x0000000189912FC0-0x0000000189912FE0
	public static new ConfigBulletMoveAngleRotating ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA576 */, bool useObjectPool = false /* Metadata: 0x00AFA57A */) => default; // 0x0000000184154070-0x0000000184154290
	[BlackList] // 0x000000018991A790-0x000000018991A7D0
	// [XID] // 0x000000018991A790-0x000000018991A7D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841530F0-0x00000001841533C0
	// [XID] // 0x0000000189924F00-0x0000000189924F20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184154D40-0x0000000184154FA0
	[BlackList] // 0x000000018992C460-0x000000018992C4A0
	// [XID] // 0x000000018992C460-0x000000018992C4A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841544B0-0x00000001841545A0
	[BlackList] // 0x0000000189936830-0x0000000189936870
	// [XID] // 0x0000000189936830-0x0000000189936870
	public override void AutoAllocTypeFields() {} // 0x00000001841533C0-0x0000000184153460
	[BlackList] // 0x0000000189940F40-0x0000000189940F80
	// [XID] // 0x0000000189940F40-0x0000000189940F80
	public override void AutoRecycleTypeFields() {} // 0x0000000184153460-0x0000000184153520
	[BlackList] // 0x000000018994B900-0x000000018994B940
	// [XID] // 0x000000018994B900-0x000000018994B940
	public override void ReturnToObjectPool() {} // 0x0000000184155090-0x0000000184155130
}

