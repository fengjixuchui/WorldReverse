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
public class ConfigWeatherArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18940
{
	// Fields
	private SimpleSafeUInt32 area_idRawNum; // 0x10
	private Point2D[] _points; // 0x18

	// Properties
	public uint area_id { /* [XID] */ /* 0x0000000189869DC0-0x0000000189869DE0 */ get => default; /* [XID] */ /* 0x0000000189871170-0x0000000189871190 */ private set {} } // 0x0000000182C14280-0x0000000182C14350 0x0000000182C13DB0-0x0000000182C13E90
	public Point2D[] points { /* [XID] */ /* 0x0000000189878AD0-0x0000000189878AF0 */ get => default; /* [XID] */ /* 0x00000001898800C0-0x00000001898800E0 */ private set {} } // 0x0000000182C13E90-0x0000000182C13F30 0x0000000182C141D0-0x0000000182C14280

	// Constructors
	public ConfigWeatherArea() {} // 0x0000000182C14640-0x0000000182C146A0

	// Methods
	// [XID] // 0x0000000189887620-0x0000000189887640
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C14350-0x0000000182C14460
	// [XID] // 0x000000018988E920-0x000000018988E940
	public void InitEmpty() {} // 0x0000000182C139B0-0x0000000182C13AB0
	[BlackList] // 0x0000000189895DA0-0x0000000189895DE0
	// [XID] // 0x0000000189895DA0-0x0000000189895DE0
	public bool FromJson(JSONNode node) => default; // 0x0000000182C13630-0x0000000182C139B0
	// [XID] // 0x00000001898A0330-0x00000001898A0350
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C12C10-0x0000000182C12F10
	// [XID] // 0x00000001898A7A90-0x00000001898A7AB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB459 */, bool useObjectPool = false /* Metadata: 0x00AFB45D */) => default; // 0x0000000182C13AB0-0x0000000182C13DB0
	// [XID] // 0x00000001898AF650-0x00000001898AF670
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB45E */, bool useObjectPool = false /* Metadata: 0x00AFB462 */) => default; // 0x0000000182C13360-0x0000000182C13630
	[BlackList] // 0x00000001898B6A30-0x00000001898B6A70
	// [XID] // 0x00000001898B6A30-0x00000001898B6A70
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C12F10-0x0000000182C131E0
	// [XID] // 0x00000001898C12E0-0x00000001898C1300
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C13F30-0x0000000182C141D0
	[BlackList] // 0x00000001898C8C00-0x00000001898C8C40
	// [XID] // 0x00000001898C8C00-0x00000001898C8C40
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C131E0-0x0000000182C13280
	[BlackList] // 0x00000001898D3190-0x00000001898D31D0
	// [XID] // 0x00000001898D3190-0x00000001898D31D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C13280-0x0000000182C13360
	[BlackList] // 0x00000001898DE020-0x00000001898DE060
	// [XID] // 0x00000001898DE020-0x00000001898DE060
	public virtual void ReturnToObjectPool() {} // 0x0000000182C145A0-0x0000000182C14640
	[BlackList] // 0x00000001898E8AE0-0x00000001898E8B20
	// [XID] // 0x00000001898E8AE0-0x00000001898E8B20
	public virtual void OnPoolAllocated() {} // 0x0000000182C14500-0x0000000182C145A0
	[BlackList] // 0x00000001898F3220-0x00000001898F3260
	// [XID] // 0x00000001898F3220-0x00000001898F3260
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C14460-0x0000000182C14500
}

