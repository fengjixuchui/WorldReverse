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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class RoomWeatherExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16280
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 roomIDRawNum; // 0x14
	protected SimpleSafeUInt32 areaIDRawNum; // 0x18
	protected string _profileName; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189703450-0x0000000189703470 */ get => default; /* [XID] */ /* 0x000000018970AB20-0x000000018970AB40 */ protected set {} } // 0x00000001829965B0-0x0000000182996680 0x0000000182995EE0-0x0000000182995FC0
	public uint roomID { /* [XID] */ /* 0x0000000189712510-0x0000000189712530 */ get => default; /* [XID] */ /* 0x0000000189719C90-0x0000000189719CB0 */ protected set {} } // 0x0000000182995480-0x0000000182995550 0x0000000182995D30-0x0000000182995E10
	public uint areaID { /* [XID] */ /* 0x0000000189721270-0x0000000189721290 */ get => default; /* [XID] */ /* 0x00000001897288B0-0x00000001897288D0 */ protected set {} } // 0x0000000182995E10-0x0000000182995EE0 0x0000000182995C50-0x0000000182995D30
	public string profileName { /* [XID] */ /* 0x0000000189730040-0x0000000189730060 */ get => default; /* [XID] */ /* 0x0000000189737900-0x0000000189737920 */ protected set {} } // 0x0000000182995550-0x00000001829955F0 0x0000000182996680-0x0000000182996730

	// Constructors
	public RoomWeatherExcelConfig() {} // 0x00000001829967D0-0x0000000182996830

	// Methods
	// [IDTag] // 0x000000018973F400-0x000000018973F440
	// [XID] // 0x000000018973F400-0x000000018973F440
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182995900-0x0000000182995C50
	// [IDTag] // 0x0000000189749920-0x0000000189749960
	// [XID] // 0x0000000189749920-0x0000000189749960
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001829955F0-0x0000000182995900
	// [XID] // 0x0000000189753D60-0x0000000189753D80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF364E */, bool useObjectPool = false /* Metadata: 0x00AF3652 */) => default; // 0x0000000182995FC0-0x0000000182996470
	[BlackList] // 0x000000018975B200-0x000000018975B240
	// [XID] // 0x000000018975B200-0x000000018975B240
	public virtual void AutoAllocTypeFields() {} // 0x00000001829952E0-0x0000000182995380
	[BlackList] // 0x0000000189765A70-0x0000000189765AB0
	// [XID] // 0x0000000189765A70-0x0000000189765AB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182995380-0x0000000182995480
	[BlackList] // 0x0000000189770190-0x00000001897701D0
	// [XID] // 0x0000000189770190-0x00000001897701D0
	public virtual void ReturnToObjectPool() {} // 0x0000000182996730-0x00000001829967D0
	[BlackList] // 0x000000018977A7E0-0x000000018977A820
	// [XID] // 0x000000018977A7E0-0x000000018977A820
	public virtual void OnPoolAllocated() {} // 0x0000000182996510-0x00000001829965B0
	[BlackList] // 0x0000000189785200-0x0000000189785240
	// [XID] // 0x0000000189785200-0x0000000189785240
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182996470-0x0000000182996510
}

