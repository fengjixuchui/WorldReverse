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
	public class MonoHDRSettingDialog : MonoBehaviour // TypeDefIndex: 30550
	{
		// Fields
		private Animator _animator; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTitle; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSubTitle; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTips; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTab1Label; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTab2SceneLabel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtTab2UILabel; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tab1GO; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _tab2GO; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab1Slider; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2SceneSlider; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2UISlider; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab1L1Btn; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab1R1Btn; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2L1Btn; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2R1Btn; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2L2Btn; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tab2R2Btn; // 0xA8
	
		// Properties
		public Button tab1L1Btn { /* [XID] */ /* 0x0000000189889DE0-0x0000000189889E00 */ get => default; } // 0x0000000184084940-0x0000000184084A00 
		public Button tab1R1Btn { /* [XID] */ /* 0x0000000189891280-0x00000001898912A0 */ get => default; } // 0x0000000184084A00-0x0000000184084AC0 
		public Button tab2L1Btn { /* [XID] */ /* 0x0000000189898890-0x00000001898988B0 */ get => default; } // 0x0000000184084C60-0x0000000184084D20 
		public Button tab2R1Btn { /* [XID] */ /* 0x000000018989FAD0-0x000000018989FAF0 */ get => default; } // 0x0000000184084DE0-0x0000000184084EA0 
		public Button tab2L2Btn { /* [XID] */ /* 0x00000001898A7500-0x00000001898A7520 */ get => default; } // 0x0000000184084D20-0x0000000184084DE0 
		public Button tab2R2Btn { /* [XID] */ /* 0x00000001898AEEE0-0x00000001898AEF00 */ get => default; } // 0x0000000184084EA0-0x0000000184084F60 
		public UnityEngine.UI.Text txtTitle { /* [XID] */ /* 0x00000001898B62F0-0x00000001898B6310 */ get => default; } // 0x0000000184085480-0x0000000184085520 
		public UnityEngine.UI.Text txtSubTitle { /* [XID] */ /* 0x00000001898BDBC0-0x00000001898BDBE0 */ get => default; } // 0x0000000184085160-0x0000000184085200 
		public UnityEngine.UI.Text txtTips { /* [XID] */ /* 0x00000001898C5460-0x00000001898C5480 */ get => default; } // 0x00000001840853E0-0x0000000184085480 
		public UnityEngine.UI.Text txtTab1Label { /* [XID] */ /* 0x00000001898CC980-0x00000001898CC9A0 */ get => default; } // 0x0000000184085200-0x00000001840852A0 
		public UnityEngine.UI.Text txtTab2SceneLabel { /* [XID] */ /* 0x00000001898D43A0-0x00000001898D43C0 */ get => default; } // 0x00000001840852A0-0x0000000184085340 
		public UnityEngine.UI.Text txtTab2UILabel { /* [XID] */ /* 0x00000001898DBB80-0x00000001898DBBA0 */ get => default; } // 0x0000000184085340-0x00000001840853E0 
		public GameObject tab1GO { /* [XID] */ /* 0x00000001898E3760-0x00000001898E3780 */ get => default; } // 0x00000001840848A0-0x0000000184084940 
		public GameObject tab2GO { /* [XID] */ /* 0x00000001898EB400-0x00000001898EB420 */ get => default; } // 0x0000000184084BC0-0x0000000184084C60 
		public Slider tab1Slider { /* [XID] */ /* 0x00000001898F2B40-0x00000001898F2B60 */ get => default; } // 0x0000000184084AC0-0x0000000184084BC0 
		public Slider tab2SceneSlider { /* [XID] */ /* 0x00000001898FA2D0-0x00000001898FA2F0 */ get => default; } // 0x0000000184084F60-0x0000000184085060 
		public Slider tab2UISlider { /* [XID] */ /* 0x0000000189901CA0-0x0000000189901CC0 */ get => default; } // 0x0000000184085060-0x0000000184085160 
		public bool showSubTitle { /* [XID] */ /* 0x0000000189909510-0x0000000189909530 */ set {} } // 0x0000000184085520-0x0000000184085620
		public Button prevPageBtn { /* [XID] */ /* 0x00000001899275E0-0x0000000189927600 */ get => default; } // 0x00000001840846C0-0x00000001840848A0 
		public Button nextPageBtn { /* [XID] */ /* 0x000000018992ED40-0x000000018992ED60 */ get => default; } // 0x00000001840844E0-0x00000001840846C0 
		public Button confirmBtn { /* [XID] */ /* 0x0000000189936170-0x0000000189936190 */ get => default; } // 0x0000000184084300-0x00000001840844E0 
		public Button closeBtn { /* [XID] */ /* 0x000000018993DB90-0x000000018993DBB0 */ get => default; } // 0x0000000184084120-0x0000000184084300 
	
		// Constructors
		public MonoHDRSettingDialog() {} // 0x0000000184084060-0x0000000184084120
	
		// Methods
		// [XID] // 0x0000000189910920-0x0000000189910940
		public void PlaySwitchNextPageAni() {} // 0x0000000184083C60-0x0000000184083DB0
		// [XID] // 0x0000000189918540-0x0000000189918560
		public void PlaySwitchPrevPageAni() {} // 0x0000000184083DB0-0x0000000184083F00
		// [XID] // 0x000000018991FD40-0x000000018991FD60
		public void ResetAniTrigger() {} // 0x0000000184083F00-0x0000000184084060
	}
}
