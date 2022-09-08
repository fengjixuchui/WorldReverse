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
public class ConfigTriggerMassiveElementTask : ConfigAbilityTask, IAutoAllocRecycle // TypeDefIndex: 17382
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMassiveEntityElement[] _entityElements; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigMassiveElementTriggerAction[] _elementTriggerActions; // 0x30

	// Properties
	public ConfigMassiveEntityElement[] entityElements { /* [XID] */ /* 0x000000018976FEB0-0x000000018976FED0 */ get => default; /* [XID] */ /* 0x0000000189777670-0x0000000189777690 */ private set {} } // 0x00000001836561B0-0x0000000183656250 0x0000000183655700-0x00000001836557B0
	public ConfigMassiveElementTriggerAction[] elementTriggerActions { /* [XID] */ /* 0x000000018977ED60-0x000000018977ED80 */ get => default; /* [XID] */ /* 0x00000001897867C0-0x00000001897867E0 */ private set {} } // 0x0000000183655660-0x0000000183655700 0x0000000183655BA0-0x0000000183655C50

	// Constructors
	public ConfigTriggerMassiveElementTask() {} // 0x00000001836575C0-0x0000000183657620

	// Methods
	// [XID] // 0x000000018978DD90-0x000000018978DDB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183657360-0x0000000183657470
	// [XID] // 0x0000000189795400-0x0000000189795420
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183656F70-0x0000000183657070
	// [XID] // 0x000000018979D7F0-0x000000018979D810
	public override ConfigAbilityTask Clone(bool useObjectPool = false /* Metadata: 0x00AF6C6B */) => default; // 0x0000000183656B80-0x0000000183656C60
	// [XID] // 0x00000001897A4AF0-0x00000001897A4B10
	public override int GetHashNum() => default; // 0x0000000183655590-0x0000000183655660
	// [XID] // 0x00000001897AC100-0x00000001897AC120
	public override void InitEmpty() {} // 0x00000001836565C0-0x00000001836566B0
	[BlackList] // 0x00000001897B4070-0x00000001897B40B0
	// [XID] // 0x00000001897B4070-0x00000001897B40B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183655E30-0x00000001836561B0
	// [XID] // 0x00000001897BF110-0x00000001897BF130
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183654D20-0x0000000183655040
	[BlackList] // 0x00000001897C66A0-0x00000001897C66E0
	// [XID] // 0x00000001897C66A0-0x00000001897C66E0
	public static new ConfigTriggerMassiveElementTask ParseFromJson(JSONNode node) => default; // 0x0000000183656CC0-0x0000000183656F10
	// [XID] // 0x00000001897D0C70-0x00000001897D0C90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C6C */, bool useObjectPool = false /* Metadata: 0x00AF6C70 */) => default; // 0x0000000183656880-0x0000000183656B80
	// [XID] // 0x00000001897D8B10-0x00000001897D8B30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C71 */, bool useObjectPool = false /* Metadata: 0x00AF6C75 */) => default; // 0x0000000183655890-0x0000000183655BA0
	// [XID] // 0x00000001897DFD50-0x00000001897DFD70
	public static new ConfigTriggerMassiveElementTask ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6C76 */, bool useObjectPool = false /* Metadata: 0x00AF6C7A */) => default; // 0x0000000183656250-0x0000000183656470
	[BlackList] // 0x00000001897E72D0-0x00000001897E7310
	// [XID] // 0x00000001897E72D0-0x00000001897E7310
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183655040-0x0000000183655310
	// [XID] // 0x00000001897F2350-0x00000001897F2370
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183657070-0x0000000183657360
	[BlackList] // 0x00000001897F9A00-0x00000001897F9A40
	// [XID] // 0x00000001897F9A00-0x00000001897F9A40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183656790-0x0000000183656880
	[BlackList] // 0x0000000189804070-0x00000001898040B0
	// [XID] // 0x0000000189804070-0x00000001898040B0
	public override void AutoAllocTypeFields() {} // 0x0000000183655310-0x00000001836553B0
	[BlackList] // 0x000000018980E5D0-0x000000018980E610
	// [XID] // 0x000000018980E5D0-0x000000018980E610
	public override void AutoRecycleTypeFields() {} // 0x00000001836553B0-0x0000000183655470
	[BlackList] // 0x0000000189819050-0x0000000189819090
	// [XID] // 0x0000000189819050-0x0000000189819090
	public override void ReturnToObjectPool() {} // 0x0000000183657520-0x00000001836575C0
	// [XID] // 0x0000000189823310-0x0000000189823330
	public override AbilityTask CreateTaskFromConfig() => default; // 0x0000000183657470-0x0000000183657520
	// [XID] // 0x000000018982ACF0-0x000000018982AD10
	public override AbilityTaskBlackboard CreateTaskBlackboardFromConfig() => default; // 0x0000000183655D50-0x0000000183655E30
}

