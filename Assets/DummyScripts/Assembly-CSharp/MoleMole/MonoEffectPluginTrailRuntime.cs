/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Serialization;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public sealed class MonoEffectPluginTrailRuntime : BaseMonoEffectPlugin // TypeDefIndex: 19742
	{
		// Fields
		public Transform PointStart; // 0x28
		public Transform PointEnd; // 0x30
		public int MaxFrame; // 0x38
		public int Granularity; // 0x3C
		public Color MyColor; // 0x40
		public UnityEngine.Material MyMaterial; // 0x50
		public float Duration; // 0x58
		public float FadeTime; // 0x5C
		public int InterPointCount; // 0x60
		// [FormerlySerializedAs] // 0x0000000189B5F8D0-0x0000000189B5F900
		public float LerpCenter; // 0x64
		// [FormerlySerializedAs] // 0x0000000189B67000-0x0000000189B67030
		public float MinChangeHeadDistance; // 0x68
		public SplineControlPoint[] FramePosList; // 0x70
		public int ClipHash; // 0x78
		private const float FRAME_DURATION = 0.016949153f; // Metadata: 0x00AFCCF1
		private float mTrailWidth; // 0x7C
		private WeaponSpline mSpline; // 0x80
		private float mFadeT; // 0x88
		private bool mIsFading; // 0x8C
		private float mFadeTime; // 0x90
		private float mFadeElapsedime; // 0x94
		private GameObject mMeshObj; // 0x98
		private bool mSetuped; // 0xA0
		private bool _toBeDeallocated; // 0xA1
		private float _StackTime; // 0xA4
		private float _Timer; // 0xA8
		private float _LastNorTime; // 0xAC
		private Vector3 _LastFramePos; // 0xB0
		private int _CurIndex; // 0xBC
		private int _stateHash; // 0xC0
		private Animator _animator; // 0xC8
		private Vector3[] AbsVertices; // 0xD0
		private Vector3[] _relativeVertices; // 0xD8
		private int[] Indices; // 0xE0
		private Vector2[] UVs; // 0xE8
		private Color[] Colors; // 0xF0
		private const int BlockSize = 108; // Metadata: 0x00AFCCF5
		private Mesh _mesh; // 0xF8
	
		// Properties
		private Vector3[] RelativeVertices { /* [XID] */ /* 0x0000000189B6FB20-0x0000000189B6FB40 */ get => default; } // 0x0000000183C97740-0x0000000183C97910 
		public Vector3 CurHeadPos { /* [XID] */ /* 0x0000000189B77030-0x0000000189B77050 */ get => default; } // 0x0000000183C99070-0x0000000183C99220 
	
		// Constructors
		public MonoEffectPluginTrailRuntime() {} // 0x0000000183C98F80-0x0000000183C99070
	
		// Methods
		// [XID] // 0x0000000189B7E6C0-0x0000000189B7E6E0
		public void OnAwaked() {} // 0x0000000183C980D0-0x0000000183C982B0
		// [XID] // 0x0000000189B86300-0x0000000189B86320
		public void RealSetup() {} // 0x0000000183C98980-0x0000000183C98E20
		// [XID] // 0x0000000189B8D3B0-0x0000000189B8D3D0
		private float GetNormalizedTime() => default; // 0x0000000183C972D0-0x0000000183C974B0
		// [XID] // 0x0000000189B94A70-0x0000000189B94A90
		public override void Init() {} // 0x0000000183C97580-0x0000000183C97630
		// [XID] // 0x0000000189B9C140-0x0000000189B9C160
		public void StopSmoothly(float fadeTime) {} // 0x0000000183C98EC0-0x0000000183C98F80
		// [XID] // 0x0000000189BA3890-0x0000000189BA38B0
		public override void LateTick(float inDeltaTime) {} // 0x0000000183C97910-0x0000000183C97C30
		// [XID] // 0x0000000189BAACE0-0x0000000189BAAD00
		private void OnDrawGizmos() {} // 0x0000000183C982B0-0x0000000183C988D0
		// [XID] // 0x0000000189BB22B0-0x0000000189BB22D0
		public override void Destroied() {} // 0x0000000183C96F70-0x0000000183C970A0
		// [XID] // 0x0000000189BB9640-0x0000000189BB9660
		public override void Disabled() {} // 0x0000000183C970A0-0x0000000183C97150
		// [XID] // 0x0000000189BC1580-0x0000000189BC15A0
		private void Start() {} // 0x0000000183C98E20-0x0000000183C98EC0
		// [XID] // 0x0000000189BC8CC0-0x0000000189BC8CE0
		public override void Awaked() {} // 0x0000000183C95F30-0x0000000183C95FE0
		// [XID] // 0x0000000189BD04A0-0x0000000189BD04C0
		private void RefreshSpline() {} // 0x0000000183C96190-0x0000000183C96EF0
		// [XID] // 0x0000000189BD79D0-0x0000000189BD79F0
		private Vector3 FramePosListLerp(float norm, int index) => default; // 0x0000000183C95180-0x0000000183C95830
		// [XID] // 0x0000000189BDF5A0-0x0000000189BDF5C0
		private void UpdateVertex() {} // 0x0000000183C95890-0x0000000183C95F30
		// [XID] // 0x00000001895EC110-0x00000001895EC130
		private void UpdateFade() {} // 0x0000000183C971B0-0x0000000183C972D0
		// [XID] // 0x00000001895F3590-0x00000001895F35B0
		private void InitMeshObj() {} // 0x0000000183C97C30-0x0000000183C980D0
		// [XID] // 0x00000001895FAEB0-0x00000001895FAED0
		private BaseEntity GetOriginalOwner() => default; // 0x0000000183C96040-0x0000000183C96190
		// [XID] // 0x00000001896026C0-0x00000001896026E0
		public override bool IsToBeDeallocated() => default; // 0x0000000183C97630-0x0000000183C976E0
		// [XID] // 0x000000018960A0B0-0x000000018960A0D0
		public override void OnSetEffectStop() {} // 0x0000000183C988D0-0x0000000183C98980
	}
}
