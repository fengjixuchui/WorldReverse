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
	public class MonoCodexSubQuestContentItemRow : MonoBehaviour // TypeDefIndex: 30509
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _simpleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _playText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _selectText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _simpleGrp; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _playGrp; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _selectGrp; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _playButton; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _selectButton; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _playObject; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMarkPlay; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectMarkSelect; // 0x68
		private Animator _playButtonAnimator; // 0x70
		private Animator _grpAnimator; // 0x78
		private bool _selected; // 0x80
		private int rowType; // 0x90
	
		// Properties
		public Button playButton { /* [XID] */ /* 0x0000000189A9C0A0-0x0000000189A9C0C0 */ get => default; } // 0x0000000184BAA760-0x0000000184BAA800 
		public Button selectButton { /* [XID] */ /* 0x0000000189AA3770-0x0000000189AA3790 */ get => default; } // 0x0000000184BAA800-0x0000000184BAA8A0 
		public bool selected { /* [XID] */ /* 0x0000000189AD8840-0x0000000189AD8860 */ get => default; /* [XID] */ /* 0x0000000189AD0C40-0x0000000189AD0C60 */ set {} } // 0x0000000184BAA8A0-0x0000000184BAA950 0x0000000184BAA950-0x0000000184BAAA60
		public bool canBeSelect { /* [XID] */ /* 0x0000000189AE0480-0x0000000189AE04C0 */ get; /* [XID] */ /* 0x0000000189AEAB10-0x0000000189AEAB50 */ private set; } // 0x0000000184BAA700-0x0000000184BAA760 0x0000000184BA9E90-0x0000000184BA9F00
		public RectTransform actionTrans { /* [XID] */ /* 0x0000000189AF5400-0x0000000189AF5440 */ get; /* [XID] */ /* 0x0000000189AFFA60-0x0000000189AFFAA0 */ private set; } // 0x0000000184BAA6A0-0x0000000184BAA700 0x0000000184BA9C80-0x0000000184BA9CF0
	
		// Constructors
		public MonoCodexSubQuestContentItemRow() {} // 0x0000000184BAA600-0x0000000184BAA6A0
	
		// Methods
		// [XID] // 0x0000000189AAAE10-0x0000000189AAAE30
		private void SetAllInactive() {} // 0x0000000184BA9D90-0x0000000184BA9E90
		// [XID] // 0x0000000189AB27E0-0x0000000189AB2800
		public void SetSimpleText(string text) {} // 0x0000000184BAA4A0-0x0000000184BAA600
		// [XID] // 0x0000000189ABA2F0-0x0000000189ABA310
		public void SetPlayText(string text) {} // 0x0000000184BA9F00-0x0000000184BAA0D0
		// [XID] // 0x0000000189AC1C00-0x0000000189AC1C20
		public void SetSelectText(string text) {} // 0x0000000184BAA2D0-0x0000000184BAA4A0
		// [XID] // 0x0000000189AC91B0-0x0000000189AC91D0
		public void SetPlay(bool play) {} // 0x0000000184BAA0D0-0x0000000184BAA2D0
		// [XID] // 0x0000000189B0A270-0x0000000189B0A290
		public int GetRowType() => default; // 0x0000000184BA9CF0-0x0000000184BA9D90
	}
}
