/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class RuntimeSequence // TypeDefIndex: 21102
{
	// Fields
	private List<BaseEntity> _entities; // 0x10
	private Queue<SequenceLine> _sequenceQueue; // 0x18

	// Properties
	public List<BaseEntity> entities { /* [XID] */ /* 0x0000000189B4BE80-0x0000000189B4BEA0 */ get => default; } // 0x00000001832E2690-0x00000001832E2730 

	// Constructors
	public RuntimeSequence() {} // 0x00000001832E3090-0x00000001832E3140

	// Methods
	// [XID] // 0x0000000189B53310-0x0000000189B53330
	public void Clear() {} // 0x00000001832E2730-0x00000001832E2960
	// [XID] // 0x0000000189B5ACD0-0x0000000189B5ACF0
	public bool IsValid() => default; // 0x00000001832E2490-0x00000001832E2690
	// [XID] // 0x0000000189B62110-0x0000000189B62130
	public bool HasEntity(uint id) => default; // 0x00000001832E2B80-0x00000001832E2D50
	// [XID] // 0x0000000189B69D70-0x0000000189B69D90
	public void EnqueueConvLine(ConvLineData line) {} // 0x00000001832E2960-0x00000001832E2B80
	// [XID] // 0x0000000189B712A0-0x0000000189B712C0
	public bool ProcessSequence() => default; // 0x00000001832E2D50-0x00000001832E3090
	// [XID] // 0x0000000189B78900-0x0000000189B78920
	private void SayDialogAudio(BaseEntity entity, uint dialogId) {} // 0x00000001832E2390-0x00000001832E2490
}

