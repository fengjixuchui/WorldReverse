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
public class ConfigGadgetStateEnableAction : ConfigGadgetStateAction, IAutoAllocRecycle // TypeDefIndex: 14960
{
	// Fields
	private bool _enable; // 0x20

	// Properties
	public bool enable { /* [XID] */ /* 0x0000000189650C90-0x0000000189650CB0 */ get => default; /* [XID] */ /* 0x00000001896584F0-0x0000000189658510 */ private set {} } // 0x0000000182D39490-0x0000000182D39530 0x0000000182D3A250-0x0000000182D3A300

	// Constructors
	public ConfigGadgetStateEnableAction() {} // 0x0000000182D3A7A0-0x0000000182D3A800

	// Methods
	// [XID] // 0x0000000189649600-0x0000000189649620
	public override void DoAction(BaseEntity entity, GadgetState state) {} // 0x0000000182D39DC0-0x0000000182D39EC0
	// [XID] // 0x000000018965FA20-0x000000018965FA40
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D3A610-0x0000000182D3A700
	// [XID] // 0x00000001896674D0-0x00000001896674F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182D3A360-0x0000000182D3A410
	// [XID] // 0x000000018966ECE0-0x000000018966ED00
	public override ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFC2D */) => default; // 0x0000000182D39EC0-0x0000000182D39FA0
	// [XID] // 0x00000001896766E0-0x0000000189676700
	public override int GetHashNum() => default; // 0x0000000182D38C30-0x0000000182D38D00
	// [XID] // 0x000000018967DEC0-0x000000018967DEE0
	public override void InitEmpty() {} // 0x0000000182D39850-0x0000000182D398F0
	[BlackList] // 0x00000001896856C0-0x0000000189685700
	// [XID] // 0x00000001896856C0-0x0000000189685700
	public override bool FromJson(JSONNode node) => default; // 0x0000000182D39110-0x0000000182D39490
	// [XID] // 0x0000000189690680-0x00000001896906A0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182D384F0-0x0000000182D386F0
	[BlackList] // 0x0000000189697EE0-0x0000000189697F20
	// [XID] // 0x0000000189697EE0-0x0000000189697F20
	public static new ConfigGadgetStateEnableAction ParseFromJson(JSONNode node) => default; // 0x0000000182D3A000-0x0000000182D3A250
	// [XID] // 0x00000001896A24E0-0x00000001896A2500
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC2E */, bool useObjectPool = false /* Metadata: 0x00AEFC32 */) => default; // 0x0000000182D39AC0-0x0000000182D39DC0
	// [XID] // 0x00000001896A9680-0x00000001896A96A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC33 */, bool useObjectPool = false /* Metadata: 0x00AEFC37 */) => default; // 0x0000000182D38DE0-0x0000000182D39010
	// [XID] // 0x00000001896B07B0-0x00000001896B07D0
	public static new ConfigGadgetStateEnableAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC38 */, bool useObjectPool = false /* Metadata: 0x00AEFC3C */) => default; // 0x0000000182D39530-0x0000000182D39750
	[BlackList] // 0x00000001896B81B0-0x00000001896B81F0
	// [XID] // 0x00000001896B81B0-0x00000001896B81F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D386F0-0x0000000182D389C0
	// [XID] // 0x00000001896C2200-0x00000001896C2220
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D3A410-0x0000000182D3A610
	[BlackList] // 0x00000001896C97F0-0x00000001896C9830
	// [XID] // 0x00000001896C97F0-0x00000001896C9830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182D399D0-0x0000000182D39AC0
	[BlackList] // 0x00000001896D3C00-0x00000001896D3C40
	// [XID] // 0x00000001896D3C00-0x00000001896D3C40
	public override void AutoAllocTypeFields() {} // 0x0000000182D389C0-0x0000000182D38A60
	[BlackList] // 0x00000001896DE620-0x00000001896DE660
	// [XID] // 0x00000001896DE620-0x00000001896DE660
	public override void AutoRecycleTypeFields() {} // 0x0000000182D38A60-0x0000000182D38B10
	[BlackList] // 0x00000001896E8A80-0x00000001896E8AC0
	// [XID] // 0x00000001896E8A80-0x00000001896E8AC0
	public override void ReturnToObjectPool() {} // 0x0000000182D3A700-0x0000000182D3A7A0
}

