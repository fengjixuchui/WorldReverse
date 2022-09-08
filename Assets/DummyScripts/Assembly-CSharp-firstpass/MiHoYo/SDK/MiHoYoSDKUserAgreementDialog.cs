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
	internal class MiHoYoSDKUserAgreementDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8880
	{
		// Fields
		private const string UserAgreementPrefebPath = "UI/NewUserAgreementDialog.Prefab"; // Metadata: 0x00AE4062
		private const string UserAgreementBtnPath = "Dialog/UserAgreementBtn"; // Metadata: 0x00AE4086
		private const string PrivacyBtnPath = "Dialog/PrivacyBtn"; // Metadata: 0x00AE40A1
		private const string RefuseBtnPath = "Dialog/RefuseBtn"; // Metadata: 0x00AE40B6
		private const string AcceptBtnPath = "Dialog/AcceptBtn"; // Metadata: 0x00AE40CA
		private const string TitlePath = "Dialog/Title"; // Metadata: 0x00AE40DE
		private const string ContentPath = "Dialog/Content"; // Metadata: 0x00AE40EE
		private const string SubTitlePath = "Dialog/SubTitle"; // Metadata: 0x00AE4100
		private const string UserAgreementBtnTextPath = "Dialog/UserAgreementBtn/Text"; // Metadata: 0x00AE4113
		private const string PrivacyBtnTextPath = "Dialog/PrivacyBtn/Text"; // Metadata: 0x00AE4133
		private const string RefuseBtnTextPath = "Dialog/RefuseBtn/Text"; // Metadata: 0x00AE414D
		private const string AcceptBtnTextPath = "Dialog/AcceptBtn/Text"; // Metadata: 0x00AE4166
		private Button userAgreementButton; // 0x30
		private Button privacyButton; // 0x38
		private Button refuseButton; // 0x40
		private Button acceptButton; // 0x48
		private static MiHoYoSDKUserAgreementDialog _instance; // 0x00
	
		// Events
		public event Action OnAcceptUserAgreement;
		public event Action OnRefuseUserAgreement;
	
		// Constructors
		public MiHoYoSDKUserAgreementDialog() {} // 0x000000018596D1A0-0x000000018596D200
	
		// Methods
		// [XID] // 0x0000000189655C00-0x0000000189655C20
		public static MiHoYoSDKUserAgreementDialog Instance() => default; // 0x000000018596CCA0-0x000000018596CDB0
		// [XID] // 0x000000018965D360-0x000000018965D380
		public static bool IsExist() => default; // 0x000000018596CDB0-0x000000018596CEB0
		// [XID] // 0x0000000189664970-0x0000000189664990
		public void Init() {} // 0x000000018596C840-0x000000018596CCA0
		// [XID] // 0x000000018966BF80-0x000000018966BFA0
		private void updateText(bool isUpdate = false /* Metadata: 0x00AE4060 */) {} // 0x000000018596D680-0x000000018596E020
		// [XID] // 0x0000000189673D80-0x0000000189673DA0
		public void Show(bool isUpdate = false /* Metadata: 0x00AE4061 */) {} // 0x000000018596D030-0x000000018596D140
		// [XID] // 0x000000018967B5A0-0x000000018967B5C0
		public void Hide() {} // 0x000000018596C770-0x000000018596C840
		// [XID] // 0x0000000189682CF0-0x0000000189682D10
		private void ClickRefuseButton() {} // 0x000000018596C360-0x000000018596C530
		// [XID] // 0x000000018968A880-0x000000018968A8A0
		private void ClickAcceptButton() {} // 0x000000018596C280-0x000000018596C360
		// [XID] // 0x00000001896926C0-0x00000001896926E0
		private void ClickUserAgreementButton() {} // 0x000000018596C530-0x000000018596C5F0
		// [XID] // 0x0000000189699930-0x0000000189699950
		private void ClickUserPrivacyButton() {} // 0x000000018596C5F0-0x000000018596C6B0
		// [XID] // 0x00000001896A0F50-0x00000001896A0F70
		private void OnEure() {} // 0x000000018596CF90-0x000000018596D030
		// [XID] // 0x00000001896A83B0-0x00000001896A83D0
		private void OnCancel() {} // 0x000000018596CEB0-0x000000018596CF90
		// [XID] // 0x00000001896AF710-0x00000001896AF730
		public override void Dealloc() {} // 0x000000018596C6B0-0x000000018596C770
	}
}
