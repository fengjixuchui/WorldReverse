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
public class ConfigAttackUsePrefab : ConfigBaseAttackPattern, IAutoAllocRecycle // TypeDefIndex: 17534
{
	// Fields
	private string _prefabPathName; // 0x38
	private bool _isConnect; // 0x40
	private SimpleSafeFloat durationRawNum; // 0x44

	// Properties
	public string prefabPathName { /* [XID] */ /* 0x000000018979D7D0-0x000000018979D7F0 */ get => default; /* [XID] */ /* 0x00000001897A4A50-0x00000001897A4A70 */ private set {} } // 0x0000000184ED6C40-0x0000000184ED6CE0 0x0000000184ED5D60-0x0000000184ED5E10
	public bool isConnect { /* [XID] */ /* 0x00000001897AC0A0-0x00000001897AC0C0 */ get => default; /* [XID] */ /* 0x00000001897B3F90-0x00000001897B3FB0 */ private set {} } // 0x0000000184ED4480-0x0000000184ED4520 0x0000000184ED50D0-0x0000000184ED5180
	public float duration { /* [XID] */ /* 0x00000001897BBCB0-0x00000001897BBCD0 */ get => default; /* [XID] */ /* 0x00000001897C3510-0x00000001897C3530 */ private set {} } // 0x0000000184ED4EA0-0x0000000184ED4F80 0x0000000184ED55E0-0x0000000184ED56C0

	// Constructors
	public ConfigAttackUsePrefab() {} // 0x0000000184ED6EB0-0x0000000184ED6F10

	// Methods
	// [XID] // 0x00000001897CACF0-0x00000001897CAD10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184ED6CE0-0x0000000184ED6E10
	// [XID] // 0x00000001897D2350-0x00000001897D2370
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184ED6850-0x0000000184ED6930
	// [XID] // 0x00000001897DA0D0-0x00000001897DA0F0
	public override ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF7209 */) => default; // 0x0000000184ED6460-0x0000000184ED6540
	// [XID] // 0x00000001897E14A0-0x00000001897E14C0
	public override int GetHashNum() => default; // 0x0000000184ED5000-0x0000000184ED50D0
	// [XID] // 0x00000001897E8D30-0x00000001897E8D50
	public override void InitEmpty() {} // 0x0000000184ED5E80-0x0000000184ED5F90
	[BlackList] // 0x00000001897F0960-0x00000001897F09A0
	// [XID] // 0x00000001897F0960-0x00000001897F09A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184ED57C0-0x0000000184ED5B40
	// [XID] // 0x00000001897FB390-0x00000001897FB3B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184ED45A0-0x0000000184ED49B0
	[BlackList] // 0x0000000189802760-0x00000001898027A0
	// [XID] // 0x0000000189802760-0x00000001898027A0
	public static new ConfigAttackUsePrefab ParseFromJson(JSONNode node) => default; // 0x0000000184ED65A0-0x0000000184ED67F0
	// [XID] // 0x000000018980CA90-0x000000018980CAB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF720A */, bool useObjectPool = false /* Metadata: 0x00AF720E */) => default; // 0x0000000184ED6160-0x0000000184ED6460
	// [XID] // 0x00000001898142B0-0x00000001898142D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF720F */, bool useObjectPool = false /* Metadata: 0x00AF7213 */) => default; // 0x0000000184ED5260-0x0000000184ED55E0
	// [XID] // 0x000000018981BDE0-0x000000018981BE00
	public static new ConfigAttackUsePrefab ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7214 */, bool useObjectPool = false /* Metadata: 0x00AF7218 */) => default; // 0x0000000184ED5B40-0x0000000184ED5D60
	[BlackList] // 0x00000001898232B0-0x00000001898232F0
	// [XID] // 0x00000001898232B0-0x00000001898232F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184ED49B0-0x0000000184ED4C80
	// [XID] // 0x000000018982D960-0x000000018982D980
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184ED6930-0x0000000184ED6C40
	[BlackList] // 0x00000001898350F0-0x0000000189835130
	// [XID] // 0x00000001898350F0-0x0000000189835130
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184ED6070-0x0000000184ED6160
	[BlackList] // 0x000000018983F730-0x000000018983F770
	// [XID] // 0x000000018983F730-0x000000018983F770
	public override void AutoAllocTypeFields() {} // 0x0000000184ED4C80-0x0000000184ED4D20
	[BlackList] // 0x0000000189849A90-0x0000000189849AD0
	// [XID] // 0x0000000189849A90-0x0000000189849AD0
	public override void AutoRecycleTypeFields() {} // 0x0000000184ED4D20-0x0000000184ED4E00
	[BlackList] // 0x0000000189853BA0-0x0000000189853BE0
	// [XID] // 0x0000000189853BA0-0x0000000189853BE0
	public override void ReturnToObjectPool() {} // 0x0000000184ED6E10-0x0000000184ED6EB0
}

