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
public class ConfigGuideHideandSeekSkillCategoryCondition : ConfigGuidePageCheckBaseCondition, IAutoAllocRecycle // TypeDefIndex: 18296
{
	// Fields
	private SimpleSafeInt32 indexRawNum; // 0x28
	private bool _isSelect; // 0x2C

	// Properties
	public int index { /* [XID] */ /* 0x00000001898AF710-0x00000001898AF730 */ get => default; /* [XID] */ /* 0x00000001898B6B90-0x00000001898B6BB0 */ private set {} } // 0x0000000183844D10-0x0000000183844DE0 0x00000001838450E0-0x00000001838451C0
	public bool isSelect { /* [XID] */ /* 0x00000001898BE340-0x00000001898BE360 */ get => default; /* [XID] */ /* 0x00000001898C5BF0-0x00000001898C5C10 */ private set {} } // 0x0000000183844960-0x0000000183844A00 0x0000000183845B20-0x0000000183845BD0

	// Constructors
	public ConfigGuideHideandSeekSkillCategoryCondition() {} // 0x0000000183845C70-0x0000000183846620

	// Methods
	// [XID] // 0x00000001898CD340-0x00000001898CD360
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183845A10-0x0000000183845B20
	// [XID] // 0x00000001898D4C10-0x00000001898D4C30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001838456A0-0x0000000183845750
	// [XID] // 0x00000001898DC630-0x00000001898DC650
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF932F */) => default; // 0x00000001838451C0-0x00000001838452A0
	// [XID] // 0x00000001898E40A0-0x00000001898E40C0
	public override int GetHashNum() => default; // 0x0000000183843C60-0x0000000183843D30
	// [XID] // 0x00000001898EBC10-0x00000001898EBC30
	public override void InitEmpty() {} // 0x0000000183844A70-0x0000000183844B40
	[BlackList] // 0x00000001898F3360-0x00000001898F33A0
	// [XID] // 0x00000001898F3360-0x00000001898F33A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001838443C0-0x0000000183844740
	// [XID] // 0x00000001898FDC60-0x00000001898FDC80
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001838433D0-0x00000001838436F0
	[BlackList] // 0x0000000189905420-0x0000000189905460
	// [XID] // 0x0000000189905420-0x0000000189905460
	public static new ConfigGuideHideandSeekSkillCategoryCondition ParseFromJson(JSONNode node) => default; // 0x00000001838453F0-0x0000000183845640
	// [XID] // 0x000000018990FC90-0x000000018990FCB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9330 */, bool useObjectPool = false /* Metadata: 0x00AF9334 */) => default; // 0x0000000183844DE0-0x00000001838450E0
	// [XID] // 0x00000001899177A0-0x00000001899177C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9335 */, bool useObjectPool = false /* Metadata: 0x00AF9339 */) => default; // 0x0000000183843F10-0x00000001838441F0
	// [XID] // 0x000000018991EDC0-0x000000018991EDE0
	public static new ConfigGuideHideandSeekSkillCategoryCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF933A */, bool useObjectPool = false /* Metadata: 0x00AF933E */) => default; // 0x0000000183844740-0x0000000183844960
	[BlackList] // 0x0000000189926740-0x0000000189926780
	// [XID] // 0x0000000189926740-0x0000000189926780
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001838436F0-0x00000001838439C0
	// [XID] // 0x0000000189930E20-0x0000000189930E40
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183845750-0x0000000183845A10
	[BlackList] // 0x0000000189938170-0x00000001899381B0
	// [XID] // 0x0000000189938170-0x00000001899381B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183844C20-0x0000000183844D10
	// [XID] // 0x0000000189942770-0x0000000189942790
	protected override bool CheckPageCurrent(BasePageContext context) => default; // 0x00000001838442F0-0x00000001838443C0
	// [XID] // 0x000000018994A0A0-0x000000018994A0C0
	protected override bool CheckPageCondition() => default; // 0x0000000183843D90-0x0000000183843E90
	[BlackList] // 0x0000000189951B50-0x0000000189951B90
	// [XID] // 0x0000000189951B50-0x0000000189951B90
	public override void AutoAllocTypeFields() {} // 0x00000001838439C0-0x0000000183843A60
	[BlackList] // 0x000000018995BF80-0x000000018995BFC0
	// [XID] // 0x000000018995BF80-0x000000018995BFC0
	public override void AutoRecycleTypeFields() {} // 0x0000000183843A60-0x0000000183843B40
	[BlackList] // 0x00000001899669D0-0x0000000189966A10
	// [XID] // 0x00000001899669D0-0x0000000189966A10
	public override void ReturnToObjectPool() {} // 0x0000000183845BD0-0x0000000183845C70
}

