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
public class ConfigDynamicAbilityPreload : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17916
{
	// Fields
	private string[] _preloadEffect; // 0x10
	private string[] _preloadGadget; // 0x18
	private string[] _preloadCamera; // 0x20
	private string[] _preloadSkillIcon; // 0x28

	// Properties
	public string[] preloadEffect { /* [XID] */ /* 0x0000000189751560-0x0000000189751580 */ get => default; /* [XID] */ /* 0x0000000189714CB0-0x0000000189714CD0 */ private set {} } // 0x000000018487C570-0x000000018487C610 0x000000018487CE30-0x000000018487CEE0
	public string[] preloadGadget { /* [XID] */ /* 0x00000001897C7250-0x00000001897C7270 */ get => default; /* [XID] */ /* 0x0000000189723B90-0x0000000189723BB0 */ private set {} } // 0x000000018487CA10-0x000000018487CAB0 0x000000018487C4C0-0x000000018487C570
	public string[] preloadCamera { /* [XID] */ /* 0x00000001897CE770-0x00000001897CE790 */ get => default; /* [XID] */ /* 0x0000000189732AC0-0x0000000189732AE0 */ private set {} } // 0x000000018487DB80-0x000000018487DC20 0x000000018487D2F0-0x000000018487D3A0
	public string[] preloadSkillIcon { /* [XID] */ /* 0x000000018973A1D0-0x000000018973A1F0 */ get => default; /* [XID] */ /* 0x0000000189741D20-0x0000000189741D40 */ private set {} } // 0x000000018487DAE0-0x000000018487DB80 0x000000018487D3A0-0x000000018487D450

	// Constructors
	public ConfigDynamicAbilityPreload() {} // 0x000000018487DCC0-0x000000018487E000

	// Methods
	// [XID] // 0x0000000189749700-0x0000000189749720
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018487D860-0x000000018487D9A0
	// [XID] // 0x0000000189750BC0-0x0000000189750BE0
	public void InitEmpty() {} // 0x000000018487CEE0-0x000000018487CFF0
	[BlackList] // 0x0000000189757F70-0x0000000189757FB0
	// [XID] // 0x0000000189757F70-0x0000000189757FB0
	public bool FromJson(JSONNode node) => default; // 0x000000018487CAB0-0x000000018487CE30
	// [XID] // 0x00000001897629F0-0x0000000189762A10
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018487BC10-0x000000018487C0A0
	// [XID] // 0x0000000189769FF0-0x000000018976A010
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81E1 */, bool useObjectPool = false /* Metadata: 0x00AF81E5 */) => default; // 0x000000018487CFF0-0x000000018487D2F0
	// [XID] // 0x0000000189771850-0x0000000189771870
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF81E6 */, bool useObjectPool = false /* Metadata: 0x00AF81EA */) => default; // 0x000000018487C610-0x000000018487CA10
	[BlackList] // 0x0000000189778F60-0x0000000189778FA0
	// [XID] // 0x0000000189778F60-0x0000000189778FA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018487C0A0-0x000000018487C370
	// [XID] // 0x0000000189783710-0x0000000189783730
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018487D450-0x000000018487D860
	[BlackList] // 0x000000018978ADC0-0x000000018978AE00
	// [XID] // 0x000000018978ADC0-0x000000018978AE00
	public virtual void AutoAllocTypeFields() {} // 0x000000018487C370-0x000000018487C410
	[BlackList] // 0x00000001897952C0-0x0000000189795300
	// [XID] // 0x00000001897952C0-0x0000000189795300
	public virtual void AutoRecycleTypeFields() {} // 0x000000018487C410-0x000000018487C4C0
	[BlackList] // 0x00000001897A02B0-0x00000001897A02F0
	// [XID] // 0x00000001897A02B0-0x00000001897A02F0
	public virtual void ReturnToObjectPool() {} // 0x000000018487DC20-0x000000018487DCC0
	[BlackList] // 0x00000001897AA6A0-0x00000001897AA6E0
	// [XID] // 0x00000001897AA6A0-0x00000001897AA6E0
	public virtual void OnPoolAllocated() {} // 0x000000018487DA40-0x000000018487DAE0
	[BlackList] // 0x00000001897B58D0-0x00000001897B5910
	// [XID] // 0x00000001897B58D0-0x00000001897B5910
	public virtual void OnBeforePoolRecycled() {} // 0x000000018487D9A0-0x000000018487DA40
}

