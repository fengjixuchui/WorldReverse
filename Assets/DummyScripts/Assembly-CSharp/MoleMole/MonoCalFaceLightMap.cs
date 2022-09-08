/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCalFaceLightMap : MonoBehaviour // TypeDefIndex: 26502
	{
		// Fields
		private static readonly string TEXTURE_PICS_FOLDER; // 0x00
		private static readonly string PIC_PRE_NAME; // 0x08
		public float LightXStartAngle; // 0x18
		public float LightXEndAngle; // 0x1C
		public float LightYStartAngle; // 0x20
		public float LightYEndAngle; // 0x24
		private Texture2D _texA; // 0x28
		private Texture2D _texB; // 0x30
		// [Header] // 0x00000001899DFF90-0x00000001899DFFC0
		public bool UsingUncompressedLightMapForCheck; // 0x38
		// [Header] // 0x00000001899E8F40-0x00000001899E8F70
		public bool UsingInterploating; // 0x39
		// [Header] // 0x00000001899F21C0-0x00000001899F21F0
		public bool IsInterpolateOddFrames; // 0x3A
		// [Header] // 0x00000001899FB270-0x00000001899FB2A0
		public Transform AttachedBone; // 0x40
		// [Header] // 0x0000000189A03DA0-0x0000000189A03DD0
		public Transform OriginalAttachedBone; // 0x48
		// [Header] // 0x0000000189A0CA90-0x0000000189A0CAC0
		public string DirLightName; // 0x50
		// [Header] // 0x0000000189A15B00-0x0000000189A15B30
		public AnimationCurve YAngleMapCurve; // 0x58
		// [Header] // 0x0000000189A1E640-0x0000000189A1E670
		public float LowSpeedThreshold; // 0x60
		// [Header] // 0x0000000189A27210-0x0000000189A27240
		public float SpeedLerpParam; // 0x64
		// [Header] // 0x0000000189A30190-0x0000000189A301C0
		public AngleSection[] HorizonKeyAngleSections; // 0x68
		// [Header] // 0x0000000189A391B0-0x0000000189A391E0
		public AngleSection[] VerticalKeyAngleSections; // 0x70
		private Renderer[] _renders; // 0x78
		private MaterialPropertyBlock _mpb; // 0x80
		private Texture2D _prevRowStateTex; // 0x88
		private Texture2D _curRowStateTex; // 0x90
		private int _usingRGToGetRowState; // 0x98
		private int _isFlipLightMapInHorizon; // 0x9C
		private int _yAngleSetInMaterial; // 0xA0
		private int _xAngleChosedByManger; // 0xA4
		private static readonly int ANGLE_NUM; // 0x10
		private Vector3 _curDeltaAngle; // 0xA8
		private Vector3 _prevDeltaAngle; // 0xB4
		private GameObject _dirLight; // 0xC0
		private Vector3 _prevSpeed; // 0xC8
		private Vector3 _curSpeed; // 0xD4
		private bool[] _isInLowSpeedState; // 0xE0
		private bool[] _isInIncreasingOrder; // 0xE8
		private bool[] _isInStaticState; // 0xF0
		private bool _updateStaticState; // 0xF8
		private static readonly float STATIC_DEGREE_EPSILON; // 0x14
		private static readonly int YANGLE_OFFSET_WHNE_COMPRESSING; // 0x18
	
		// Nested types
		public enum AngleAxisType // TypeDefIndex: 26503
		{
			Vertical = 0,
			Horizon = 1
		}
	
		// Constructors
		public MonoCalFaceLightMap() {} // 0x0000000184805090-0x00000001848051D0
		static MonoCalFaceLightMap() {} // 0x0000000184804FE0-0x0000000184805090
	
		// Methods
		// [XID] // 0x0000000189A42220-0x0000000189A42240
		private void Awake() {} // 0x0000000184803220-0x00000001848032C0
		[DebuggerHidden] // 0x0000000189A497D0-0x0000000189A49810
		// [XID] // 0x0000000189A497D0-0x0000000189A49810
		private IEnumerator Cleantextures() => default; // 0x00000001848043D0-0x00000001848044D0
		// [XID] // 0x0000000189A54000-0x0000000189A54020
		private void CalDeltaAngle() {} // 0x00000001848044D0-0x0000000184804910
		// [XID] // 0x0000000189A5BA10-0x0000000189A5BA30
		private void Update() {} // 0x0000000184804E80-0x0000000184804FE0
		// [XID] // 0x0000000189A63120-0x0000000189A63140
		private void UpdateRotationSpeedState() {} // 0x0000000184803660-0x0000000184803A40
		// [XID] // 0x0000000189A6ACA0-0x0000000189A6ACC0
		private string[] GetTextureRelativePaths(out float windowRadiusRatio) {
			windowRadiusRatio = default;
			return default;
		} // 0x0000000184803A40-0x00000001848043D0
		// [XID] // 0x0000000189A72300-0x0000000189A72320
		private void SetTextures() {} // 0x0000000184804910-0x0000000184804E80
		// [XID] // 0x0000000189A79FC0-0x0000000189A79FE0
		private void SetCompressLightMap() {} // 0x0000000184802A60-0x0000000184802F80
		// [XID] // 0x0000000189A81460-0x0000000189A81480
		private int GetSection(float inAngle, AngleSection[] sections) => default; // 0x00000001848032C0-0x00000001848033E0
		// [XID] // 0x0000000189A88E80-0x0000000189A88EA0
		private float GetAngle(float inAngle, float prevInAngle, AngleAxisType angleType, AngleSection[] keyAngleSections) => default; // 0x0000000184802F80-0x0000000184803220
		// [IDTag] // 0x0000000189A905F0-0x0000000189A90630
		// [XID] // 0x0000000189A905F0-0x0000000189A90630
		private float NormalizeAngle(float angle) => default; // 0x00000001848033E0-0x00000001848034D0
		// [IDTag] // 0x0000000189A9AE30-0x0000000189A9AE70
		// [XID] // 0x0000000189A9AE30-0x0000000189A9AE70
		private Vector3 NormalizeAngle(Vector3 angle) => default; // 0x00000001848034D0-0x0000000184803660
	}
}
