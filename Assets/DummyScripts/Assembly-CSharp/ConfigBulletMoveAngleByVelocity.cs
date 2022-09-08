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
public class ConfigBulletMoveAngleByVelocity : ConfigBulletMoveAngle, IAutoAllocRecycle // TypeDefIndex: 18599
{
	// Fields
	private SimpleSafeFloat traceLerpCoefRawNum; // 0x10

	// Properties
	public float traceLerpCoef { /* [XID] */ /* 0x0000000189809B10-0x0000000189809B30 */ get => default; /* [XID] */ /* 0x00000001898112A0-0x00000001898112C0 */ private set {} } // 0x000000018296A450-0x000000018296A530 0x000000018296AC20-0x000000018296AD00

	// Constructors
	public ConfigBulletMoveAngleByVelocity() {} // 0x000000018296B150-0x000000018296B1F0

	// Methods
	// [XID] // 0x0000000189818D30-0x0000000189818D50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018296AFB0-0x000000018296B0B0
	// [XID] // 0x00000001898205F0-0x0000000189820610
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018296AD00-0x000000018296ADB0
	// [XID] // 0x0000000189827C60-0x0000000189827C80
	public override ConfigBulletMoveAngle Clone(bool useObjectPool = false /* Metadata: 0x00AFA55B */) => default; // 0x000000018296A830-0x000000018296A910
	// [XID] // 0x000000018982EF00-0x000000018982EF20
	public override int GetHashNum() => default; // 0x00000001829696B0-0x0000000182969780
	// [XID] // 0x0000000189836810-0x0000000189836830
	public override void InitEmpty() {} // 0x000000018296A1A0-0x000000018296A280
	[BlackList] // 0x000000018983DBC0-0x000000018983DC00
	// [XID] // 0x000000018983DBC0-0x000000018983DC00
	public override bool FromJson(JSONNode node) => default; // 0x0000000182969B90-0x0000000182969F10
	// [XID] // 0x0000000189848080-0x00000001898480A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182968EF0-0x0000000182969140
	[BlackList] // 0x000000018984F780-0x000000018984F7C0
	// [XID] // 0x000000018984F780-0x000000018984F7C0
	public static new ConfigBulletMoveAngleByVelocity ParseFromJson(JSONNode node) => default; // 0x000000018296A970-0x000000018296ABC0
	// [XID] // 0x0000000189859D70-0x0000000189859D90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA55C */, bool useObjectPool = false /* Metadata: 0x00AFA560 */) => default; // 0x000000018296A530-0x000000018296A830
	// [XID] // 0x0000000189860E30-0x0000000189860E50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA561 */, bool useObjectPool = false /* Metadata: 0x00AFA565 */) => default; // 0x0000000182969860-0x0000000182969A90
	// [XID] // 0x00000001898686B0-0x00000001898686D0
	public static new ConfigBulletMoveAngleByVelocity ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA566 */, bool useObjectPool = false /* Metadata: 0x00AFA56A */) => default; // 0x0000000182969F10-0x000000018296A130
	[BlackList] // 0x000000018986FAE0-0x000000018986FB20
	// [XID] // 0x000000018986FAE0-0x000000018986FB20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182969140-0x0000000182969410
	// [XID] // 0x000000018987A6D0-0x000000018987A6F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018296ADB0-0x000000018296AFB0
	[BlackList] // 0x0000000189881820-0x0000000189881860
	// [XID] // 0x0000000189881820-0x0000000189881860
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018296A360-0x000000018296A450
	[BlackList] // 0x000000018988BC20-0x000000018988BC60
	// [XID] // 0x000000018988BC20-0x000000018988BC60
	public override void AutoAllocTypeFields() {} // 0x0000000182969410-0x00000001829694B0
	[BlackList] // 0x0000000189895E80-0x0000000189895EC0
	// [XID] // 0x0000000189895E80-0x0000000189895EC0
	public override void AutoRecycleTypeFields() {} // 0x00000001829694B0-0x0000000182969590
	[BlackList] // 0x00000001898A03B0-0x00000001898A03F0
	// [XID] // 0x00000001898A03B0-0x00000001898A03F0
	public override void ReturnToObjectPool() {} // 0x000000018296B0B0-0x000000018296B150
}

