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
	public class MonoFleurFairMusicGameMainPage : MonoUIProxy // TypeDefIndex: 30772
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _musicName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _score; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _comboText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _pausePanel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _comboPanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rateText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _rateProgress; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _musicProgress; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _comboAnimator; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _comboEffectList; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rateTextObj; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadItemNavigator _panelJoyModule; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<MonoUIContainer> _musicContainerList; // 0xA8
	
		// Properties
		public List<MonoUIContainer> musicContainerList { /* [XID] */ /* 0x000000018992A5F0-0x000000018992A610 */ get => default; } // 0x0000000184ADFCB0-0x0000000184ADFD60 
		public uint combo { /* [XID] */ /* 0x0000000189931BC0-0x0000000189931BE0 */ set {} } // 0x0000000184ADFEB0-0x0000000184ADFFA0
		public GameObject pausePanel { /* [XID] */ /* 0x0000000189939620-0x0000000189939640 */ get => default; } // 0x0000000184ADFE10-0x0000000184ADFEB0 
		public MonoJoypadItemNavigator panelJoyModule { /* [XID] */ /* 0x00000001899408F0-0x0000000189940910 */ get => default; } // 0x0000000184ADFD60-0x0000000184ADFE10 
		public Animator comboAnimator { /* [XID] */ /* 0x0000000189948170-0x0000000189948190 */ get => default; } // 0x0000000184ADFB50-0x0000000184ADFC00 
		public List<GameObject> comboEffectList { /* [XID] */ /* 0x000000018994F8F0-0x000000018994F910 */ get => default; } // 0x0000000184ADFC00-0x0000000184ADFCB0 
		public bool showComboPanel { /* [XID] */ /* 0x0000000189956E90-0x0000000189956EB0 */ set {} } // 0x0000000184AE04A0-0x0000000184AE0590
		public bool showRateTextObj { /* [XID] */ /* 0x000000018995EA00-0x000000018995EA20 */ set {} } // 0x0000000184AE0590-0x0000000184AE0680
		public float rateText { /* [XID] */ /* 0x0000000189966120-0x0000000189966140 */ set {} } // 0x0000000184AE0290-0x0000000184AE03C0
		public float rateProgress { /* [XID] */ /* 0x000000018996D600-0x000000018996D620 */ set {} } // 0x0000000184AE0190-0x0000000184AE0290
		public float musicProgress { /* [XID] */ /* 0x0000000189975180-0x00000001899751A0 */ set {} } // 0x0000000184AE0080-0x0000000184AE0190
		public string musicName { /* [XID] */ /* 0x000000018997C340-0x000000018997C360 */ set {} } // 0x0000000184ADFFA0-0x0000000184AE0080
		public string score { /* [XID] */ /* 0x0000000189984060-0x0000000189984080 */ set {} } // 0x0000000184AE03C0-0x0000000184AE04A0
		public MonoUIContainer BtnPause { /* [XID] */ /* 0x000000018998BBF0-0x000000018998BC10 */ get => default; } // 0x0000000184ADF910-0x0000000184ADF9D0 
		public MonoUIContainer BtnResume { /* [XID] */ /* 0x00000001899937C0-0x00000001899937E0 */ get => default; } // 0x0000000184ADFA90-0x0000000184ADFB50 
		public MonoUIContainer BtnReStart { /* [XID] */ /* 0x000000018999B080-0x000000018999B0A0 */ get => default; } // 0x0000000184ADF9D0-0x0000000184ADFA90 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x00000001899A28C0-0x00000001899A28E0 */ get => default; } // 0x0000000184ADF850-0x0000000184ADF910 
	
		// Constructors
		public MonoFleurFairMusicGameMainPage() {} // 0x0000000184ADF7A0-0x0000000184ADF850
	}
}
