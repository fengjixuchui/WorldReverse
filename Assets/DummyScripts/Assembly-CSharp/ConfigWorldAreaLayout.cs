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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigWorldAreaLayout : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14972
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigLevel1WorldArea[] _level1Areas; // 0x10

	// Properties
	public ConfigLevel1WorldArea[] level1Areas { /* [XID] */ /* 0x0000000189965770-0x0000000189965790 */ get => default; /* [XID] */ /* 0x000000018996CEF0-0x000000018996CF10 */ private set {} } // 0x00000001845596A0-0x0000000184559740 0x0000000184558C30-0x0000000184558CE0

	// Constructors
	public ConfigWorldAreaLayout() {} // 0x00000001845597E0-0x0000000184559840

	// Methods
	// [XID] // 0x0000000189938830-0x0000000189938850
	public ConfigWorldArea FindLevel1Area(Vector3 worldPosition) => default; // 0x00000001845588A0-0x0000000184558A20
	// [XID] // 0x0000000189940100-0x0000000189940120
	public ConfigWorldArea FindLevel2Area(Vector3 worldPosition) => default; // 0x0000000184557B00-0x0000000184557D20
	// [XID] // 0x00000001899476A0-0x00000001899476C0
	public int GetLevel1AreaGreyLevel(Vector3 worldPosition) => default; // 0x00000001845587B0-0x00000001845588A0
	// [XID] // 0x000000018994EEC0-0x000000018994EEE0
	public int GetLevel2AreaGreyLevel(Vector3 worldPosition) => default; // 0x0000000184558340-0x0000000184558430
	// [XID] // 0x0000000189956520-0x0000000189956540
	public string GetLocationName(Vector3 location) => default; // 0x0000000184558FE0-0x0000000184559290
	// [XID] // 0x000000018995DEF0-0x000000018995DF10
	public CityConfig GetCityConfigByPosition(Vector3 location) => default; // 0x0000000184558A20-0x0000000184558B60
	// [XID] // 0x0000000189974750-0x0000000189974770
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184559480-0x0000000184559560
	// [XID] // 0x000000018997BD20-0x000000018997BD40
	public void InitEmpty() {} // 0x0000000184558B60-0x0000000184558C30
	[BlackList] // 0x00000001899838D0-0x0000000189983910
	// [XID] // 0x00000001899838D0-0x0000000189983910
	public bool FromJson(JSONNode node) => default; // 0x0000000184558430-0x00000001845587B0
	// [XID] // 0x000000018998E140-0x000000018998E160
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184557920-0x0000000184557B00
	// [XID] // 0x0000000189995BB0-0x0000000189995BD0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCCE */, bool useObjectPool = false /* Metadata: 0x00AEFCD2 */) => default; // 0x0000000184558CE0-0x0000000184558FE0
	// [XID] // 0x000000018999D630-0x000000018999D650
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCD3 */, bool useObjectPool = false /* Metadata: 0x00AEFCD7 */) => default; // 0x0000000184558130-0x0000000184558340
	[BlackList] // 0x00000001899A4EF0-0x00000001899A4F30
	// [XID] // 0x00000001899A4EF0-0x00000001899A4F30
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184557D20-0x0000000184557FF0
	// [XID] // 0x00000001899AF8D0-0x00000001899AF8F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184559290-0x0000000184559480
	[BlackList] // 0x00000001899B6D30-0x00000001899B6D70
	// [XID] // 0x00000001899B6D30-0x00000001899B6D70
	public virtual void AutoAllocTypeFields() {} // 0x0000000184557FF0-0x0000000184558090
	[BlackList] // 0x00000001899C1850-0x00000001899C1890
	// [XID] // 0x00000001899C1850-0x00000001899C1890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184558090-0x0000000184558130
	[BlackList] // 0x00000001899CC0C0-0x00000001899CC100
	// [XID] // 0x00000001899CC0C0-0x00000001899CC100
	public virtual void ReturnToObjectPool() {} // 0x0000000184559740-0x00000001845597E0
	[BlackList] // 0x00000001899D6510-0x00000001899D6550
	// [XID] // 0x00000001899D6510-0x00000001899D6550
	public virtual void OnPoolAllocated() {} // 0x0000000184559600-0x00000001845596A0
	[BlackList] // 0x00000001899E0AC0-0x00000001899E0B00
	// [XID] // 0x00000001899E0AC0-0x00000001899E0B00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184559560-0x0000000184559600
}

