/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SdkInvokeData : ITaskData // TypeDefIndex: 26623
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 26; // Metadata: 0x00B0C727
	private int _uid; // 0x14
	private Queue<SdkInvokeTaskCellBase> _runQueue; // 0x18

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189AF5660-0x0000000189AF5680 */ get => default; } // 0x000000018434EEE0-0x000000018434F010 
	public int nodeIndex { get; set; } // 0x000000018434F250-0x000000018434F2B0 0x000000018434F3F0-0x000000018434F450
	public int typeId { /* [XID] */ /* 0x0000000189B0BBD0-0x0000000189B0BBF0 */ get => default; } // 0x000000018434F2B0-0x000000018434F350 
	public int uid { /* [XID] */ /* 0x0000000189B29420-0x0000000189B29440 */ get => default; } // 0x000000018434F350-0x000000018434F3F0 
	public Queue<SdkInvokeTaskCellBase> runQueue { /* [XID] */ /* 0x0000000189B380F0-0x0000000189B38110 */ get => default; } // 0x000000018434F010-0x000000018434F0B0 

	// Constructors
	public SdkInvokeData() {} // 0x000000018434F1B0-0x000000018434F250
	static SdkInvokeData() {} // 0x000000018434F150-0x000000018434F1B0

	// Methods
	// [XID] // 0x0000000189B130A0-0x0000000189B130C0
	public void Init() {} // 0x000000018434EE20-0x000000018434EEE0
	// [XID] // 0x0000000189B1A830-0x0000000189B1A850
	public void Write() {} // 0x000000018434F0B0-0x000000018434F150
	// [XID] // 0x0000000189B21E40-0x0000000189B21E60
	public void Free() {} // 0x000000018434ECC0-0x000000018434ED70
	// [XID] // 0x0000000189B308E0-0x0000000189B30900
	private void Clear() {} // 0x000000018434ED70-0x000000018434EE20
	public void AddSdkInvokeTaskCell<ExecuteType, FlushType>(SdkInvokeTaskCell<ExecuteType, FlushType> _e, SdkInvokeTaskCell<ExecuteType, FlushType> _f, ExecuteType _eData)
		where ExecuteType : class
		where FlushType : class {}
}

