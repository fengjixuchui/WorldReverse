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
public class ConfigCutsceneContext : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17785
{
	// Fields
	private CutsceneIndexType _type; // 0x10
	private bool _enableForceStreaming; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigTimeline _cutsceneConfig; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigVideo _videoConfig; // 0x20

	// Properties
	public CutsceneIndexType type { /* [XID] */ /* 0x00000001899E04A0-0x00000001899E04C0 */ get => default; /* [XID] */ /* 0x00000001899E8000-0x00000001899E8020 */ private set {} } // 0x0000000182C21C00-0x0000000182C21CA0 0x0000000182C21470-0x0000000182C21520
	public bool enableForceStreaming { /* [XID] */ /* 0x00000001899EF4F0-0x00000001899EF510 */ get => default; /* [XID] */ /* 0x00000001899F6E10-0x00000001899F6E30 */ private set {} } // 0x0000000182C20650-0x0000000182C206F0 0x0000000182C21520-0x0000000182C215D0
	public ConfigTimeline cutsceneConfig { /* [XID] */ /* 0x00000001899FE670-0x00000001899FE690 */ get => default; /* [XID] */ /* 0x0000000189A05E90-0x0000000189A05EB0 */ private set {} } // 0x0000000182C20BB0-0x0000000182C20C50 0x0000000182C20B00-0x0000000182C20BB0
	public ConfigVideo videoConfig { /* [XID] */ /* 0x0000000189A0D1E0-0x0000000189A0D200 */ get => default; /* [XID] */ /* 0x0000000189A14A80-0x0000000189A14AA0 */ private set {} } // 0x0000000182C205B0-0x0000000182C20650 0x0000000182C213C0-0x0000000182C21470

	// Constructors
	public ConfigCutsceneContext() {} // 0x0000000182C21D40-0x0000000182C21DB0

	// Methods
	// [XID] // 0x0000000189A1BD10-0x0000000189A1BD30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C21960-0x0000000182C21AC0
	// [XID] // 0x0000000189A23500-0x0000000189A23520
	public void InitEmpty() {} // 0x0000000182C20FD0-0x0000000182C210C0
	[BlackList] // 0x0000000189A2A920-0x0000000189A2A960
	// [XID] // 0x0000000189A2A920-0x0000000189A2A960
	public bool FromJson(JSONNode node) => default; // 0x0000000182C20C50-0x0000000182C20FD0
	// [XID] // 0x0000000189A35090-0x0000000189A350B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C1FC00-0x0000000182C20090
	// [XID] // 0x0000000189A3C590-0x0000000189A3C5B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C15 */, bool useObjectPool = false /* Metadata: 0x00AF7C19 */) => default; // 0x0000000182C210C0-0x0000000182C213C0
	// [XID] // 0x0000000189A44090-0x0000000189A440B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C1A */, bool useObjectPool = false /* Metadata: 0x00AF7C1E */) => default; // 0x0000000182C206F0-0x0000000182C20B00
	[BlackList] // 0x0000000189A4B5E0-0x0000000189A4B620
	// [XID] // 0x0000000189A4B5E0-0x0000000189A4B620
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C20090-0x0000000182C20360
	// [XID] // 0x0000000189A55F00-0x0000000189A55F20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C215D0-0x0000000182C21960
	[BlackList] // 0x0000000189A5D900-0x0000000189A5D940
	// [XID] // 0x0000000189A5D900-0x0000000189A5D940
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C20360-0x0000000182C20400
	[BlackList] // 0x0000000189A68470-0x0000000189A684B0
	// [XID] // 0x0000000189A68470-0x0000000189A684B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C20400-0x0000000182C205B0
	[BlackList] // 0x0000000189A729E0-0x0000000189A72A20
	// [XID] // 0x0000000189A729E0-0x0000000189A72A20
	public virtual void ReturnToObjectPool() {} // 0x0000000182C21CA0-0x0000000182C21D40
	[BlackList] // 0x0000000189A7D330-0x0000000189A7D370
	// [XID] // 0x0000000189A7D330-0x0000000189A7D370
	public virtual void OnPoolAllocated() {} // 0x0000000182C21B60-0x0000000182C21C00
	[BlackList] // 0x0000000189A87C80-0x0000000189A87CC0
	// [XID] // 0x0000000189A87C80-0x0000000189A87CC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C21AC0-0x0000000182C21B60
}

