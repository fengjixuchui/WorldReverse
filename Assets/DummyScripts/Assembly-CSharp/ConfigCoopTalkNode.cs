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
public class ConfigCoopTalkNode : ConfigCoopBaseNode, IAutoAllocRecycle // TypeDefIndex: 17749
{
	// Fields
	private uint _talkId; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTalkScheme _talkConfig; // 0x28

	// Properties
	public uint talkId { /* [XID] */ /* 0x0000000189A819D0-0x0000000189A819F0 */ get => default; /* [XID] */ /* 0x0000000189A894F0-0x0000000189A89510 */ private set {} } // 0x0000000181C8A570-0x0000000181C8A610 0x0000000181C88840-0x0000000181C888F0
	public ConfigTalkScheme talkConfig { /* [XID] */ /* 0x0000000189A90D30-0x0000000189A90D50 */ get => default; /* [XID] */ /* 0x0000000189A984A0-0x0000000189A984C0 */ private set {} } // 0x0000000181C89D10-0x0000000181C89DB0 0x0000000181C895E0-0x0000000181C89690

	// Constructors
	public ConfigCoopTalkNode() {} // 0x0000000181C8A6B0-0x0000000181C8A710

	// Methods
	// [XID] // 0x0000000189A9F8B0-0x0000000189A9F8D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C8A450-0x0000000181C8A570
	// [XID] // 0x0000000189AA7120-0x0000000189AA7140
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181C8A0C0-0x0000000181C8A1A0
	// [XID] // 0x0000000189AAE7A0-0x0000000189AAE7C0
	public override ConfigCoopBaseNode Clone(bool useObjectPool = false /* Metadata: 0x00AF7AD5 */) => default; // 0x0000000181C89C30-0x0000000181C89D10
	// [XID] // 0x0000000189AB6020-0x0000000189AB6040
	public override int GetHashNum() => default; // 0x0000000181C88A10-0x0000000181C88AE0
	// [XID] // 0x0000000189ABDA90-0x0000000189ABDAB0
	public override void InitEmpty() {} // 0x0000000181C89690-0x0000000181C89760
	[BlackList] // 0x0000000189AC5630-0x0000000189AC5670
	// [XID] // 0x0000000189AC5630-0x0000000189AC5670
	public override bool FromJson(JSONNode node) => default; // 0x0000000181C88FD0-0x0000000181C89350
	// [XID] // 0x0000000189ACFBF0-0x0000000189ACFC10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181C88080-0x0000000181C88390
	[BlackList] // 0x0000000189AD7900-0x0000000189AD7940
	// [XID] // 0x0000000189AD7900-0x0000000189AD7940
	public static new ConfigCoopTalkNode ParseFromJson(JSONNode node) => default; // 0x0000000181C89E10-0x0000000181C8A060
	// [XID] // 0x0000000189AE2140-0x0000000189AE2160
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AD6 */, bool useObjectPool = false /* Metadata: 0x00AF7ADA */) => default; // 0x0000000181C89930-0x0000000181C89C30
	// [XID] // 0x0000000189AE9990-0x0000000189AE99B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7ADB */, bool useObjectPool = false /* Metadata: 0x00AF7ADF */) => default; // 0x0000000181C88BC0-0x0000000181C88ED0
	// [XID] // 0x0000000189AF1730-0x0000000189AF1750
	public static new ConfigCoopTalkNode ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AE0 */, bool useObjectPool = false /* Metadata: 0x00AF7AE4 */) => default; // 0x0000000181C89350-0x0000000181C89570
	[BlackList] // 0x0000000189AF8DF0-0x0000000189AF8E30
	// [XID] // 0x0000000189AF8DF0-0x0000000189AF8E30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C88390-0x0000000181C88660
	// [XID] // 0x0000000189B03330-0x0000000189B03350
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C8A1A0-0x0000000181C8A450
	[BlackList] // 0x0000000189B0AAA0-0x0000000189B0AAE0
	// [XID] // 0x0000000189B0AAA0-0x0000000189B0AAE0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181C89840-0x0000000181C89930
	[BlackList] // 0x0000000189B14F30-0x0000000189B14F70
	// [XID] // 0x0000000189B14F30-0x0000000189B14F70
	public override void AutoAllocTypeFields() {} // 0x0000000181C88660-0x0000000181C88700
	[BlackList] // 0x0000000189B1F5E0-0x0000000189B1F620
	// [XID] // 0x0000000189B1F5E0-0x0000000189B1F620
	public override void AutoRecycleTypeFields() {} // 0x0000000181C88700-0x0000000181C88840
	[BlackList] // 0x0000000189B299A0-0x0000000189B299E0
	// [XID] // 0x0000000189B299A0-0x0000000189B299E0
	public override void ReturnToObjectPool() {} // 0x0000000181C8A610-0x0000000181C8A6B0
}

