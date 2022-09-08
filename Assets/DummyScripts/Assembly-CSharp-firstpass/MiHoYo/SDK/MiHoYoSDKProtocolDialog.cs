/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKProtocolDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8872
	{
		// Fields
		private const string UserAgreementPrefebPath = "UI/UserAgreementDialog.Prefab"; // Metadata: 0x00AE3B7F
		private const string AgreeAllPath = "Dialog/AgreeAll"; // Metadata: 0x00AE3BA0
		private const string UserAgreementPath = "Dialog/UserAgreement"; // Metadata: 0x00AE3BB3
		private const string PrivacyPath = "Dialog/Privacy"; // Metadata: 0x00AE3BCB
		private const string MarketingPath = "Dialog/Marketing"; // Metadata: 0x00AE3BDD
		private const string TogglePath = "/Toggle"; // Metadata: 0x00AE3BF1
		private const string TextPath = "/Text"; // Metadata: 0x00AE3BFC
		private const string ButtonPath = "/Button"; // Metadata: 0x00AE3C05
		private const string SubTextPath = "/SubText"; // Metadata: 0x00AE3C10
		private const string RefuseBtnPath = "Dialog/RefuseBtn"; // Metadata: 0x00AE3C1C
		private const string AcceptBtnPath = "Dialog/AcceptBtn"; // Metadata: 0x00AE3C30
		private const string TitlePath = "Dialog/Title"; // Metadata: 0x00AE3C44
		private const string ContentPath = "Dialog/Content/ViewPort/Content"; // Metadata: 0x00AE3C54
		private const string RefuseBtnTextPath = "Dialog/RefuseBtn/Text"; // Metadata: 0x00AE3C77
		private const string AcceptBtnTextPath = "Dialog/AcceptBtn/Text"; // Metadata: 0x00AE3C90
		private Toggle agreeAllToggle; // 0x30
		private Toggle userAgreeToggle; // 0x38
		private Toggle privacyToggle; // 0x40
		private Toggle marketingToggle; // 0x48
		private Button userAgreementButton; // 0x50
		private Button privacyButton; // 0x58
		private Button marketingButton; // 0x60
		private Button refuseButton; // 0x68
		private Button acceptButton; // 0x70
		private string marketingStatus; // 0x78
		private static MiHoYoSDKProtocolDialog _instance; // 0x10
	
		// Properties
		public static string marketingText { /* [XID] */ /* 0x0000000189965D90-0x0000000189965DD0 */ get; /* [XID] */ /* 0x000000018995B2F0-0x000000018995B330 */ set; } // 0x0000000186264540-0x00000001862645A0 0x0000000186264850-0x00000001862648B0
		public static string marketingURL { /* [XID] */ /* 0x000000018997ADF0-0x000000018997AE30 */ get; /* [XID] */ /* 0x0000000189970280-0x00000001899702C0 */ set; } // 0x00000001862645A0-0x0000000186264610 0x00000001862648B0-0x0000000186264920
	
		// Events
		public event Action<string> OnAcceptUserAgreement;
		public event Action OnRefuseUserAgreement;
	
		// Constructors
		public MiHoYoSDKProtocolDialog() {} // 0x00000001862642A0-0x0000000186264300
	
		// Methods
		// [XID] // 0x00000001899852F0-0x0000000189985310
		public static MiHoYoSDKProtocolDialog Instance() => default; // 0x00000001862628E0-0x0000000186262A00
		// [XID] // 0x000000018998CE00-0x000000018998CE20
		public static bool IsExist() => default; // 0x0000000186262A00-0x0000000186262B00
		// [XID] // 0x0000000189994AE0-0x0000000189994B00
		public void Init() {} // 0x00000001862620C0-0x00000001862628E0
		// [XID] // 0x000000018977B5A0-0x000000018977B5C0
		private void UpdateText(ProtocolType protocolType = ProtocolType.Default /* Metadata: 0x00AE3B77 */) {} // 0x00000001862634E0-0x00000001862642A0
		// [XID] // 0x0000000189773EF0-0x0000000189773F10
		public void Show(ProtocolType protocolType = ProtocolType.Default /* Metadata: 0x00AE3B7B */) {} // 0x0000000186262E20-0x0000000186262FA0
		// [XID] // 0x00000001899AB8B0-0x00000001899AB8D0
		public void Hide() {} // 0x0000000186261FF0-0x00000001862620C0
		// [XID] // 0x00000001899B3150-0x00000001899B3170
		private bool IsShowMarketingProtocol() => default; // 0x0000000186262B00-0x0000000186262CA0
		// [XID] // 0x00000001899A0AD0-0x00000001899A0AF0
		private void UpdateAcceptButtonStatus() {} // 0x0000000186263000-0x00000001862632B0
		// [XID] // 0x00000001899C1E90-0x00000001899C1EB0
		private void UpdateAgreeAllToggleStatus() {} // 0x00000001862632B0-0x00000001862634E0
		// [XID] // 0x00000001899C92A0-0x00000001899C92C0
		private void ClickRefuseButton() {} // 0x0000000186261B20-0x0000000186261CF0
		// [XID] // 0x0000000189783120-0x0000000189783140
		private void ClickAcceptButton() {} // 0x0000000186261510-0x0000000186261630
		// [XID] // 0x00000001899D8270-0x00000001899D8290
		private void ClickAgreeAllToggle(bool value) {} // 0x0000000186261630-0x0000000186261860
		// [XID] // 0x0000000189AD0460-0x0000000189AD0480
		private void ClickUserAgreeToggle(bool value) {} // 0x0000000186261CF0-0x0000000186261DB0
		// [XID] // 0x0000000189B22E30-0x0000000189B22E50
		private void ClickPrivacyToggle(bool value) {} // 0x0000000186261A60-0x0000000186261B20
		// [XID] // 0x00000001899EE8C0-0x00000001899EE8E0
		private void ClickMarketingToggle(bool value) {} // 0x0000000186261970-0x0000000186261A60
		// [XID] // 0x0000000189B2A4A0-0x0000000189B2A4C0
		private void ClickUserAgreementButton() {} // 0x0000000186261DB0-0x0000000186261E70
		// [XID] // 0x00000001899FD770-0x00000001899FD790
		private void ClickUserPrivacyButton() {} // 0x0000000186261E70-0x0000000186261F30
		// [XID] // 0x0000000189A04E20-0x0000000189A04E40
		private void ClickMarketingButton() {} // 0x0000000186261860-0x0000000186261970
		// [XID] // 0x0000000189A0C4D0-0x0000000189A0C4F0
		private void OnEure() {} // 0x0000000186262D80-0x0000000186262E20
		// [XID] // 0x0000000189A13ED0-0x0000000189A13EF0
		private void OnCancel() {} // 0x0000000186262CA0-0x0000000186262D80
		// [XID] // 0x00000001898A38A0-0x00000001898A38C0
		public override void Dealloc() {} // 0x0000000186261F30-0x0000000186261FF0
	}
}
