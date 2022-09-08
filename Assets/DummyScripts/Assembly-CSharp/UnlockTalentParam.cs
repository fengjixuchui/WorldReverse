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
public class UnlockTalentParam : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19044
{
	// Fields
	private string _abilityName; // 0x10
	private string _talentParam; // 0x18

	// Properties
	public string abilityName { /* [XID] */ /* 0x0000000189B9A960-0x0000000189B9A980 */ get => default; /* [XID] */ /* 0x0000000189BA20B0-0x0000000189BA20D0 */ private set {} } // 0x0000000185069440-0x00000001850694E0 0x0000000185069D20-0x0000000185069DD0
	public string talentParam { /* [XID] */ /* 0x00000001898F26E0-0x00000001898F2700 */ get => default; /* [XID] */ /* 0x0000000189BB0D30-0x0000000189BB0D50 */ private set {} } // 0x0000000185068070-0x0000000185068110 0x0000000185068DD0-0x0000000185068E80

	// Constructors
	public UnlockTalentParam() {} // 0x0000000185069F80-0x0000000185069FE0

	// Methods
	// [XID] // 0x0000000189BB7EC0-0x0000000189BB7EE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185069DD0-0x0000000185069EE0
	// [XID] // 0x0000000189BBF670-0x0000000189BBF690
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185069990-0x0000000185069A90
	// [XID] // 0x0000000189BC7280-0x0000000189BC72A0
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB889 */) => default; // 0x00000001850695A0-0x0000000185069680
	// [XID] // 0x0000000189BCEFD0-0x0000000189BCEFF0
	public override int GetHashNum() => default; // 0x0000000185068190-0x0000000185068260
	// [XID] // 0x0000000189BD6340-0x0000000189BD6360
	public override void InitEmpty() {} // 0x0000000185068E80-0x0000000185068F70
	[BlackList] // 0x0000000189BDDE20-0x0000000189BDDE60
	// [XID] // 0x0000000189BDDE20-0x0000000189BDDE60
	public override bool FromJson(JSONNode node) => default; // 0x0000000185068740-0x0000000185068AC0
	// [XID] // 0x00000001895ED970-0x00000001895ED990
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001850678A0-0x0000000185067BB0
	[BlackList] // 0x00000001895F50D0-0x00000001895F5110
	// [XID] // 0x00000001895F50D0-0x00000001895F5110
	public static new UnlockTalentParam ParseFromJson(JSONNode node) => default; // 0x00000001850696E0-0x0000000185069930
	// [XID] // 0x00000001895FF6F0-0x00000001895FF710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB88A */, bool useObjectPool = false /* Metadata: 0x00AFB88E */) => default; // 0x0000000185069140-0x0000000185069440
	// [XID] // 0x0000000189606E40-0x0000000189606E60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB88F */, bool useObjectPool = false /* Metadata: 0x00AFB893 */) => default; // 0x0000000185068340-0x0000000185068640
	// [XID] // 0x000000018960E780-0x000000018960E7A0
	public static new UnlockTalentParam ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB894 */, bool useObjectPool = false /* Metadata: 0x00AFB898 */) => default; // 0x0000000185068AC0-0x0000000185068CE0
	[BlackList] // 0x0000000189615E20-0x0000000189615E60
	// [XID] // 0x0000000189615E20-0x0000000189615E60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185067BB0-0x0000000185067E80
	// [XID] // 0x00000001896206E0-0x0000000189620700
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185069A90-0x0000000185069D20
	[BlackList] // 0x0000000189627BF0-0x0000000189627C30
	// [XID] // 0x0000000189627BF0-0x0000000189627C30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185069050-0x0000000185069140
	// [XID] // 0x0000000189632440-0x0000000189632460
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x00000001850694E0-0x00000001850695A0
	[BlackList] // 0x0000000189639EB0-0x0000000189639EF0
	// [XID] // 0x0000000189639EB0-0x0000000189639EF0
	public override void AutoAllocTypeFields() {} // 0x0000000185067E80-0x0000000185067F20
	[BlackList] // 0x0000000189644610-0x0000000189644650
	// [XID] // 0x0000000189644610-0x0000000189644650
	public override void AutoRecycleTypeFields() {} // 0x0000000185067F20-0x0000000185067FD0
	[BlackList] // 0x000000018964EC60-0x000000018964ECA0
	// [XID] // 0x000000018964EC60-0x000000018964ECA0
	public override void ReturnToObjectPool() {} // 0x0000000185069EE0-0x0000000185069F80
}

