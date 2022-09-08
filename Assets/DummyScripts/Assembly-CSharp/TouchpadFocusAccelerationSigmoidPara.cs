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
public class TouchpadFocusAccelerationSigmoidPara : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19106
{
	// Fields
	private SimpleSafeFloat phaseRawNum; // 0x10
	private SimpleSafeFloat slopeRawNum; // 0x14
	private SimpleSafeFloat amplitudeRawNum; // 0x18
	private SimpleSafeFloat clipRawNum; // 0x1C

	// Properties
	public float phase { /* [XID] */ /* 0x0000000189659FD0-0x0000000189659FF0 */ get => default; /* [XID] */ /* 0x000000018983AD40-0x000000018983AD60 */ private set {} } // 0x0000000184B39000-0x0000000184B390E0 0x0000000184B38F20-0x0000000184B39000
	public float slope { /* [XID] */ /* 0x00000001898423C0-0x00000001898423E0 */ get => default; /* [XID] */ /* 0x0000000189849810-0x0000000189849830 */ private set {} } // 0x0000000184B394E0-0x0000000184B395C0 0x0000000184B39F00-0x0000000184B39FE0
	public float amplitude { /* [XID] */ /* 0x0000000189850FF0-0x0000000189851010 */ get => default; /* [XID] */ /* 0x00000001898584C0-0x00000001898584E0 */ private set {} } // 0x0000000184B39A40-0x0000000184B39B20 0x0000000184B39E20-0x0000000184B39F00
	public float clip { /* [XID] */ /* 0x000000018985F4F0-0x000000018985F510 */ get => default; /* [XID] */ /* 0x0000000189866D70-0x0000000189866D90 */ private set {} } // 0x0000000184B38E40-0x0000000184B38F20 0x0000000184B39FE0-0x0000000184B3A0C0

	// Constructors
	public TouchpadFocusAccelerationSigmoidPara() {} // 0x0000000184B3A740-0x0000000184B3A7A0

	// Methods
	// [XID] // 0x000000018986E5B0-0x000000018986E5D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B3A420-0x0000000184B3A560
	// [XID] // 0x00000001898759A0-0x00000001898759C0
	public void InitEmpty() {} // 0x0000000184B39940-0x0000000184B39A40
	[BlackList] // 0x000000018987D600-0x000000018987D640
	// [XID] // 0x000000018987D600-0x000000018987D640
	public bool FromJson(JSONNode node) => default; // 0x0000000184B395C0-0x0000000184B39940
	// [XID] // 0x00000001898875E0-0x0000000189887600
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B38420-0x0000000184B389C0
	// [XID] // 0x000000018988E8E0-0x000000018988E900
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1F7 */, bool useObjectPool = false /* Metadata: 0x00AFC1FB */) => default; // 0x0000000184B39B20-0x0000000184B39E20
	// [XID] // 0x000000018965A0D0-0x000000018965A0F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC1FC */, bool useObjectPool = false /* Metadata: 0x00AFC200 */) => default; // 0x0000000184B390E0-0x0000000184B394E0
	[BlackList] // 0x000000018989D3C0-0x000000018989D400
	// [XID] // 0x000000018989D3C0-0x000000018989D400
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B389C0-0x0000000184B38C90
	// [XID] // 0x00000001898A7A50-0x00000001898A7A70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B3A0C0-0x0000000184B3A420
	[BlackList] // 0x00000001898AF5B0-0x00000001898AF5F0
	// [XID] // 0x00000001898AF5B0-0x00000001898AF5F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B38C90-0x0000000184B38D30
	[BlackList] // 0x00000001898B9FC0-0x00000001898BA000
	// [XID] // 0x00000001898B9FC0-0x00000001898BA000
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B38D30-0x0000000184B38E40
	[BlackList] // 0x00000001898C43E0-0x00000001898C4420
	// [XID] // 0x00000001898C43E0-0x00000001898C4420
	public virtual void ReturnToObjectPool() {} // 0x0000000184B3A6A0-0x0000000184B3A740
	[BlackList] // 0x00000001898CE9B0-0x00000001898CE9F0
	// [XID] // 0x00000001898CE9B0-0x00000001898CE9F0
	public virtual void OnPoolAllocated() {} // 0x0000000184B3A600-0x0000000184B3A6A0
	[BlackList] // 0x00000001898D9410-0x00000001898D9450
	// [XID] // 0x00000001898D9410-0x00000001898D9450
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B3A560-0x0000000184B3A600
}

