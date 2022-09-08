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
public class WatcherTriggerConfig : IAutoAllocRecycle // TypeDefIndex: 15407
{
	// Fields
	protected WatcherTriggerType _triggerType; // 0x10
	protected string[] _paramList; // 0x18

	// Properties
	public WatcherTriggerType triggerType { /* [XID] */ /* 0x0000000189BC61E0-0x0000000189BC6200 */ get => default; /* [XID] */ /* 0x0000000189BCDDC0-0x0000000189BCDDE0 */ protected set {} } // 0x00000001821EB650-0x00000001821EB6F0 0x00000001821EB1C0-0x00000001821EB270
	public string[] paramList { /* [XID] */ /* 0x0000000189BD52B0-0x0000000189BD52D0 */ get => default; /* [XID] */ /* 0x0000000189BDCE20-0x0000000189BDCE40 */ protected set {} } // 0x00000001821EB120-0x00000001821EB1C0 0x00000001821EB5A0-0x00000001821EB650

	// Constructors
	public WatcherTriggerConfig() {} // 0x00000001821EBC40-0x00000001821EBCA0

	// Methods
	// [XID] // 0x00000001895E96D0-0x00000001895E96F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001821EB270-0x00000001821EB5A0
	// [XID] // 0x00000001895F0E60-0x00000001895F0E80
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1451 */, bool useObjectPool = false /* Metadata: 0x00AF1455 */) => default; // 0x00000001821EB6F0-0x00000001821EBA60
	[BlackList] // 0x00000001895F8890-0x00000001895F88D0
	// [XID] // 0x00000001895F8890-0x00000001895F88D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001821EAFE0-0x00000001821EB080
	[BlackList] // 0x0000000189602DD0-0x0000000189602E10
	// [XID] // 0x0000000189602DD0-0x0000000189602E10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001821EB080-0x00000001821EB120
	[BlackList] // 0x000000018960D6C0-0x000000018960D700
	// [XID] // 0x000000018960D6C0-0x000000018960D700
	public virtual void ReturnToObjectPool() {} // 0x00000001821EBBA0-0x00000001821EBC40
	[BlackList] // 0x0000000189617A70-0x0000000189617AB0
	// [XID] // 0x0000000189617A70-0x0000000189617AB0
	public virtual void OnPoolAllocated() {} // 0x00000001821EBB00-0x00000001821EBBA0
	[BlackList] // 0x00000001896222E0-0x0000000189622320
	// [XID] // 0x00000001896222E0-0x0000000189622320
	public virtual void OnBeforePoolRecycled() {} // 0x00000001821EBA60-0x00000001821EBB00
}

