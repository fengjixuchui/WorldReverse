/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityReusedCache // TypeDefIndex: 20815
{
	// Fields
	public const int DEFAULT_CACHE_ENTITY_COUNT = 30; // Metadata: 0x00AFE47A
	public const long MAX_CACHE_TIME = 120000; // Metadata: 0x00AFE47E
	private static float _z; // 0x00
	public static Transform CACHE_ROOT; // 0x08
	private Dictionary<uint, Queue<BaseEntity>> _reuseEntitiesDic; // 0x10
	private HashList<uint> _configIdLRUList; // 0x18
	private Dictionary<uint, long> _timeCache; // 0x20
	private int _capacity; // 0x28
	public const float ConfigIDReusePoolEntityPositionTag = -1000000f; // Metadata: 0x00AFE486

	// Properties
	public static float PRE_Z { /* [XID] */ /* 0x000000018979E130-0x000000018979E150 */ get => default; } // 0x0000000183731780-0x0000000183731840 

	// Constructors
	public EntityReusedCache() {} // Dummy constructor
	public EntityReusedCache(int capcity = 30 /* Metadata: 0x00AFE476 */) {} // 0x0000000183731840-0x0000000183731900

	// Methods
	// [XID] // 0x000000018977C820-0x000000018977C840
	public BaseEntity GetReusedEntityByConfigId(uint configId) => default; // 0x0000000183730460-0x0000000183730900
	// [XID] // 0x00000001896F5730-0x00000001896F5750
	private int getCacheEntityCount() => default; // 0x0000000183730900-0x0000000183730AE0
	// [XID] // 0x00000001896FCF90-0x00000001896FCFB0
	private int getCacheConfigIDCount() => default; // 0x000000018372EEA0-0x000000018372EF60
	// [XID] // 0x00000001897043E0-0x0000000189704400
	public void SetReusedEntityToCache(BaseEntity entity) {} // 0x000000018372FCC0-0x0000000183730460
	// [XID] // 0x0000000189B3C130-0x0000000189B3C150
	private void CheckConfigId() {} // 0x0000000183730C00-0x0000000183731780
	// [XID] // 0x00000001897134E0-0x0000000189713500
	public static bool DestroyEntity(BaseEntity entity, SliceFrameWatch watch) => default; // 0x0000000183730AE0-0x0000000183730C00
	// [XID] // 0x000000018971AD40-0x000000018971AD60
	public void Clear() {} // 0x000000018372F590-0x000000018372F8B0
	// [XID] // 0x0000000189722040-0x0000000189722060
	public void Destroy() {} // 0x000000018372EF60-0x000000018372F2A0
	// [XID] // 0x0000000189729770-0x0000000189729790
	public void Tick(SliceFrameWatch watch) {} // 0x000000018372F2A0-0x000000018372F590
	// [XID] // 0x0000000189730FA0-0x0000000189730FC0
	public string Dump() => default; // 0x000000018372F8B0-0x000000018372FCC0
}

