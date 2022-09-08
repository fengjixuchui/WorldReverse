/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoDamageText : MonoBehaviour // TypeDefIndex: 29704
	{
		// Fields
		private Dictionary<ElementType, UnityEngine.UI.Text> _elemtTextDict; // 0x18
		private float _speedX; // 0x20
		private uint _attackeeRuntimeID; // 0x24
		private Vector3 _positionOffset; // 0x28
		private float _uiPositionXOffset; // 0x34
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animation _animation; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _textAnimation; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _normalText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Outline _normalTextOutline; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UpdateMethod _updateMethod; // 0x58
		// [Range] // 0x0000000189B266B0-0x0000000189B266F0
		[SerializeField] // 0x0000000189B266B0-0x0000000189B266F0
		private float _smoothTime; // 0x5C
		// [Range] // 0x00000001899A72B0-0x00000001899A72F0
		[SerializeField] // 0x00000001899A72B0-0x00000001899A72F0
		private float _smoothFrame; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _normalFontSize; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _amplifyFontSize; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _criticalFontSize; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _currentVelocity; // 0x70
		public List<FontStyle> listFont; // 0x80
		public List<Color> listTextColor; // 0x88
		public List<Color> listOutLineColor; // 0x90
		private const string CURE_TEXT_ATTACH_POINT = "MoveHead"; // Metadata: 0x00B0FCA3
		private Transform _attachPoint; // 0xA0
		private Vector3 _beginPosition; // 0xA8
		public int greyIndex; // 0xB4
		public int selfIndex; // 0xB8
	
		// Properties
		public uint resourceHandle { /* [XID] */ /* 0x0000000189B639C0-0x0000000189B63A00 */ get; /* [XID] */ /* 0x0000000189B6DDE0-0x0000000189B6DE20 */ set; } // 0x0000000183F3FB30-0x0000000183F3FB90 0x0000000183F3FB90-0x0000000183F3FC00
	
		// Nested types
		public enum DamageShowType // TypeDefIndex: 29705
		{
			Normal = 0,
			Resist = 1,
			MuteElemHurt = 2,
			Self = 3
		}
	
		public enum DamageType // TypeDefIndex: 29706
		{
			Normal = 0,
			Amplify = 1,
			Critical = 2
		}
	
		private enum UpdateMethod // TypeDefIndex: 29707
		{
			DeltaTime = 0,
			FrameCount = 1
		}
	
		// Constructors
		public MonoDamageText() {} // 0x0000000183F3FA00-0x0000000183F3FB30
	
		// Methods
		// [XID] // 0x0000000189B785B0-0x0000000189B785D0
		public void SetupView(ElementType type, DamageType damageType, DamageShowType showType, float damage, string showDamageText, Vector3 pos, BaseEntity attackee) {} // 0x0000000183F3F020-0x0000000183F3F6F0
		// [XID] // 0x0000000189B7FB10-0x0000000189B7FB30
		public void SetupViewForCure(BaseEntity target, float addHP) {} // 0x0000000183F3EAE0-0x0000000183F3F020
		// [XID] // 0x0000000189B875A0-0x0000000189B875C0
		private void Update() {} // 0x0000000183F3F6F0-0x0000000183F3FA00
		// [XID] // 0x0000000189B8E6F0-0x0000000189B8E710
		private Vector3 GetUIPositionWithOffset(BaseEntity attackee) => default; // 0x0000000183F3E7A0-0x0000000183F3EAE0
		// [XID] // 0x0000000189B95C10-0x0000000189B95C30
		public static DamageShowType GetDamageShowTypeByResult(AttackResult result) => default; // 0x0000000183F3E6D0-0x0000000183F3E7A0
	}
}
