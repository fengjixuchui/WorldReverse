/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SpacialProbeInfo : MoveInfoBase, IAutoAllocRecycle // TypeDefIndex: 20331
{
	// Fields
	public Vector3? probeDestination; // 0x10
	public SpacialProbeStatus status; // 0x20
	public float nextAvailableTick; // 0x24
	public int probeNumberRemaining; // 0x28
	private float terrainOffsetMedian; // 0x2C
	private float consecutiveProbeAngleVariance; // 0x30

	// Nested types
	public enum SpacialProbeStatus // TypeDefIndex: 20332
	{
		Inactive = 0,
		Probing = 1
	}

	// Constructors
	public SpacialProbeInfo() {} // 0x000000018393B220-0x000000018393B290

	// Methods
	[BlackList] // 0x0000000189A6DBE0-0x0000000189A6DC20
	// [XID] // 0x0000000189A6DBE0-0x0000000189A6DC20
	public override void AutoAllocTypeFields() {} // 0x0000000183939590-0x0000000183939630
	[BlackList] // 0x0000000189A78640-0x0000000189A78680
	// [XID] // 0x0000000189A78640-0x0000000189A78680
	public override void AutoRecycleTypeFields() {} // 0x0000000183939630-0x0000000183939700
	[BlackList] // 0x0000000189A82E40-0x0000000189A82E80
	// [XID] // 0x0000000189A82E40-0x0000000189A82E80
	public override void ReturnToObjectPool() {} // 0x000000018393B180-0x000000018393B220
	// [XID] // 0x0000000189A8D7F0-0x0000000189A8D810
	public override void Clear() {} // 0x0000000183939760-0x0000000183939820
	// [XID] // 0x0000000189A94DB0-0x0000000189A94DD0
	public override void Enter(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018393A280-0x000000018393A4C0
	// [XID] // 0x0000000189A9C610-0x0000000189A9C630
	public override void Leave(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIManager aiManager) {} // 0x000000018393A0E0-0x000000018393A1C0
	// [XID] // 0x0000000189AA3D80-0x0000000189AA3DA0
	public override void UpdateInternal(AILocomotionHandler taskHandler, AIKnowledge aiKnowledge, LCAIBeta lcai, LCAIManager aiManager) {} // 0x0000000183939820-0x0000000183939BB0
	// [XID] // 0x0000000189AAB2D0-0x0000000189AAB2F0
	private void CalculateProbingDestination(AIKnowledge knowledge, float? angleLimit) {} // 0x000000018393A4C0-0x000000018393B180
	// [XID] // 0x0000000189AB2CE0-0x0000000189AB2D00
	private bool IsDestinationValid(AIKnowledge knowledge, Vector3 candidatePos, Vector3 candidateDir) => default; // 0x0000000183939CA0-0x000000018393A050
}

