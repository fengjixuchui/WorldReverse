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
public class ConfigClimate : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17655
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigClimateCommon _common; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigClimateInfoBase> _templates; // 0x18

	// Properties
	public ConfigClimateCommon common { /* [XID] */ /* 0x0000000189867030-0x0000000189867050 */ get => default; /* [XID] */ /* 0x000000018986E810-0x000000018986E830 */ private set {} } // 0x0000000181868080-0x0000000181868120 0x0000000181867380-0x0000000181867430
	public Dictionary<string, ConfigClimateInfoBase> templates { /* [XID] */ /* 0x0000000189875CC0-0x0000000189875CE0 */ get => default; /* [XID] */ /* 0x000000018987D880-0x000000018987D8A0 */ private set {} } // 0x0000000181866FE0-0x0000000181867080 0x0000000181866F30-0x0000000181866FE0

	// Constructors
	public ConfigClimate() {} // 0x00000001818681C0-0x0000000181868220

	// Methods
	// [XID] // 0x0000000189884770-0x0000000189884790
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181867E30-0x0000000181867F40
	// [XID] // 0x000000018988BDC0-0x000000018988BDE0
	public void InitEmpty() {} // 0x00000001818677B0-0x00000001818678A0
	[BlackList] // 0x0000000189893490-0x00000001898934D0
	// [XID] // 0x0000000189893490-0x00000001898934D0
	public bool FromJson(JSONNode node) => default; // 0x0000000181867430-0x00000001818677B0
	// [XID] // 0x000000018989D6A0-0x000000018989D6C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181866780-0x0000000181866A70
	// [XID] // 0x00000001898A50A0-0x00000001898A50C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF764F */, bool useObjectPool = false /* Metadata: 0x00AF7653 */) => default; // 0x00000001818678A0-0x0000000181867BA0
	// [XID] // 0x00000001898AC500-0x00000001898AC520
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7654 */, bool useObjectPool = false /* Metadata: 0x00AF7658 */) => default; // 0x0000000181867080-0x0000000181867380
	[BlackList] // 0x00000001898B3AA0-0x00000001898B3AE0
	// [XID] // 0x00000001898B3AA0-0x00000001898B3AE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181866A70-0x0000000181866D40
	// [XID] // 0x00000001898BE480-0x00000001898BE4A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181867BA0-0x0000000181867E30
	[BlackList] // 0x00000001898C5C90-0x00000001898C5CD0
	// [XID] // 0x00000001898C5C90-0x00000001898C5CD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181866D40-0x0000000181866DE0
	[BlackList] // 0x00000001898D0680-0x00000001898D06C0
	// [XID] // 0x00000001898D0680-0x00000001898D06C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181866DE0-0x0000000181866F30
	[BlackList] // 0x00000001898DAC60-0x00000001898DACA0
	// [XID] // 0x00000001898DAC60-0x00000001898DACA0
	public virtual void ReturnToObjectPool() {} // 0x0000000181868120-0x00000001818681C0
	[BlackList] // 0x00000001898E5B40-0x00000001898E5B80
	// [XID] // 0x00000001898E5B40-0x00000001898E5B80
	public virtual void OnPoolAllocated() {} // 0x0000000181867FE0-0x0000000181868080
	[BlackList] // 0x00000001898F0400-0x00000001898F0440
	// [XID] // 0x00000001898F0400-0x00000001898F0440
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181867F40-0x0000000181867FE0
}

