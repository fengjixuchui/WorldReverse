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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AudioAvatarMovePlugin : AudioMovePlugin // TypeDefIndex: 12000
{
	// Fields
	private const int TICK_INTERVAL = 4; // Metadata: 0x00AEB360
	private static readonly ConditionalNamedStateAudioEvent<VCBaseMove.BaseMoveState> _hashConverter; // 0x00
	private ConfigAudioAvatarMove _avatarMoveConfig; // 0x78
	private float _lastFrameSpeed; // 0x80
	private float _lastTimeInAirflow; // 0x84
	private VCBaseMove.BaseMoveState _lastMoveState; // 0x88
	private Animator _animator; // 0x90
	private StateTriggeredAudioEvent<VCBaseMove.BaseMoveState> _enterStateEvents; // 0x98
	private StateTriggeredAudioEvent<VCBaseMove.BaseMoveState> _exitStateEvents; // 0xA0
	private VCHumanoidMove _moveComponent; // 0xA8
	private FlyTurnEventTicker _flyTurnEventTicker; // 0xB0
	private int _tickIntervalCounter; // 0xB8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189865ED0-0x0000000189865EF0 */ get => default; } // 0x00000001843177B0-0x0000000184317850 

	// Nested types
	private class MoveStateConverter : ConditionalNamedStateAudioEvent<VCBaseMove.BaseMoveState> // TypeDefIndex: 12001
	{
		// Constructors
		public MoveStateConverter() {} // 0x0000000182EC38F0-0x0000000182EC3950

		// Methods
		// [XID] // 0x000000018992FD10-0x000000018992FD30
		public VCBaseMove.BaseMoveState Convert(string nextStateName) => default; // 0x0000000182EC37A0-0x0000000182EC38F0
	}

	private class EventPoster : IAudioEventPoster // TypeDefIndex: 12002
	{
		// Fields
		private AudioAvatarMovePlugin _host; // 0x10

		// Constructors
		public EventPoster() {} // Dummy constructor
		public EventPoster(AudioAvatarMovePlugin host) {} // 0x0000000182EC3D90-0x0000000182EC3E00

		// Methods
		// [XID] // 0x0000000189937230-0x0000000189937250
		public void PostEvent(uint eventId) {} // 0x0000000182EC3CA0-0x0000000182EC3D90
	}

	private class SwitchSetter : IAudioSwitchSetter // TypeDefIndex: 12003
	{
		// Fields
		private AudioAvatarMovePlugin _host; // 0x10

		// Constructors
		public SwitchSetter() {} // Dummy constructor
		public SwitchSetter(AudioAvatarMovePlugin host) {} // 0x0000000182EC4010-0x0000000182EC4080

		// Methods
		// [XID] // 0x000000018993ED20-0x000000018993ED40
		public void SetSwitch(uint key, uint value) {} // 0x0000000182EC3F00-0x0000000182EC4010
	}

	private class FlyTurnEventTicker // TypeDefIndex: 12004
	{
		// Fields
		private readonly VCHumanoidMove _move; // 0x10
		private readonly EventPoster _eventPoster; // 0x18
		private uint _eventId; // 0x20
		private float _interval; // 0x24
		private float _time; // 0x28

		// Constructors
		public FlyTurnEventTicker() {} // Dummy constructor
		public FlyTurnEventTicker(VCHumanoidMove move, EventPoster eventPoster) {} // 0x0000000182EC3710-0x0000000182EC37A0

		// Methods
		// [XID] // 0x00000001899463F0-0x0000000189946410
		public void Setup(uint eventId, float interval) {} // 0x0000000182EC3490-0x0000000182EC3560
		// [XID] // 0x000000018994DB00-0x000000018994DB20
		public void Tick(float angle) {} // 0x0000000182EC3560-0x0000000182EC3710
		// [XID] // 0x0000000189955100-0x0000000189955120
		public void Reset() {} // 0x0000000182EC33F0-0x0000000182EC3490
	}

	// Constructors
	public AudioAvatarMovePlugin() {} // Dummy constructor
	static AudioAvatarMovePlugin() {} // 0x00000001843176B0-0x0000000184317730
	public AudioAvatarMovePlugin(VCBaseAudio owner) {} // 0x0000000184317730-0x00000001843177B0

	// Methods
	// [XID] // 0x000000018986D550-0x000000018986D570
	public override void Init() {} // 0x00000001843162F0-0x0000000184316510
	// [XID] // 0x00000001898749D0-0x00000001898749F0
	public override void Tick(float deltaTime) {} // 0x00000001843175E0-0x00000001843176B0
	// [XID] // 0x000000018987C5C0-0x000000018987C5E0
	private static new EventID[] GetSelfOnEventIDsExcludingBase() => default; // 0x0000000184315C80-0x0000000184315D60
	// [XID] // 0x0000000189883670-0x0000000189883690
	public override bool OnEvent(BaseEvent e) => default; // 0x0000000184317020-0x0000000184317110
	// [XID] // 0x00000001897812E0-0x0000000189781300
	public void SetMoveStateAudioConfig(ConfigMoveStateAudio config) {} // 0x00000001843156A0-0x0000000184315870
	// [XID] // 0x00000001896B5780-0x00000001896B57A0
	public void PostEnterSpeedupFieldEvent() {} // 0x0000000184315B60-0x0000000184315C80
	// [XID] // 0x0000000189899CD0-0x0000000189899CF0
	protected override void TickMoveParameters() {} // 0x0000000184315000-0x0000000184315150
	// [XID] // 0x00000001898A0E90-0x00000001898A0EB0
	protected override void TickMoveStateParameters() {} // 0x0000000184316E80-0x0000000184316F30
	// [XID] // 0x00000001898A8460-0x00000001898A8480
	private bool HandleEvtFallOnGround(EvtFallOnGround evt) => default; // 0x00000001843168B0-0x0000000184316A40
	// [XID] // 0x00000001898B0010-0x00000001898B0030
	private void TickStateChange(VCBaseMove.BaseMoveState currentState) {} // 0x00000001843159C0-0x0000000184315AE0
	// [XID] // 0x00000001898B7450-0x00000001898B7470
	private void TickMoveStateSlopeCline() {} // 0x0000000184316A40-0x0000000184316BE0
	// [XID] // 0x00000001898BEC00-0x00000001898BEC20
	private void TickAirStateParameters() {} // 0x0000000184315870-0x00000001843159C0
	// [XID] // 0x00000001898C64C0-0x00000001898C64E0
	private void TickFlyStateParameters() {} // 0x0000000184316F30-0x0000000184317020
	// [XID] // 0x00000001898CDBB0-0x00000001898CDBD0
	private void TickFlyDirectionRtpc(float angle) {} // 0x0000000184315D60-0x0000000184315F80
	// [XID] // 0x00000001898D55B0-0x00000001898D55D0
	private void TickFlySpeedRtpc() {} // 0x0000000184316D30-0x0000000184316E80
	// [XID] // 0x00000001898DCEF0-0x00000001898DCF10
	private void TickClimbStateParameters() {} // 0x0000000184316100-0x00000001843162F0
	// [XID] // 0x00000001898E49D0-0x00000001898E49F0
	private void TickAllStateParameters() {} // 0x0000000184317110-0x0000000184317310
	// [XID] // 0x00000001898EC330-0x00000001898EC350
	private float CalcFlySpeedRtpcValue() => default; // 0x0000000184315150-0x0000000184315360
	// [XID] // 0x00000001898F3CE0-0x00000001898F3D00
	private float CalcAirflowSpeedGain() => default; // 0x00000001843173F0-0x00000001843175E0
	// [XID] // 0x00000001898FB210-0x00000001898FB230
	private void SetLastFrameSpeedInAir() {} // 0x0000000184314E90-0x0000000184315000
	// [XID] // 0x0000000189902E20-0x0000000189902E40
	private float CalcAngleBetweenEntityAndCamera() => default; // 0x0000000184315F80-0x0000000184316100
	// [XID] // 0x000000018990A470-0x000000018990A490
	private void GetAnglesBetweenCameraAndAvatar(out float x, out float y) {
		x = default;
		y = default;
	} // 0x0000000184315360-0x0000000184315640
	// [XID] // 0x0000000189911E90-0x0000000189911EB0
	private void GetCameraAndAvatarFront(out Vector3 cameraFront, out Vector3 avatarFront) {
		cameraFront = default;
		avatarFront = default;
	} // 0x0000000184316510-0x0000000184316750
	// [XID] // 0x0000000189919900-0x0000000189919920
	private float GetAvatarAltitude() => default; // 0x0000000184314CD0-0x0000000184314E30
	// [XID] // 0x0000000189920E50-0x0000000189920E70
	private CameraEntity GetCameraEntity() => default; // 0x0000000184317310-0x00000001843173F0
	// [XID] // 0x0000000189928890-0x00000001899288B0
	private void RegisterSurfaceTypeEvent() {} // 0x0000000184316750-0x00000001843168B0
}

