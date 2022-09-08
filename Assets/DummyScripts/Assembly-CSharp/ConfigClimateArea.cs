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
public class ConfigClimateArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17656
{
	// Fields
	private SimpleSafeUInt32 area_idRawNum; // 0x10
	private JsonClimateType _climateType; // 0x14
	private SimpleSafeFloat bottomRawNum; // 0x18
	private SimpleSafeFloat topRawNum; // 0x1C
	private Point2D[] _points; // 0x20

	// Properties
	public uint area_id { /* [XID] */ /* 0x0000000189902660-0x0000000189902680 */ get => default; /* [XID] */ /* 0x0000000189909C40-0x0000000189909C60 */ private set {} } // 0x000000018490FFD0-0x00000001849100A0 0x000000018490F880-0x000000018490F960
	public JsonClimateType climateType { /* [XID] */ /* 0x0000000189911480-0x00000001899114A0 */ get => default; /* [XID] */ /* 0x0000000189919060-0x0000000189919080 */ private set {} } // 0x000000018490F210-0x000000018490F2B0 0x000000018490F2B0-0x000000018490F360
	public float bottom { /* [XID] */ /* 0x00000001899205F0-0x0000000189920610 */ get => default; /* [XID] */ /* 0x0000000189927F50-0x0000000189927F70 */ private set {} } // 0x000000018490ECD0-0x000000018490EDB0 0x000000018490EDB0-0x000000018490EE90
	public float top { /* [XID] */ /* 0x000000018992F5C0-0x000000018992F5E0 */ get => default; /* [XID] */ /* 0x0000000189936A50-0x0000000189936A70 */ private set {} } // 0x000000018490FA00-0x000000018490FAE0 0x000000018490F7A0-0x000000018490F880
	public Point2D[] points { /* [XID] */ /* 0x000000018993E570-0x000000018993E590 */ get => default; /* [XID] */ /* 0x0000000189945BE0-0x0000000189945C00 */ private set {} } // 0x000000018490F960-0x000000018490FA00 0x000000018490FF20-0x000000018490FFD0

	// Constructors
	public ConfigClimateArea() {} // 0x00000001849103E0-0x0000000184910440

	// Methods
	// [XID] // 0x000000018994D0B0-0x000000018994D0D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849100A0-0x0000000184910200
	// [XID] // 0x0000000189954800-0x0000000189954820
	public void InitEmpty() {} // 0x000000018490F360-0x000000018490F4A0
	[BlackList] // 0x000000018995C0A0-0x000000018995C0E0
	// [XID] // 0x000000018995C0A0-0x000000018995C0E0
	public bool FromJson(JSONNode node) => default; // 0x000000018490EE90-0x000000018490F210
	// [XID] // 0x0000000189966B10-0x0000000189966B30
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018490DD80-0x000000018490E3C0
	// [XID] // 0x000000018996DF00-0x000000018996DF20
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7659 */, bool useObjectPool = false /* Metadata: 0x00AF765D */) => default; // 0x000000018490F4A0-0x000000018490F7A0
	// [XID] // 0x0000000189975AD0-0x0000000189975AF0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF765E */, bool useObjectPool = false /* Metadata: 0x00AF7662 */) => default; // 0x000000018490E850-0x000000018490ECD0
	[BlackList] // 0x000000018997CA90-0x000000018997CAD0
	// [XID] // 0x000000018997CA90-0x000000018997CAD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018490E3C0-0x000000018490E690
	// [XID] // 0x00000001899878B0-0x00000001899878D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018490FAE0-0x000000018490FF20
	[BlackList] // 0x000000018998F4E0-0x000000018998F520
	// [XID] // 0x000000018998F4E0-0x000000018998F520
	public virtual void AutoAllocTypeFields() {} // 0x000000018490E690-0x000000018490E730
	[BlackList] // 0x000000018999A330-0x000000018999A370
	// [XID] // 0x000000018999A330-0x000000018999A370
	public virtual void AutoRecycleTypeFields() {} // 0x000000018490E730-0x000000018490E850
	[BlackList] // 0x00000001899A4AD0-0x00000001899A4B10
	// [XID] // 0x00000001899A4AD0-0x00000001899A4B10
	public virtual void ReturnToObjectPool() {} // 0x0000000184910340-0x00000001849103E0
	[BlackList] // 0x00000001899AF430-0x00000001899AF470
	// [XID] // 0x00000001899AF430-0x00000001899AF470
	public virtual void OnPoolAllocated() {} // 0x00000001849102A0-0x0000000184910340
	[BlackList] // 0x00000001899B9810-0x00000001899B9850
	// [XID] // 0x00000001899B9810-0x00000001899B9850
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184910200-0x00000001849102A0
}

