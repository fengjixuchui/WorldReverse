/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelCutScenePage : MonoBehaviour, IPointerClickHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 30808
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _skipSwitch; // 0x18
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _loadingAnim; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _showText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _textAnimator; // 0x30
		private Button _skipButtonSwitch; // 0x38
		private UnityEvent _onClick; // 0x40
		private DragEvent _onDrag; // 0x48
		private UnityEvent _onEndDrag; // 0x50
		public float showBtnDuration; // 0x58
		private bool _draged; // 0x5C
	
		// Properties
		public GameObject loadingAnim { /* [XID] */ /* 0x00000001896DD6C0-0x00000001896DD6E0 */ get => default; } // 0x0000000184707FC0-0x0000000184708060 
		public UnityEngine.UI.Text showText { /* [XID] */ /* 0x00000001896E4D80-0x00000001896E4DA0 */ get => default; } // 0x0000000184708240-0x00000001847082E0 
		public Animator textAnimator { /* [XID] */ /* 0x00000001896EC280-0x00000001896EC2A0 */ get => default; } // 0x00000001847085A0-0x0000000184708640 
		public Button skipButton { /* [XID] */ /* 0x00000001896F3A50-0x00000001896F3A70 */ get => default; } // 0x00000001847083F0-0x00000001847085A0 
		public Animation skipButtonAnimation { /* [XID] */ /* 0x00000001896FB140-0x00000001896FB160 */ get => default; } // 0x00000001847082E0-0x00000001847083F0 
		public UnityEvent onClick { /* [XID] */ /* 0x00000001897028E0-0x0000000189702900 */ get => default; } // 0x0000000184708060-0x0000000184708100 
		public DragEvent onDrag { /* [XID] */ /* 0x000000018970A030-0x000000018970A050 */ get => default; } // 0x0000000184708100-0x00000001847081A0 
		public UnityEvent onEndDrag { /* [XID] */ /* 0x0000000189711AF0-0x0000000189711B10 */ get => default; } // 0x00000001847081A0-0x0000000184708240 
	
		// Nested types
		public class DragEvent : UnityEvent<Vector2> // TypeDefIndex: 30809
		{
			// Constructors
			public DragEvent() {} // 0x00000001846F3120-0x00000001846F3190
		}
	
		// Constructors
		public MonoInLevelCutScenePage() {} // 0x0000000184707E90-0x0000000184707FC0
	
		// Methods
		// [XID] // 0x0000000189718F80-0x0000000189718FA0
		private void OnDisable() {} // 0x0000000184707B10-0x0000000184707BB0
		// [XID] // 0x0000000189720690-0x00000001897206B0
		void IDragHandler.OnDrag(PointerEventData eventData) {} // 0x0000000184707BB0-0x0000000184707D00
		// [XID] // 0x0000000189727C40-0x0000000189727C60
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {} // 0x0000000184707DC0-0x0000000184707E90
		// [XID] // 0x000000018972F2A0-0x000000018972F2C0
		void IEndDragHandler.OnEndDrag(PointerEventData eventData) {} // 0x0000000184707D00-0x0000000184707DC0
	}
}
