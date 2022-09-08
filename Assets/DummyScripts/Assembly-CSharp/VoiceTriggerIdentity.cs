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
public class VoiceTriggerIdentity : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18077
{
	// Fields
	private AudioVoiceTrigger __gameTrigger; // 0x10
	private SimpleSafeUInt32 _gameTriggerArgsRawNum; // 0x14

	// Properties
	public AudioVoiceTrigger _gameTrigger { /* [XID] */ /* 0x000000018981BD00-0x000000018981BD20 */ get => default; /* [XID] */ /* 0x0000000189823150-0x0000000189823170 */ private set {} } // 0x000000018420FB60-0x000000018420FC00 0x000000018420F360-0x000000018420F410
	public uint _gameTriggerArgs { /* [XID] */ /* 0x000000018982AB90-0x000000018982ABB0 */ get => default; /* [XID] */ /* 0x0000000189832010-0x0000000189832030 */ private set {} } // 0x000000018420EFF0-0x000000018420F0C0 0x000000018420FC00-0x000000018420FCE0

	// Constructors
	public VoiceTriggerIdentity() {} // 0x0000000184210240-0x00000001842102A0

	// Methods
	// [XID] // 0x0000000189839780-0x00000001898397A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018420FF50-0x0000000184210060
	// [XID] // 0x0000000189840CE0-0x0000000189840D00
	public void InitEmpty() {} // 0x000000018420F790-0x000000018420F860
	[BlackList] // 0x0000000189848140-0x0000000189848180
	// [XID] // 0x0000000189848140-0x0000000189848180
	public bool FromJson(JSONNode node) => default; // 0x000000018420F410-0x000000018420F790
	// [XID] // 0x00000001898524E0-0x0000000189852500
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018420E8B0-0x000000018420EBB0
	// [XID] // 0x0000000189859E70-0x0000000189859E90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A41 */, bool useObjectPool = false /* Metadata: 0x00AF8A45 */) => default; // 0x000000018420F860-0x000000018420FB60
	// [XID] // 0x0000000189860F90-0x0000000189860FB0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A46 */, bool useObjectPool = false /* Metadata: 0x00AF8A4A */) => default; // 0x000000018420F0C0-0x000000018420F360
	[BlackList] // 0x0000000189868790-0x00000001898687D0
	// [XID] // 0x0000000189868790-0x00000001898687D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018420EBB0-0x000000018420EE80
	// [XID] // 0x0000000189872AF0-0x0000000189872B10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018420FCE0-0x000000018420FF50
	[BlackList] // 0x000000018987A7B0-0x000000018987A7F0
	// [XID] // 0x000000018987A7B0-0x000000018987A7F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018420EE80-0x000000018420EF20
	[BlackList] // 0x0000000189884650-0x0000000189884690
	// [XID] // 0x0000000189884650-0x0000000189884690
	public virtual void AutoRecycleTypeFields() {} // 0x000000018420EF20-0x000000018420EFF0
	[BlackList] // 0x000000018988EB40-0x000000018988EB80
	// [XID] // 0x000000018988EB40-0x000000018988EB80
	public virtual void ReturnToObjectPool() {} // 0x00000001842101A0-0x0000000184210240
	[BlackList] // 0x00000001898992F0-0x0000000189899330
	// [XID] // 0x00000001898992F0-0x0000000189899330
	public virtual void OnPoolAllocated() {} // 0x0000000184210100-0x00000001842101A0
	[BlackList] // 0x00000001898A3620-0x00000001898A3660
	// [XID] // 0x00000001898A3620-0x00000001898A3660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184210060-0x0000000184210100
}

