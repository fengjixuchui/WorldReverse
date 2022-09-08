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
public class ControlEmotion : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16371
{
	// Fields
	private bool _toggleEmoSync; // 0x68
	private bool _toggleBlink; // 0x69
	private bool _toggleEyeKey; // 0x6A

	// Properties
	public bool toggleEmoSync { /* [XID] */ /* 0x000000018988D5E0-0x000000018988D600 */ get => default; /* [XID] */ /* 0x0000000189894D70-0x0000000189894D90 */ private set {} } // 0x0000000183B86F70-0x0000000183B87010 0x0000000183B86290-0x0000000183B86340
	public bool toggleBlink { /* [XID] */ /* 0x000000018989C3A0-0x000000018989C3C0 */ get => default; /* [XID] */ /* 0x00000001898A3A00-0x00000001898A3A20 */ private set {} } // 0x0000000183B85BD0-0x0000000183B85C70 0x0000000183B85B20-0x0000000183B85BD0
	public bool toggleEyeKey { /* [XID] */ /* 0x00000001898AAD20-0x00000001898AAD40 */ get => default; /* [XID] */ /* 0x00000001898B2690-0x00000001898B26B0 */ private set {} } // 0x0000000183B84970-0x0000000183B84A10 0x0000000183B852C0-0x0000000183B85370
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018993E870-0x000000018993E890 */ get => default; } // 0x0000000183B86DC0-0x0000000183B86E60 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189945E60-0x0000000189945E80 */ get => default; } // 0x0000000183B86420-0x0000000183B864C0 

	// Constructors
	public ControlEmotion() {} // 0x0000000183B87670-0x0000000183B876E0

	// Methods
	// [XID] // 0x00000001898BA480-0x00000001898BA4A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B87400-0x0000000183B87530
	// [XID] // 0x00000001898C1780-0x00000001898C17A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B86EC0-0x0000000183B86F70
	// [XID] // 0x00000001898C90A0-0x00000001898C90C0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3958 */) => default; // 0x0000000183B86A30-0x0000000183B86B10
	// [XID] // 0x00000001898D08E0-0x00000001898D0900
	public override int GetHashNum() => default; // 0x0000000183B853F0-0x0000000183B854C0
	// [XID] // 0x00000001898D7FC0-0x00000001898D7FE0
	public override void InitEmpty() {} // 0x0000000183B864C0-0x0000000183B86560
	[BlackList] // 0x00000001898DFD60-0x00000001898DFDA0
	// [XID] // 0x00000001898DFD60-0x00000001898DFDA0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B85CF0-0x0000000183B86070
	// [XID] // 0x00000001898EA810-0x00000001898EA830
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B84A10-0x0000000183B84D90
	[BlackList] // 0x00000001898F1F30-0x00000001898F1F70
	// [XID] // 0x00000001898F1F30-0x00000001898F1F70
	public static new ControlEmotion ParseFromJson(JSONNode node) => default; // 0x0000000183B86B70-0x0000000183B86DC0
	// [XID] // 0x00000001898FC630-0x00000001898FC650
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3959 */, bool useObjectPool = false /* Metadata: 0x00AF395D */) => default; // 0x0000000183B86730-0x0000000183B86A30
	// [XID] // 0x00000001899040B0-0x00000001899040D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF395E */, bool useObjectPool = false /* Metadata: 0x00AF3962 */) => default; // 0x0000000183B85610-0x0000000183B85940
	// [XID] // 0x000000018990B690-0x000000018990B6B0
	public static new ControlEmotion ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3963 */, bool useObjectPool = false /* Metadata: 0x00AF3967 */) => default; // 0x0000000183B86070-0x0000000183B86290
	[BlackList] // 0x0000000189913360-0x00000001899133A0
	// [XID] // 0x0000000189913360-0x00000001899133A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B84D90-0x0000000183B85060
	// [XID] // 0x000000018991DA90-0x000000018991DAB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B870F0-0x0000000183B87400
	[BlackList] // 0x00000001899251A0-0x00000001899251E0
	// [XID] // 0x00000001899251A0-0x00000001899251E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B86640-0x0000000183B86730
	// [XID] // 0x000000018992F7E0-0x000000018992F800
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000183B87530-0x0000000183B875D0
	// [XID] // 0x0000000189936C90-0x0000000189936CB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183B85940-0x0000000183B85AA0
	[BlackList] // 0x000000018994D3B0-0x000000018994D3F0
	// [XID] // 0x000000018994D3B0-0x000000018994D3F0
	public override void AutoAllocTypeFields() {} // 0x0000000183B85060-0x0000000183B85100
	[BlackList] // 0x0000000189957C60-0x0000000189957CA0
	// [XID] // 0x0000000189957C60-0x0000000189957CA0
	public override void AutoRecycleTypeFields() {} // 0x0000000183B85100-0x0000000183B851B0
	[BlackList] // 0x00000001899627B0-0x00000001899627F0
	// [XID] // 0x00000001899627B0-0x00000001899627F0
	public override void ReturnToObjectPool() {} // 0x0000000183B875D0-0x0000000183B87670
}

