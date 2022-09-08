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

public sealed class LevelWitchTimePlugin : BaseComponentPlugin // TypeDefIndex: 12134
{
	// Fields
	public float _witchTimeScale; // 0x58
	private float _duration; // 0x5C
	private NormalTimer _timer; // 0x60
	private int _witchTimeStageEffectStackIx; // 0x68
	private bool _enteringTimeSlow; // 0x6C
	private bool _notStartEffect; // 0x6D
	private HashSet<uint> _ignoreRuntimeIDSet; // 0x70
	private uint _ownerID; // 0x78
	private LevelEntity _levelEntity; // 0x80
	private SimpleSafeUInt32[] _witchCamps; // 0x88
	private string _openEffectPattern; // 0x90
	private string _closeEffectPattern; // 0x98
	private string _weatherEffectPattern; // 0xA0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189879560-0x0000000189879580 */ get => default; } // 0x0000000183A161F0-0x0000000183A16290 

	// Constructors
	public LevelWitchTimePlugin() {} // 0x0000000183A16180-0x0000000183A161F0

	// Methods
	// [XID] // 0x0000000189880BF0-0x0000000189880C10
	public override void Init() {} // 0x0000000183A14D60-0x0000000183A14F30
	// [XID] // 0x0000000189887FE0-0x0000000189888000
	public override void Destroy() {} // 0x0000000183A14780-0x0000000183A14880
	// [XID] // 0x000000018988F520-0x000000018988F540
	public void Refresh(float duration, SimpleSafeUInt32[] camps, float timescale, uint ownerID, bool enteringTimeSlow = false /* Metadata: 0x00AEB541 */, float delayDuration = 0f /* Metadata: 0x00AEB542 */, float delayRatio = 0.5f /* Metadata: 0x00AEB546 */, bool useMaxDuration = true /* Metadata: 0x00AEB54A */, bool notStartEffect = false /* Metadata: 0x00AEB54B */) {} // 0x0000000183A13C50-0x0000000183A13E90
	// [XID] // 0x0000000189896A60-0x0000000189896A80
	private void Setup(SimpleSafeUInt32[] camps, float duration, float timescale, bool enteringTimeSlow, float delayDuration, float delayRatio, bool notStartEffect) {} // 0x0000000183A14640-0x0000000183A14780
	// [XID] // 0x000000018989DEF0-0x000000018989DF10
	private void SwitchSide(SimpleSafeUInt32[] camps, float duration, float timescale, bool enteringTimeSlow, float delayDuration, float delayTimescale, uint newOwnerID, bool notStartEffect) {} // 0x0000000183A150F0-0x0000000183A152E0
	// [XID] // 0x00000001898A58B0-0x00000001898A58D0
	private void ExtendDuration(uint ownerID, float duration, float timescale, bool enteringTimeSlow, float delayDuration, float delayTimescale, bool useMaxDuration) {} // 0x0000000183A13EF0-0x0000000183A14100
	// [XID] // 0x00000001898ACDE0-0x00000001898ACE00
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000183A14B40-0x0000000183A14C40
	// [XID] // 0x00000001898B4330-0x00000001898B4350
	public override bool OnEvent(BaseEvent evt) => default; // 0x0000000183A15E40-0x0000000183A15F70
	// [XID] // 0x00000001898BC170-0x00000001898BC190
	private void WitchTimeStart() {} // 0x0000000183A15850-0x0000000183A15A60
	// [XID] // 0x00000001898C3510-0x00000001898C3530
	private void DoWitchTimeStart() {} // 0x0000000183A14C40-0x0000000183A14D60
	// [XID] // 0x00000001898CAE50-0x00000001898CAE70
	private void TryApplyWitchTime(uint actorID) {} // 0x0000000183A15470-0x0000000183A155C0
	// [XID] // 0x00000001898D2550-0x00000001898D2570
	private void TryRemoveWitchTime(uint actorID) {} // 0x0000000183A14100-0x0000000183A14250
	// [XID] // 0x00000001898D9E90-0x00000001898D9EB0
	private void PushRenderingDataBySide() {} // 0x0000000183A152E0-0x0000000183A15380
	// [XID] // 0x00000001898E1A20-0x00000001898E1A40
	private void WitchTimeSFX() {} // 0x0000000183A14880-0x0000000183A14920
	// [XID] // 0x00000001898E97B0-0x00000001898E97D0
	private void PushRenderingData() {} // 0x0000000183A14920-0x0000000183A149C0
	// [XID] // 0x00000001898F0D20-0x00000001898F0D40
	private void ApplyWitchTimeSlowedBySide() {} // 0x0000000183A15F70-0x0000000183A160D0
	// [XID] // 0x00000001898F86A0-0x00000001898F86C0
	private void RemoveWitchTimeSlowedBySide() {} // 0x0000000183A14F30-0x0000000183A15090
	// [XID] // 0x00000001898FFEA0-0x00000001898FFEC0
	private void TryPopRenderingData() {} // 0x0000000183A160D0-0x0000000183A16180
	// [XID] // 0x0000000189907600-0x0000000189907620
	public void WitchTimeStop() {} // 0x0000000183A14330-0x0000000183A14420
	// [XID] // 0x000000018990EF50-0x000000018990EF70
	private bool OnPostEntityCreated(EvtEntityCreated evt) => default; // 0x0000000183A15A60-0x0000000183A15BC0
	// [XID] // 0x0000000189916820-0x0000000189916840
	private bool OnCreateStage(EvtStageCreated evt) => default; // 0x0000000183A14250-0x0000000183A14330
	// [XID] // 0x000000018991DFD0-0x000000018991DFF0
	private void ActStartParticleEffect() {} // 0x0000000183A15BC0-0x0000000183A15D00
	// [XID] // 0x00000001899258C0-0x00000001899258E0
	private void ActStopParticleEffect() {} // 0x0000000183A15D00-0x0000000183A15E40
	// [XID] // 0x000000018992CD70-0x000000018992CD90
	public void SetEffectPattern(string opp, string clp, string wep) {} // 0x0000000183A149C0-0x0000000183A14B40
	// [XID] // 0x0000000189934260-0x0000000189934280
	private void ActOpenEffect() {} // 0x0000000183A14420-0x0000000183A14640
	// [XID] // 0x000000018993BF70-0x000000018993BF90
	private void ActCloseEffect() {} // 0x0000000183A15630-0x0000000183A15850
}

