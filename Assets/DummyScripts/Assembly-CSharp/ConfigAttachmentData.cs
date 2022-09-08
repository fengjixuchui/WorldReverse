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
public class ConfigAttachmentData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18039
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAttachment> _attachMap; // 0x10

	// Properties
	public Dictionary<string, ConfigAttachment> attachMap { /* [XID] */ /* 0x0000000189A0D160-0x0000000189A0D180 */ get => default; /* [XID] */ /* 0x0000000189A14A00-0x0000000189A14A20 */ private set {} } // 0x0000000183230DC0-0x0000000183230E60 0x0000000183230900-0x00000001832309B0

	// Constructors
	public ConfigAttachmentData() {} // 0x0000000183230F00-0x0000000183230F60

	// Methods
	// [XID] // 0x0000000189A1BCD0-0x0000000189A1BCF0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183230BA0-0x0000000183230C80
	// [XID] // 0x0000000189A234C0-0x0000000189A234E0
	public void InitEmpty() {} // 0x0000000183230530-0x0000000183230600
	[BlackList] // 0x0000000189A2A8C0-0x0000000189A2A900
	// [XID] // 0x0000000189A2A8C0-0x0000000189A2A900
	public bool FromJson(JSONNode node) => default; // 0x00000001832301B0-0x0000000183230530
	// [XID] // 0x0000000189A35030-0x0000000189A35050
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018322F990-0x000000018322FB70
	// [XID] // 0x0000000189A3C490-0x0000000189A3C4B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8783 */, bool useObjectPool = false /* Metadata: 0x00AF8787 */) => default; // 0x0000000183230600-0x0000000183230900
	// [XID] // 0x0000000189A44030-0x0000000189A44050
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8788 */, bool useObjectPool = false /* Metadata: 0x00AF878C */) => default; // 0x000000018322FFA0-0x00000001832301B0
	[BlackList] // 0x0000000189A4B5A0-0x0000000189A4B5E0
	// [XID] // 0x0000000189A4B5A0-0x0000000189A4B5E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018322FB70-0x000000018322FE40
	// [XID] // 0x0000000189A55E60-0x0000000189A55E80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832309B0-0x0000000183230BA0
	[BlackList] // 0x0000000189A5D7A0-0x0000000189A5D7E0
	// [XID] // 0x0000000189A5D7A0-0x0000000189A5D7E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018322FE40-0x000000018322FEE0
	[BlackList] // 0x0000000189A68370-0x0000000189A683B0
	// [XID] // 0x0000000189A68370-0x0000000189A683B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018322FEE0-0x000000018322FFA0
	[BlackList] // 0x0000000189A72960-0x0000000189A729A0
	// [XID] // 0x0000000189A72960-0x0000000189A729A0
	public virtual void ReturnToObjectPool() {} // 0x0000000183230E60-0x0000000183230F00
	[BlackList] // 0x0000000189A7D2B0-0x0000000189A7D2F0
	// [XID] // 0x0000000189A7D2B0-0x0000000189A7D2F0
	public virtual void OnPoolAllocated() {} // 0x0000000183230D20-0x0000000183230DC0
	[BlackList] // 0x0000000189A87C20-0x0000000189A87C60
	// [XID] // 0x0000000189A87C20-0x0000000189A87C60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183230C80-0x0000000183230D20
}

