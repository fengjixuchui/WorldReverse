/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole.Audio.Music;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommandThreadMusicFunctionalities : CommandThreadFunctionalities<SharedMusicFunctionalities> // TypeDefIndex: 11347
{
	// Fields
	private readonly StateAutomaton _stateAutomaton; // 0x20
	private readonly Stack<uint> _overrideStates; // 0x28
	private readonly TransitionCallback _stateTransitionCallback; // 0x30
	private SyncId _syncId; // 0x38

	// Properties
	public bool isInCombatState { /* [XID] */ /* 0x00000001899C3710-0x00000001899C3730 */ get => default; } // 0x00000001823B2DF0-0x00000001823B2EA0 

	// Constructors
	public CommandThreadMusicFunctionalities() {} // Dummy constructor
	public CommandThreadMusicFunctionalities(CommandThreadContext context, SharedMusicFunctionalities shared) {} // 0x00000001823B33E0-0x00000001823B3560

	// Methods
	// [XID] // 0x00000001899EE960-0x00000001899EE980
	public override void Init() {} // 0x00000001823B1FF0-0x00000001823B21D0
	// [XID] // 0x00000001899D21D0-0x00000001899D21F0
	public override void Tick(float deltaTime) {} // 0x00000001823B22F0-0x00000001823B23C0
	// [XID] // 0x00000001899D9920-0x00000001899D9940
	public override void EnterHomeWorld(bool firstTime) {} // 0x00000001823B2870-0x00000001823B2960
	// [XID] // 0x0000000189B988F0-0x0000000189B98910
	public override void ExitHomeWorld() {} // 0x00000001823B2EA0-0x00000001823B2F40
	// [XID] // 0x0000000189B9FD80-0x0000000189B9FDA0
	public override void ExitGameWorld() {} // 0x00000001823B2A50-0x00000001823B2AF0
	// [XID] // 0x0000000189BB5F70-0x0000000189BB5F90
	public override void CreateLevel() {} // 0x00000001823B14D0-0x00000001823B15B0
	// [XID] // 0x00000001899F77C0-0x00000001899F77E0
	public override void EnterLevel() {} // 0x00000001823B27D0-0x00000001823B2870
	// [XID] // 0x0000000189BCCD40-0x0000000189BCCD60
	public override void ExitLevel() {} // 0x00000001823B1E90-0x00000001823B1F30
	// [XID] // 0x0000000189BD4400-0x0000000189BD4420
	public override void DumpCriticalInfo(StringBuilder builder) {} // 0x00000001823B31E0-0x00000001823B3290
	// [XID] // 0x0000000189A0DC60-0x0000000189A0DC80
	public override void Destroy() {} // 0x00000001823B19A0-0x00000001823B1A40
	// [XID] // 0x0000000189A15300-0x0000000189A15320
	public void PostTrigger(uint nameId, SyncId syncId) {} // 0x00000001823B21D0-0x00000001823B22F0
	// [XID] // 0x0000000189A1C4F0-0x0000000189A1C510
	public int PushOverrideMusicState(uint stateValue) => default; // 0x00000001823B2490-0x00000001823B2590
	// [XID] // 0x0000000189979980-0x00000001899799A0
	public void PopOverrideMusicState() {} // 0x00000001823B3290-0x00000001823B33E0
	// [XID] // 0x0000000189A2B160-0x0000000189A2B180
	public void SetMusicStateFromAutomaton(uint stateValue) {} // 0x00000001823B23C0-0x00000001823B2490
	// [XID] // 0x0000000189A53A30-0x0000000189A53A50
	public void PostMusicTriggerFromAutomaton(uint triggerId) {} // 0x00000001823B17B0-0x00000001823B18E0
	// [XID] // 0x0000000189958740-0x0000000189958760
	public void SetCombatFiercenessRtpcValue(float value) {} // 0x00000001823B1A40-0x00000001823B1BB0
	// [XID] // 0x0000000189A41A20-0x0000000189A41A40
	public uint GetMusicStateGroupName() => default; // 0x00000001823B2AF0-0x00000001823B2C10
	// [XID] // 0x0000000189A49030-0x0000000189A49050
	public void Stop() {} // 0x00000001823B12F0-0x00000001823B13D0
	// [XID] // 0x0000000189A50920-0x0000000189A50940
	public void PostStimulus(MusicStimulus stimulus) {} // 0x00000001823B2D10-0x00000001823B2DF0
	// [XID] // 0x0000000189618370-0x0000000189618390
	public void PostUInt32Stimulus(MusicStimulus stimulus, uint parameter) {} // 0x00000001823B1D90-0x00000001823B1E90
	// [XID] // 0x0000000189A5FAB0-0x0000000189A5FAD0
	public void PostStringStimulus(MusicStimulus stimulus, string parameter) {} // 0x00000001823B13D0-0x00000001823B14D0
	// [XID] // 0x000000018969FA30-0x000000018969FA50
	public void Input(Input input) {} // 0x00000001823B1F30-0x00000001823B1FF0
	// [XID] // 0x0000000189698670-0x0000000189698690
	public void UpdateEnemyStatusParameters(EnemyStatusParameters parameters) {} // 0x00000001823B1BB0-0x00000001823B1CD0
	// [XID] // 0x0000000189A76270-0x0000000189A76290
	public void UpdateMapArea(uint areaStateValue, uint subStateGroup, uint defaultSubState) {} // 0x00000001823B2960-0x00000001823B2A50
	// [XID] // 0x0000000189A7DC60-0x0000000189A7DC80
	public void UpdateBoundary(string name) {} // 0x00000001823B18E0-0x00000001823B19A0
	// [XID] // 0x0000000189A854D0-0x0000000189A854F0
	public void RegisterCombatFiercenessTeller(ICombatFiercenessTeller teller) {} // 0x00000001823B1CD0-0x00000001823B1D90
	// [XID] // 0x0000000189667B10-0x0000000189667B30
	public void RemoveCombatFiercenessTeller() {} // 0x00000001823B2F40-0x00000001823B2FF0
	// [XID] // 0x0000000189A94210-0x0000000189A94230
	public void UpdateUInt32ParamValue(MusicGameParam gameParam, uint value) {} // 0x00000001823B30E0-0x00000001823B31E0
	// [XID] // 0x0000000189A47AB0-0x0000000189A47AD0
	public void UpdateFloatParamValue(MusicGameParam gameParam, float value) {} // 0x00000001823B2C10-0x00000001823B2D10
	// [XID] // 0x00000001898A2B00-0x00000001898A2B20
	public void UpdateStringParamValue(MusicGameParam gameParam, string value) {} // 0x00000001823B15B0-0x00000001823B16B0
	// [XID] // 0x0000000189AAA570-0x0000000189AAA590
	private void SubmitSwitchPhaseCmd(MusicOccasion phase) {} // 0x00000001823B2590-0x00000001823B2670
	// [XID] // 0x00000001898AA000-0x00000001898AA020
	private void StateTransitionCallback(StateTag from, StateTag to, Persistents persistents) {} // 0x00000001823B2670-0x00000001823B27D0
	// [XID] // 0x0000000189A31160-0x0000000189A31180
	private void UpdateTimeParamValue() {} // 0x00000001823B2FF0-0x00000001823B30E0
	// [XID] // 0x0000000189AC1450-0x0000000189AC1470
	private void SetMusicState(uint stateValue) {} // 0x00000001823B16B0-0x00000001823B17B0
}

