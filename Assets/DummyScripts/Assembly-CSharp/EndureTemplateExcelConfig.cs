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
public class EndureTemplateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15569
{
	// Fields
	protected EndureType _type; // 0x10
	protected SimpleSafeFloat gaugeLengthRawNum; // 0x14
	protected SimpleSafeFloat waneSpeedRawNum; // 0x18
	protected SimpleSafeFloat recoverTimeRawNum; // 0x1C
	protected SimpleSafeFloat enduranceRawNum; // 0x20

	// Properties
	public EndureType type { /* [XID] */ /* 0x00000001898E2D00-0x00000001898E2D20 */ get => default; /* [XID] */ /* 0x00000001898EAA30-0x00000001898EAA50 */ protected set {} } // 0x00000001828C2380-0x00000001828C2420 0x00000001828C1EF0-0x00000001828C1FA0
	public float gaugeLength { /* [XID] */ /* 0x0000000189A19940-0x0000000189A19960 */ get => default; /* [XID] */ /* 0x00000001898F9910-0x00000001898F9930 */ protected set {} } // 0x00000001828C17C0-0x00000001828C18A0 0x00000001828C18A0-0x00000001828C1980
	public float waneSpeed { /* [XID] */ /* 0x0000000189A433A0-0x0000000189A433C0 */ get => default; /* [XID] */ /* 0x0000000189908AB0-0x0000000189908AD0 */ protected set {} } // 0x00000001828C0BE0-0x00000001828C0CC0 0x00000001828C22A0-0x00000001828C2380
	public float recoverTime { /* [XID] */ /* 0x00000001899100B0-0x00000001899100D0 */ get => default; /* [XID] */ /* 0x0000000189917C40-0x0000000189917C60 */ protected set {} } // 0x00000001828C16E0-0x00000001828C17C0 0x00000001828C1FA0-0x00000001828C2080
	public float endurance { /* [XID] */ /* 0x000000018991F160-0x000000018991F180 */ get => default; /* [XID] */ /* 0x0000000189926BC0-0x0000000189926BE0 */ protected set {} } // 0x00000001828C0E70-0x00000001828C0F50 0x00000001828C2080-0x00000001828C2160

	// Constructors
	public EndureTemplateExcelConfig() {} // 0x00000001828C24C0-0x00000001828C2520

	// Methods
	// [IDTag] // 0x000000018992E390-0x000000018992E3D0
	// [XID] // 0x000000018992E390-0x000000018992E3D0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001828C1300-0x00000001828C16E0
	// [IDTag] // 0x0000000189938690-0x00000001899386D0
	// [XID] // 0x0000000189938690-0x00000001899386D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001828C0F50-0x00000001828C1300
	// [XID] // 0x0000000189942CF0-0x0000000189942D10
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1F5C */, bool useObjectPool = false /* Metadata: 0x00AF1F60 */) => default; // 0x00000001828C1980-0x00000001828C1EF0
	[BlackList] // 0x000000018994A560-0x000000018994A5A0
	// [XID] // 0x000000018994A560-0x000000018994A5A0
	public virtual void AutoAllocTypeFields() {} // 0x00000001828C0CC0-0x00000001828C0D60
	[BlackList] // 0x0000000189954C80-0x0000000189954CC0
	// [XID] // 0x0000000189954C80-0x0000000189954CC0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828C0D60-0x00000001828C0E70
	[BlackList] // 0x000000018995F730-0x000000018995F770
	// [XID] // 0x000000018995F730-0x000000018995F770
	public virtual void ReturnToObjectPool() {} // 0x00000001828C2420-0x00000001828C24C0
	[BlackList] // 0x0000000189969CC0-0x0000000189969D00
	// [XID] // 0x0000000189969CC0-0x0000000189969D00
	public virtual void OnPoolAllocated() {} // 0x00000001828C2200-0x00000001828C22A0
	[BlackList] // 0x0000000189974650-0x0000000189974690
	// [XID] // 0x0000000189974650-0x0000000189974690
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828C2160-0x00000001828C2200
}

