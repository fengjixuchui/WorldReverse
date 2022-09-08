/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class VoicePipelineWaitingList // TypeDefIndex: 11536
{
	// Fields
	private Node _first; // 0x10
	private Node _last; // 0x18
	private int _count; // 0x20

	// Properties
	public Node first { /* [XID] */ /* 0x000000018966F140-0x000000018966F160 */ get => default; } // 0x0000000183360CE0-0x0000000183360D80 
	public Node last { /* [XID] */ /* 0x0000000189676AF0-0x0000000189676B10 */ get => default; } // 0x0000000183360C40-0x0000000183360CE0 
	public int count { /* [XID] */ /* 0x0000000189956A60-0x0000000189956A80 */ get => default; } // 0x0000000183360BA0-0x0000000183360C40 

	// Nested types
	public class Node // TypeDefIndex: 11537
	{
		// Properties
		public IVoiceIntention intention { /* [XID] */ /* 0x00000001896D4040-0x00000001896D4080 */ get; /* [XID] */ /* 0x00000001896DEB90-0x00000001896DEBD0 */ set; } // 0x000000018337C1A0-0x000000018337C200 0x000000018337C200-0x000000018337C260
		public Node next { /* [XID] */ /* 0x00000001896E8FF0-0x00000001896E9030 */ get; /* [XID] */ /* 0x00000001896F34D0-0x00000001896F3510 */ set; } // 0x000000018337C260-0x000000018337C2C0 0x000000018337C140-0x000000018337C1A0
		public int stub { /* [XID] */ /* 0x00000001896FDD10-0x00000001896FDD50 */ get; /* [XID] */ /* 0x0000000189708180-0x00000001897081C0 */ set; } // 0x000000018337C010-0x000000018337C070 0x000000018337C070-0x000000018337C0D0
		public AudioPostedEventStatus postedEventStatus { /* [XID] */ /* 0x0000000189712A30-0x0000000189712A70 */ get; /* [XID] */ /* 0x000000018971D1D0-0x000000018971D210 */ set; } // 0x000000018337C2C0-0x000000018337C330 0x000000018337C0D0-0x000000018337C140

		// Constructors
		public Node() {} // 0x000000018337C330-0x000000018337C390
	}

	// Constructors
	public VoicePipelineWaitingList() {} // 0x0000000183360E60-0x0000000183360EC0

	// Methods
	// [XID] // 0x0000000189621230-0x0000000189621250
	public void AddFirst(Node node) {} // 0x0000000183360D80-0x0000000183360E60
	// [XID] // 0x0000000189BABA50-0x0000000189BABA70
	public void AddLast(Node node) {} // 0x0000000183360AD0-0x0000000183360BA0
	// [XID] // 0x0000000189B58FE0-0x0000000189B59000
	public void RemoveFirst() {} // 0x0000000183360730-0x0000000183360880
	// [XID] // 0x000000018969C790-0x000000018969C7B0
	public void RemoveByStub(int stub) {} // 0x0000000183360880-0x0000000183360A20
	// [XID] // 0x0000000189B542C0-0x0000000189B542E0
	public void Clear() {} // 0x0000000183360A20-0x0000000183360AD0
}

