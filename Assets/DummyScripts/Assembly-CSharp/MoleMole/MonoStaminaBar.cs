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
	public class MonoStaminaBar : MonoBaseStamina // TypeDefIndex: 31266
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animation _animation; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private List<StaminaBar> _staminaBars; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private StaminaBar _tempBar; // 0x28
		private bool _afterFadeOut; // 0x48
		private const int FLEXIBLE_WIDTH = 128; // Metadata: 0x00B12136
		private float _temporaryStamina; // 0x4C
	
		// Properties
		public override float maxStamina { /* [XID] */ /* 0x0000000189846390-0x00000001898463B0 */ set {} } // 0x00000001850078A0-0x0000000185007B40
		public override float temporaryStamina { /* [XID] */ /* 0x000000018984D980-0x000000018984D9A0 */ set {} } // 0x0000000185007B40-0x0000000185007D00
		public override float currStamina { /* [XID] */ /* 0x00000001898549E0-0x0000000189854A00 */ set {} } // 0x00000001850076D0-0x00000001850078A0
	
		// Nested types
		[Serializable]
		public struct StaminaBar // TypeDefIndex: 31267
		{
			// Fields
			public RectTransform group; // 0x00
			public LayoutElement layoutElement; // 0x08
			public SmoothMask fill; // 0x10
			[ReadOnly] // 0x0000000189727BD0-0x0000000189727BE0
			public float fullRatio; // 0x18
		}
	
		// Constructors
		public MonoStaminaBar() {} // 0x0000000185007660-0x00000001850076D0
	
		// Methods
		// [XID] // 0x000000018982FF20-0x000000018982FF40
		private void OnDisable() {} // 0x00000001850075C0-0x0000000185007660
		// [XID] // 0x0000000189837660-0x0000000189837680
		public override void FadeOut() {} // 0x00000001850073A0-0x0000000185007460
		// [XID] // 0x000000018983ED50-0x000000018983ED70
		public override void FadeInIfNeeded() {} // 0x00000001850072E0-0x00000001850073A0
	}
}
