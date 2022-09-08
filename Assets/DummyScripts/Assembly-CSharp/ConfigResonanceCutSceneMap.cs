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
public class ConfigResonanceCutSceneMap : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18891
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<ElementType, ConfigResonanceCutScene> _cutsceneMap; // 0x10

	// Properties
	public Dictionary<ElementType, ConfigResonanceCutScene> cutsceneMap { /* [XID] */ /* 0x00000001896B1610-0x00000001896B1630 */ get => default; /* [XID] */ /* 0x00000001896B90B0-0x00000001896B90D0 */ private set {} } // 0x00000001836C0EB0-0x00000001836C0F50 0x00000001836C1020-0x00000001836C10D0

	// Constructors
	public ConfigResonanceCutSceneMap() {} // 0x00000001836C1880-0x00000001836C18E0

	// Methods
	// [XID] // 0x00000001896C0480-0x00000001896C04A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001836C15C0-0x00000001836C16A0
	// [XID] // 0x00000001896C7C10-0x00000001896C7C30
	public void InitEmpty() {} // 0x00000001836C0F50-0x00000001836C1020
	[BlackList] // 0x00000001896CF5B0-0x00000001896CF5F0
	// [XID] // 0x00000001896CF5B0-0x00000001896CF5F0
	public bool FromJson(JSONNode node) => default; // 0x00000001836C0B30-0x00000001836C0EB0
	// [XID] // 0x00000001896D9810-0x00000001896D9830
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001836C0310-0x00000001836C04F0
	// [XID] // 0x00000001896E0F30-0x00000001896E0F50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB2A1 */, bool useObjectPool = false /* Metadata: 0x00AFB2A5 */) => default; // 0x00000001836C10D0-0x00000001836C13D0
	// [XID] // 0x00000001896E81A0-0x00000001896E81C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB2A6 */, bool useObjectPool = false /* Metadata: 0x00AFB2AA */) => default; // 0x00000001836C0920-0x00000001836C0B30
	[BlackList] // 0x00000001896EF860-0x00000001896EF8A0
	// [XID] // 0x00000001896EF860-0x00000001896EF8A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001836C04F0-0x00000001836C07C0
	// [XID] // 0x00000001896F9FB0-0x00000001896F9FD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001836C13D0-0x00000001836C15C0
	[BlackList] // 0x0000000189701700-0x0000000189701740
	// [XID] // 0x0000000189701700-0x0000000189701740
	public virtual void AutoAllocTypeFields() {} // 0x00000001836C07C0-0x00000001836C0860
	[BlackList] // 0x000000018970BE30-0x000000018970BE70
	// [XID] // 0x000000018970BE30-0x000000018970BE70
	public virtual void AutoRecycleTypeFields() {} // 0x00000001836C0860-0x00000001836C0920
	[BlackList] // 0x00000001897164E0-0x0000000189716520
	// [XID] // 0x00000001897164E0-0x0000000189716520
	public virtual void ReturnToObjectPool() {} // 0x00000001836C17E0-0x00000001836C1880
	[BlackList] // 0x0000000189720D10-0x0000000189720D50
	// [XID] // 0x0000000189720D10-0x0000000189720D50
	public virtual void OnPoolAllocated() {} // 0x00000001836C1740-0x00000001836C17E0
	[BlackList] // 0x000000018972B170-0x000000018972B1B0
	// [XID] // 0x000000018972B170-0x000000018972B1B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001836C16A0-0x00000001836C1740
}

