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
	public class MonoPickupListItem : MonoReusableListItem // TypeDefIndex: 31130
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected Animator _animator; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private CanvasGroup _canvasGroup; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _actionButton; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text textItem; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _icon; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bg; // 0x48
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _keyContainer; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animation _animation; // 0x58
		private Animator _actionButtonAnimator; // 0x60
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x00000001897B6790-0x00000001897B67B0 */ get => default; } // 0x000000018371D4A0-0x000000018371D540 
		public Image iconImage { /* [XID] */ /* 0x00000001897BE5D0-0x00000001897BE5F0 */ get => default; } // 0x000000018371D540-0x000000018371D5E0 
		public string text { /* [XID] */ /* 0x00000001897CD4A0-0x00000001897CD4C0 */ get => default; /* [XID] */ /* 0x00000001897C5C80-0x00000001897C5CA0 */ set {} } // 0x000000018371D680-0x000000018371D740 0x000000018371D930-0x000000018371DA00
		public Color textColor { /* [XID] */ /* 0x00000001897D4AC0-0x00000001897D4AE0 */ set {} } // 0x000000018371D850-0x000000018371D930
		public RectTransform keyContainer { /* [XID] */ /* 0x00000001897F5E00-0x00000001897F5E20 */ get => default; } // 0x000000018371D5E0-0x000000018371D680 
		public bool highlight { /* [XID] */ /* 0x00000001897FD560-0x00000001897FD580 */ set {} } // 0x000000018371D740-0x000000018371D850
	
		// Constructors
		public MonoPickupListItem() {} // 0x000000018371D430-0x000000018371D4A0
	
		// Methods
		// [XID] // 0x00000001897DC140-0x00000001897DC160
		public void FadeIn() {} // 0x000000018371C800-0x000000018371C990
		// [XID] // 0x00000001897E3A30-0x00000001897E3A50
		public override void FadeOut() {} // 0x000000018371C990-0x000000018371CB10
		// [IDTag] // 0x00000001897EB6E0-0x00000001897EB720
		// [XID] // 0x00000001897EB6E0-0x00000001897EB720
		public void TriggerHighlight(bool trigger) {} // 0x000000018371CFB0-0x000000018371D0D0
		// [IDTag] // 0x0000000189804AC0-0x0000000189804B00
		// [XID] // 0x0000000189804AC0-0x0000000189804B00
		public void TriggerHighlight() {} // 0x000000018371CEF0-0x000000018371CFB0
		// [XID] // 0x000000018980F3D0-0x000000018980F3F0
		public void Deselect() {} // 0x000000018371C6E0-0x000000018371C7A0
		// [XID] // 0x0000000189816A60-0x0000000189816A80
		private void GetActionButtonAnimator() {} // 0x000000018371CB10-0x000000018371CC10
		// [XID] // 0x000000018981E2E0-0x000000018981E300
		public void TriggerPress() {} // 0x000000018371D280-0x000000018371D430
		// [XID] // 0x00000001898257C0-0x00000001898257E0
		public void TriggerHighlighted() {} // 0x000000018371D0D0-0x000000018371D280
		// [XID] // 0x000000018982CF80-0x000000018982CFA0
		public void TriggerDisabled() {} // 0x000000018371CC10-0x000000018371CEF0
	}
}
