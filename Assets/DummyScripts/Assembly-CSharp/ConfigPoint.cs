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
public class ConfigPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18512
{
	// Fields
	private SimpleSafeUInt32 pointIdRawNum; // 0x10
	private MoleMole.Config.Vector _position; // 0x14
	private MoleMole.Config.Vector _rotation; // 0x20
	private SimpleSafeFloat velocityRawNum; // 0x2C
	private SimpleSafeFloat timeRawNum; // 0x30
	private bool _isReachEvent; // 0x34
	private MoleMole.Config.Vector _rotAxis; // 0x38
	private SimpleSafeFloat rotSpeedRawNum; // 0x44
	private SimpleSafeFloat arriveRangeRawNum; // 0x48

	// Properties
	public uint pointId { /* [XID] */ /* 0x00000001897ABE40-0x00000001897ABE60 */ get => default; /* [XID] */ /* 0x00000001897B3DD0-0x00000001897B3DF0 */ private set {} } // 0x000000018389CDB0-0x000000018389CE80 0x000000018389DEF0-0x000000018389DFD0
	public MoleMole.Config.Vector position { /* [XID] */ /* 0x00000001897BBB70-0x00000001897BBB90 */ get => default; /* [XID] */ /* 0x00000001897C33B0-0x00000001897C33D0 */ private set {} } // 0x000000018389D9F0-0x000000018389DAD0 0x000000018389D620-0x000000018389D6F0
	public MoleMole.Config.Vector rotation { /* [XID] */ /* 0x00000001897CAB30-0x00000001897CAB50 */ get => default; /* [XID] */ /* 0x00000001897D2190-0x00000001897D21B0 */ private set {} } // 0x000000018389DD70-0x000000018389DE50 0x000000018389D200-0x000000018389D2D0
	public float velocity { /* [XID] */ /* 0x00000001897DA050-0x00000001897DA070 */ get => default; /* [XID] */ /* 0x00000001897E12E0-0x00000001897E1300 */ private set {} } // 0x000000018389DC90-0x000000018389DD70 0x000000018389D2D0-0x000000018389D3B0
	public float time { /* [XID] */ /* 0x00000001897E8B70-0x00000001897E8B90 */ get => default; /* [XID] */ /* 0x00000001897F07A0-0x00000001897F07C0 */ private set {} } // 0x000000018389EB20-0x000000018389EC00 0x000000018389E6E0-0x000000018389E7C0
	public bool isReachEvent { /* [XID] */ /* 0x00000001897F7EC0-0x00000001897F7EE0 */ get => default; /* [XID] */ /* 0x00000001897FF590-0x00000001897FF5B0 */ private set {} } // 0x000000018389DE50-0x000000018389DEF0 0x000000018389BEB0-0x000000018389BF60
	public MoleMole.Config.Vector rotAxis { /* [XID] */ /* 0x0000000189806CD0-0x0000000189806CF0 */ get => default; /* [XID] */ /* 0x000000018980E370-0x000000018980E390 */ private set {} } // 0x000000018389D540-0x000000018389D620 0x000000018389CCE0-0x000000018389CDB0
	public float rotSpeed { /* [XID] */ /* 0x0000000189815A70-0x0000000189815A90 */ get => default; /* [XID] */ /* 0x000000018981D4D0-0x000000018981D4F0 */ private set {} } // 0x000000018389DBB0-0x000000018389DC90 0x000000018389C530-0x000000018389C610
	public float arriveRange { /* [XID] */ /* 0x0000000189824940-0x0000000189824960 */ get => default; /* [XID] */ /* 0x000000018982C430-0x000000018982C450 */ private set {} } // 0x000000018389DAD0-0x000000018389DBB0 0x000000018389C450-0x000000018389C530

	// Constructors
	public ConfigPoint() {} // 0x000000018389ECA0-0x000000018389ED40

	// Methods
	// [XID] // 0x0000000189833900-0x0000000189833920
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018389E7C0-0x000000018389E9E0
	// [XID] // 0x000000018983AE80-0x000000018983AEA0
	public void InitEmpty() {} // 0x000000018389D3B0-0x000000018389D540
	[BlackList] // 0x0000000189842500-0x0000000189842540
	// [XID] // 0x0000000189842500-0x0000000189842540
	public bool FromJson(JSONNode node) => default; // 0x000000018389CE80-0x000000018389D200
	// [XID] // 0x000000018984C940-0x000000018984C960
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018389B520-0x000000018389BEB0
	// [XID] // 0x0000000189853A40-0x0000000189853A60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FED */, bool useObjectPool = false /* Metadata: 0x00AF9FF1 */) => default; // 0x000000018389D6F0-0x000000018389D9F0
	// [XID] // 0x000000018985B4D0-0x000000018985B4F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9FF2 */, bool useObjectPool = false /* Metadata: 0x00AF9FF6 */) => default; // 0x000000018389C610-0x000000018389CCE0
	[BlackList] // 0x0000000189862A30-0x0000000189862A70
	// [XID] // 0x0000000189862A30-0x0000000189862A70
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018389BF60-0x000000018389C230
	// [XID] // 0x000000018986CB70-0x000000018986CB90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018389DFD0-0x000000018389E6E0
	[BlackList] // 0x0000000189873FE0-0x0000000189874020
	// [XID] // 0x0000000189873FE0-0x0000000189874020
	public virtual void AutoAllocTypeFields() {} // 0x000000018389C230-0x000000018389C2D0
	[BlackList] // 0x000000018987EB60-0x000000018987EBA0
	// [XID] // 0x000000018987EB60-0x000000018987EBA0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018389C2D0-0x000000018389C450
	[BlackList] // 0x0000000189888E00-0x0000000189888E40
	// [XID] // 0x0000000189888E00-0x0000000189888E40
	public virtual void ReturnToObjectPool() {} // 0x000000018389EC00-0x000000018389ECA0
	[BlackList] // 0x00000001898932F0-0x0000000189893330
	// [XID] // 0x00000001898932F0-0x0000000189893330
	public virtual void OnPoolAllocated() {} // 0x000000018389EA80-0x000000018389EB20
	[BlackList] // 0x000000018989D4C0-0x000000018989D500
	// [XID] // 0x000000018989D4C0-0x000000018989D500
	public virtual void OnBeforePoolRecycled() {} // 0x000000018389E9E0-0x000000018389EA80
}

