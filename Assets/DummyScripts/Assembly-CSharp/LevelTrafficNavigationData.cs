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

public class LevelTrafficNavigationData : ITaskData // TypeDefIndex: 26610
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 22; // Metadata: 0x00B0C6A2
	private int _uid; // 0x14
	public Queue<TrafficPathQueryPattern> QueueToQueryTrafficPath; // 0x18

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189754F50-0x0000000189754F70 */ get => default; } // 0x00000001825CC520-0x00000001825CC650 
	public int nodeIndex { get; set; } // 0x00000001825CC7F0-0x00000001825CC850 0x00000001825CC990-0x00000001825CC9F0
	public int typeId { /* [XID] */ /* 0x000000018976B2B0-0x000000018976B2D0 */ get => default; } // 0x00000001825CC850-0x00000001825CC8F0 
	public int uid { /* [XID] */ /* 0x0000000189789030-0x0000000189789050 */ get => default; } // 0x00000001825CC8F0-0x00000001825CC990 

	// Constructors
	public LevelTrafficNavigationData() {} // 0x00000001825CC750-0x00000001825CC7F0
	static LevelTrafficNavigationData() {} // 0x00000001825CC6F0-0x00000001825CC750

	// Methods
	// [XID] // 0x00000001897728C0-0x00000001897728E0
	public void Init() {} // 0x00000001825CC460-0x00000001825CC520
	// [XID] // 0x0000000189779FF0-0x000000018977A010
	public void Write() {} // 0x00000001825CC650-0x00000001825CC6F0
	// [XID] // 0x0000000189781B80-0x0000000189781BA0
	public void Free() {} // 0x00000001825CC230-0x00000001825CC2E0
	// [XID] // 0x0000000189790640-0x0000000189790660
	private void Clear() {} // 0x00000001825CC2E0-0x00000001825CC390
	// [XID] // 0x0000000189798010-0x0000000189798030
	public void EnqueueTrafficPathQuery(TrafficPathQueryPattern pattern) {} // 0x00000001825CC390-0x00000001825CC460
}

