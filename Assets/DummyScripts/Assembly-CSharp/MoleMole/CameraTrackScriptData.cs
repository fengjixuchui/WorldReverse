/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Cinemachine;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x0000000189951A40-0x0000000189951A90
	public class CameraTrackScriptData : ScriptableObject // TypeDefIndex: 19580
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _baseLineLength_xz; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private float _deltaLookAngleRatio; // 0x1C
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public BaseLineData baseLine; // 0x20
		public CinemachineSmoothPath baseLinePath; // 0x28
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public CameraTrackData cameraNormalTrack; // 0x30
		public CinemachineSmoothPath cameraNormalTrackPath; // 0x38
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public CameraTrackData cameraSlopUpperTrack; // 0x40
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public CameraTrackData cameraSlopLowerTrack; // 0x48
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public CameraTrackContrictData cameraPoleMaxContrict; // 0x50
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public CameraTrackContrictData cameraPoleMinContrict; // 0x58
	
		// Properties
		public float BASELINE_LENGTH_XZ { /* [XID] */ /* 0x000000018999A050-0x000000018999A070 */ get => default; } // 0x0000000181AD8320-0x0000000181AD83D0 
		public float DELTA_LOOK_ANGLE_RATIO { /* [XID] */ /* 0x00000001899A1690-0x00000001899A16B0 */ get => default; } // 0x0000000181AD83D0-0x0000000181AD8480 
	
		// Constructors
		public CameraTrackScriptData() {} // 0x0000000181AD8290-0x0000000181AD8320
	
		// Methods
		// [XID] // 0x00000001899A9080-0x00000001899A90A0
		public float GetBaselinePosT(float dist) => default; // 0x0000000181AD7DB0-0x0000000181AD8090
		// [XID] // 0x00000001899B0B50-0x00000001899B0B70
		private Vector3 GetTrackPos(float posT) => default; // 0x0000000181AD8090-0x0000000181AD8190
		// [XID] // 0x00000001899B7DF0-0x00000001899B7E10
		private Vector3 GetBasePos(float posT) => default; // 0x0000000181AD7BB0-0x0000000181AD7CB0
		// [XID] // 0x00000001899BF970-0x00000001899BF990
		public Vector3 GetTrackPosByDist(float dist) => default; // 0x0000000181AD7CB0-0x0000000181AD7DB0
		// [XID] // 0x00000001899C71F0-0x00000001899C7210
		public Vector3 GetBaselinePosByDist(float dist) => default; // 0x0000000181AD8190-0x0000000181AD8290
	}
}
