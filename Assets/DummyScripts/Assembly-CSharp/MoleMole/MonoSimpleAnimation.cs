/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x0000000189AF2A80-0x0000000189AF2AF0
	// [RequireComponent] // 0x0000000189AF2A80-0x0000000189AF2AF0
	public sealed class MonoSimpleAnimation : MonoAuxObject // TypeDefIndex: 19834
	{
		// Fields
		// [Header] // 0x0000000189B2DD80-0x0000000189B2DDB0
		public bool useKeyedRotation; // 0x28
		// [Header] // 0x0000000189B0A820-0x0000000189B0A850
		public Vector3 keyedRotation; // 0x2C
		public bool useAnimRotation; // 0x38
		// [Header] // 0x0000000189B134A0-0x0000000189B134D0
		public bool useKeyedRadialBlur; // 0x39
		public Vector2 radialBlurCenter; // 0x3C
		public float radialBlurStrenth; // 0x44
		public float radialBlurScatterScale; // 0x48
		// [Header] // 0x0000000189B1C610-0x0000000189B1C640
		public GameObject realAnimGameObject; // 0x50
		// [Header] // 0x0000000189B251E0-0x0000000189B25210
		public bool useFixedParentAnchor; // 0x58
		// [Header] // 0x0000000189B2DD80-0x0000000189B2DDB0
		public bool useKeyedFOV; // 0x59
		// [Header] // 0x0000000189B351B0-0x0000000189B351E0
		public float keyedFOV; // 0x5C
		// [Header] // 0x0000000189B3E430-0x0000000189B3E460
		public bool useKeyedDirectionalLightRotation; // 0x60
		// [Header] // 0x0000000189B47570-0x0000000189B475A0
		public Vector3 keyedDirectionalLightRotation; // 0x64
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool hasPushedLevelTimeScale; // 0x70
		// [Header] // 0x0000000189B57F30-0x0000000189B57F60
		public Vector3 DefaultOffset; // 0x74
		// [Header] // 0x0000000189B6B5C0-0x0000000189B6B5F0
		public float initFOV; // 0x88
		// [Header] // 0x0000000189B74240-0x0000000189B74270
		public float initClipZNear; // 0x8C
		// [Header] // 0x0000000189B7CEB0-0x0000000189B7CEE0
		public TimeScaleMode timeScaleMode; // 0x90
		// [Header] // 0x0000000189B862D0-0x0000000189B86300
		public Graphic[] graphics; // 0x98
		[NonSerialized]
		public bool selfUpdateKeyedRotation; // 0xA0
		// [Header] // 0x0000000189B8EB60-0x0000000189B8EB90
		public bool UseSpecificCircleTrack; // 0xA1
		// [Header] // 0x0000000189B97970-0x0000000189B979A0
		public CircleTrack circleTrack; // 0xA8
		private bool _hasSetCircleStartTime; // 0xB0
		private float _circleStartTime; // 0xB4
		private Vector3 _circleLookAtPos; // 0xB8
		private Animation _animation; // 0xC8
		private float _sampleTimer; // 0xD0
		private AnimationState _animationState; // 0xD8
		private float _lastTimeScale; // 0xE0
		private int _levelEntityTimescalIx; // 0xE4
	
		// Properties
		public Transform ownedParent { /* [XID] */ /* 0x0000000189BA04F0-0x0000000189BA0530 */ get; /* [XID] */ /* 0x0000000189BAAC80-0x0000000189BAACC0 */ private set; } // 0x000000018412A890-0x000000018412A8F0 0x00000001841292B0-0x0000000184129320
	
		// Nested types
		public enum TimeScaleMode // TypeDefIndex: 19835
		{
			DoNothing = 0,
			IgnoreTimeScale = 1,
			UseLevelTimeScale = 2
		}
	
		[Serializable]
		public class CircleTrack // TypeDefIndex: 19836
		{
			// Fields
			public float radius; // 0x10
			public float angularSpeed; // 0x14
			public float startAngle; // 0x18
			public float elevation; // 0x1C
			public bool isAntiClockwise; // 0x20
			public GameObject centerPos; // 0x28
	
			// Constructors
			public CircleTrack() {} // 0x0000000184FF2CA0-0x0000000184FF2D20
		}
	
		// Constructors
		public MonoSimpleAnimation() {} // 0x000000018412A730-0x000000018412A890
	
		// Methods
		// [XID] // 0x0000000189BB5140-0x0000000189BB5160
		private void Awake() {} // 0x0000000184128F40-0x0000000184129130
		// [XID] // 0x0000000189BBC780-0x0000000189BBC7A0
		private void Start() {} // 0x0000000184129820-0x0000000184129DE0
		// [XID] // 0x0000000189BC43A0-0x0000000189BC43C0
		public void SyncRotation() {} // 0x0000000184129F40-0x000000018412A070
		// [XID] // 0x0000000189BCBE20-0x0000000189BCBE40
		public void SyncRadialBlur() {} // 0x0000000184129DE0-0x0000000184129F40
		// [XID] // 0x0000000189BD3310-0x0000000189BD3330
		public void SetOwnedParent(Transform ownedParent) {} // 0x00000001841295F0-0x0000000184129820
		// [XID] // 0x0000000189BDACA0-0x0000000189BDACC0
		private void OnDestroy() {} // 0x0000000184129320-0x0000000184129490
		// [XID] // 0x00000001895E7580-0x00000001895E75A0
		private void PushLevelTimeScale(float timescale) {} // 0x0000000184129130-0x00000001841292B0
		// [XID] // 0x00000001895EEE80-0x00000001895EEEA0
		private void PopLevelTimeScale() {} // 0x0000000184129490-0x00000001841295F0
		// [XID] // 0x00000001895F68C0-0x00000001895F68E0
		private void Update() {} // 0x000000018412A070-0x000000018412A730
	}
}
