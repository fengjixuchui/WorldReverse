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
	public class MonoStaminaInfo : MonoBaseStamina // TypeDefIndex: 31268
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		protected Animator _animator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected StaminaBar[] _staminaBars; // 0x20
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected StaminaBar _tempBar; // 0x28
		private MonoAttachToPoint _attachCom; // 0x48
	
		// Properties
		public override float maxStamina { /* [XID] */ /* 0x000000018989F9D0-0x000000018989F9F0 */ set {} } // 0x00000001850086A0-0x00000001850089E0
		public override float temporaryStamina { /* [XID] */ /* 0x00000001898A73E0-0x00000001898A7400 */ set {} } // 0x00000001850089E0-0x0000000185008B50
		public override float currStamina { /* [XID] */ /* 0x00000001898AEDA0-0x00000001898AEDC0 */ set {} } // 0x0000000185008540-0x00000001850086A0
	
		// Nested types
		[Serializable]
		public struct StaminaBar // TypeDefIndex: 31269
		{
			// Fields
			public RectTransform group; // 0x00
			public SmoothMask fill; // 0x08
			public SmoothMask background; // 0x10
			public SmoothMask blur; // 0x18
		}
	
		// Constructors
		public MonoStaminaInfo() {} // 0x00000001850084D0-0x0000000185008540
	
		// Methods
		// [XID] // 0x0000000189882570-0x0000000189882590
		public void Awake() {} // 0x0000000185007D60-0x0000000185007E10
		// [XID] // 0x0000000189889C50-0x0000000189889C70
		public override void FadeInIfNeeded() {} // 0x0000000185007EF0-0x0000000185008090
		// [XID] // 0x00000001898911C0-0x00000001898911E0
		public override void FadeOut() {} // 0x0000000185008090-0x0000000185008230
		// [XID] // 0x00000001898987D0-0x00000001898987F0
		public override void Hide() {} // 0x0000000185008310-0x0000000185008450
	}
}
