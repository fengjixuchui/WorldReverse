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
public class ConfigGadgetTriggerAbility : ConfigBaseGadgetTriggerAction, IAutoAllocRecycle // TypeDefIndex: 14952
{
	// Fields
	private string _abilityName; // 0x10

	// Properties
	public string abilityName { /* [XID] */ /* 0x0000000189637880-0x00000001896378A0 */ get => default; /* [XID] */ /* 0x000000018963ECA0-0x000000018963ECC0 */ private set {} } // 0x00000001837A05A0-0x00000001837A0640 0x00000001837A0D10-0x00000001837A0DC0

	// Constructors
	public ConfigGadgetTriggerAbility() {} // 0x00000001837A0FF0-0x00000001837A1050

	// Methods
	// [XID] // 0x000000018962FCA0-0x000000018962FCC0
	public override void DoTriggerAction(LCGadgetCombat gadgetCombat, uint otherID, int actionIdx) {} // 0x000000018379EC20-0x000000018379ED60
	// [XID] // 0x00000001896464A0-0x00000001896464C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837A0DC0-0x00000001837A0EB0
	// [XID] // 0x000000018964DCC0-0x000000018964DCE0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001837A0A30-0x00000001837A0B10
	// [XID] // 0x0000000189655540-0x0000000189655560
	public override ConfigBaseGadgetTriggerAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFBAD */) => default; // 0x00000001837A0640-0x00000001837A0720
	// [XID] // 0x000000018965CCE0-0x000000018965CD00
	public override int GetHashNum() => default; // 0x000000018379F4D0-0x000000018379F5A0
	// [XID] // 0x00000001896641E0-0x0000000189664200
	public override void InitEmpty() {} // 0x00000001837A0000-0x00000001837A00D0
	[BlackList] // 0x000000018966B8C0-0x000000018966B900
	// [XID] // 0x000000018966B8C0-0x000000018966B900
	public override bool FromJson(JSONNode node) => default; // 0x000000018379F9F0-0x000000018379FD70
	// [XID] // 0x0000000189676700-0x0000000189676720
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018379ED60-0x000000018379EF90
	[BlackList] // 0x000000018967DEE0-0x000000018967DF20
	// [XID] // 0x000000018967DEE0-0x000000018967DF20
	public static new ConfigGadgetTriggerAbility ParseFromJson(JSONNode node) => default; // 0x00000001837A0780-0x00000001837A09D0
	// [XID] // 0x0000000189688BC0-0x0000000189688BE0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBAE */, bool useObjectPool = false /* Metadata: 0x00AEFBB2 */) => default; // 0x00000001837A02A0-0x00000001837A05A0
	// [XID] // 0x00000001896906A0-0x00000001896906C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBB3 */, bool useObjectPool = false /* Metadata: 0x00AEFBB7 */) => default; // 0x000000018379F680-0x000000018379F8F0
	// [XID] // 0x0000000189697F20-0x0000000189697F40
	public static new ConfigGadgetTriggerAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBB8 */, bool useObjectPool = false /* Metadata: 0x00AEFBBC */) => default; // 0x000000018379FD70-0x000000018379FF90
	[BlackList] // 0x000000018969F1F0-0x000000018969F230
	// [XID] // 0x000000018969F1F0-0x000000018969F230
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018379EF90-0x000000018379F260
	// [XID] // 0x00000001896A96A0-0x00000001896A96C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837A0B10-0x00000001837A0D10
	[BlackList] // 0x00000001896B07D0-0x00000001896B0810
	// [XID] // 0x00000001896B07D0-0x00000001896B0810
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001837A01B0-0x00000001837A02A0
	[BlackList] // 0x00000001896BB090-0x00000001896BB0D0
	// [XID] // 0x00000001896BB090-0x00000001896BB0D0
	public override void AutoAllocTypeFields() {} // 0x000000018379F260-0x000000018379F300
	[BlackList] // 0x00000001896C5390-0x00000001896C53D0
	// [XID] // 0x00000001896C5390-0x00000001896C53D0
	public override void AutoRecycleTypeFields() {} // 0x000000018379F300-0x000000018379F3B0
	[BlackList] // 0x00000001896CFBB0-0x00000001896CFBF0
	// [XID] // 0x00000001896CFBB0-0x00000001896CFBF0
	public override void ReturnToObjectPool() {} // 0x00000001837A0F50-0x00000001837A0FF0
}

