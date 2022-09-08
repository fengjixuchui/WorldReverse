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
public class AnimatorRecordTransitionInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18867
{
	// Fields
	private SimpleSafeFloat transitionDurationRawNum; // 0x10
	private SimpleSafeFloat normalizedTransitionTimeRawNum; // 0x14
	private SimpleSafeUInt32 durationUnitRawNum; // 0x18

	// Properties
	public float transitionDuration { /* [XID] */ /* 0x0000000189B39EB0-0x0000000189B39ED0 */ get => default; /* [XID] */ /* 0x0000000189B417F0-0x0000000189B41810 */ private set {} } // 0x0000000183374310-0x00000001833743F0 0x0000000183373CD0-0x0000000183373DB0
	public float normalizedTransitionTime { /* [XID] */ /* 0x0000000189B49180-0x0000000189B491A0 */ get => default; /* [XID] */ /* 0x0000000189B507E0-0x0000000189B50800 */ private set {} } // 0x00000001833738F0-0x00000001833739D0 0x0000000183373640-0x0000000183373720
	public uint durationUnit { /* [XID] */ /* 0x0000000189B580C0-0x0000000189B580E0 */ get => default; /* [XID] */ /* 0x0000000189B5FA20-0x0000000189B5FA40 */ private set {} } // 0x0000000183373820-0x00000001833738F0 0x0000000183372E90-0x0000000183372F70

	// Constructors
	public AnimatorRecordTransitionInfo() {} // 0x0000000183374490-0x00000001833744F0

	// Methods
	// [XID] // 0x0000000189B67160-0x0000000189B67180
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833740B0-0x00000001833741D0
	// [XID] // 0x0000000189B6E3C0-0x0000000189B6E3E0
	public void InitEmpty() {} // 0x0000000183373720-0x0000000183373820
	[BlackList] // 0x0000000189B75B90-0x0000000189B75BD0
	// [XID] // 0x0000000189B75B90-0x0000000189B75BD0
	public bool FromJson(JSONNode node) => default; // 0x00000001833732C0-0x0000000183373640
	// [XID] // 0x0000000189B80050-0x0000000189B80070
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001833725A0-0x0000000183372A10
	// [XID] // 0x0000000189B87B40-0x0000000189B87B60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1A3 */, bool useObjectPool = false /* Metadata: 0x00AFB1A7 */) => default; // 0x00000001833739D0-0x0000000183373CD0
	// [XID] // 0x0000000189B8ED30-0x0000000189B8ED50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1A8 */, bool useObjectPool = false /* Metadata: 0x00AFB1AC */) => default; // 0x0000000183372F70-0x00000001833732C0
	[BlackList] // 0x0000000189B96140-0x0000000189B96180
	// [XID] // 0x0000000189B96140-0x0000000189B96180
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183372A10-0x0000000183372CE0
	// [XID] // 0x0000000189BA0670-0x0000000189BA0690
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183373DB0-0x00000001833740B0
	[BlackList] // 0x0000000189BA7E70-0x0000000189BA7EB0
	// [XID] // 0x0000000189BA7E70-0x0000000189BA7EB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183372CE0-0x0000000183372D80
	[BlackList] // 0x0000000189BB2330-0x0000000189BB2370
	// [XID] // 0x0000000189BB2330-0x0000000189BB2370
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183372D80-0x0000000183372E90
	[BlackList] // 0x0000000189BBC890-0x0000000189BBC8D0
	// [XID] // 0x0000000189BBC890-0x0000000189BBC8D0
	public virtual void ReturnToObjectPool() {} // 0x00000001833743F0-0x0000000183374490
	[BlackList] // 0x0000000189BC72C0-0x0000000189BC7300
	// [XID] // 0x0000000189BC72C0-0x0000000189BC7300
	public virtual void OnPoolAllocated() {} // 0x0000000183374270-0x0000000183374310
	[BlackList] // 0x0000000189BD1DE0-0x0000000189BD1E20
	// [XID] // 0x0000000189BD1DE0-0x0000000189BD1E20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001833741D0-0x0000000183374270
}

