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
public class ConfigAIInvestigateData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17428
{
	// Fields
	private SimpleSafeInt32 speedLevelRawNum; // 0x10
	private SimpleSafeFloat lookAroundTimeRawNum; // 0x14
	private bool _spacial; // 0x18

	// Properties
	public int speedLevel { /* [XID] */ /* 0x00000001898D0700-0x00000001898D0720 */ get => default; /* [XID] */ /* 0x00000001898D7D80-0x00000001898D7DA0 */ private set {} } // 0x00000001831EF970-0x00000001831EFA40 0x00000001831EFA40-0x00000001831EFB20
	public float lookAroundTime { /* [XID] */ /* 0x00000001898DFB60-0x00000001898DFB80 */ get => default; /* [XID] */ /* 0x00000001898E75D0-0x00000001898E75F0 */ private set {} } // 0x00000001831F07A0-0x00000001831F0880 0x00000001831EFDF0-0x00000001831EFED0
	public bool spacial { /* [XID] */ /* 0x00000001898EEDC0-0x00000001898EEDE0 */ get => default; /* [XID] */ /* 0x00000001898F6700-0x00000001898F6720 */ private set {} } // 0x00000001831F0300-0x00000001831F03A0 0x00000001831EFED0-0x00000001831EFF80

	// Constructors
	public ConfigAIInvestigateData() {} // 0x00000001831F0E80-0x00000001831F0F50

	// Methods
	// [XID] // 0x00000001898FDDC0-0x00000001898FDDE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001831F0B80-0x00000001831F0CA0
	// [XID] // 0x00000001899055E0-0x0000000189905600
	public void InitEmpty() {} // 0x00000001831F03A0-0x00000001831F04A0
	[BlackList] // 0x000000018990CED0-0x000000018990CF10
	// [XID] // 0x000000018990CED0-0x000000018990CF10
	public bool FromJson(JSONNode node) => default; // 0x00000001831EFF80-0x00000001831F0300
	// [XID] // 0x00000001899179E0-0x0000000189917A00
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001831EF140-0x00000001831EF500
	// [XID] // 0x000000018991EF40-0x000000018991EF60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E49 */, bool useObjectPool = false /* Metadata: 0x00AF6E4D */) => default; // 0x00000001831F04A0-0x00000001831F07A0
	// [XID] // 0x0000000189926980-0x00000001899269A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E4E */, bool useObjectPool = false /* Metadata: 0x00AF6E52 */) => default; // 0x00000001831EFB20-0x00000001831EFDF0
	[BlackList] // 0x000000018992DF50-0x000000018992DF90
	// [XID] // 0x000000018992DF50-0x000000018992DF90
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001831EF500-0x00000001831EF7D0
	// [XID] // 0x0000000189938310-0x0000000189938330
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001831F0880-0x00000001831F0B80
	[BlackList] // 0x000000018993FCA0-0x000000018993FCE0
	// [XID] // 0x000000018993FCA0-0x000000018993FCE0
	public virtual void AutoAllocTypeFields() {} // 0x00000001831EF7D0-0x00000001831EF870
	[BlackList] // 0x000000018994A200-0x000000018994A240
	// [XID] // 0x000000018994A200-0x000000018994A240
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831EF870-0x00000001831EF970
	[BlackList] // 0x0000000189954900-0x0000000189954940
	// [XID] // 0x0000000189954900-0x0000000189954940
	public virtual void ReturnToObjectPool() {} // 0x00000001831F0DE0-0x00000001831F0E80
	[BlackList] // 0x000000018995F2B0-0x000000018995F2F0
	// [XID] // 0x000000018995F2B0-0x000000018995F2F0
	public virtual void OnPoolAllocated() {} // 0x00000001831F0D40-0x00000001831F0DE0
	[BlackList] // 0x0000000189969A00-0x0000000189969A40
	// [XID] // 0x0000000189969A00-0x0000000189969A40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831F0CA0-0x00000001831F0D40
}

