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
public class AnimatorParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18868
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AnimatorFloat[] _floats; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AnimatorInt[] _ints; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AnimatorBool[] _bools; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AnimatorTrigger[] _triggers; // 0x28

	// Properties
	public AnimatorFloat[] floats { /* [XID] */ /* 0x0000000189606EA0-0x0000000189606EC0 */ get => default; /* [XID] */ /* 0x000000018960E820-0x000000018960E840 */ private set {} } // 0x00000001822BDB10-0x00000001822BDBB0 0x00000001822BC450-0x00000001822BC500
	public AnimatorInt[] ints { /* [XID] */ /* 0x0000000189615EA0-0x0000000189615EC0 */ get => default; /* [XID] */ /* 0x000000018961D7B0-0x000000018961D7D0 */ private set {} } // 0x00000001822BDA70-0x00000001822BDB10 0x00000001822BD330-0x00000001822BD3E0
	public AnimatorBool[] bools { /* [XID] */ /* 0x0000000189624BD0-0x0000000189624BF0 */ get => default; /* [XID] */ /* 0x000000018962C390-0x000000018962C3B0 */ private set {} } // 0x00000001822BCDD0-0x00000001822BCE70 0x00000001822BD280-0x00000001822BD330
	public AnimatorTrigger[] triggers { /* [XID] */ /* 0x0000000189633F10-0x0000000189633F30 */ get => default; /* [XID] */ /* 0x000000018963B6C0-0x000000018963B6E0 */ private set {} } // 0x00000001822BC900-0x00000001822BC9A0 0x00000001822BCD20-0x00000001822BCDD0

	// Constructors
	public AnimatorParameters() {} // 0x00000001822BDC50-0x00000001822BDCB0

	// Methods
	// [XID] // 0x0000000189642F00-0x0000000189642F20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822BD7F0-0x00000001822BD930
	// [XID] // 0x000000018964A5A0-0x000000018964A5C0
	public void InitEmpty() {} // 0x00000001822BCE70-0x00000001822BCF80
	[BlackList] // 0x0000000189651DC0-0x0000000189651E00
	// [XID] // 0x0000000189651DC0-0x0000000189651E00
	public bool FromJson(JSONNode node) => default; // 0x00000001822BC9A0-0x00000001822BCD20
	// [XID] // 0x000000018965C620-0x000000018965C640
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001822BBB80-0x00000001822BC010
	// [XID] // 0x0000000189663C20-0x0000000189663C40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1AD */, bool useObjectPool = false /* Metadata: 0x00AFB1B1 */) => default; // 0x00000001822BCF80-0x00000001822BD280
	// [XID] // 0x000000018966B420-0x000000018966B440
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB1B2 */, bool useObjectPool = false /* Metadata: 0x00AFB1B6 */) => default; // 0x00000001822BC500-0x00000001822BC900
	[BlackList] // 0x0000000189673120-0x0000000189673160
	// [XID] // 0x0000000189673120-0x0000000189673160
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001822BC010-0x00000001822BC2E0
	// [XID] // 0x000000018967D9E0-0x000000018967DA00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822BD3E0-0x00000001822BD7F0
	[BlackList] // 0x0000000189684FC0-0x0000000189685000
	// [XID] // 0x0000000189684FC0-0x0000000189685000
	public virtual void AutoAllocTypeFields() {} // 0x00000001822BC2E0-0x00000001822BC380
	[BlackList] // 0x000000018968FE60-0x000000018968FEA0
	// [XID] // 0x000000018968FE60-0x000000018968FEA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822BC380-0x00000001822BC450
	[BlackList] // 0x000000018969A330-0x000000018969A370
	// [XID] // 0x000000018969A330-0x000000018969A370
	public virtual void ReturnToObjectPool() {} // 0x00000001822BDBB0-0x00000001822BDC50
	[BlackList] // 0x00000001896A4740-0x00000001896A4780
	// [XID] // 0x00000001896A4740-0x00000001896A4780
	public virtual void OnPoolAllocated() {} // 0x00000001822BD9D0-0x00000001822BDA70
	[BlackList] // 0x00000001896AEC70-0x00000001896AECB0
	// [XID] // 0x00000001896AEC70-0x00000001896AECB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822BD930-0x00000001822BD9D0
}

