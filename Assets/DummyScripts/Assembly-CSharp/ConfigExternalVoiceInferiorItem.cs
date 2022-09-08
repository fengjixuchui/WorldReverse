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
public class ConfigExternalVoiceInferiorItem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18074
{
	// Fields
	private string _guid; // 0x10
	private bool _include; // 0x18

	// Properties
	public string guid { /* [XID] */ /* 0x00000001897576C0-0x00000001897576E0 */ get => default; /* [XID] */ /* 0x0000000189B7A370-0x0000000189B7A390 */ private set {} } // 0x000000018216E750-0x000000018216E7F0 0x000000018216EC70-0x000000018216ED20
	public bool include { /* [XID] */ /* 0x0000000189B81B50-0x0000000189B81B70 */ get => default; /* [XID] */ /* 0x0000000189B891F0-0x0000000189B89210 */ private set {} } // 0x000000018216D9E0-0x000000018216DA80 0x000000018216EBC0-0x000000018216EC70

	// Constructors
	public ConfigExternalVoiceInferiorItem() {} // 0x000000018216F250-0x000000018216F2B0

	// Methods
	// [XID] // 0x0000000189B907D0-0x0000000189B907F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018216EF60-0x000000018216F070
	// [XID] // 0x0000000189B97C80-0x0000000189B97CA0
	public void InitEmpty() {} // 0x000000018216E7F0-0x000000018216E8C0
	[BlackList] // 0x0000000189B9EFB0-0x0000000189B9EFF0
	// [XID] // 0x0000000189B9EFB0-0x0000000189B9EFF0
	public bool FromJson(JSONNode node) => default; // 0x000000018216E3D0-0x000000018216E750
	// [XID] // 0x0000000189801B10-0x0000000189801B30
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018216DA80-0x000000018216DD30
	// [XID] // 0x000000018978FFD0-0x000000018978FFF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A23 */, bool useObjectPool = false /* Metadata: 0x00AF8A27 */) => default; // 0x000000018216E8C0-0x000000018216EBC0
	// [XID] // 0x00000001897977A0-0x00000001897977C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A28 */, bool useObjectPool = false /* Metadata: 0x00AF8A2C */) => default; // 0x000000018216E140-0x000000018216E3D0
	[BlackList] // 0x0000000189BBF830-0x0000000189BBF870
	// [XID] // 0x0000000189BBF830-0x0000000189BBF870
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018216DD30-0x000000018216E000
	// [XID] // 0x0000000189BCA970-0x0000000189BCA990
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018216ED20-0x000000018216EF60
	[BlackList] // 0x0000000189BD1FA0-0x0000000189BD1FE0
	// [XID] // 0x0000000189BD1FA0-0x0000000189BD1FE0
	public virtual void AutoAllocTypeFields() {} // 0x000000018216E000-0x000000018216E0A0
	[BlackList] // 0x0000000189BDC820-0x0000000189BDC860
	// [XID] // 0x0000000189BDC820-0x0000000189BDC860
	public virtual void AutoRecycleTypeFields() {} // 0x000000018216E0A0-0x000000018216E140
	[BlackList] // 0x00000001895EC310-0x00000001895EC350
	// [XID] // 0x00000001895EC310-0x00000001895EC350
	public virtual void ReturnToObjectPool() {} // 0x000000018216F1B0-0x000000018216F250
	[BlackList] // 0x00000001895F6BC0-0x00000001895F6C00
	// [XID] // 0x00000001895F6BC0-0x00000001895F6C00
	public virtual void OnPoolAllocated() {} // 0x000000018216F110-0x000000018216F1B0
	[BlackList] // 0x00000001896010E0-0x0000000189601120
	// [XID] // 0x00000001896010E0-0x0000000189601120
	public virtual void OnBeforePoolRecycled() {} // 0x000000018216F070-0x000000018216F110
}

