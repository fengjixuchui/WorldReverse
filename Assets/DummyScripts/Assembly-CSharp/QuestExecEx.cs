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
public class QuestExecEx : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14941
{
	// Fields
	private QuestExecType _type; // 0x10
	private string[] _param; // 0x18

	// Properties
	public QuestExecType type { /* [XID] */ /* 0x0000000189AE5B00-0x0000000189AE5B20 */ get => default; /* [XID] */ /* 0x0000000189AECFA0-0x0000000189AECFC0 */ private set {} } // 0x0000000183008910-0x00000001830089B0 0x00000001830083A0-0x0000000183008450
	public string[] param { /* [XID] */ /* 0x0000000189AF48D0-0x0000000189AF48F0 */ get => default; /* [XID] */ /* 0x0000000189AFBF20-0x0000000189AFBF40 */ private set {} } // 0x0000000183008A60-0x0000000183008B00 0x00000001830089B0-0x0000000183008A60

	// Constructors
	public QuestExecEx(QuestExecType type, string[] param) {} // 0x0000000183008BA0-0x0000000183008C40
	public QuestExecEx() {} // 0x0000000183008C40-0x0000000183008CA0

	// Methods
	// [XID] // 0x0000000189B03850-0x0000000189B03870
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001830086C0-0x00000001830087D0
	// [XID] // 0x0000000189B0AEE0-0x0000000189B0AF00
	public void InitEmpty() {} // 0x0000000183007FD0-0x00000001830080A0
	[BlackList] // 0x0000000189B12760-0x0000000189B127A0
	// [XID] // 0x0000000189B12760-0x0000000189B127A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183007C50-0x0000000183007FD0
	// [XID] // 0x00000001896169D0-0x00000001896169F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001830072E0-0x00000001830075A0
	// [XID] // 0x0000000189B24320-0x0000000189B24340
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB0A */, bool useObjectPool = false /* Metadata: 0x00AEFB0E */) => default; // 0x00000001830080A0-0x00000001830083A0
	// [XID] // 0x000000018997F0D0-0x000000018997F0F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB0F */, bool useObjectPool = false /* Metadata: 0x00AEFB13 */) => default; // 0x00000001830079B0-0x0000000183007C50
	[BlackList] // 0x0000000189B32BE0-0x0000000189B32C20
	// [XID] // 0x0000000189B32BE0-0x0000000189B32C20
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001830075A0-0x0000000183007870
	// [XID] // 0x0000000189B3D1E0-0x0000000189B3D200
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183008450-0x00000001830086C0
	[BlackList] // 0x0000000189B44F90-0x0000000189B44FD0
	// [XID] // 0x0000000189B44F90-0x0000000189B44FD0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183007870-0x0000000183007910
	[BlackList] // 0x0000000189B4F630-0x0000000189B4F670
	// [XID] // 0x0000000189B4F630-0x0000000189B4F670
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183007910-0x00000001830079B0
	[BlackList] // 0x0000000189B59E80-0x0000000189B59EC0
	// [XID] // 0x0000000189B59E80-0x0000000189B59EC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183008B00-0x0000000183008BA0
	[BlackList] // 0x0000000189B646B0-0x0000000189B646F0
	// [XID] // 0x0000000189B646B0-0x0000000189B646F0
	public virtual void OnPoolAllocated() {} // 0x0000000183008870-0x0000000183008910
	[BlackList] // 0x0000000189B6EB20-0x0000000189B6EB60
	// [XID] // 0x0000000189B6EB20-0x0000000189B6EB60
	public virtual void OnBeforePoolRecycled() {} // 0x00000001830087D0-0x0000000183008870
}

