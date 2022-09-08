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
	public class MonoReactionText : MonoBehaviour // TypeDefIndex: 29773
	{
		// Fields
		private Dictionary<ElementReactionType, UnityEngine.UI.Text> _reactionTextDict; // 0x18
		private UnityEngine.UI.Text _lastText; // 0x20
		private float _speedX; // 0x28
		private uint _attackeeRuntimeID; // 0x2C
		private Vector3 _initPosition; // 0x30
		private bool _hasInitPos; // 0x3C
		private Vector3 _positionOffset; // 0x40
		private float _uiPositionXOffset; // 0x4C
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Animation _animation; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UpdateMethod _updateMethod; // 0x58
		// [Range] // 0x000000018999C8B0-0x000000018999C8F0
		[SerializeField] // 0x000000018999C8B0-0x000000018999C8F0
		private float _smoothTime; // 0x5C
		// [Range] // 0x00000001899A72B0-0x00000001899A72F0
		[SerializeField] // 0x00000001899A72B0-0x00000001899A72F0
		private float _smoothFrame; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _normalFontSize; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _currentVelocity; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector3 _beginOffset; // 0x78
		private Transform _attachPoint; // 0x88
		private static readonly ElementReactionType[] _elementReactionValues; // 0x00
	
		// Properties
		public uint resourceHandle { /* [XID] */ /* 0x00000001899D2800-0x00000001899D2840 */ get; /* [XID] */ /* 0x00000001899DCC70-0x00000001899DCCB0 */ set; } // 0x000000018442E750-0x000000018442E7B0 0x000000018442E7B0-0x000000018442E810
	
		// Nested types
		private enum UpdateMethod // TypeDefIndex: 29774
		{
			DeltaTime = 0,
			FrameCount = 1
		}
	
		// Constructors
		static MonoReactionText() {} // 0x000000018442E570-0x000000018442E670
		public MonoReactionText() {} // 0x000000018442E670-0x000000018442E750
	
		// Methods
		// [XID] // 0x00000001899E7800-0x00000001899E7820
		public bool SetupView(ElementReactionType reaction, ElementType elemType1, ElementType elemType2, BaseEntity attackee) => default; // 0x000000018442DE30-0x000000018442E260
		// [XID] // 0x00000001899EED70-0x00000001899EED90
		private void Init() {} // 0x000000018442D570-0x000000018442DAD0
		// [XID] // 0x00000001899F6630-0x00000001899F6650
		private void Update() {} // 0x000000018442E260-0x000000018442E570
		// [XID] // 0x00000001899FDBB0-0x00000001899FDBD0
		private Vector3 GetUIPositionWithOffset(BaseEntity attackee) => default; // 0x000000018442DAD0-0x000000018442DE30
	}
}
