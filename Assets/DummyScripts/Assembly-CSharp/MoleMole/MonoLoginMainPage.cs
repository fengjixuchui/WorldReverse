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
	public class MonoLoginMainPage : MonoUIProxy // TypeDefIndex: 30297
	{
		// Fields
		public LoginMainPageContext.LoginState showCurState; // 0x40
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public GameObject firstSelectPanel; // 0x48
		public GameObject bottomPanel; // 0x50
		public GameObject midPanel; // 0x58
		public GameObject progressPanel; // 0x60
		public SimpleText progressText; // 0x68
		public bool isProgressShow; // 0x70
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoUIContainer _quitBtnPC; // 0x78
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public UnityEngine.UI.Text curInfo; // 0x80
		public UnityEngine.UI.Text userInfo; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _versionLabel; // 0x90
		public UnityEngine.UI.Text selectServerDesc; // 0x98
		public UnityEngine.UI.Text switchBtnText; // 0xA0
		public Button bgBtn; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Button switchServerBtn; // 0xB0
		public Button pressStartBtn; // 0xB8
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoLoginDialog _loginDialog; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0xC8
		public MonoServerSelectDialog serverDialog; // 0xD0
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoUIContainer _downloadBtn; // 0xD8
		// [Header] // 0x00000001897BFE60-0x00000001897BFEB0
		[SerializeField] // 0x00000001897BFE60-0x00000001897BFEB0
		private GameObject _bgmTips; // 0xE0
	
		// Properties
		public MonoLoginDialog loginDialog { /* [XID] */ /* 0x00000001897F9040-0x00000001897F9060 */ get => default; } // 0x0000000184280C00-0x0000000184280CB0 
		public MonoUIContainer logoutButton { /* [XID] */ /* 0x0000000189800650-0x0000000189800670 */ get => default; } // 0x0000000184280E90-0x0000000184280F50 
		public MonoUIContainer loginButton { /* [XID] */ /* 0x0000000189807CD0-0x0000000189807CF0 */ get => default; } // 0x0000000184280B40-0x0000000184280C00 
		public MonoUIContainer repairButton { /* [XID] */ /* 0x000000018980F5D0-0x000000018980F5F0 */ get => default; } // 0x0000000184281180-0x0000000184281240 
		public MonoUIContainer noticeButton { /* [XID] */ /* 0x0000000189816C40-0x0000000189816C60 */ get => default; } // 0x0000000184280F50-0x0000000184281010 
		public Button scanCodeButton { /* [XID] */ /* 0x000000018981E4F0-0x000000018981E510 */ get => default; } // 0x0000000184281240-0x0000000184281300 
		public Button continueServerBtn { /* [XID] */ /* 0x0000000189825970-0x0000000189825990 */ get => default; } // 0x0000000184280910-0x00000001842809D0 
		public Button quitButton { /* [XID] */ /* 0x000000018982D120-0x000000018982D140 */ get => default; } // 0x00000001842810D0-0x0000000184281180 
		public string version { /* [XID] */ /* 0x0000000189834880-0x00000001898348A0 */ set {} } // 0x00000001842818A0-0x0000000184281970
		public MonoMaskController logoutButtonMask { /* [XID] */ /* 0x000000018983BEF0-0x000000018983BF10 */ get => default; } // 0x0000000184280CB0-0x0000000184280E90 
		public MonoUIContainer downloadBtn { /* [XID] */ /* 0x0000000189843520-0x0000000189843540 */ get => default; } // 0x0000000184280A90-0x0000000184280B40 
		public MonoUIContainer userAgrPS4Btn { /* [XID] */ /* 0x000000018984AA20-0x000000018984AA40 */ get => default; } // 0x00000001842813C0-0x0000000184281480 
		public MonoUIContainer privacyPS4Btn { /* [XID] */ /* 0x0000000189851E00-0x0000000189851E20 */ get => default; } // 0x0000000184281010-0x00000001842810D0 
		public MonoUIContainer startPS4Btn { /* [XID] */ /* 0x00000001898596C0-0x00000001898596E0 */ get => default; } // 0x0000000184281300-0x00000001842813C0 
		public MonoUIContainer detailsPS4Btn { /* [XID] */ /* 0x0000000189860860-0x0000000189860880 */ get => default; } // 0x00000001842809D0-0x0000000184280A90 
		public GameObject bgmTips { /* [XID] */ /* 0x0000000189867F50-0x0000000189867F70 */ get => default; } // 0x0000000184280860-0x0000000184280910 
		public float progressFillArea { /* [XID] */ /* 0x000000018986F4B0-0x000000018986F4D0 */ set {} } // 0x0000000184281480-0x0000000184281690
		public string progressTxtLabel { /* [XID] */ /* 0x0000000189876B00-0x0000000189876B20 */ set {} } // 0x0000000184281690-0x00000001842818A0
	
		// Constructors
		public MonoLoginMainPage() {} // 0x0000000184280780-0x0000000184280860
	
		// Methods
		// [XID] // 0x00000001897CBA40-0x00000001897CBA60
		protected void Awake() {} // 0x000000018427FE90-0x0000000184280220
		// [XID] // 0x00000001897D3350-0x00000001897D3370
		public void SetBtnScanQRCodeActive(bool isActive) {} // 0x0000000184280420-0x0000000184280520
		// [XID] // 0x00000001897DADB0-0x00000001897DADD0
		public void SetBtnBulletinActive(bool isActive) {} // 0x0000000184280350-0x0000000184280420
		// [XID] // 0x00000001897E24C0-0x00000001897E24E0
		public void FadeIn() {} // 0x0000000184280220-0x0000000184280350
		// [XID] // 0x00000001897E9C30-0x00000001897E9C50
		public void WhiteCurtain() {} // 0x0000000184280650-0x0000000184280780
		// [XID] // 0x00000001897F18F0-0x00000001897F1910
		public void StartFadeIn() {} // 0x0000000184280520-0x0000000184280650
	}
}
