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
public class ConfigLevel1WorldArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18935
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWorldArea _level1Area; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWorldArea[] _level2Areas; // 0x18

	// Properties
	public ConfigWorldArea level1Area { /* [XID] */ /* 0x0000000189B61050-0x0000000189B61070 */ get => default; /* [XID] */ /* 0x0000000189B68740-0x0000000189B68760 */ private set {} } // 0x0000000183AF38F0-0x0000000183AF3990 0x0000000183AF3D80-0x0000000183AF3E30
	public ConfigWorldArea[] level2Areas { /* [XID] */ /* 0x0000000189B6FC20-0x0000000189B6FC40 */ get => default; /* [XID] */ /* 0x0000000189B77110-0x0000000189B77130 */ private set {} } // 0x0000000183AF34D0-0x0000000183AF3570 0x0000000183AF3120-0x0000000183AF31D0

	// Constructors
	public ConfigLevel1WorldArea() {} // 0x0000000183AF43B0-0x0000000183AF4410

	// Methods
	// [XID] // 0x0000000189B7E7E0-0x0000000189B7E800
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AF40C0-0x0000000183AF41D0
	// [XID] // 0x0000000189B86420-0x0000000189B86440
	public void InitEmpty() {} // 0x0000000183AF3990-0x0000000183AF3A80
	[BlackList] // 0x0000000189B8D450-0x0000000189B8D490
	// [XID] // 0x0000000189B8D450-0x0000000189B8D490
	public bool FromJson(JSONNode node) => default; // 0x0000000183AF3570-0x0000000183AF38F0
	// [XID] // 0x0000000189B97A40-0x0000000189B97A60
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AF2980-0x0000000183AF2C70
	// [XID] // 0x0000000189B9EE70-0x0000000189B9EE90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB42B */, bool useObjectPool = false /* Metadata: 0x00AFB42F */) => default; // 0x0000000183AF3A80-0x0000000183AF3D80
	// [XID] // 0x0000000189BA6740-0x0000000189BA6760
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB430 */, bool useObjectPool = false /* Metadata: 0x00AFB434 */) => default; // 0x0000000183AF31D0-0x0000000183AF34D0
	[BlackList] // 0x0000000189BAD9C0-0x0000000189BADA00
	// [XID] // 0x0000000189BAD9C0-0x0000000189BADA00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AF2C70-0x0000000183AF2F40
	// [XID] // 0x0000000189BB7F40-0x0000000189BB7F60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AF3E30-0x0000000183AF40C0
	[BlackList] // 0x0000000189BBF6B0-0x0000000189BBF6F0
	// [XID] // 0x0000000189BBF6B0-0x0000000189BBF6F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AF2F40-0x0000000183AF2FE0
	[BlackList] // 0x0000000189BCA7F0-0x0000000189BCA830
	// [XID] // 0x0000000189BCA7F0-0x0000000189BCA830
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AF2FE0-0x0000000183AF3120
	[BlackList] // 0x0000000189BD4C50-0x0000000189BD4C90
	// [XID] // 0x0000000189BD4C50-0x0000000189BD4C90
	public virtual void ReturnToObjectPool() {} // 0x0000000183AF4310-0x0000000183AF43B0
	[BlackList] // 0x0000000189BDF740-0x0000000189BDF780
	// [XID] // 0x0000000189BDF740-0x0000000189BDF780
	public virtual void OnPoolAllocated() {} // 0x0000000183AF4270-0x0000000183AF4310
	[BlackList] // 0x00000001895EF000-0x00000001895EF040
	// [XID] // 0x00000001895EF000-0x00000001895EF040
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AF41D0-0x0000000183AF4270
}

