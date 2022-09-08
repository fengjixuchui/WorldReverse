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
	public class MonoTheatreMechanicusEntryPage : MonoUIProxy // TypeDefIndex: 30397
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _diffListObj; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _diffList; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _diffBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _diffBtnText; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _matchingObj; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _matchingTimeText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _consumeCountText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _consumeImg; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _closeDiffBtn; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _consumeObj; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _diffBtnPS; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMaxContentSizeFitter _contentFilter; // 0xA8
	
		// Properties
		public Image consumeImg { /* [XID] */ /* 0x000000018983A580-0x000000018983A5A0 */ get => default; } // 0x0000000183B6DAC0-0x0000000183B6DB70 
		public MonoSimpleReusableList diffList { /* [XID] */ /* 0x0000000189841B80-0x0000000189841BA0 */ get => default; } // 0x0000000183B6DD70-0x0000000183B6DE10 
		public MonoMaxContentSizeFitter contentFilter { /* [XID] */ /* 0x0000000189849090-0x00000001898490B0 */ get => default; } // 0x0000000183B6DC20-0x0000000183B6DCD0 
		public Button BtnDifficult { /* [XID] */ /* 0x0000000189850810-0x0000000189850830 */ get => default; } // 0x0000000183B6D430-0x0000000183B6D4D0 
		public MonoUIContainer BtnDifficultPS { /* [XID] */ /* 0x0000000189857BE0-0x0000000189857C00 */ get => default; } // 0x0000000183B6D380-0x0000000183B6D430 
		public Button BtnCloseDifficult { /* [XID] */ /* 0x000000018985EC90-0x000000018985ECB0 */ get => default; } // 0x0000000183B6D2D0-0x0000000183B6D380 
		public string diffBtnText { /* [XID] */ /* 0x0000000189866430-0x0000000189866450 */ set {} } // 0x0000000183B6DEF0-0x0000000183B6DFD0
		public GameObject diffListObj { /* [XID] */ /* 0x000000018986DD60-0x000000018986DD80 */ get => default; } // 0x0000000183B6DCD0-0x0000000183B6DD70 
		public bool showMatching { /* [XID] */ /* 0x0000000189875100-0x0000000189875120 */ set {} } // 0x0000000183B6E0B0-0x0000000183B6E1A0
		public string matchingTimeText { /* [XID] */ /* 0x000000018987CD70-0x000000018987CD90 */ set {} } // 0x0000000183B6DFD0-0x0000000183B6E0B0
		public string consumeCountText { /* [XID] */ /* 0x0000000189883D10-0x0000000189883D30 */ set {} } // 0x0000000183B6DE10-0x0000000183B6DEF0
		public Transform coinRoot { /* [XID] */ /* 0x000000018988B3B0-0x000000018988B3D0 */ get => default; } // 0x0000000183B6DA10-0x0000000183B6DAC0 
		public GameObject consumeRoot { /* [XID] */ /* 0x0000000189892AF0-0x0000000189892B10 */ get => default; } // 0x0000000183B6DB70-0x0000000183B6DC20 
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x000000018989A170-0x000000018989A190 */ get => default; } // 0x0000000183B6D7D0-0x0000000183B6D890 
		public MonoUIContainer BtnSinglePlayer { /* [XID] */ /* 0x00000001898A1430-0x00000001898A1450 */ get => default; } // 0x0000000183B6D890-0x0000000183B6D950 
		public MonoUIContainer BtnMultiPlayer { /* [XID] */ /* 0x00000001898A8CA0-0x00000001898A8CC0 */ get => default; } // 0x0000000183B6D710-0x0000000183B6D7D0 
		public MonoUIContainer BtnGadget { /* [XID] */ /* 0x00000001898B0620-0x00000001898B0640 */ get => default; } // 0x0000000183B6D4D0-0x0000000183B6D590 
		public MonoUIContainer BtnHandBook { /* [XID] */ /* 0x00000001898B7C10-0x00000001898B7C30 */ get => default; } // 0x0000000183B6D590-0x0000000183B6D650 
		public MonoUIContainer BtnInstruction { /* [XID] */ /* 0x00000001898BF1E0-0x00000001898BF200 */ get => default; } // 0x0000000183B6D650-0x0000000183B6D710 
		public MonoUIContainer BtnTrialLevel { /* [XID] */ /* 0x00000001898C6B80-0x00000001898C6BA0 */ get => default; } // 0x0000000183B6D950-0x0000000183B6DA10 
	
		// Constructors
		public MonoTheatreMechanicusEntryPage() {} // 0x0000000183B6D220-0x0000000183B6D2D0
	}
}
