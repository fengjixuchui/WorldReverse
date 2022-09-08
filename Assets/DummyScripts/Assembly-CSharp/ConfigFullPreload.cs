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
public class ConfigFullPreload : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18806
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPlatformPreloadMapping _platformPreloadMapping; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigPreload _commonPreload; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<SimpleSafeUInt32, ConfigPreload> _entitiesPreload; // 0x20

	// Properties
	public ConfigPlatformPreloadMapping platformPreloadMapping { /* [XID] */ /* 0x00000001898172C0-0x00000001898172E0 */ get => default; /* [XID] */ /* 0x000000018981EBA0-0x000000018981EBC0 */ private set {} } // 0x0000000182C39D70-0x0000000182C39E10 0x0000000182C39680-0x0000000182C39730
	public ConfigPreload commonPreload { /* [XID] */ /* 0x00000001898260D0-0x00000001898260F0 */ get => default; /* [XID] */ /* 0x000000018982D6C0-0x000000018982D6E0 */ private set {} } // 0x0000000182C382A0-0x0000000182C38340 0x0000000182C394D0-0x0000000182C39580
	public Dictionary<SimpleSafeUInt32, ConfigPreload> entitiesPreload { /* [XID] */ /* 0x0000000189834E50-0x0000000189834E70 */ get => default; /* [XID] */ /* 0x000000018983C610-0x000000018983C630 */ private set {} } // 0x0000000182C390B0-0x0000000182C39150 0x0000000182C38C40-0x0000000182C38CF0

	// Constructors
	public ConfigFullPreload() {} // 0x0000000182C3A130-0x0000000182C3A190

	// Methods
	// [XID] // 0x0000000189843C80-0x0000000189843CA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C39E10-0x0000000182C39F50
	// [XID] // 0x000000018984B130-0x000000018984B150
	public void InitEmpty() {} // 0x0000000182C39580-0x0000000182C39680
	[BlackList] // 0x00000001898523C0-0x0000000189852400
	// [XID] // 0x00000001898523C0-0x0000000189852400
	public bool FromJson(JSONNode node) => default; // 0x0000000182C39150-0x0000000182C394D0
	// [XID] // 0x000000018985C930-0x000000018985C950
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C38340-0x0000000182C38710
	// [XID] // 0x00000001898641F0-0x0000000189864210
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD4D */, bool useObjectPool = false /* Metadata: 0x00AFAD51 */) => default; // 0x0000000182C39730-0x0000000182C39A30
	// [XID] // 0x000000018986B6A0-0x000000018986B6C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD52 */, bool useObjectPool = false /* Metadata: 0x00AFAD56 */) => default; // 0x0000000182C38CF0-0x0000000182C390B0
	[BlackList] // 0x00000001898729F0-0x0000000189872A30
	// [XID] // 0x00000001898729F0-0x0000000189872A30
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C38710-0x0000000182C389E0
	// [XID] // 0x000000018987D640-0x000000018987D660
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C39A30-0x0000000182C39D70
	[BlackList] // 0x00000001898844B0-0x00000001898844F0
	// [XID] // 0x00000001898844B0-0x00000001898844F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C389E0-0x0000000182C38A80
	[BlackList] // 0x000000018988E980-0x000000018988E9C0
	// [XID] // 0x000000018988E980-0x000000018988E9C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C38A80-0x0000000182C38C40
	[BlackList] // 0x00000001898991B0-0x00000001898991F0
	// [XID] // 0x00000001898991B0-0x00000001898991F0
	public virtual void ReturnToObjectPool() {} // 0x0000000182C3A090-0x0000000182C3A130
	[BlackList] // 0x00000001898A3480-0x00000001898A34C0
	// [XID] // 0x00000001898A3480-0x00000001898A34C0
	public virtual void OnPoolAllocated() {} // 0x0000000182C39FF0-0x0000000182C3A090
	[BlackList] // 0x00000001898ADD50-0x00000001898ADD90
	// [XID] // 0x00000001898ADD50-0x00000001898ADD90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C39F50-0x0000000182C39FF0
}

