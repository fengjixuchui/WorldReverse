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

public sealed class EntityAiData : TaskDataWithLOD, ITaskData // TypeDefIndex: 26593
{
	// Fields
	private const int INIT_MAX_NUM = 10; // Metadata: 0x00B0C5EC
	private static bool[] _dataIdentifies; // 0x00
	private static int _nextDataId; // 0x08
	private static ThreadList<EntityAiData> _datas; // 0x10
	private static Queue<int> _freeIndex; // 0x18
	public const int staticTypeId = 2; // Metadata: 0x00B0C5F0
	private int _uid; // 0x2C
	public LCAIBeta ownerAI; // 0x30
	public bool isActive; // 0x38

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001897D6460-0x00000001897D6480 */ get => default; } // 0x000000018305C320-0x000000018305C7A0 
	public int nodeIndex { /* [XID] */ /* 0x00000001897DDCA0-0x00000001897DDCE0 */ get; /* [XID] */ /* 0x00000001897E8470-0x00000001897E84B0 */ set; } // 0x000000018305CAF0-0x000000018305CB50 0x000000018305CC90-0x000000018305CCF0
	public int typeId { /* [XID] */ /* 0x00000001897F33E0-0x00000001897F3400 */ get => default; } // 0x000000018305CB50-0x000000018305CBF0 
	public int uid { /* [XID] */ /* 0x0000000189818990-0x00000001898189B0 */ get => default; } // 0x000000018305CBF0-0x000000018305CC90 

	// Constructors
	public EntityAiData() {} // 0x000000018305CA90-0x000000018305CAF0
	static EntityAiData() {} // 0x000000018305C990-0x000000018305CA90

	// Methods
	// [XID] // 0x00000001897FAC30-0x00000001897FAC50
	public static EntityAiData Read(int id) => default; // 0x000000018305C7A0-0x000000018305C890
	// [XID] // 0x00000001898022A0-0x00000001898022C0
	public void Init() {} // 0x000000018305C200-0x000000018305C2C0
	// [XID] // 0x0000000189809670-0x0000000189809690
	public void Write() {} // 0x000000018305C890-0x000000018305C990
	// [XID] // 0x0000000189810E80-0x0000000189810EA0
	public void Free() {} // 0x000000018305C080-0x000000018305C200
	// [XID] // 0x0000000189820200-0x0000000189820220
	protected override void Clear() {} // 0x000000018305BFD0-0x000000018305C080
}

