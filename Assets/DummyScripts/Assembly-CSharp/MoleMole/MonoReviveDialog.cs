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
	public class MonoReviveDialog : MonoUIProxy // TypeDefIndex: 30578
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _quitButtonContainer; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _reviveButtonContainer; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoLocalizedText _deathCauseLabel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _dieTipsLabel; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoLocalizedText _autoQuitLabel; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _restartGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _quitGrp; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private RectTransform _reviveGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _reviveCountGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reviveRemainCount; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _reviveMaxCount; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform quitOption; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform checkPointOption; // 0xA0
	
		// Properties
		public Button quitButton { /* [XID] */ /* 0x00000001899A8A90-0x00000001899A8AB0 */ get => default; } // 0x0000000181433A40-0x0000000181433AF0 
		public Button restartButton { /* [XID] */ /* 0x00000001899B03D0-0x00000001899B03F0 */ get => default; } // 0x0000000181433AF0-0x0000000181433BF0 
		public string restartButtonText { /* [XID] */ /* 0x00000001899B7700-0x00000001899B7720 */ set {} } // 0x0000000181434010-0x0000000181434120
		public MonoUIContainer reviveButton { /* [XID] */ /* 0x00000001899BF0E0-0x00000001899BF100 */ get => default; } // 0x0000000181433BF0-0x0000000181433C90 
		public string deathCauseTextID { /* [XID] */ /* 0x00000001899C6A80-0x00000001899C6AA0 */ set {} } // 0x0000000181433E30-0x0000000181433F30
		public bool showReviveGroup { /* [XID] */ /* 0x00000001899CE020-0x00000001899CE040 */ set {} } // 0x00000001814347E0-0x00000001814348E0
		public bool showReviveCountGroup { /* [XID] */ /* 0x00000001899D5780-0x00000001899D57A0 */ set {} } // 0x00000001814346E0-0x00000001814347E0
		public uint reviveRemainCount { /* [XID] */ /* 0x00000001899DCB10-0x00000001899DCB30 */ set {} } // 0x0000000181434200-0x00000001814342E0
		public uint reviveMaxCount { /* [XID] */ /* 0x00000001899E4770-0x00000001899E4790 */ set {} } // 0x0000000181434120-0x0000000181434200
		public bool showAutoQuitLabel { /* [XID] */ /* 0x00000001899EBAA0-0x00000001899EBAC0 */ set {} } // 0x0000000181434440-0x0000000181434520
		public uint secondsBeforeAutoQuit { /* [XID] */ /* 0x00000001899F3590-0x00000001899F35B0 */ set {} } // 0x00000001814342E0-0x0000000181434440
		public string dieTips { /* [XID] */ /* 0x00000001899FAF10-0x00000001899FAF30 */ set {} } // 0x0000000181433F30-0x0000000181434010
		public bool showRestartGrp { /* [XID] */ /* 0x0000000189A02160-0x0000000189A02180 */ get => default; /* [XID] */ /* 0x0000000189A09930-0x0000000189A09950 */ set {} } // 0x0000000181433D60-0x0000000181433E30 0x0000000181434600-0x00000001814346E0
		public bool showQuitGrp { /* [XID] */ /* 0x0000000189A11070-0x0000000189A11090 */ get => default; /* [XID] */ /* 0x0000000189A18420-0x0000000189A18440 */ set {} } // 0x0000000181433C90-0x0000000181433D60 0x0000000181434520-0x0000000181434600
	
		// Constructors
		public MonoReviveDialog() {} // 0x0000000181433990-0x0000000181433A40
	}
}
