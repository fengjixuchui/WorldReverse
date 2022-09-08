/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigWidget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19160
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigBaseWidget> _widgets; // 0x10

	// Properties
	public Dictionary<string, ConfigBaseWidget> widgets { /* [XID] */ /* 0x0000000189633E70-0x0000000189633E90 */ get => default; /* [XID] */ /* 0x000000018963B600-0x000000018963B620 */ private set {} } // 0x000000018449AA50-0x000000018449AAF0 0x000000018449A5D0-0x000000018449A680

	// Constructors
	public ConfigWidget() {} // 0x000000018449AFA0-0x000000018449B000

	// Methods
	// [XID] // 0x0000000189642E60-0x0000000189642E80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018449ACE0-0x000000018449ADC0
	// [XID] // 0x000000018964A540-0x000000018964A560
	public void InitEmpty() {} // 0x000000018449A680-0x000000018449A750
	[BlackList] // 0x0000000189651D20-0x0000000189651D60
	// [XID] // 0x0000000189651D20-0x0000000189651D60
	public bool FromJson(JSONNode node) => default; // 0x000000018449A250-0x000000018449A5D0
	// [XID] // 0x000000018965C560-0x000000018965C580
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184499A30-0x0000000184499C10
	// [XID] // 0x0000000189663B60-0x0000000189663B80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3CD */, bool useObjectPool = false /* Metadata: 0x00AFC3D1 */) => default; // 0x000000018449A750-0x000000018449AA50
	// [XID] // 0x000000018966B3C0-0x000000018966B3E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC3D2 */, bool useObjectPool = false /* Metadata: 0x00AFC3D6 */) => default; // 0x000000018449A040-0x000000018449A250
	[BlackList] // 0x0000000189673060-0x00000001896730A0
	// [XID] // 0x0000000189673060-0x00000001896730A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184499C10-0x0000000184499EE0
	// [XID] // 0x000000018967D920-0x000000018967D940
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018449AAF0-0x000000018449ACE0
	[BlackList] // 0x0000000189684EE0-0x0000000189684F20
	// [XID] // 0x0000000189684EE0-0x0000000189684F20
	public virtual void AutoAllocTypeFields() {} // 0x0000000184499EE0-0x0000000184499F80
	[BlackList] // 0x000000018968FD60-0x000000018968FDA0
	// [XID] // 0x000000018968FD60-0x000000018968FDA0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184499F80-0x000000018449A040
	[BlackList] // 0x000000018969A2B0-0x000000018969A2F0
	// [XID] // 0x000000018969A2B0-0x000000018969A2F0
	public virtual void ReturnToObjectPool() {} // 0x000000018449AF00-0x000000018449AFA0
	[BlackList] // 0x00000001896A4660-0x00000001896A46A0
	// [XID] // 0x00000001896A4660-0x00000001896A46A0
	public virtual void OnPoolAllocated() {} // 0x000000018449AE60-0x000000018449AF00
	[BlackList] // 0x00000001896AEBD0-0x00000001896AEC10
	// [XID] // 0x00000001896AEBD0-0x00000001896AEC10
	public virtual void OnBeforePoolRecycled() {} // 0x000000018449ADC0-0x000000018449AE60
}

