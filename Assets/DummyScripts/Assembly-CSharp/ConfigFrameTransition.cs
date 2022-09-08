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
public class ConfigFrameTransition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17899
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeFloat durationRawNum; // 0x14

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001895FB150-0x00000001895FB170 */ get => default; /* [XID] */ /* 0x00000001896028B0-0x00000001896028D0 */ private set {} } // 0x0000000185547070-0x0000000185547110 0x00000001855474E0-0x0000000185547590
	public float duration { /* [XID] */ /* 0x000000018960A250-0x000000018960A270 */ get => default; /* [XID] */ /* 0x00000001896119C0-0x00000001896119E0 */ private set {} } // 0x00000001855468E0-0x00000001855469C0 0x0000000185546C10-0x0000000185546CF0

	// Constructors
	public ConfigFrameTransition() {} // 0x0000000185547AC0-0x0000000185547B60

	// Methods
	// [XID] // 0x0000000189619340-0x0000000189619360
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001855477D0-0x00000001855478E0
	// [XID] // 0x00000001896208E0-0x0000000189620900
	public void InitEmpty() {} // 0x0000000185547110-0x00000001855471E0
	[BlackList] // 0x0000000189627E10-0x0000000189627E50
	// [XID] // 0x0000000189627E10-0x0000000189627E50
	public bool FromJson(JSONNode node) => default; // 0x0000000185546CF0-0x0000000185547070
	// [XID] // 0x0000000189632660-0x0000000189632680
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001855461D0-0x00000001855464A0
	// [XID] // 0x000000018963A130-0x000000018963A150
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF80A3 */, bool useObjectPool = false /* Metadata: 0x00AF80A7 */) => default; // 0x00000001855471E0-0x00000001855474E0
	// [XID] // 0x00000001896416E0-0x0000000189641700
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF80A8 */, bool useObjectPool = false /* Metadata: 0x00AF80AC */) => default; // 0x00000001855469C0-0x0000000185546C10
	[BlackList] // 0x0000000189649040-0x0000000189649080
	// [XID] // 0x0000000189649040-0x0000000189649080
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001855464A0-0x0000000185546770
	// [XID] // 0x0000000189653660-0x0000000189653680
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185547590-0x00000001855477D0
	[BlackList] // 0x000000018965AFB0-0x000000018965AFF0
	// [XID] // 0x000000018965AFB0-0x000000018965AFF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185546770-0x0000000185546810
	[BlackList] // 0x0000000189665490-0x00000001896654D0
	// [XID] // 0x0000000189665490-0x00000001896654D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185546810-0x00000001855468E0
	[BlackList] // 0x0000000189670230-0x0000000189670270
	// [XID] // 0x0000000189670230-0x0000000189670270
	public virtual void ReturnToObjectPool() {} // 0x0000000185547A20-0x0000000185547AC0
	[BlackList] // 0x000000018967A8A0-0x000000018967A8E0
	// [XID] // 0x000000018967A8A0-0x000000018967A8E0
	public virtual void OnPoolAllocated() {} // 0x0000000185547980-0x0000000185547A20
	[BlackList] // 0x0000000189685120-0x0000000189685160
	// [XID] // 0x0000000189685120-0x0000000189685160
	public virtual void OnBeforePoolRecycled() {} // 0x00000001855478E0-0x0000000185547980
}

