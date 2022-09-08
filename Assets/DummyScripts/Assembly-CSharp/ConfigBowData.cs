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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigBowData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18069
{
	// Fields
	private string _bowRatioName; // 0x10
	private MoleMole.Config.Vector _bowStringLoosePoint; // 0x18
	private SimpleSafeFloat bowStringMaxLenRawNum; // 0x24

	// Properties
	public string bowRatioName { /* [XID] */ /* 0x00000001898FAA20-0x00000001898FAA40 */ get => default; /* [XID] */ /* 0x00000001899025A0-0x00000001899025C0 */ private set {} } // 0x000000018247B580-0x000000018247B620 0x000000018247BC70-0x000000018247BD20
	public MoleMole.Config.Vector bowStringLoosePoint { /* [XID] */ /* 0x0000000189909B60-0x0000000189909B80 */ get => default; /* [XID] */ /* 0x0000000189911340-0x0000000189911360 */ private set {} } // 0x000000018247B9A0-0x000000018247BA80 0x000000018247C420-0x000000018247C4F0
	public float bowStringMaxLen { /* [XID] */ /* 0x0000000189918EE0-0x0000000189918F00 */ get => default; /* [XID] */ /* 0x0000000189920550-0x0000000189920570 */ private set {} } // 0x000000018247BA80-0x000000018247BB60 0x000000018247C020-0x000000018247C100

	// Constructors
	public ConfigBowData() {} // 0x000000018247C820-0x000000018247C880

	// Methods
	// [XID] // 0x0000000189927E70-0x0000000189927E90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018247C4F0-0x000000018247C640
	// [XID] // 0x000000018992F520-0x000000018992F540
	public void InitEmpty() {} // 0x000000018247BB60-0x000000018247BC70
	[BlackList] // 0x0000000189936930-0x0000000189936970
	// [XID] // 0x0000000189936930-0x0000000189936970
	public bool FromJson(JSONNode node) => default; // 0x000000018247B620-0x000000018247B9A0
	// [XID] // 0x0000000189941060-0x0000000189941080
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018247A9E0-0x000000018247ADE0
	// [XID] // 0x0000000189948B20-0x0000000189948B40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89E5 */, bool useObjectPool = false /* Metadata: 0x00AF89E9 */) => default; // 0x000000018247BD20-0x000000018247C020
	// [XID] // 0x00000001899502F0-0x0000000189950310
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF89EA */, bool useObjectPool = false /* Metadata: 0x00AF89EE */) => default; // 0x000000018247B230-0x000000018247B580
	[BlackList] // 0x00000001899578A0-0x00000001899578E0
	// [XID] // 0x00000001899578A0-0x00000001899578E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018247ADE0-0x000000018247B0B0
	// [XID] // 0x0000000189962450-0x0000000189962470
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018247C100-0x000000018247C420
	[BlackList] // 0x00000001899698A0-0x00000001899698E0
	// [XID] // 0x00000001899698A0-0x00000001899698E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018247B0B0-0x000000018247B150
	[BlackList] // 0x00000001899741F0-0x0000000189974230
	// [XID] // 0x00000001899741F0-0x0000000189974230
	public virtual void AutoRecycleTypeFields() {} // 0x000000018247B150-0x000000018247B230
	[BlackList] // 0x000000018997E4A0-0x000000018997E4E0
	// [XID] // 0x000000018997E4A0-0x000000018997E4E0
	public virtual void ReturnToObjectPool() {} // 0x000000018247C780-0x000000018247C820
	[BlackList] // 0x0000000189989420-0x0000000189989460
	// [XID] // 0x0000000189989420-0x0000000189989460
	public virtual void OnPoolAllocated() {} // 0x000000018247C6E0-0x000000018247C780
	[BlackList] // 0x0000000189993F70-0x0000000189993FB0
	// [XID] // 0x0000000189993F70-0x0000000189993FB0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018247C640-0x000000018247C6E0
}

