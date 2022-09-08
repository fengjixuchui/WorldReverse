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
	public class MonoLoadingCanvas : MonoBehaviour // TypeDefIndex: 30296
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _tipsText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoProgressBar _progressBar; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgImg; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _animator; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTipsTitle; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTipsContent; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnNext; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _bgIcon; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _headphoneTip; // 0x58
		// [Tooltip] // 0x00000001896E7BD0-0x00000001896E7C00
		public float dummyLoadingStartProgress; // 0x60
		// [Tooltip] // 0x00000001896F0800-0x00000001896F0830
		public float dummyLoadingStartDelayS; // 0x64
		// [Tooltip] // 0x00000001896F98D0-0x00000001896F9900
		public float dummyLoadingMinProgress; // 0x68
		// [Tooltip] // 0x00000001897029C0-0x00000001897029F0
		public float dummyLoadingMaxProgress; // 0x6C
		// [Tooltip] // 0x000000018970B7F0-0x000000018970B820
		public float dummyLoadingStepMinProgress; // 0x70
		// [Tooltip] // 0x0000000189714630-0x0000000189714660
		public float dummyLoadingStepMaxProgress; // 0x74
		// [Tooltip] // 0x000000018971D740-0x000000018971D770
		public float dummyLoadingStepMinIntervalS; // 0x78
		// [Tooltip] // 0x00000001897265A0-0x00000001897265D0
		public float dummyLoadingStepMaxIntervalS; // 0x7C
	
		// Properties
		public UnityEngine.UI.Text tipsText { /* [XID] */ /* 0x000000018972F340-0x000000018972F360 */ get => default; } // 0x000000018427DFA0-0x000000018427E040 
		public MonoProgressBar progressBar { /* [XID] */ /* 0x0000000189736D20-0x0000000189736D40 */ get => default; } // 0x000000018427DF00-0x000000018427DFA0 
		public Image bgImg { /* [XID] */ /* 0x000000018973E880-0x000000018973E8A0 */ get => default; } // 0x000000018427DDC0-0x000000018427DE60 
		public Animator animator { /* [XID] */ /* 0x0000000189745BC0-0x0000000189745BE0 */ get => default; } // 0x000000018427DC80-0x000000018427DD20 
		public UnityEngine.UI.Text txtTipsTitle { /* [XID] */ /* 0x000000018974D690-0x000000018974D6B0 */ get => default; } // 0x000000018427E290-0x000000018427E330 
		public UnityEngine.UI.Text txtTipsContent { /* [XID] */ /* 0x0000000189754CB0-0x0000000189754CD0 */ get => default; } // 0x000000018427E1F0-0x000000018427E290 
		public Button btnNext { /* [XID] */ /* 0x000000018975BE60-0x000000018975BE80 */ get => default; } // 0x000000018427DE60-0x000000018427DF00 
		public Image bgIcon { /* [XID] */ /* 0x0000000189763830-0x0000000189763850 */ get => default; } // 0x000000018427DD20-0x000000018427DDC0 
		public UnityEngine.UI.Text txtNextBtn { /* [XID] */ /* 0x000000018976AFF0-0x000000018976B010 */ get => default; } // 0x000000018427E040-0x000000018427E1F0 
		public bool showHeadphoneTip { /* [XID] */ /* 0x0000000189772620-0x0000000189772640 */ set {} } // 0x000000018427E330-0x000000018427E420
	
		// Constructors
		public MonoLoadingCanvas() {} // 0x000000018427DBC0-0x000000018427DC80
	}
}
