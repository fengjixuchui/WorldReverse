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
public class ConfigElementDecrate : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18118
{
	// Fields
	private ElementType _elem1; // 0x10
	private ElementType _elem2; // 0x14
	private SimpleSafeFloat ratioRawNum; // 0x18

	// Properties
	public ElementType elem1 { /* [XID] */ /* 0x0000000189B23D80-0x0000000189B23DA0 */ get => default; /* [XID] */ /* 0x0000000189B2B080-0x0000000189B2B0A0 */ private set {} } // 0x0000000182D93DF0-0x0000000182D93E90 0x0000000182D93190-0x0000000182D93240
	public ElementType elem2 { /* [XID] */ /* 0x0000000189B326E0-0x0000000189B32700 */ get => default; /* [XID] */ /* 0x0000000189B39FB0-0x0000000189B39FD0 */ private set {} } // 0x0000000182D943B0-0x0000000182D94450 0x0000000182D93A40-0x0000000182D93AF0
	public float ratio { /* [XID] */ /* 0x0000000189B41910-0x0000000189B41930 */ get => default; /* [XID] */ /* 0x0000000189B49380-0x0000000189B493A0 */ private set {} } // 0x0000000182D930B0-0x0000000182D93190 0x0000000182D93890-0x0000000182D93970

	// Constructors
	public ConfigElementDecrate() {} // 0x0000000182D944F0-0x0000000182D94590

	// Methods
	// [XID] // 0x0000000189B50940-0x0000000189B50960
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D94150-0x0000000182D94270
	// [XID] // 0x0000000189B58260-0x0000000189B58280
	public void InitEmpty() {} // 0x0000000182D93970-0x0000000182D93A40
	[BlackList] // 0x0000000189B5FB20-0x0000000189B5FB60
	// [XID] // 0x0000000189B5FB20-0x0000000189B5FB60
	public bool FromJson(JSONNode node) => default; // 0x0000000182D93510-0x0000000182D93890
	// [XID] // 0x0000000189B6A0F0-0x0000000189B6A110
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D928A0-0x0000000182D92C70
	// [XID] // 0x0000000189B717F0-0x0000000189B71810
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BB3 */, bool useObjectPool = false /* Metadata: 0x00AF8BB7 */) => default; // 0x0000000182D93AF0-0x0000000182D93DF0
	// [XID] // 0x0000000189B78CC0-0x0000000189B78CE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BB8 */, bool useObjectPool = false /* Metadata: 0x00AF8BBC */) => default; // 0x0000000182D93240-0x0000000182D93510
	[BlackList] // 0x0000000189B80110-0x0000000189B80150
	// [XID] // 0x0000000189B80110-0x0000000189B80150
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D92C70-0x0000000182D92F40
	// [XID] // 0x0000000189B8A890-0x0000000189B8A8B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D93E90-0x0000000182D94150
	[BlackList] // 0x0000000189B91E20-0x0000000189B91E60
	// [XID] // 0x0000000189B91E20-0x0000000189B91E60
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D92F40-0x0000000182D92FE0
	[BlackList] // 0x0000000189B9C380-0x0000000189B9C3C0
	// [XID] // 0x0000000189B9C380-0x0000000189B9C3C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D92FE0-0x0000000182D930B0
	[BlackList] // 0x0000000189BA68A0-0x0000000189BA68E0
	// [XID] // 0x0000000189BA68A0-0x0000000189BA68E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D94450-0x0000000182D944F0
	[BlackList] // 0x0000000189BB0F50-0x0000000189BB0F90
	// [XID] // 0x0000000189BB0F50-0x0000000189BB0F90
	public virtual void OnPoolAllocated() {} // 0x0000000182D94310-0x0000000182D943B0
	[BlackList] // 0x0000000189BBB230-0x0000000189BBB270
	// [XID] // 0x0000000189BBB230-0x0000000189BBB270
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D94270-0x0000000182D94310
}

