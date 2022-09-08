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

public class CoopTask // TypeDefIndex: 20784
{
	// Fields
	private uint _mainCoopId; // 0x10
	private ConfigCoopInteractionGroup _coopGrp; // 0x18
	private uint _currentNodeId; // 0x20
	private uint _nextNodeId; // 0x24
	private bool _isFinish; // 0x28
	private Dictionary<uint, CoopBaseNodeTask> _coopDic; // 0x30

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898E0560-0x00000001898E0580 */ get => default; } // 0x0000000183AD7D40-0x0000000183AD7DF0 
	public uint mainCoopId { /* [XID] */ /* 0x0000000189AFFFF0-0x0000000189B00010 */ get => default; } // 0x0000000183AD7DF0-0x0000000183AD7E90 
	public bool isFinish { /* [XID] */ /* 0x0000000189B07530-0x0000000189B07550 */ get => default; /* [XID] */ /* 0x0000000189B0ED50-0x0000000189B0ED70 */ set {} } // 0x0000000183AD7B30-0x0000000183AD7BD0 0x0000000183AD7A80-0x0000000183AD7B30

	// Constructors
	public CoopTask() {} // 0x0000000183AD80F0-0x0000000183AD8170

	// Methods
	// [XID] // 0x0000000189B160D0-0x0000000189B160F0
	public void Init(uint mainCoopId, ConfigCoopInteractionGroup grp) {} // 0x0000000183AD77C0-0x0000000183AD78C0
	// [XID] // 0x000000018997F090-0x000000018997F0B0
	private void CreateCoopNodeDic(ConfigCoopInteractionGroup grp) {} // 0x0000000183AD7E90-0x0000000183AD80F0
	// [XID] // 0x0000000189A23F10-0x0000000189A23F30
	public void StartCurrentNode() {} // 0x0000000183AD7970-0x0000000183AD7A80
	// [XID] // 0x0000000189B2C650-0x0000000189B2C670
	public void MoveNextNodeAndStart() {} // 0x0000000183AD7C80-0x0000000183AD7D40
	// [XID] // 0x0000000189B33B80-0x0000000189B33BA0
	public void SetNextNodeId(uint nodeId) {} // 0x0000000183AD78C0-0x0000000183AD7970
	// [XID] // 0x0000000189B3B470-0x0000000189B3B490
	public void SetFailNodeId() {} // 0x0000000183AD7BD0-0x0000000183AD7C80
	// [XID] // 0x0000000189B42CF0-0x0000000189B42D10
	public virtual void OnCoopEvent(CoopEvent evt) {} // 0x0000000183AD76C0-0x0000000183AD77C0
}

