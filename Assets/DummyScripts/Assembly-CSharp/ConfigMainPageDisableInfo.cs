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
public class ConfigMainPageDisableInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19110
{
	// Fields
	private MainPageUIDisableType[] _uiDisableList; // 0x10
	private InputEventType[] _enabledInputEventList; // 0x18

	// Properties
	public MainPageUIDisableType[] uiDisableList { /* [XID] */ /* 0x0000000189A7E790-0x0000000189A7E7B0 */ get => default; /* [XID] */ /* 0x0000000189A86050-0x0000000189A86070 */ private set {} } // 0x0000000181C58800-0x0000000181C588A0 0x0000000181C590B0-0x0000000181C59160
	public InputEventType[] enabledInputEventList { /* [XID] */ /* 0x0000000189A8D9B0-0x0000000189A8D9D0 */ get => default; /* [XID] */ /* 0x0000000189A94EF0-0x0000000189A94F10 */ private set {} } // 0x0000000181C588A0-0x0000000181C58940 0x0000000181C59400-0x0000000181C594B0

	// Constructors
	public ConfigMainPageDisableInfo() {} // 0x0000000181C597A0-0x0000000181C59800

	// Methods
	// [XID] // 0x0000000189A9C830-0x0000000189A9C850
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C594B0-0x0000000181C595C0
	// [XID] // 0x0000000189AA3F80-0x0000000189AA3FA0
	public void InitEmpty() {} // 0x0000000181C58CC0-0x0000000181C58DB0
	[BlackList] // 0x0000000189AAB470-0x0000000189AAB4B0
	// [XID] // 0x0000000189AAB470-0x0000000189AAB4B0
	public bool FromJson(JSONNode node) => default; // 0x0000000181C58940-0x0000000181C58CC0
	// [XID] // 0x0000000189AB5E60-0x0000000189AB5E80
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C57E50-0x0000000181C58120
	// [XID] // 0x0000000189ABD950-0x0000000189ABD970
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC23B */, bool useObjectPool = false /* Metadata: 0x00AFC23F */) => default; // 0x0000000181C58DB0-0x0000000181C590B0
	// [XID] // 0x0000000189AC5470-0x0000000189AC5490
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC240 */, bool useObjectPool = false /* Metadata: 0x00AFC244 */) => default; // 0x0000000181C58530-0x0000000181C58800
	[BlackList] // 0x0000000189ACC860-0x0000000189ACC8A0
	// [XID] // 0x0000000189ACC860-0x0000000189ACC8A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C58120-0x0000000181C583F0
	// [XID] // 0x0000000189AD7660-0x0000000189AD7680
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C59160-0x0000000181C59400
	[BlackList] // 0x0000000189ADF0F0-0x0000000189ADF130
	// [XID] // 0x0000000189ADF0F0-0x0000000189ADF130
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C583F0-0x0000000181C58490
	[BlackList] // 0x0000000189AE9730-0x0000000189AE9770
	// [XID] // 0x0000000189AE9730-0x0000000189AE9770
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C58490-0x0000000181C58530
	[BlackList] // 0x0000000189AF42F0-0x0000000189AF4330
	// [XID] // 0x0000000189AF42F0-0x0000000189AF4330
	public virtual void ReturnToObjectPool() {} // 0x0000000181C59700-0x0000000181C597A0
	[BlackList] // 0x0000000189AFE8F0-0x0000000189AFE930
	// [XID] // 0x0000000189AFE8F0-0x0000000189AFE930
	public virtual void OnPoolAllocated() {} // 0x0000000181C59660-0x0000000181C59700
	[BlackList] // 0x0000000189B08EB0-0x0000000189B08EF0
	// [XID] // 0x0000000189B08EB0-0x0000000189B08EF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C595C0-0x0000000181C59660
}

