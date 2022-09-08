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
public class ConfigGadgetStateFireAISound : ConfigGadgetStateAction, IAutoAllocRecycle // TypeDefIndex: 14958
{
	// Fields
	private SimpleSafeFloat volumeRawNum; // 0x20

	// Properties
	public float volume { /* [XID] */ /* 0x0000000189AE8670-0x0000000189AE8690 */ get => default; /* [XID] */ /* 0x0000000189AF0590-0x0000000189AF05B0 */ private set {} } // 0x00000001837911E0-0x00000001837912C0 0x000000018378FAB0-0x000000018378FB90

	// Constructors
	public ConfigGadgetStateFireAISound() {} // 0x0000000183791660-0x0000000183791700

	// Methods
	// [XID] // 0x0000000189AE1140-0x0000000189AE1160
	public override void DoAction(BaseEntity entity, GadgetState state) {} // 0x0000000183790BF0-0x0000000183790D40
	// [XID] // 0x0000000189AF7A60-0x0000000189AF7A80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837914C0-0x00000001837915C0
	// [XID] // 0x0000000189AFEFB0-0x0000000189AFEFD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183791130-0x00000001837911E0
	// [XID] // 0x0000000189B06840-0x0000000189B06860
	public override ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFC0D */) => default; // 0x0000000183790D40-0x0000000183790E20
	// [XID] // 0x0000000189B0DFD0-0x0000000189B0DFF0
	public override int GetHashNum() => default; // 0x000000018378F9E0-0x000000018378FAB0
	// [XID] // 0x0000000189B15290-0x0000000189B152B0
	public override void InitEmpty() {} // 0x0000000183790640-0x0000000183790720
	[BlackList] // 0x0000000189B1CD50-0x0000000189B1CD90
	// [XID] // 0x0000000189B1CD50-0x0000000189B1CD90
	public override bool FromJson(JSONNode node) => default; // 0x000000018378FFA0-0x0000000183790320
	// [XID] // 0x0000000189B27320-0x0000000189B27340
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018378F220-0x000000018378F470
	[BlackList] // 0x0000000189B2E4B0-0x0000000189B2E4F0
	// [XID] // 0x0000000189B2E4B0-0x0000000189B2E4F0
	public static new ConfigGadgetStateFireAISound ParseFromJson(JSONNode node) => default; // 0x0000000183790E80-0x00000001837910D0
	// [XID] // 0x0000000189B38AF0-0x0000000189B38B10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC0E */, bool useObjectPool = false /* Metadata: 0x00AEFC12 */) => default; // 0x00000001837908F0-0x0000000183790BF0
	// [XID] // 0x0000000189B40520-0x0000000189B40540
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC13 */, bool useObjectPool = false /* Metadata: 0x00AEFC17 */) => default; // 0x000000018378FC70-0x000000018378FEA0
	// [XID] // 0x0000000189B47E80-0x0000000189B47EA0
	public static new ConfigGadgetStateFireAISound ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC18 */, bool useObjectPool = false /* Metadata: 0x00AEFC1C */) => default; // 0x0000000183790320-0x0000000183790540
	[BlackList] // 0x0000000189B4F5F0-0x0000000189B4F630
	// [XID] // 0x0000000189B4F5F0-0x0000000189B4F630
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018378F470-0x000000018378F740
	// [XID] // 0x0000000189B59E60-0x0000000189B59E80
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837912C0-0x00000001837914C0
	[BlackList] // 0x0000000189B61510-0x0000000189B61550
	// [XID] // 0x0000000189B61510-0x0000000189B61550
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183790800-0x00000001837908F0
	[BlackList] // 0x0000000189B6BAF0-0x0000000189B6BB30
	// [XID] // 0x0000000189B6BAF0-0x0000000189B6BB30
	public override void AutoAllocTypeFields() {} // 0x000000018378F740-0x000000018378F7E0
	[BlackList] // 0x0000000189B76250-0x0000000189B76290
	// [XID] // 0x0000000189B76250-0x0000000189B76290
	public override void AutoRecycleTypeFields() {} // 0x000000018378F7E0-0x000000018378F8C0
	[BlackList] // 0x0000000189B80610-0x0000000189B80650
	// [XID] // 0x0000000189B80610-0x0000000189B80650
	public override void ReturnToObjectPool() {} // 0x00000001837915C0-0x0000000183791660
}

