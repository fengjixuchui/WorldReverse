/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PriorityQueueForTextMap // TypeDefIndex: 21328
{
	// Fields
	private Dictionary<uint, QueueNode> _queueNodeDic; // 0x10
	private Stack<QueueNode> _reuseNodeStack; // 0x18
	private QueueNode _firstNode; // 0x20
	private QueueNode _lastNode; // 0x28
	private int _count; // 0x30

	// Properties
	public int Count { /* [XID] */ /* 0x0000000189AF7000-0x0000000189AF7020 */ get => default; } // 0x0000000184B20A90-0x0000000184B20B30 

	// Nested types
	public class QueueNode // TypeDefIndex: 21329
	{
		// Fields
		public uint value; // 0x10
		public QueueNode prevNode; // 0x18
		public QueueNode nextNode; // 0x20

		// Constructors
		public QueueNode() {} // 0x0000000184B381A0-0x0000000184B38200

		// Methods
		// [XID] // 0x0000000189B23980-0x0000000189B239A0
		public void Clear() {} // 0x0000000184B38100-0x0000000184B381A0
	}

	// Constructors
	public PriorityQueueForTextMap() {} // 0x0000000184B20B30-0x0000000184B20BF0

	// Methods
	// [XID] // 0x0000000189AFE610-0x0000000189AFE630
	public void Enqueue(uint value) {} // 0x0000000184B20890-0x0000000184B20A90
	// [XID] // 0x0000000189B05EE0-0x0000000189B05F00
	public uint Dequeue() => default; // 0x0000000184B204C0-0x0000000184B205C0
	// [XID] // 0x0000000189B0D5F0-0x0000000189B0D610
	public void Clear() {} // 0x0000000184B206A0-0x0000000184B207A0
	// [XID] // 0x0000000189B14A30-0x0000000189B14A50
	private void PushUnuseNode(QueueNode unuseNode) {} // 0x0000000184B205C0-0x0000000184B206A0
	// [XID] // 0x0000000189B1C430-0x0000000189B1C450
	private QueueNode PopUnuseNode() => default; // 0x0000000184B207A0-0x0000000184B20890
}

