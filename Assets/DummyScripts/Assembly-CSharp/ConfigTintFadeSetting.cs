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
public class ConfigTintFadeSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18178
{
	// Fields
	private SimpleSafeFloat tintDistanceRawNum; // 0x10
	private SimpleSafeInt32 tintSizeRawNum; // 0x14

	// Properties
	public float tintDistance { /* [XID] */ /* 0x000000018969A430-0x000000018969A450 */ get => default; /* [XID] */ /* 0x00000001896A1D00-0x00000001896A1D20 */ private set {} } // 0x0000000181C1ECF0-0x0000000181C1EDD0 0x0000000181C1F040-0x0000000181C1F120
	public int tintSize { /* [XID] */ /* 0x00000001896A9120-0x00000001896A9140 */ get => default; /* [XID] */ /* 0x00000001896B02D0-0x00000001896B02F0 */ private set {} } // 0x0000000181C1E250-0x0000000181C1E320 0x0000000181C1D9F0-0x0000000181C1DAD0

	// Constructors
	public ConfigTintFadeSetting() {} // 0x0000000181C1F410-0x0000000181C1F4E0

	// Methods
	// [XID] // 0x00000001896B7B90-0x00000001896B7BB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C1F120-0x0000000181C1F230
	// [XID] // 0x00000001896BEB50-0x00000001896BEB70
	public void InitEmpty() {} // 0x0000000181C1E8F0-0x0000000181C1E9F0
	[BlackList] // 0x00000001896C6570-0x00000001896C65B0
	// [XID] // 0x00000001896C6570-0x00000001896C65B0
	public bool FromJson(JSONNode node) => default; // 0x0000000181C1E570-0x0000000181C1E8F0
	// [XID] // 0x00000001896D0AE0-0x00000001896D0B00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C1DAD0-0x0000000181C1DDE0
	// [XID] // 0x00000001896D7FF0-0x00000001896D8010
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E07 */, bool useObjectPool = false /* Metadata: 0x00AF8E0B */) => default; // 0x0000000181C1E9F0-0x0000000181C1ECF0
	// [XID] // 0x0000000189A4F250-0x0000000189A4F270
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8E0C */, bool useObjectPool = false /* Metadata: 0x00AF8E10 */) => default; // 0x0000000181C1E320-0x0000000181C1E570
	[BlackList] // 0x00000001896E6C60-0x00000001896E6CA0
	// [XID] // 0x00000001896E6C60-0x00000001896E6CA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C1DDE0-0x0000000181C1E0B0
	// [XID] // 0x00000001896F0EA0-0x00000001896F0EC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C1EDD0-0x0000000181C1F040
	[BlackList] // 0x00000001896F86E0-0x00000001896F8720
	// [XID] // 0x00000001896F86E0-0x00000001896F8720
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C1E0B0-0x0000000181C1E150
	[BlackList] // 0x00000001897030B0-0x00000001897030F0
	// [XID] // 0x00000001897030B0-0x00000001897030F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C1E150-0x0000000181C1E250
	[BlackList] // 0x000000018970D7D0-0x000000018970D810
	// [XID] // 0x000000018970D7D0-0x000000018970D810
	public virtual void ReturnToObjectPool() {} // 0x0000000181C1F370-0x0000000181C1F410
	[BlackList] // 0x0000000189717D50-0x0000000189717D90
	// [XID] // 0x0000000189717D50-0x0000000189717D90
	public virtual void OnPoolAllocated() {} // 0x0000000181C1F2D0-0x0000000181C1F370
	[BlackList] // 0x0000000189722460-0x00000001897224A0
	// [XID] // 0x0000000189722460-0x00000001897224A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C1F230-0x0000000181C1F2D0
}

