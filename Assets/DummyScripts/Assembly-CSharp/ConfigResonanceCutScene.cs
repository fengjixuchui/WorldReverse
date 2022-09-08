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
public class ConfigResonanceCutScene : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18890
{
	// Fields
	private SimpleSafeUInt32 cutsceneIndexRawNum; // 0x10
	private string _vfxAbility; // 0x18

	// Properties
	public uint cutsceneIndex { /* [XID] */ /* 0x000000018960E800-0x000000018960E820 */ get => default; /* [XID] */ /* 0x0000000189615E80-0x0000000189615EA0 */ private set {} } // 0x0000000182F81800-0x0000000182F818D0 0x0000000182F82050-0x0000000182F82130
	public string vfxAbility { /* [XID] */ /* 0x000000018961D750-0x000000018961D770 */ get => default; /* [XID] */ /* 0x0000000189624BB0-0x0000000189624BD0 */ private set {} } // 0x0000000182F814A0-0x0000000182F81540 0x0000000182F82130-0x0000000182F821E0

	// Constructors
	public ConfigResonanceCutScene() {} // 0x0000000182F82740-0x0000000182F827A0

	// Methods
	// [XID] // 0x000000018962C370-0x000000018962C390
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182F82450-0x0000000182F82560
	// [XID] // 0x0000000189633EF0-0x0000000189633F10
	public void InitEmpty() {} // 0x0000000182F81C50-0x0000000182F81D50
	[BlackList] // 0x000000018963B680-0x000000018963B6C0
	// [XID] // 0x000000018963B680-0x000000018963B6C0
	public bool FromJson(JSONNode node) => default; // 0x0000000182F818D0-0x0000000182F81C50
	// [XID] // 0x0000000189645D40-0x0000000189645D60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182F80D50-0x0000000182F81050
	// [XID] // 0x000000018964D660-0x000000018964D680
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB297 */, bool useObjectPool = false /* Metadata: 0x00AFB29B */) => default; // 0x0000000182F81D50-0x0000000182F82050
	// [XID] // 0x0000000189654E80-0x0000000189654EA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB29C */, bool useObjectPool = false /* Metadata: 0x00AFB2A0 */) => default; // 0x0000000182F81540-0x0000000182F81800
	[BlackList] // 0x000000018965C5C0-0x000000018965C600
	// [XID] // 0x000000018965C5C0-0x000000018965C600
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182F81050-0x0000000182F81320
	// [XID] // 0x0000000189666CB0-0x0000000189666CD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182F821E0-0x0000000182F82450
	[BlackList] // 0x000000018966E380-0x000000018966E3C0
	// [XID] // 0x000000018966E380-0x000000018966E3C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182F81320-0x0000000182F813C0
	[BlackList] // 0x00000001896792D0-0x0000000189679310
	// [XID] // 0x00000001896792D0-0x0000000189679310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182F813C0-0x0000000182F814A0
	[BlackList] // 0x00000001896837B0-0x00000001896837F0
	// [XID] // 0x00000001896837B0-0x00000001896837F0
	public virtual void ReturnToObjectPool() {} // 0x0000000182F826A0-0x0000000182F82740
	[BlackList] // 0x000000018968E590-0x000000018968E5D0
	// [XID] // 0x000000018968E590-0x000000018968E5D0
	public virtual void OnPoolAllocated() {} // 0x0000000182F82600-0x0000000182F826A0
	[BlackList] // 0x0000000189698E00-0x0000000189698E40
	// [XID] // 0x0000000189698E00-0x0000000189698E40
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182F82560-0x0000000182F82600
}

