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

public class ConfigLoaderData : ITaskData // TypeDefIndex: 26583
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 14; // Metadata: 0x00B0C598
	private int _uid; // 0x14
	public Queue<ConfigLoadAndSerializePattern> QueueToLoad; // 0x18
	public Queue<ConfigSerializePattern> QueueToSerialize; // 0x20

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189A8D580-0x0000000189A8D5A0 */ get => default; } // 0x0000000182E3A870-0x0000000182E3A9A0 
	public int nodeIndex { get; set; } // 0x0000000182E3AB60-0x0000000182E3ABC0 0x0000000182E3AD00-0x0000000182E3AD60
	public int typeId { /* [XID] */ /* 0x0000000189AA3AB0-0x0000000189AA3AD0 */ get => default; } // 0x0000000182E3ABC0-0x0000000182E3AC60 
	public int uid { /* [XID] */ /* 0x0000000189AC1F20-0x0000000189AC1F40 */ get => default; } // 0x0000000182E3AC60-0x0000000182E3AD00 

	// Constructors
	public ConfigLoaderData() {} // 0x0000000182E3AAA0-0x0000000182E3AB60
	static ConfigLoaderData() {} // 0x0000000182E3AA40-0x0000000182E3AAA0

	// Methods
	// [XID] // 0x0000000189AAB0D0-0x0000000189AAB0F0
	public void Init() {} // 0x0000000182E3A7B0-0x0000000182E3A870
	// [XID] // 0x0000000189AB2A20-0x0000000189AB2A40
	public void Write() {} // 0x0000000182E3A9A0-0x0000000182E3AA40
	// [XID] // 0x0000000189ABA590-0x0000000189ABA5B0
	public void Free() {} // 0x0000000182E3A560-0x0000000182E3A610
	// [XID] // 0x0000000189AC94F0-0x0000000189AC9510
	private void Clear() {} // 0x0000000182E3A610-0x0000000182E3A6E0
	// [XID] // 0x0000000189AD0F00-0x0000000189AD0F20
	public void EnqueueLoadAndSerializePattern(ConfigLoadAndSerializePattern pattern) {} // 0x0000000182E3A490-0x0000000182E3A560
	// [XID] // 0x0000000189AD8C30-0x0000000189AD8C50
	public void EnqueueSerializePattern(ConfigSerializePattern pattern) {} // 0x0000000182E3A6E0-0x0000000182E3A7B0
}

