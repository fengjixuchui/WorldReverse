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
public class ConfigPredicateByTime : ConfigGadgetPredicate, IAutoAllocRecycle // TypeDefIndex: 14963
{
	// Fields
	private bool _isNight; // 0x10

	// Properties
	public bool isNight { /* [XID] */ /* 0x0000000189897E40-0x0000000189897E60 */ get => default; /* [XID] */ /* 0x000000018989F1E0-0x000000018989F200 */ private set {} } // 0x0000000186578910-0x00000001865789B0 0x00000001865781D0-0x0000000186578280

	// Constructors
	public ConfigPredicateByTime() {} // 0x0000000186579750-0x00000001865797B0

	// Methods
	// [XID] // 0x00000001898908A0-0x00000001898908C0
	public override bool IsTrue(BaseEntity entity, int param) => default; // 0x0000000186577D20-0x0000000186577E40
	// [XID] // 0x00000001898A6D80-0x00000001898A6DA0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001865795C0-0x00000001865796B0
	// [XID] // 0x00000001898AE590-0x00000001898AE5B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000186579310-0x00000001865793C0
	// [XID] // 0x00000001898B5A70-0x00000001898B5A90
	public override ConfigGadgetPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AEFC61 */) => default; // 0x0000000186578F20-0x0000000186579000
	// [XID] // 0x00000001898BD4C0-0x00000001898BD4E0
	public override int GetHashNum() => default; // 0x0000000186577C50-0x0000000186577D20
	// [XID] // 0x00000001898C4C60-0x00000001898C4C80
	public override void InitEmpty() {} // 0x00000001865789B0-0x0000000186578A50
	[BlackList] // 0x00000001898CC070-0x00000001898CC0B0
	// [XID] // 0x00000001898CC070-0x00000001898CC0B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000186578300-0x0000000186578680
	// [XID] // 0x00000001898D6B80-0x00000001898D6BA0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000186577510-0x0000000186577710
	[BlackList] // 0x00000001898DE860-0x00000001898DE8A0
	// [XID] // 0x00000001898DE860-0x00000001898DE8A0
	public static new ConfigPredicateByTime ParseFromJson(JSONNode node) => default; // 0x0000000186579060-0x00000001865792B0
	// [XID] // 0x00000001898E92E0-0x00000001898E9300
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC62 */, bool useObjectPool = false /* Metadata: 0x00AEFC66 */) => default; // 0x0000000186578C20-0x0000000186578F20
	// [XID] // 0x00000001898F0A80-0x00000001898F0AA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC67 */, bool useObjectPool = false /* Metadata: 0x00AEFC6B */) => default; // 0x0000000186577F20-0x0000000186578150
	// [XID] // 0x00000001898F83B0-0x00000001898F83D0
	public static new ConfigPredicateByTime ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC6C */, bool useObjectPool = false /* Metadata: 0x00AEFC70 */) => default; // 0x0000000186578680-0x00000001865788A0
	[BlackList] // 0x00000001898FFB30-0x00000001898FFB70
	// [XID] // 0x00000001898FFB30-0x00000001898FFB70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000186577710-0x00000001865779E0
	// [XID] // 0x000000018990A180-0x000000018990A1A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001865793C0-0x00000001865795C0
	[BlackList] // 0x0000000189911B00-0x0000000189911B40
	// [XID] // 0x0000000189911B00-0x0000000189911B40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000186578B30-0x0000000186578C20
	[BlackList] // 0x000000018991C800-0x000000018991C840
	// [XID] // 0x000000018991C800-0x000000018991C840
	public override void AutoAllocTypeFields() {} // 0x00000001865779E0-0x0000000186577A80
	[BlackList] // 0x0000000189926EC0-0x0000000189926F00
	// [XID] // 0x0000000189926EC0-0x0000000189926F00
	public override void AutoRecycleTypeFields() {} // 0x0000000186577A80-0x0000000186577B30
	[BlackList] // 0x0000000189931340-0x0000000189931380
	// [XID] // 0x0000000189931340-0x0000000189931380
	public override void ReturnToObjectPool() {} // 0x00000001865796B0-0x0000000186579750
}

