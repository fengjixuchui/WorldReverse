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

namespace MoleMole
{
	[Serializable]
	public struct HeadControllerStyle // TypeDefIndex: 19612
	{
		// Fields
		public HCInAvatarView inAvatarView; // 0x00
		public HCInWeaponView inWeaponView; // 0x60
		public HCInRelicView inRelicView; // 0x80
	
		// Nested types
		[Serializable]
		public struct HCState // TypeDefIndex: 19613
		{
			// Fields
			[SerializeField] // 0x0000000189765340-0x0000000189765390
			// [Tooltip] // 0x0000000189765340-0x0000000189765390
			private float _angleSpeed; // 0x00
			[SerializeField] // 0x0000000189771460-0x00000001897714B0
			// [Tooltip] // 0x0000000189771460-0x00000001897714B0
			private Range _time; // 0x04
			[SerializeField] // 0x000000018977D390-0x000000018977D3E0
			// [Tooltip] // 0x000000018977D390-0x000000018977D3E0
			private AngleRange[] _conditionAngleRange; // 0x10
			[SerializeField] // 0x00000001897892E0-0x0000000189789320
			// [Tooltip] // 0x00000001897892E0-0x0000000189789320
			private AngleRange[] _randomAngleRange; // 0x18
	
			// Nested types
			[Serializable]
			private struct Range // TypeDefIndex: 19614
			{
				// Fields
				[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
				private float _min; // 0x00
				[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
				private float _max; // 0x04
	
				// Methods
				// [XID] // 0x00000001897C3250-0x00000001897C3270
				public bool InRange(float value) => default; // 0x0000000182BC97E0-0x0000000182BC97F0
				// [XID] // 0x00000001899434F0-0x0000000189943510
				public float Get() => default; // 0x0000000182BC96E0-0x0000000182BC97E0
			}
	
			[Serializable]
			private struct AngleRange // TypeDefIndex: 19615
			{
				// Fields
				[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
				private Range _horizonAngleRange; // 0x00
				[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
				private Range _verticalAngleRange; // 0x08
	
				// Methods
				// [XID] // 0x00000001897E1180-0x00000001897E11A0
				public bool IsInAngleRange(float horizonAngle, float verticalAngle) => default; // 0x0000000182BACAF0-0x0000000182BACBE0
				// [XID] // 0x0000000189959A90-0x0000000189959AB0
				public Vector2 GetRandomAngle() => default; // 0x0000000182BACBE0-0x0000000182BACBF0
			}
	
			// Methods
			// [XID] // 0x0000000189794F80-0x0000000189794FA0
			public float GetAngleSpeed() => default; // 0x0000000182BAD140-0x0000000182BAD2B0
			// [XID] // 0x000000018993C150-0x000000018993C170
			public float GetTime() => default; // 0x0000000182BAD080-0x0000000182BAD140
			// [XID] // 0x00000001899613D0-0x00000001899613F0
			public bool CheckCondition(float horizonAngle, float verticalAngle) => default; // 0x0000000182BAD410-0x0000000182BAD880
			// [XID] // 0x0000000189952570-0x0000000189952590
			public Vector2 GetRandomAngle() => default; // 0x0000000182BAD2B0-0x0000000182BAD410
		}
	
		[Serializable]
		public struct HCInAvatarView // TypeDefIndex: 19616
		{
			// Fields
			public HCState waitState; // 0x00
			public HCState randomPosState; // 0x20
			public HCState lookCameraState; // 0x40
		}
	
		[Serializable]
		public struct HCInWeaponView // TypeDefIndex: 19617
		{
			// Fields
			public HCState weaponState; // 0x00
		}
	
		[Serializable]
		public struct HCInRelicView // TypeDefIndex: 19618
		{
			// Fields
			public HCState relicState; // 0x00
		}
	}
}
