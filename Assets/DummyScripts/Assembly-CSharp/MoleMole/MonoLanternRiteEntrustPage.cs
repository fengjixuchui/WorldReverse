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
	public class MonoLanternRiteEntrustPage : MonoUIProxy // TypeDefIndex: 31236
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image[] _imgBGs; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _grpTab; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _btnReturn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _grpSelect; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockedTitle; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _lockedTips; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mainTitle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mainChapter; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _mainDesc; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardScroller; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _grpLanterns; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _lanternsA; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _lanternsB; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer[] _lanternsC; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList[] _taskList; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _progressTitle; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _progressNum; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _progressList; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _finishedFadeTime; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _finishedNextTime; // 0xDC
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _finishedPlayTime; // 0xE0
	
		// Properties
		public Image[] imgBGs { /* [XID] */ /* 0x00000001898606E0-0x0000000189860700 */ get => default; } // 0x0000000183F94DC0-0x0000000183F94E60 
		public RectTransform[] grpTab { /* [XID] */ /* 0x0000000189867DB0-0x0000000189867DD0 */ get => default; } // 0x0000000183F94D20-0x0000000183F94DC0 
		public RectTransform[] grpSelect { /* [XID] */ /* 0x000000018986F350-0x000000018986F370 */ get => default; } // 0x0000000183F94C80-0x0000000183F94D20 
		public Button btnReturn { /* [XID] */ /* 0x0000000189876980-0x00000001898769A0 */ get => default; } // 0x0000000183F94910-0x0000000183F949C0 
		public UnityEngine.UI.Text lockedTitle { /* [XID] */ /* 0x000000018987E4A0-0x000000018987E4C0 */ get => default; } // 0x0000000183F94F60-0x0000000183F95000 
		public UnityEngine.UI.Text lockedTips { /* [XID] */ /* 0x0000000189885850-0x0000000189885870 */ get => default; } // 0x0000000183F94EC0-0x0000000183F94F60 
		public UnityEngine.UI.Text mainTitle { /* [XID] */ /* 0x000000018988CB40-0x000000018988CB60 */ get => default; } // 0x0000000183F95160-0x0000000183F95200 
		public UnityEngine.UI.Text mainChapter { /* [XID] */ /* 0x0000000189894210-0x0000000189894230 */ get => default; } // 0x0000000183F95000-0x0000000183F950B0 
		public UnityEngine.UI.Text mainDesc { /* [XID] */ /* 0x000000018989B780-0x000000018989B7A0 */ get => default; } // 0x0000000183F950B0-0x0000000183F95160 
		public MonoGridScroller rewardScroller { /* [XID] */ /* 0x00000001898A2CB0-0x00000001898A2CD0 */ get => default; } // 0x0000000183F95410-0x0000000183F954C0 
		public RectTransform[] grpLanterns { /* [XID] */ /* 0x00000001898AA1B0-0x00000001898AA1D0 */ get => default; } // 0x0000000183F94BD0-0x0000000183F94C80 
		public MonoUIContainer[][] lanterns { /* [XID] */ /* 0x00000001898B1B70-0x00000001898B1BB0 */ get; /* [XID] */ /* 0x00000001898BC580-0x00000001898BC5C0 */ private set; } // 0x0000000183F94E60-0x0000000183F94EC0 0x0000000183F941B0-0x0000000183F94220
		public MonoSimpleReusableList[] taskList { /* [XID] */ /* 0x00000001898C6A80-0x00000001898C6AA0 */ get => default; } // 0x0000000183F954C0-0x0000000183F95570 
		public UnityEngine.UI.Text progressTitle { /* [XID] */ /* 0x00000001898CE030-0x00000001898CE050 */ get => default; } // 0x0000000183F95360-0x0000000183F95410 
		public UnityEngine.UI.Text progressNum { /* [XID] */ /* 0x00000001898D5B10-0x00000001898D5B30 */ get => default; } // 0x0000000183F952B0-0x0000000183F95360 
		public MonoSimpleReusableList progressList { /* [XID] */ /* 0x00000001898DD730-0x00000001898DD750 */ get => default; } // 0x0000000183F95200-0x0000000183F952B0 
		public float finishedFadeTime { /* [XID] */ /* 0x00000001898E4F90-0x00000001898E4FB0 */ get => default; } // 0x0000000183F949C0-0x0000000183F94A70 
		public float finishedNextTime { /* [XID] */ /* 0x00000001898EC840-0x00000001898EC860 */ get => default; } // 0x0000000183F94A70-0x0000000183F94B20 
		public float finishedPlayTime { /* [XID] */ /* 0x00000001898F4250-0x00000001898F4270 */ get => default; } // 0x0000000183F94B20-0x0000000183F94BD0 
		public MonoUIContainer BtnSwitchPrev { /* [XID] */ /* 0x00000001898FB9A0-0x00000001898FB9C0 */ get => default; } // 0x0000000183F945E0-0x0000000183F946F0 
		public MonoUIContainer BtnSwitchNext { /* [XID] */ /* 0x00000001899033B0-0x00000001899033D0 */ get => default; } // 0x0000000183F944D0-0x0000000183F945E0 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x000000018990A900-0x000000018990A920 */ get => default; } // 0x0000000183F943C0-0x0000000183F944D0 
		public MonoUIContainer BtnCollect { /* [XID] */ /* 0x0000000189912550-0x0000000189912570 */ get => default; } // 0x0000000183F942B0-0x0000000183F943C0 
		public MonoUIContainer BtnViewTask { /* [XID] */ /* 0x0000000189919E60-0x0000000189919E80 */ get => default; } // 0x0000000183F94800-0x0000000183F94910 
		public MonoUIContainer BtnViewLanternpoint { /* [XID] */ /* 0x00000001899216A0-0x00000001899216C0 */ get => default; } // 0x0000000183F946F0-0x0000000183F94800 
	
		// Constructors
		public MonoLanternRiteEntrustPage() {} // 0x0000000183F94220-0x0000000183F942B0
	
		// Methods
		// [XID] // 0x0000000189928DC0-0x0000000189928DE0
		private void Awake() {} // 0x0000000183F93EE0-0x0000000183F941B0
	}
}
