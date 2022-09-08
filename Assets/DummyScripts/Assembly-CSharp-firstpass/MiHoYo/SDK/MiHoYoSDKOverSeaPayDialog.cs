/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKOverSeaPayDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8882
	{
		// Fields
		private JSONNode payInfo; // 0x20
		private JSONObject vendors; // 0x28
		private MiHoYoSDKOverSeaPayManager.PayVendor selectVendor; // 0x30
		private bool isPaying; // 0x34
		private const string PayDialogPrefabPath = "UI/OverSeaPayDialog.Prefab"; // Metadata: 0x00AE41A7
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE41C5
		private const string TitleTextPath = "Dialog/TitleText"; // Metadata: 0x00AE41D7
		private const string GoodsContentGameObjectPath = "Dialog/GoodsDialog"; // Metadata: 0x00AE41EB
		private const string GoodsNameTextPath = "Dialog/GoodsDialog/GoodsNameText"; // Metadata: 0x00AE4201
		private const string GoodsPriceTextPath = "Dialog/GoodsDialog/GoodsPriceText"; // Metadata: 0x00AE4225
		private const string PayTypeTitleTextPath = "Dialog/GoodsDialog/PayTypeTitleText"; // Metadata: 0x00AE424A
		private const string PayTypeBtnPath = "Dialog/GoodsDialog/PayTypeBtn"; // Metadata: 0x00AE4271
		private const string PayTypeBtnTextPath = "Dialog/GoodsDialog/PayTypeBtn/Text"; // Metadata: 0x00AE4292
		private const string SubPayTypeTitleTextPath = "Dialog/GoodsDialog/SubPayTypeTitleText"; // Metadata: 0x00AE42B8
		private const string VisaBtnPath = "Dialog/GoodsDialog/SubPayTypeGrid/Visa"; // Metadata: 0x00AE42E2
		private const string MasterCardBtnPath = "Dialog/GoodsDialog/SubPayTypeGrid/MasterCard"; // Metadata: 0x00AE430C
		private const string AmericanExpressBtnPath = "Dialog/GoodsDialog/SubPayTypeGrid/AmericanExpress"; // Metadata: 0x00AE433C
		private const string JCBBtnPath = "Dialog/GoodsDialog/SubPayTypeGrid/JCB"; // Metadata: 0x00AE4371
		private const string PayPalBtnPath = "Dialog/GoodsDialog/SubPayTypeGrid/PayPal"; // Metadata: 0x00AE439A
		private const string PayButtonPath = "Dialog/GoodsDialog/PayBtn"; // Metadata: 0x00AE43C6
		private const string PayButtonTitlePath = "Dialog/GoodsDialog/PayBtn/Text"; // Metadata: 0x00AE43E3
		private const string PayButtonLoadingObjectPath = "Dialog/GoodsDialog/Loading"; // Metadata: 0x00AE4405
		private const string PayStatusObjectPath = "Dialog/StatusContent"; // Metadata: 0x00AE4423
		private const string PaySuccessObjectPath = "Dialog/StatusContent/Success"; // Metadata: 0x00AE443B
		private const string PaySuccessTitleTextPath = "Dialog/StatusContent/Success/Result"; // Metadata: 0x00AE445B
		private const string PaySuccessTipsTextPath = "Dialog/StatusContent/Success/Tips"; // Metadata: 0x00AE4482
		private const string PaySuccessButtonPath = "Dialog/StatusContent/Success/RefreshBtn"; // Metadata: 0x00AE44A7
		private const string PaySuccessButtonTextPath = "Dialog/StatusContent/Success/RefreshBtn/Text"; // Metadata: 0x00AE44D2
		private const string PayFailObjectPath = "Dialog/StatusContent/Fail"; // Metadata: 0x00AE4502
		private const string PayFailTitleTextPath = "Dialog/StatusContent/Fail/Result"; // Metadata: 0x00AE451F
		private const string PayFailTipsTextPath = "Dialog/StatusContent/Fail/Tips"; // Metadata: 0x00AE4543
		private const string PayFailButtonPath = "Dialog/StatusContent/Fail/RefreshBtn"; // Metadata: 0x00AE4565
		private const string PayFailButtonTextPath = "Dialog/StatusContent/Fail/RefreshBtn/Text"; // Metadata: 0x00AE458D
		private Button backButton; // 0x38
		private UnityEngine.UI.Text dialogTitleText; // 0x40
		private GameObject goodsContentGameObject; // 0x48
		private UnityEngine.UI.Text goodsNameText; // 0x50
		private UnityEngine.UI.Text goodsPriceText; // 0x58
		private UnityEngine.UI.Text payTypeTitleText; // 0x60
		private Toggle payTypeButton; // 0x68
		private UnityEngine.UI.Text payTypeButtonText; // 0x70
		private UnityEngine.UI.Text subPayTypeTitleText; // 0x78
		private Toggle visaToggle; // 0x80
		private Toggle masterCardToggle; // 0x88
		private Toggle americanExpressToggle; // 0x90
		private Toggle jcbToggle; // 0x98
		private Toggle payPalToggle; // 0xA0
		private Button payButton; // 0xA8
		private UnityEngine.UI.Text payButtonTitleText; // 0xB0
		private GameObject payButtonLoadingObject; // 0xB8
		private GameObject payStatusObject; // 0xC0
		private GameObject paySuccessObject; // 0xC8
		private UnityEngine.UI.Text paySuccessTitleText; // 0xD0
		private UnityEngine.UI.Text paySuccessTipsText; // 0xD8
		private Button paySuccessButton; // 0xE0
		private UnityEngine.UI.Text paySuccessButtonText; // 0xE8
		private GameObject payFailObject; // 0xF0
		private UnityEngine.UI.Text payFailTitleText; // 0xF8
		private UnityEngine.UI.Text payFailTipsText; // 0x100
		private Button payFailButton; // 0x108
		private UnityEngine.UI.Text payFailButtonText; // 0x110
		private static MiHoYoSDKOverSeaPayDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKOverSeaPayDialog() {} // 0x0000000185F46F30-0x0000000185F46FA0
	
		// Methods
		// [XID] // 0x00000001896E3380-0x00000001896E33A0
		public static MiHoYoSDKOverSeaPayDialog Instance() => default; // 0x0000000185F456B0-0x0000000185F457C0
		// [XID] // 0x00000001896256F0-0x0000000189625710
		public static bool IsExist() => default; // 0x0000000185F457C0-0x0000000185F458C0
		// [XID] // 0x00000001896F18F0-0x00000001896F1910
		public void Init() {} // 0x0000000185F443D0-0x0000000185F456B0
		// [XID] // 0x000000018991A2A0-0x000000018991A2C0
		public void Show(JSONNode info, JSONObject vendorsObject) {} // 0x0000000185F46DB0-0x0000000185F46ED0
		// [XID] // 0x00000001896B3D70-0x00000001896B3D90
		public void Hide() {} // 0x0000000185F442D0-0x0000000185F443D0
		// [XID] // 0x00000001896755D0-0x00000001896755F0
		public void Back() {} // 0x0000000185F43B00-0x0000000185F43CC0
		// [XID] // 0x000000018970FE90-0x000000018970FEB0
		public void ShowBuyLoading() {} // 0x0000000185F46AB0-0x0000000185F46B70
		// [XID] // 0x0000000189717060-0x0000000189717080
		public void HideBuyLoading() {} // 0x0000000185F44210-0x0000000185F442D0
		// [XID] // 0x00000001898BD640-0x00000001898BD660
		public void ShowPaySuccess() {} // 0x0000000185F46C90-0x0000000185F46DB0
		// [XID] // 0x00000001897F7880-0x00000001897F78A0
		public void ShowNetworkError() {} // 0x0000000185F46B70-0x0000000185F46C90
		// [XID] // 0x0000000189818910-0x0000000189818930
		private void RequestPlatList() {} // 0x0000000185F469F0-0x0000000185F46AB0
		// [XID] // 0x0000000189734E50-0x0000000189734E70
		private void RefreshPayInfo() {} // 0x0000000185F45A20-0x0000000185F469F0
		// [XID] // 0x000000018973CA50-0x000000018973CA70
		private void ClickPayTypeButton(bool value) {} // 0x0000000185F43FC0-0x0000000185F44070
		// [XID] // 0x0000000189743F00-0x0000000189743F20
		private void ClickVisaVendor(bool value) {} // 0x0000000185F44070-0x0000000185F44130
		// [XID] // 0x000000018974BB90-0x000000018974BBB0
		private void ClickECMCVendor(bool value) {} // 0x0000000185F43D80-0x0000000185F43E40
		// [XID] // 0x0000000189752E90-0x0000000189752EB0
		private void ClickAMEXVendor(bool value) {} // 0x0000000185F43CC0-0x0000000185F43D80
		// [XID] // 0x000000018975A160-0x000000018975A180
		private void ClickJCBVendor(bool value) {} // 0x0000000185F43E40-0x0000000185F43F00
		// [XID] // 0x0000000189761EC0-0x0000000189761EE0
		private void ClickPayPalVendor(bool value) {} // 0x0000000185F43F00-0x0000000185F43FC0
		// [XID] // 0x00000001897692D0-0x00000001897692F0
		private void clickPayButton() {} // 0x0000000185F46FA0-0x0000000185F47150
		// [XID] // 0x0000000189770A40-0x0000000189770A60
		private void OnEnsure() {} // 0x0000000185F45980-0x0000000185F45A20
		// [XID] // 0x00000001897782F0-0x0000000189778310
		private void OnCancel() {} // 0x0000000185F458C0-0x0000000185F45980
		// [XID] // 0x000000018977F7A0-0x000000018977F7C0
		public override void Dealloc() {} // 0x0000000185F44130-0x0000000185F44210
	}
}
