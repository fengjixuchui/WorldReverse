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
	public class WindFlag : MonoBehaviour // TypeDefIndex: 31997
	{
		// Fields
		public WindBoneConfig config; // 0x18
		public WindBone[] windBones; // 0x20
		public SpringMagicBone[] springMagicBones; // 0x28
		private QualityLevel m_qualityLevel; // 0x30
		public QualityLevel runtimeQualityLevel; // 0x34
		private float _windLevel; // 0x38
		private Vector3 _windDirection; // 0x3C
		private bool _inited; // 0x48
	
		// Properties
		public QualityLevel qualityLevel { /* [XID] */ /* 0x00000001899A2760-0x00000001899A2780 */ get => default; /* [XID] */ /* 0x00000001899AA110-0x00000001899AA130 */ set {} } // 0x0000000181D8E320-0x0000000181D8E3C0 0x0000000181D8E3C0-0x0000000181D8E570
	
		// Nested types
		public enum QualityLevel // TypeDefIndex: 31998
		{
			None = 0,
			Low = 1,
			Medium = 2,
			High = 3,
			ExtraHigh = 4
		}
	
		// Constructors
		public WindFlag() {} // 0x0000000181D8E2B0-0x0000000181D8E320
	
		// Methods
		// [XID] // 0x00000001899B1AC0-0x00000001899B1AE0
		private void Start() {} // 0x0000000181D8DDB0-0x0000000181D8E160
		// [XID] // 0x00000001899B8E20-0x00000001899B8E40
		private void OnDisable() {} // 0x0000000181D8DB30-0x0000000181D8DDB0
		// [IDTag] // 0x00000001899C0680-0x00000001899C06C0
		// [XID] // 0x00000001899C0680-0x00000001899C06C0
		private void SetWindValue(WindBone _windBone, WindFlagTemplate from, WindFlagTemplate to, float t) {} // 0x0000000181D8D120-0x0000000181D8D690
		// [IDTag] // 0x00000001899CB010-0x00000001899CB050
		// [XID] // 0x00000001899CB010-0x00000001899CB050
		private void SetWindValue(SpringMagicBone _springMagicBone, WindFlagTemplate from, WindFlagTemplate to, float t) {} // 0x0000000181D8CEF0-0x0000000181D8D120
		// [XID] // 0x00000001899D55F0-0x00000001899D5610
		private void Update() {} // 0x0000000181D8E200-0x0000000181D8E2B0
		// [IDTag] // 0x00000001899DC9B0-0x00000001899DC9F0
		// [XID] // 0x00000001899DC9B0-0x00000001899DC9F0
		public void UpdateQuality() {} // 0x0000000181D8E160-0x0000000181D8E200
		// [XID] // 0x00000001899E7600-0x00000001899E7620
		private void UpdateWindValue() {} // 0x0000000181D8D690-0x0000000181D8DB30
		// [IDTag] // 0x00000001899EEB90-0x00000001899EEBD0
		// [XID] // 0x00000001899EEB90-0x00000001899EEBD0
		private void UpdateQuality(SpringMagicBone _springMagicBone) {} // 0x0000000181D8CC60-0x0000000181D8CDC0
		// [IDTag] // 0x00000001899F9460-0x00000001899F94A0
		// [XID] // 0x00000001899F9460-0x00000001899F94A0
		private void UpdateQuality(WindBone _windBone) {} // 0x0000000181D8CDC0-0x0000000181D8CEF0
	}
}
