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
public class CameraPlayCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18777
{
	// Fields
	private SimpleSafeFloat degreeXRawNum; // 0x10
	private SimpleSafeFloat degreeYRawNum; // 0x14
	private SimpleSafeFloat lengthRawNum; // 0x18

	// Properties
	public float degreeX { /* [XID] */ /* 0x00000001899B3AE0-0x00000001899B3B00 */ get => default; /* [XID] */ /* 0x00000001899BAF90-0x00000001899BAFB0 */ private set {} } // 0x0000000184A7B130-0x0000000184A7B210 0x0000000184A7ACF0-0x0000000184A7ADD0
	public float degreeY { /* [XID] */ /* 0x00000001899C2920-0x00000001899C2940 */ get => default; /* [XID] */ /* 0x00000001899C9FE0-0x00000001899CA000 */ private set {} } // 0x0000000184A7B210-0x0000000184A7B2F0 0x0000000184A7B830-0x0000000184A7B910
	public float length { /* [XID] */ /* 0x00000001899D1860-0x00000001899D1880 */ get => default; /* [XID] */ /* 0x00000001899D8DB0-0x00000001899D8DD0 */ private set {} } // 0x0000000184A7B750-0x0000000184A7B830 0x0000000184A7B670-0x0000000184A7B750

	// Constructors
	public CameraPlayCondition() {} // 0x0000000184A7C2D0-0x0000000184A7C330

	// Methods
	// [XID] // 0x00000001899E03C0-0x00000001899E03E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A7BFD0-0x0000000184A7C0F0
	// [XID] // 0x00000001899E7EC0-0x00000001899E7EE0
	public void InitEmpty() {} // 0x0000000184A7B910-0x0000000184A7BA00
	[BlackList] // 0x00000001899EF350-0x00000001899EF390
	// [XID] // 0x00000001899EF350-0x00000001899EF390
	public bool FromJson(JSONNode node) => default; // 0x0000000184A7B2F0-0x0000000184A7B670
	// [XID] // 0x00000001899F9B50-0x00000001899F9B70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A7A420-0x0000000184A7A890
	// [XID] // 0x0000000189A00F70-0x0000000189A00F90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABE9 */, bool useObjectPool = false /* Metadata: 0x00AFABED */) => default; // 0x0000000184A7BA00-0x0000000184A7BD00
	// [XID] // 0x0000000189A08870-0x0000000189A08890
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFABEE */, bool useObjectPool = false /* Metadata: 0x00AFABF2 */) => default; // 0x0000000184A7ADD0-0x0000000184A7B130
	[BlackList] // 0x0000000189A0FE30-0x0000000189A0FE70
	// [XID] // 0x0000000189A0FE30-0x0000000189A0FE70
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A7A890-0x0000000184A7AB60
	// [XID] // 0x0000000189A1A350-0x0000000189A1A370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A7BD00-0x0000000184A7BFD0
	[BlackList] // 0x0000000189A21950-0x0000000189A21990
	// [XID] // 0x0000000189A21950-0x0000000189A21990
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A7AB60-0x0000000184A7AC00
	[BlackList] // 0x0000000189A2BD90-0x0000000189A2BDD0
	// [XID] // 0x0000000189A2BD90-0x0000000189A2BDD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A7AC00-0x0000000184A7ACF0
	[BlackList] // 0x0000000189A367F0-0x0000000189A36830
	// [XID] // 0x0000000189A367F0-0x0000000189A36830
	public virtual void ReturnToObjectPool() {} // 0x0000000184A7C230-0x0000000184A7C2D0
	[BlackList] // 0x0000000189A40ED0-0x0000000189A40F10
	// [XID] // 0x0000000189A40ED0-0x0000000189A40F10
	public virtual void OnPoolAllocated() {} // 0x0000000184A7C190-0x0000000184A7C230
	[BlackList] // 0x0000000189A4B4C0-0x0000000189A4B500
	// [XID] // 0x0000000189A4B4C0-0x0000000189A4B500
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A7C0F0-0x0000000184A7C190
}

