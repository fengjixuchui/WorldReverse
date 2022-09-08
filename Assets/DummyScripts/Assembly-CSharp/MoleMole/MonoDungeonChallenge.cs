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
	public class MonoDungeonChallenge : MonoBehaviour // TypeDefIndex: 31201
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Animator _panelAnimator; // 0x18
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _startSubTitleGrp; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _startDescription; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _startSubTitle; // 0x30
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _completeTitle; // 0x38
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _failTitle; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _failSubTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _failSubTitleGrp; // 0x50
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _subTargetGrp; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subTargetTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _subTargetNewTag; // 0x68
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _hintProgress; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _hintSubProgress; // 0x78
		// [Range] // 0x0000000189B15BB0-0x0000000189B15C00
		[SerializeField] // 0x0000000189B15BB0-0x0000000189B15C00
		[Space] // 0x0000000189B15BB0-0x0000000189B15C00
		private float _startDuration; // 0x80
		// [Range] // 0x0000000189B23590-0x0000000189B235D0
		[SerializeField] // 0x0000000189B23590-0x0000000189B235D0
		private float _failDuration; // 0x84
		// [Range] // 0x0000000189B2D610-0x0000000189B2D650
		[SerializeField] // 0x0000000189B2D610-0x0000000189B2D650
		private float _completeDuration; // 0x88
		private AnimatorStateInfo? _animatorState; // 0x8C
		private bool _completeTriggerValue; // 0xB4
		private bool _startTriggerValue; // 0xB5
		private bool _failTriggerValue; // 0xB6
		private bool _canShowProgress; // 0xB7
		private bool _hideProgress; // 0xB8
	
		// Properties
		public string startDescription { /* [XID] */ /* 0x0000000189B545F0-0x0000000189B54610 */ set {} } // 0x0000000183F46930-0x0000000183F46A00
		public string startSubTitle { /* [XID] */ /* 0x0000000189B5C1C0-0x0000000189B5C1E0 */ set {} } // 0x0000000183F46A00-0x0000000183F46AD0
		public string failSubTitle { /* [XID] */ /* 0x0000000189B637C0-0x0000000189B637E0 */ set {} } // 0x0000000183F46420-0x0000000183F464F0
		public string completeTitle { /* [XID] */ /* 0x0000000189B6AF80-0x0000000189B6AFA0 */ set {} } // 0x0000000183F46350-0x0000000183F46420
		public string failTitle { /* [XID] */ /* 0x0000000189B725C0-0x0000000189B725E0 */ set {} } // 0x0000000183F464F0-0x0000000183F465C0
		public string hintProgress { /* [XID] */ /* 0x0000000189B79B10-0x0000000189B79B30 */ set {} } // 0x0000000183F465C0-0x0000000183F46690
		public bool showStartSubTitle { /* [XID] */ /* 0x0000000189B88A10-0x0000000189B88A30 */ set {} } // 0x0000000183F46850-0x0000000183F46930
		public bool showFailSubTitle { /* [XID] */ /* 0x0000000189B8FEC0-0x0000000189B8FEE0 */ set {} } // 0x0000000183F46690-0x0000000183F46770
		public bool showHintSubProgress { /* [XID] */ /* 0x0000000189B97300-0x0000000189B97320 */ set {} } // 0x0000000183F46770-0x0000000183F46850
		public float startDuration { /* [XID] */ /* 0x0000000189BA6130-0x0000000189BA6150 */ get => default; } // 0x0000000183F460F0-0x0000000183F461A0 
		public float completeDuration { /* [XID] */ /* 0x0000000189BAD3C0-0x0000000189BAD3E0 */ get => default; } // 0x0000000183F45DE0-0x0000000183F45E90 
		public float failDuration { /* [XID] */ /* 0x0000000189BB4B90-0x0000000189BB4BB0 */ get => default; } // 0x0000000183F45E90-0x0000000183F45F40 
		public Animator panelAnimator { /* [XID] */ /* 0x0000000189BBC100-0x0000000189BBC120 */ get => default; } // 0x0000000183F46050-0x0000000183F460F0 
		public bool ShowSubTarget { /* [XID] */ /* 0x0000000189BC3E60-0x0000000189BC3EA0 */ get; /* [XID] */ /* 0x0000000189BCE780-0x0000000189BCE7C0 */ set; } // 0x0000000183F45D80-0x0000000183F45DE0 0x0000000183F46210-0x0000000183F46280
		public bool ShowSubTargetNewTag { /* [XID] */ /* 0x0000000189BD8C20-0x0000000189BD8C60 */ get; /* [XID] */ /* 0x00000001895E8830-0x00000001895E8870 */ set; } // 0x0000000183F45D20-0x0000000183F45D80 0x0000000183F461A0-0x0000000183F46210
		public string SubTargetTitle { /* [XID] */ /* 0x00000001895F2E40-0x00000001895F2E60 */ set {} } // 0x0000000183F46280-0x0000000183F46350
		public bool isEnd { /* [XID] */ /* 0x000000018961FFE0-0x0000000189620000 */ get => default; } // 0x0000000183F45F40-0x0000000183F46050 
	
		// Constructors
		public MonoDungeonChallenge() {} // 0x0000000183F45C20-0x0000000183F45D20
	
		// Methods
		// [XID] // 0x0000000189B4CED0-0x0000000189B4CEF0
		private void OnEnable() {} // 0x0000000183F45250-0x0000000183F45560
		// [XID] // 0x0000000189B81280-0x0000000189B812A0
		public void HintProgressUpdate() {} // 0x0000000183F45000-0x0000000183F450E0
		// [XID] // 0x0000000189B9E780-0x0000000189B9E7A0
		public void SavaAnimatorState() {} // 0x0000000183F45560-0x0000000183F457A0
		// [XID] // 0x00000001895FA6A0-0x00000001895FA6C0
		private void SetSubTarget() {} // 0x0000000183F450E0-0x0000000183F45250
		// [XID] // 0x0000000189602040-0x0000000189602060
		public void ShowStart() {} // 0x0000000183F45A10-0x0000000183F45B40
		// [XID] // 0x0000000189609860-0x0000000189609880
		public void ShowComplete() {} // 0x0000000183F457A0-0x0000000183F458E0
		// [XID] // 0x0000000189611080-0x00000001896110A0
		public void ShowFail() {} // 0x0000000183F458E0-0x0000000183F45A10
		// [XID] // 0x0000000189618A50-0x0000000189618A70
		public void SkipCurrentHint() {} // 0x0000000183F45B40-0x0000000183F45C20
	}
}
