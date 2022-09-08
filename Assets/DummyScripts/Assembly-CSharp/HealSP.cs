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
public class HealSP : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16442
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amount; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCasterMaxSPRatio; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByTargetMaxSPRatio; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _amountByCurrentComboRatio; // 0x80
	private bool _muteHealEffect; // 0x88
	private SimpleSafeFloat healRatioRawNum; // 0x8C

	// Properties
	public DynamicFloat amount { /* [XID] */ /* 0x00000001898E1590-0x00000001898E15B0 */ get => default; /* [XID] */ /* 0x00000001898E8FE0-0x00000001898E9000 */ private set {} } // 0x0000000183211670-0x0000000183211710 0x00000001832102F0-0x00000001832103A0
	public DynamicFloat amountByCasterMaxSPRatio { /* [XID] */ /* 0x00000001898F07A0-0x00000001898F07C0 */ get => default; /* [XID] */ /* 0x00000001898F8130-0x00000001898F8150 */ private set {} } // 0x0000000183211390-0x0000000183211430 0x00000001832110C0-0x0000000183211170
	public DynamicFloat amountByTargetMaxSPRatio { /* [XID] */ /* 0x00000001898FF710-0x00000001898FF730 */ get => default; /* [XID] */ /* 0x0000000189906F30-0x0000000189906F50 */ private set {} } // 0x0000000183212740-0x00000001832127E0 0x0000000183210BE0-0x0000000183210C90
	public DynamicFloat amountByCurrentComboRatio { /* [XID] */ /* 0x000000018990E950-0x000000018990E970 */ get => default; /* [XID] */ /* 0x0000000189915F80-0x0000000189915FA0 */ private set {} } // 0x0000000183211D80-0x0000000183211E30 0x0000000183210C90-0x0000000183210D40
	public bool muteHealEffect { /* [XID] */ /* 0x000000018991DA30-0x000000018991DA50 */ get => default; /* [XID] */ /* 0x0000000189925180-0x00000001899251A0 */ private set {} } // 0x00000001832101E0-0x0000000183210290 0x0000000183210AB0-0x0000000183210B60
	public float healRatio { /* [XID] */ /* 0x000000018992C7E0-0x000000018992C800 */ get => default; /* [XID] */ /* 0x0000000189933EA0-0x0000000189933EC0 */ private set {} } // 0x0000000183211B60-0x0000000183211C40 0x000000018320FFB0-0x0000000183210090

	// Constructors
	public HealSP() {} // 0x0000000183212A50-0x0000000183212AF0

	// Methods
	// [XID] // 0x000000018993B9F0-0x000000018993BA10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832127E0-0x00000001832129B0
	// [XID] // 0x0000000189942B30-0x0000000189942B50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832120E0-0x0000000183212210
	// [XID] // 0x000000018994A320-0x000000018994A340
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3B8A */) => default; // 0x0000000183211C40-0x0000000183211D20
	// [XID] // 0x0000000189951E10-0x0000000189951E30
	public override int GetHashNum() => default; // 0x0000000183210110-0x00000001832101E0
	// [XID] // 0x0000000189959390-0x00000001899593B0
	public override void InitEmpty() {} // 0x00000001832114A0-0x00000001832115F0
	[BlackList] // 0x0000000189960C40-0x0000000189960C80
	// [XID] // 0x0000000189960C40-0x0000000189960C80
	public override bool FromJson(JSONNode node) => default; // 0x0000000183210D40-0x00000001832110C0
	// [XID] // 0x000000018996B250-0x000000018996B270
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018320F1F0-0x000000018320F8E0
	[BlackList] // 0x0000000189972D10-0x0000000189972D50
	// [XID] // 0x0000000189972D10-0x0000000189972D50
	public static new HealSP ParseFromJson(JSONNode node) => default; // 0x0000000183211E30-0x0000000183212080
	// [XID] // 0x000000018997CD70-0x000000018997CD90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B8B */, bool useObjectPool = false /* Metadata: 0x00AF3B8F */) => default; // 0x0000000183211860-0x0000000183211B60
	// [XID] // 0x0000000189984A30-0x0000000189984A50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B90 */, bool useObjectPool = false /* Metadata: 0x00AF3B94 */) => default; // 0x0000000183210420-0x0000000183210A30
	// [XID] // 0x000000018998C5F0-0x000000018998C610
	public static new HealSP ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3B95 */, bool useObjectPool = false /* Metadata: 0x00AF3B99 */) => default; // 0x0000000183211170-0x0000000183211390
	[BlackList] // 0x00000001899942F0-0x0000000189994330
	// [XID] // 0x00000001899942F0-0x0000000189994330
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018320F8E0-0x000000018320FBB0
	// [XID] // 0x000000018999ECB0-0x000000018999ECD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183212210-0x0000000183212740
	[BlackList] // 0x00000001899A65F0-0x00000001899A6630
	// [XID] // 0x00000001899A65F0-0x00000001899A6630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183211770-0x0000000183211860
	[BlackList] // 0x00000001899B0FF0-0x00000001899B1030
	// [XID] // 0x00000001899B0FF0-0x00000001899B1030
	public override void AutoAllocTypeFields() {} // 0x000000018320FBB0-0x000000018320FC50
	[BlackList] // 0x00000001899BB3F0-0x00000001899BB430
	// [XID] // 0x00000001899BB3F0-0x00000001899BB430
	public override void AutoRecycleTypeFields() {} // 0x000000018320FC50-0x000000018320FF10
	[BlackList] // 0x00000001899C5E30-0x00000001899C5E70
	// [XID] // 0x00000001899C5E30-0x00000001899C5E70
	public override void ReturnToObjectPool() {} // 0x00000001832129B0-0x0000000183212A50
}

