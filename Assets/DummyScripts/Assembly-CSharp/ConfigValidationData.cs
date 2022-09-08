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

public class ConfigValidationData : ITaskData // TypeDefIndex: 26587
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 16; // Metadata: 0x00B0C5B4
	private int _uid; // 0x14
	public const int QueueMaxSize = 100; // Metadata: 0x00B0C5B8
	public Queue<ConfigHashValidationPattern> QueueToValidateHash; // 0x18

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189BCA3A0-0x0000000189BCA3C0 */ get => default; } // 0x00000001813EA510-0x00000001813EA640 
	public int nodeIndex { get; set; } // 0x00000001813EA7E0-0x00000001813EA840 0x00000001813EA980-0x00000001813EA9E0
	public int typeId { /* [XID] */ /* 0x00000001895E5BF0-0x00000001895E5C10 */ get => default; } // 0x00000001813EA840-0x00000001813EA8E0 
	public int uid { /* [XID] */ /* 0x0000000189603D20-0x0000000189603D40 */ get => default; } // 0x00000001813EA8E0-0x00000001813EA980 

	// Constructors
	public ConfigValidationData() {} // 0x00000001813EA740-0x00000001813EA7E0
	static ConfigValidationData() {} // 0x00000001813EA6E0-0x00000001813EA740

	// Methods
	// [XID] // 0x00000001895ED540-0x00000001895ED560
	public void Init() {} // 0x00000001813EA450-0x00000001813EA510
	// [XID] // 0x00000001895F4BF0-0x00000001895F4C10
	public void Write() {} // 0x00000001813EA640-0x00000001813EA6E0
	// [XID] // 0x00000001895FC340-0x00000001895FC360
	public void Free() {} // 0x00000001813EA2F0-0x00000001813EA3A0
	// [XID] // 0x000000018960B660-0x000000018960B680
	private void Clear() {} // 0x00000001813EA3A0-0x00000001813EA450
	// [XID] // 0x0000000189612A90-0x0000000189612AB0
	public void EnqueueValidateHashPattern(ConfigHashValidationPattern pattern) {} // 0x00000001813EA1C0-0x00000001813EA2F0
}

