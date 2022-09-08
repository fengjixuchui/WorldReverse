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
public class ConfigGlobalInteraction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18116
{
	// Fields
	private SimpleSafeFloat talkEnableAngleRawNum; // 0x10
	private SimpleSafeFloat headCtrlEnableAngleRawNum; // 0x14
	private SimpleSafeFloat headCtrlDisableAngleRawNum; // 0x18

	// Properties
	public float talkEnableAngle { /* [XID] */ /* 0x00000001899BFB70-0x00000001899BFB90 */ get => default; /* [XID] */ /* 0x00000001899C7310-0x00000001899C7330 */ private set {} } // 0x0000000183961C10-0x0000000183961CF0 0x0000000183961110-0x00000001839611F0
	public float headCtrlEnableAngle { /* [XID] */ /* 0x00000001899CE8E0-0x00000001899CE900 */ get => default; /* [XID] */ /* 0x00000001899D6050-0x00000001899D6070 */ private set {} } // 0x0000000183961A50-0x0000000183961B30 0x0000000183961570-0x0000000183961650
	public float headCtrlDisableAngle { /* [XID] */ /* 0x00000001899DD480-0x00000001899DD4A0 */ get => default; /* [XID] */ /* 0x00000001899E51A0-0x00000001899E51C0 */ private set {} } // 0x0000000183961030-0x0000000183961110 0x0000000183961B30-0x0000000183961C10

	// Constructors
	public ConfigGlobalInteraction() {} // 0x00000001839622C0-0x0000000183962380

	// Methods
	// [XID] // 0x00000001899EC530-0x00000001899EC550
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183961FC0-0x00000001839620E0
	// [XID] // 0x00000001899F41F0-0x00000001899F4210
	public void InitEmpty() {} // 0x0000000183961650-0x0000000183961750
	[BlackList] // 0x00000001899FB7B0-0x00000001899FB7F0
	// [XID] // 0x00000001899FB7B0-0x00000001899FB7F0
	public bool FromJson(JSONNode node) => default; // 0x00000001839611F0-0x0000000183961570
	// [XID] // 0x0000000189A05D70-0x0000000189A05D90
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839604E0-0x00000001839608F0
	// [XID] // 0x0000000189A0D100-0x0000000189A0D120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B9F */, bool useObjectPool = false /* Metadata: 0x00AF8BA3 */) => default; // 0x0000000183961750-0x0000000183961A50
	// [XID] // 0x0000000189A149E0-0x0000000189A14A00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BA4 */, bool useObjectPool = false /* Metadata: 0x00AF8BA8 */) => default; // 0x0000000183960D60-0x0000000183961030
	[BlackList] // 0x0000000189A1BC90-0x0000000189A1BCD0
	// [XID] // 0x0000000189A1BC90-0x0000000189A1BCD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001839608F0-0x0000000183960BC0
	// [XID] // 0x0000000189A26260-0x0000000189A26280
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183961CF0-0x0000000183961FC0
	[BlackList] // 0x0000000189A2D530-0x0000000189A2D570
	// [XID] // 0x0000000189A2D530-0x0000000189A2D570
	public virtual void AutoAllocTypeFields() {} // 0x0000000183960BC0-0x0000000183960C60
	[BlackList] // 0x0000000189A38010-0x0000000189A38050
	// [XID] // 0x0000000189A38010-0x0000000189A38050
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183960C60-0x0000000183960D60
	[BlackList] // 0x0000000189A42690-0x0000000189A426D0
	// [XID] // 0x0000000189A42690-0x0000000189A426D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183962220-0x00000001839622C0
	[BlackList] // 0x0000000189A4CCE0-0x0000000189A4CD20
	// [XID] // 0x0000000189A4CCE0-0x0000000189A4CD20
	public virtual void OnPoolAllocated() {} // 0x0000000183962180-0x0000000183962220
	[BlackList] // 0x0000000189A57490-0x0000000189A574D0
	// [XID] // 0x0000000189A57490-0x0000000189A574D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001839620E0-0x0000000183962180
}

