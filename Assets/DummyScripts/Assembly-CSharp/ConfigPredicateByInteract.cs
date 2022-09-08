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
public class ConfigPredicateByInteract : ConfigGadgetPredicate, IAutoAllocRecycle // TypeDefIndex: 14965
{
	// Fields
	private bool _isEnableInteract; // 0x10

	// Properties
	public bool isEnableInteract { /* [XID] */ /* 0x00000001899FD210-0x00000001899FD230 */ get => default; /* [XID] */ /* 0x0000000189A047D0-0x0000000189A047F0 */ private set {} } // 0x0000000181E14390-0x0000000181E14430 0x0000000181E142E0-0x0000000181E14390

	// Constructors
	public ConfigPredicateByInteract() {} // 0x0000000181E147C0-0x0000000181E14820

	// Methods
	// [XID] // 0x00000001899F5AB0-0x00000001899F5AD0
	public override bool IsTrue(BaseEntity entity, int param) => default; // 0x0000000181E12DD0-0x0000000181E12EB0
	// [XID] // 0x0000000189A0BF10-0x0000000189A0BF30
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E14630-0x0000000181E14720
	// [XID] // 0x0000000189A13880-0x0000000189A138A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000181E14230-0x0000000181E142E0
	// [XID] // 0x0000000189A1A9B0-0x0000000189A1A9D0
	public override ConfigGadgetPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AEFC81 */) => default; // 0x0000000181E13E40-0x0000000181E13F20
	// [XID] // 0x0000000189A222D0-0x0000000189A222F0
	public override int GetHashNum() => default; // 0x0000000181E12D00-0x0000000181E12DD0
	// [XID] // 0x0000000189A296A0-0x0000000189A296C0
	public override void InitEmpty() {} // 0x0000000181E138D0-0x0000000181E13970
	[BlackList] // 0x0000000189A30B70-0x0000000189A30BB0
	// [XID] // 0x0000000189A30B70-0x0000000189A30BB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000181E132C0-0x0000000181E13640
	// [XID] // 0x0000000189A3B340-0x0000000189A3B360
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181E125C0-0x0000000181E127C0
	[BlackList] // 0x0000000189A42DD0-0x0000000189A42E10
	// [XID] // 0x0000000189A42DD0-0x0000000189A42E10
	public static new ConfigPredicateByInteract ParseFromJson(JSONNode node) => default; // 0x0000000181E13F80-0x0000000181E141D0
	// [XID] // 0x0000000189A4D3A0-0x0000000189A4D3C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC82 */, bool useObjectPool = false /* Metadata: 0x00AEFC86 */) => default; // 0x0000000181E13B40-0x0000000181E13E40
	// [XID] // 0x0000000189A54B90-0x0000000189A54BB0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC87 */, bool useObjectPool = false /* Metadata: 0x00AEFC8B */) => default; // 0x0000000181E12F90-0x0000000181E131C0
	// [XID] // 0x0000000189A5C660-0x0000000189A5C680
	public static new ConfigPredicateByInteract ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC8C */, bool useObjectPool = false /* Metadata: 0x00AEFC90 */) => default; // 0x0000000181E13640-0x0000000181E13860
	[BlackList] // 0x0000000189A63ED0-0x0000000189A63F10
	// [XID] // 0x0000000189A63ED0-0x0000000189A63F10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E127C0-0x0000000181E12A90
	// [XID] // 0x0000000189A6E6A0-0x0000000189A6E6C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E14430-0x0000000181E14630
	[BlackList] // 0x0000000189A75D10-0x0000000189A75D50
	// [XID] // 0x0000000189A75D10-0x0000000189A75D50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000181E13A50-0x0000000181E13B40
	[BlackList] // 0x0000000189A80460-0x0000000189A804A0
	// [XID] // 0x0000000189A80460-0x0000000189A804A0
	public override void AutoAllocTypeFields() {} // 0x0000000181E12A90-0x0000000181E12B30
	[BlackList] // 0x0000000189A8B1A0-0x0000000189A8B1E0
	// [XID] // 0x0000000189A8B1A0-0x0000000189A8B1E0
	public override void AutoRecycleTypeFields() {} // 0x0000000181E12B30-0x0000000181E12BE0
	[BlackList] // 0x0000000189A95730-0x0000000189A95770
	// [XID] // 0x0000000189A95730-0x0000000189A95770
	public override void ReturnToObjectPool() {} // 0x0000000181E14720-0x0000000181E147C0
}

