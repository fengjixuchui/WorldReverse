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

public sealed class AIPrecombatUpdater : BrainModuleBase // TypeDefIndex: 20428
{
	// Fields
	private Dictionary<NeuronLayer, List<AIPrecombatKnowledge.TacticActionPoint>> _candidateActionPoints; // 0x30
	private Comparison<AIPrecombatKnowledge.TacticActionPoint> _compareDistanceToPlayer; // 0x38

	// Constructors
	public AIPrecombatUpdater() {} // Dummy constructor
	public AIPrecombatUpdater(AIKnowledge knowledge) {} // 0x0000000182116F30-0x0000000182117110

	// Methods
	// [XID] // 0x00000001897F0480-0x00000001897F04A0
	protected override void UpdateMainThreadInternal(float deltaTime) {} // 0x0000000182116B60-0x0000000182116C10
	// [XID] // 0x00000001897F7BB0-0x00000001897F7BD0
	protected override void UpdateComputeThreadInternal(float deltaTime) {} // 0x00000001821164A0-0x0000000182116570
	// [XID] // 0x00000001897FF270-0x00000001897FF290
	private void UpdateEnvironment() {} // 0x0000000182116C10-0x0000000182116F30
	// [XID] // 0x00000001898069F0-0x0000000189806A10
	private void UpdateBiologicalClock() {} // 0x00000001821167B0-0x0000000182116AE0
	// [XID] // 0x000000018980E1B0-0x000000018980E1D0
	private void UpdateRoutineActivity() {} // 0x00000001821165F0-0x00000001821167B0
	// [XID] // 0x00000001898158B0-0x00000001898158D0
	private void UpdateActionPoint() {} // 0x0000000182115850-0x0000000182116320
}

