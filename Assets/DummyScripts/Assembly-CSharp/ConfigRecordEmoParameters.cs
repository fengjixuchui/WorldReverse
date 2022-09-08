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
public class ConfigRecordEmoParameters : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18879
{
	// Fields
	private MoleMole.Config.Vector[] _eyeInfo; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRecordEmoFunc[] _emoFuncs; // 0x18

	// Properties
	public MoleMole.Config.Vector[] eyeInfo { /* [XID] */ /* 0x00000001896370E0-0x0000000189637100 */ get => default; /* [XID] */ /* 0x000000018963E620-0x000000018963E640 */ private set {} } // 0x00000001842F3F50-0x00000001842F3FF0 0x00000001842F4B80-0x00000001842F4C30
	public ConfigRecordEmoFunc[] emoFuncs { /* [XID] */ /* 0x0000000189645D60-0x0000000189645D80 */ get => default; /* [XID] */ /* 0x000000018964D680-0x000000018964D6A0 */ private set {} } // 0x00000001842F3FF0-0x00000001842F4090 0x00000001842F46E0-0x00000001842F4790

	// Constructors
	public ConfigRecordEmoParameters() {} // 0x00000001842F51C0-0x00000001842F5220

	// Methods
	// [XID] // 0x0000000189654EA0-0x0000000189654EC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842F4ED0-0x00000001842F4FE0
	// [XID] // 0x000000018965C600-0x000000018965C620
	public void InitEmpty() {} // 0x00000001842F4790-0x00000001842F4880
	[BlackList] // 0x0000000189663BE0-0x0000000189663C20
	// [XID] // 0x0000000189663BE0-0x0000000189663C20
	public bool FromJson(JSONNode node) => default; // 0x00000001842F4360-0x00000001842F46E0
	// [XID] // 0x000000018966E3C0-0x000000018966E3E0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001842F3860-0x00000001842F3B30
	// [XID] // 0x0000000189676100-0x0000000189676120
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB237 */, bool useObjectPool = false /* Metadata: 0x00AFB23B */) => default; // 0x00000001842F4880-0x00000001842F4B80
	// [XID] // 0x000000018967D9C0-0x000000018967D9E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB23C */, bool useObjectPool = false /* Metadata: 0x00AFB240 */) => default; // 0x00000001842F4090-0x00000001842F4360
	[BlackList] // 0x0000000189684F80-0x0000000189684FC0
	// [XID] // 0x0000000189684F80-0x0000000189684FC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001842F3B30-0x00000001842F3E00
	// [XID] // 0x000000018968FE40-0x000000018968FE60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842F4C30-0x00000001842F4ED0
	[BlackList] // 0x00000001896977C0-0x0000000189697800
	// [XID] // 0x00000001896977C0-0x0000000189697800
	public virtual void AutoAllocTypeFields() {} // 0x00000001842F3E00-0x00000001842F3EA0
	[BlackList] // 0x00000001896A1BC0-0x00000001896A1C00
	// [XID] // 0x00000001896A1BC0-0x00000001896A1C00
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842F3EA0-0x00000001842F3F50
	[BlackList] // 0x00000001896ABED0-0x00000001896ABF10
	// [XID] // 0x00000001896ABED0-0x00000001896ABF10
	public virtual void ReturnToObjectPool() {} // 0x00000001842F5120-0x00000001842F51C0
	[BlackList] // 0x00000001896B63A0-0x00000001896B63E0
	// [XID] // 0x00000001896B63A0-0x00000001896B63E0
	public virtual void OnPoolAllocated() {} // 0x00000001842F5080-0x00000001842F5120
	[BlackList] // 0x00000001896C04A0-0x00000001896C04E0
	// [XID] // 0x00000001896C04A0-0x00000001896C04E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842F4FE0-0x00000001842F5080
}

