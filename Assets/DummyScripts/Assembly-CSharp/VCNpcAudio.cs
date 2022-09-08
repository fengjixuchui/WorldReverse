/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class VCNpcAudio : VCGadgetAudio, IVoiceStreamEmployer, IDialogSpeechPoster, IAudioPotentialPatroller // TypeDefIndex: 11919
{
	// Fields
	private AudioGadgetVoiceStreamPlugin _voiceStream; // 0x148
	private AudioGadgetDialogVoicePlugin _dialogVoice; // 0x150
	private Transform _vocalBone; // 0x158
	private SyncId _vocalBoneSyncId; // 0x160
	private AudioPatrollerPlugin _patrollerPlugin; // 0x178
	private bool _isBeingDestroyed; // 0x180

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899A2350-0x00000001899A2370 */ get => default; } // 0x00000001828ADD30-0x00000001828ADDD0 

	// Constructors
	public VCNpcAudio() {} // 0x00000001828ADCD0-0x00000001828ADD30

	// Methods
	// [XID] // 0x00000001899A9BA0-0x00000001899A9BC0
	public override void Init() {} // 0x00000001828AD3F0-0x00000001828AD560
	// [XID] // 0x0000000189BD6E70-0x0000000189BD6E90
	public override void OnDisable() {} // 0x00000001828ADC10-0x00000001828ADCD0
	// [XID] // 0x0000000189BDEB60-0x0000000189BDEB80
	public override void Destroy() {} // 0x00000001828ACA00-0x00000001828ACAD0
	// [XID] // 0x00000001899C02B0-0x00000001899C02D0
	public override void PostEvent(uint eventId) {} // 0x00000001828AD240-0x00000001828AD3F0
	// [XID] // 0x00000001899C7B30-0x00000001899C7B50
	public override void Stop() {} // 0x00000001828AC650-0x00000001828AC7B0
	// [XID] // 0x0000000189609520-0x0000000189609540
	void MoleMole.IAudioPotentialPatroller.AddPatrollerPlugin() {} // 0x00000001828AD8B0-0x00000001828AD990
	// [XID] // 0x00000001899D67F0-0x00000001899D6810
	void MoleMole.IAudioPotentialPatroller.RemovePatrollerPlugin() {} // 0x00000001828AD990-0x00000001828ADA50
	// [XID] // 0x00000001899DDEB0-0x00000001899DDED0
	public void PostVoiceEvent(uint eventId) {} // 0x00000001828AD700-0x00000001828AD8B0
	// [XID] // 0x00000001899E5C50-0x00000001899E5C70
	public AudioVoiceStreamPlugin GetVoiceStreamPlugin() => default; // 0x00000001828ADA50-0x00000001828ADB00
	// [XID] // 0x00000001899ECCE0-0x00000001899ECD00
	public AudioDialogVoicePlugin GetDialogVoicePlugin() => default; // 0x00000001828ACAD0-0x00000001828ACB80
	// [XID] // 0x00000001899F4A40-0x00000001899F4A60
	protected override ConfigGadgetAudio GetConfig() => default; // 0x00000001828AC810-0x00000001828AC8F0
	// [XID] // 0x00000001899FC080-0x00000001899FC0A0
	private void FindVocalBone() {} // 0x00000001828ACD30-0x00000001828ACF30
	// [XID] // 0x0000000189A03490-0x0000000189A034B0
	private string GetVocalBoneName() => default; // 0x00000001828ADB00-0x00000001828ADC10
	// [XID] // 0x0000000189BC7DA0-0x0000000189BC7DC0
	private void RegisterVocalBone() {} // 0x00000001828ACF90-0x00000001828AD130
	// [XID] // 0x00000001895F29E0-0x00000001895F2A00
	private void UnregisterVocalBone() {} // 0x00000001828ACB80-0x00000001828ACCC0
	// [XID] // 0x0000000189A19750-0x0000000189A19770
	private void ReportPotentialPatrollerCreated() {} // 0x00000001828AC8F0-0x00000001828ACA00
	// [XID] // 0x0000000189A20DD0-0x0000000189A20DF0
	private void ReportPotentialPatrollerDestroyed() {} // 0x00000001828AD130-0x00000001828AD240
}

