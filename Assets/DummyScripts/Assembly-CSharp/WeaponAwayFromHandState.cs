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
public class WeaponAwayFromHandState : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18067
{
	// Fields
	private string _state; // 0x10
	private SimpleSafeFloat startNormTimeRawNum; // 0x18
	private SimpleSafeFloat endNormTimeRawNum; // 0x1C
	private SimpleSafeFloat delayAppearTimeRawNum; // 0x20
	private SimpleSafeFloat dissolveShowTimeRawNum; // 0x24
	private SimpleSafeFloat dissolveHideTimeRawNum; // 0x28

	// Properties
	public string state { /* [XID] */ /* 0x000000018972E330-0x000000018972E350 */ get => default; /* [XID] */ /* 0x0000000189735A00-0x0000000189735A20 */ private set {} } // 0x0000000184A949D0-0x0000000184A94A70 0x0000000184A93B40-0x0000000184A93BF0
	public float startNormTime { /* [XID] */ /* 0x000000018973D5B0-0x000000018973D5D0 */ get => default; /* [XID] */ /* 0x0000000189744A90-0x0000000189744AB0 */ private set {} } // 0x0000000184A95400-0x0000000184A954E0 0x0000000184A94160-0x0000000184A94240
	public float endNormTime { /* [XID] */ /* 0x000000018974C780-0x000000018974C7A0 */ get => default; /* [XID] */ /* 0x0000000189753A60-0x0000000189753A80 */ private set {} } // 0x0000000184A95CE0-0x0000000184A95DC0 0x0000000184A948F0-0x0000000184A949D0
	public float delayAppearTime { /* [XID] */ /* 0x000000018975B020-0x000000018975B040 */ get => default; /* [XID] */ /* 0x0000000189762970-0x0000000189762990 */ private set {} } // 0x0000000184A95950-0x0000000184A95A30 0x0000000184A95320-0x0000000184A95400
	public float dissolveShowTime { /* [XID] */ /* 0x0000000189769F90-0x0000000189769FB0 */ get => default; /* [XID] */ /* 0x0000000189771790-0x00000001897717B0 */ private set {} } // 0x0000000184A94240-0x0000000184A94320 0x0000000184A94320-0x0000000184A94400
	public float dissolveHideTime { /* [XID] */ /* 0x0000000189778F00-0x0000000189778F20 */ get => default; /* [XID] */ /* 0x0000000189780600-0x0000000189780620 */ private set {} } // 0x0000000184A94DF0-0x0000000184A94ED0 0x0000000184A93EC0-0x0000000184A93FA0

	// Constructors
	public WeaponAwayFromHandState() {} // 0x0000000184A95E60-0x0000000184A95F10

	// Methods
	// [XID] // 0x0000000189787DE0-0x0000000189787E00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A95A30-0x0000000184A95BA0
	// [XID] // 0x000000018978F360-0x000000018978F380
	public void InitEmpty() {} // 0x0000000184A94ED0-0x0000000184A95020
	[BlackList] // 0x0000000189796AD0-0x0000000189796B10
	// [XID] // 0x0000000189796AD0-0x0000000189796B10
	public bool FromJson(JSONNode node) => default; // 0x0000000184A94A70-0x0000000184A94DF0
	// [XID] // 0x00000001897A17C0-0x00000001897A17E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A933E0-0x0000000184A93B40
	// [XID] // 0x00000001897A9080-0x00000001897A90A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89D1 */, bool useObjectPool = false /* Metadata: 0x00AF89D5 */) => default; // 0x0000000184A95020-0x0000000184A95320
	// [XID] // 0x00000001897B0920-0x00000001897B0940
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89D6 */, bool useObjectPool = false /* Metadata: 0x00AF89DA */) => default; // 0x0000000184A94400-0x0000000184A948F0
	[BlackList] // 0x00000001897B8640-0x00000001897B8680
	// [XID] // 0x00000001897B8640-0x00000001897B8680
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A93BF0-0x0000000184A93EC0
	// [XID] // 0x00000001897C3450-0x00000001897C3470
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A954E0-0x0000000184A95950
	[BlackList] // 0x00000001897CABF0-0x00000001897CAC30
	// [XID] // 0x00000001897CABF0-0x00000001897CAC30
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A93FA0-0x0000000184A94040
	[BlackList] // 0x00000001897D5210-0x00000001897D5250
	// [XID] // 0x00000001897D5210-0x00000001897D5250
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A94040-0x0000000184A94160
	[BlackList] // 0x00000001897DFB10-0x00000001897DFB50
	// [XID] // 0x00000001897DFB10-0x00000001897DFB50
	public virtual void ReturnToObjectPool() {} // 0x0000000184A95DC0-0x0000000184A95E60
	[BlackList] // 0x00000001897EA4A0-0x00000001897EA4E0
	// [XID] // 0x00000001897EA4A0-0x00000001897EA4E0
	public virtual void OnPoolAllocated() {} // 0x0000000184A95C40-0x0000000184A95CE0
	[BlackList] // 0x00000001897F4E90-0x00000001897F4ED0
	// [XID] // 0x00000001897F4E90-0x00000001897F4ED0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A95BA0-0x0000000184A95C40
}

