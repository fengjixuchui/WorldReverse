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
public class ConfigAudioStageProgressEvent : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17628
{
	// Fields
	private SimpleSafeFloat progressRawNum; // 0x10
	private string[] _events; // 0x18

	// Properties
	public float progress { /* [XID] */ /* 0x0000000189A8C430-0x0000000189A8C450 */ get => default; /* [XID] */ /* 0x0000000189A938B0-0x0000000189A938D0 */ private set {} } // 0x000000018215ADF0-0x000000018215AED0 0x000000018215AD10-0x000000018215ADF0
	public string[] events { /* [XID] */ /* 0x0000000189A9B4C0-0x0000000189A9B4E0 */ get => default; /* [XID] */ /* 0x0000000189AA27E0-0x0000000189AA2800 */ private set {} } // 0x000000018215A4F0-0x000000018215A590 0x000000018215A170-0x000000018215A220

	// Constructors
	public ConfigAudioStageProgressEvent() {} // 0x000000018215B430-0x000000018215B490

	// Methods
	// [XID] // 0x0000000189AA9DA0-0x0000000189AA9DC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018215B140-0x000000018215B250
	// [XID] // 0x0000000189AB1CA0-0x0000000189AB1CC0
	public void InitEmpty() {} // 0x000000018215A910-0x000000018215AA10
	[BlackList] // 0x0000000189AB8F90-0x0000000189AB8FD0
	// [XID] // 0x0000000189AB8F90-0x0000000189AB8FD0
	public bool FromJson(JSONNode node) => default; // 0x000000018215A590-0x000000018215A910
	// [XID] // 0x0000000189AC3FA0-0x0000000189AC3FC0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182159A10-0x0000000182159D20
	// [XID] // 0x0000000189ACB470-0x0000000189ACB490
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF754F */, bool useObjectPool = false /* Metadata: 0x00AF7553 */) => default; // 0x000000018215AA10-0x000000018215AD10
	// [XID] // 0x0000000189AD2F00-0x0000000189AD2F20
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7554 */, bool useObjectPool = false /* Metadata: 0x00AF7558 */) => default; // 0x000000018215A220-0x000000018215A4F0
	[BlackList] // 0x0000000189ADA920-0x0000000189ADA960
	// [XID] // 0x0000000189ADA920-0x0000000189ADA960
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182159D20-0x0000000182159FF0
	// [XID] // 0x0000000189AE55E0-0x0000000189AE5600
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018215AED0-0x000000018215B140
	[BlackList] // 0x0000000189AECAE0-0x0000000189AECB20
	// [XID] // 0x0000000189AECAE0-0x0000000189AECB20
	public virtual void AutoAllocTypeFields() {} // 0x0000000182159FF0-0x000000018215A090
	[BlackList] // 0x0000000189AF7560-0x0000000189AF75A0
	// [XID] // 0x0000000189AF7560-0x0000000189AF75A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018215A090-0x000000018215A170
	[BlackList] // 0x0000000189B01BF0-0x0000000189B01C30
	// [XID] // 0x0000000189B01BF0-0x0000000189B01C30
	public virtual void ReturnToObjectPool() {} // 0x000000018215B390-0x000000018215B430
	[BlackList] // 0x0000000189B0C210-0x0000000189B0C250
	// [XID] // 0x0000000189B0C210-0x0000000189B0C250
	public virtual void OnPoolAllocated() {} // 0x000000018215B2F0-0x000000018215B390
	[BlackList] // 0x0000000189B16450-0x0000000189B16490
	// [XID] // 0x0000000189B16450-0x0000000189B16490
	public virtual void OnBeforePoolRecycled() {} // 0x000000018215B250-0x000000018215B2F0
}

