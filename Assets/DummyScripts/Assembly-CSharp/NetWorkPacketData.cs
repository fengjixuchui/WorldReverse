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

public class NetWorkPacketData : ITaskData // TypeDefIndex: 26618
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 19; // Metadata: 0x00B0C6F4
	private int _uid; // 0x14
	private int _queueIndex; // 0x18
	private Queue<NetPacketRequest>[] _doubleQueueBuff; // 0x20

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x000000018999B340-0x000000018999B360 */ get => default; } // 0x0000000183CC9F80-0x0000000183CCA0B0 
	public int nodeIndex { get; set; } // 0x0000000183CCA330-0x0000000183CCA390 0x0000000183CCA4D0-0x0000000183CCA530
	public int typeId { /* [XID] */ /* 0x00000001899B1EB0-0x00000001899B1ED0 */ get => default; } // 0x0000000183CCA390-0x0000000183CCA430 
	public int uid { /* [XID] */ /* 0x00000001899CFCE0-0x00000001899CFD00 */ get => default; } // 0x0000000183CCA430-0x0000000183CCA4D0 
	public Queue<NetPacketRequest> QueueToSend { /* [XID] */ /* 0x00000001899E62A0-0x00000001899E62C0 */ get => default; } // 0x0000000183CC9B00-0x0000000183CC9BD0 

	// Constructors
	public NetWorkPacketData() {} // 0x0000000183CCA1B0-0x0000000183CCA330
	static NetWorkPacketData() {} // 0x0000000183CCA150-0x0000000183CCA1B0

	// Methods
	// [XID] // 0x00000001899B9230-0x00000001899B9250
	public void Init() {} // 0x0000000183CC9EC0-0x0000000183CC9F80
	// [XID] // 0x00000001899C0B80-0x00000001899C0BA0
	public void Write() {} // 0x0000000183CCA0B0-0x0000000183CCA150
	// [XID] // 0x00000001899C8280-0x00000001899C82A0
	public void Free() {} // 0x0000000183CC9D50-0x0000000183CC9E00
	// [XID] // 0x00000001899D7070-0x00000001899D7090
	private void Clear() {} // 0x0000000183CC9E00-0x0000000183CC9EC0
	// [XID] // 0x00000001899DE5A0-0x00000001899DE5C0
	public void EnqueuePacketRequest(NetPacketRequest request) {} // 0x0000000183CC9BD0-0x0000000183CC9CA0
	// [XID] // 0x00000001899ED6D0-0x00000001899ED6F0
	public void FlipQueneBuff() {} // 0x0000000183CC9CA0-0x0000000183CC9D50
}

