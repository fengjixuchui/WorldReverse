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
	public class MiHoYoSDKPayDialog : MiHoYoSDKBaseDialog // TypeDefIndex: 8883
	{
		// Fields
		private JSONNode goodsInfo; // 0x20
		private PayPlat payPlat; // 0x28
		private const string PayDialogPrefabPath = "UI/PayDialog.Prefab"; // Metadata: 0x00AE45BA
		private const string BackButtonPath = "Dialog/BackBtn"; // Metadata: 0x00AE45D1
		private const string GoodsContentGameObjectPath = "Dialog/GoodsDialog"; // Metadata: 0x00AE45E3
		private const string GoodsNameTextPath = "Dialog/GoodsDialog/GoodsNameText"; // Metadata: 0x00AE45F9
		private const string GoodsPriceTextPath = "Dialog/GoodsDialog/GoodsPriceText"; // Metadata: 0x00AE461D
		private const string AliPayBtnPath = "Dialog/GoodsDialog/AliPayBtn"; // Metadata: 0x00AE4642
		private const string WeixinPayBtnPath = "Dialog/GoodsDialog/WeixinPayBtn"; // Metadata: 0x00AE4662
		private const string QRCodePath = "Dialog/GoodsDialog/QRCode/QRCode"; // Metadata: 0x00AE4685
		private const string QRCodePayTextPath = "Dialog/GoodsDialog/QRCode/Text"; // Metadata: 0x00AE46A9
		private const string OverdueContentPath = "Dialog/GoodsDialog/QRCode/OverdueContent"; // Metadata: 0x00AE46CB
		private const string RefreshButtonPath = "Dialog/GoodsDialog/QRCode/OverdueContent/RefreshBtn"; // Metadata: 0x00AE46F7
		private const string LoadingPath = "Dialog/GoodsDialog/QRCode/Loading"; // Metadata: 0x00AE472E
		private const string StatusGameObjectPath = "Dialog/StatusContent"; // Metadata: 0x00AE4753
		private const string SuccessContentPath = "Dialog/StatusContent/Success"; // Metadata: 0x00AE476B
		private const string FailContentPath = "Dialog/StatusContent/Fail"; // Metadata: 0x00AE478B
		private const string FailRefreshButtonPath = "Dialog/StatusContent/Fail/RefreshBtn"; // Metadata: 0x00AE47A8
		private const string SuccessRefreshButtonPath = "Dialog/StatusContent/Success/RefreshBtn"; // Metadata: 0x00AE47D0
		private const string LoginTipsObjectPath = "Dialog/StatusContent/Success/LoginTips"; // Metadata: 0x00AE47FB
		private const string QRCodeContentPath = "Dialog/GoodsDialog/QRCode"; // Metadata: 0x00AE4825
		private const string CreateOrderFailObjectPath = "Dialog/GoodsDialog/Fail"; // Metadata: 0x00AE4842
		private const string CreateOrderFailButtonPath = "Button"; // Metadata: 0x00AE485D
		private Button backButton; // 0x30
		private GameObject goodsContentGameObject; // 0x38
		private UnityEngine.UI.Text goodsNameText; // 0x40
		private UnityEngine.UI.Text goodsPriceText; // 0x48
		private Toggle aliPayToggle; // 0x50
		private Image aliPayImage; // 0x58
		private Toggle weixinPayToggle; // 0x60
		private Image weixinPayImage; // 0x68
		private GameObject qrCodeGameObject; // 0x70
		private MiHoYoSDKQRCode qrCodeCS; // 0x78
		private UnityEngine.UI.Text payTipsText; // 0x80
		private GameObject overdueGameObject; // 0x88
		private Button overdueRefreshButton; // 0x90
		private GameObject loadingGameObject; // 0x98
		private GameObject statusContentGameObject; // 0xA0
		private GameObject successContentGameObject; // 0xA8
		private GameObject failContentGameObject; // 0xB0
		private Button failRefreshButton; // 0xB8
		private Button successRefreshButton; // 0xC0
		private GameObject qrCodeContentGameObject; // 0xC8
		private GameObject createOrderFailGameObject; // 0xD0
		private Button retryButton; // 0xD8
		private static MiHoYoSDKPayDialog _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKPayDialog() {} // 0x0000000186255EA0-0x0000000186255F10
	
		// Methods
		// [XID] // 0x0000000189787170-0x0000000189787190
		public static MiHoYoSDKPayDialog Instance() => default; // 0x0000000186254BA0-0x0000000186254CB0
		// [XID] // 0x000000018978E7C0-0x000000018978E7E0
		public static bool IsExist() => default; // 0x0000000186254CB0-0x0000000186254DB0
		// [XID] // 0x0000000189795EB0-0x0000000189795ED0
		public void Init() {} // 0x0000000186253F50-0x0000000186254BA0
		// [XID] // 0x00000001897F0620-0x00000001897F0640
		public void Show(JSONNode goods) {} // 0x0000000186255D00-0x0000000186255E40
		// [XID] // 0x00000001897A56C0-0x00000001897A56E0
		public void Hide() {} // 0x0000000186253E50-0x0000000186253F50
		// [XID] // 0x00000001897ACCD0-0x00000001897ACCF0
		public void Back() {} // 0x0000000186253850-0x0000000186253A10
		// [XID] // 0x0000000189966AF0-0x0000000189966B10
		private void RefreshGoodsInfo() {} // 0x0000000186254F10-0x0000000186255490
		// [XID] // 0x00000001897BC950-0x00000001897BC970
		public void Refresh() {} // 0x0000000186255490-0x00000001862555C0
		// [XID] // 0x00000001899145E0-0x0000000189914600
		public void ShowPayLoading() {} // 0x00000001862556E0-0x0000000186255850
		// [XID] // 0x00000001896F5890-0x00000001896F58B0
		public void ShowQRCode(string url) {} // 0x0000000186255B60-0x0000000186255D00
		// [XID] // 0x00000001897D2E50-0x00000001897D2E70
		public void ShowQRCodeOverdue() {} // 0x00000001862559E0-0x0000000186255B60
		// [XID] // 0x00000001896D0940-0x00000001896D0960
		public void ShowNetworkError() {} // 0x00000001862555C0-0x00000001862556E0
		// [XID] // 0x0000000189704500-0x0000000189704520
		public void ShowPaySuccess() {} // 0x0000000186255850-0x00000001862559E0
		// [XID] // 0x0000000189660AD0-0x0000000189660AF0
		private void ClickAliPayBtn(bool value) {} // 0x0000000186253A10-0x0000000186253B60
		// [XID] // 0x00000001899A7920-0x00000001899A7940
		private void ClickWeixinPayBtn(bool value) {} // 0x0000000186253B60-0x0000000186253CB0
		// [XID] // 0x00000001897F8BD0-0x00000001897F8BF0
		private void CreateOrder() {} // 0x0000000186253CB0-0x0000000186253D70
		// [XID] // 0x00000001898002A0-0x00000001898002C0
		private void OnEnsure() {} // 0x0000000186254E70-0x0000000186254F10
		// [XID] // 0x0000000189807940-0x0000000189807960
		private void OnCancel() {} // 0x0000000186254DB0-0x0000000186254E70
		// [XID] // 0x00000001899B2790-0x00000001899B27B0
		public override void Dealloc() {} // 0x0000000186253D70-0x0000000186253E50
	}
}
