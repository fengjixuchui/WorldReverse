/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKQRLogin : MiHoYoSDKBaseDialog // TypeDefIndex: 8874
	{
		// Fields
		private LOGIN_TYPE lastLoginType; // 0x20
		private const string LoginByQRCodePrefabPath = "UI/LoginByQRCodeDialog.Prefab"; // Metadata: 0x00AE3CAD
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE3CCE
		private const string AccountLoginButtonPath = "Dialog/PCButton"; // Metadata: 0x00AE3CE1
		private const string QRBubbleTextPath = "Dialog/Bubble/Text"; // Metadata: 0x00AE3CF4
		private const string QRContentPath = "Dialog/QRContent"; // Metadata: 0x00AE3D0A
		private const string QRCodePath = "Dialog/QRContent/QRCode/QRCode"; // Metadata: 0x00AE3D1E
		private const string OverdueContentPath = "Dialog/QRContent/OverdueContent"; // Metadata: 0x00AE3D40
		private const string RefreshButtonPath = "Dialog/QRContent/OverdueContent/RefreshBtn"; // Metadata: 0x00AE3D63
		private const string LoadingPath = "Dialog/QRContent/Loading"; // Metadata: 0x00AE3D91
		private const string StatusGameObjectPath = "Dialog/StatusContent"; // Metadata: 0x00AE3DAD
		private const string SuccessContentPath = "Dialog/StatusContent/Success"; // Metadata: 0x00AE3DC5
		private const string FailContentPath = "Dialog/StatusContent/Fail"; // Metadata: 0x00AE3DE5
		private const string FailRefreshButtonPath = "Dialog/StatusContent/Fail/RefreshBtn"; // Metadata: 0x00AE3E02
		private const string SuccessRefreshButtonPath = "Dialog/StatusContent/Success/RefreshBtn"; // Metadata: 0x00AE3E2A
		private const string LoginTipsObjectPath = "Dialog/StatusContent/Success/LoginTips"; // Metadata: 0x00AE3E55
		private const string TipsObjectPath = "Dialog/QRContent/Text"; // Metadata: 0x00AE3E7F
		private Button closeButton; // 0x28
		private Button pcButton; // 0x30
		private UnityEngine.UI.Text qrBubbleText; // 0x38
		private GameObject qrContentGameObject; // 0x40
		private GameObject qrCodeGameObject; // 0x48
		private GameObject overdueGameObject; // 0x50
		private Button overdueRefreshButton; // 0x58
		private GameObject loadingGameObject; // 0x60
		private GameObject statusContentGameObject; // 0x68
		private GameObject successContentGameObject; // 0x70
		private GameObject failContentGameObject; // 0x78
		private Button failRefreshButton; // 0x80
		private GameObject successRefreshButtonObject; // 0x88
		private Button successRefreshButton; // 0x90
		private GameObject loginTipsObject; // 0x98
		private MiHoYoSDKQRCode qrCodeCS; // 0xA0
		private UnityEngine.UI.Text gameTips; // 0xA8
		private static MiHoYoSDKQRLogin _instance; // 0x00
	
		// Constructors
		public MiHoYoSDKQRLogin() {} // 0x0000000186269F00-0x0000000186269F60
	
		// Methods
		// [XID] // 0x0000000189A47A10-0x0000000189A47A30
		public static MiHoYoSDKQRLogin Instance() => default; // 0x0000000186269220-0x0000000186269330
		// [XID] // 0x0000000189A4F210-0x0000000189A4F230
		public static bool IsExist() => default; // 0x0000000186269330-0x0000000186269430
		// [XID] // 0x0000000189A56820-0x0000000189A56840
		public void Init() {} // 0x0000000186268810-0x0000000186269220
		// [XID] // 0x0000000189AFF450-0x0000000189AFF470
		public void SetGameTips(string name) {} // 0x00000001862694F0-0x0000000186269630
		// [XID] // 0x00000001897C4580-0x00000001897C45A0
		public void Show(LOGIN_TYPE type = LOGIN_TYPE.ACCOUNT_PASSWORD /* Metadata: 0x00AE3CA9 */) {} // 0x0000000186269D00-0x0000000186269EA0
		// [XID] // 0x0000000189A6D290-0x0000000189A6D2B0
		public void Hide() {} // 0x0000000186268740-0x0000000186268810
		// [XID] // 0x0000000189A74B40-0x0000000189A74B60
		public void Close() {} // 0x00000001862685C0-0x0000000186268680
		// [XID] // 0x000000018997C790-0x000000018997C7B0
		public void Back() {} // 0x00000001862684D0-0x00000001862685C0
		// [XID] // 0x000000018985A3B0-0x000000018985A3D0
		public override void Dealloc() {} // 0x0000000186268680-0x0000000186268740
		// [XID] // 0x0000000189A8B8F0-0x0000000189A8B910
		public void Refresh() {} // 0x0000000186269430-0x00000001862694F0
		// [XID] // 0x00000001897A1520-0x00000001897A1540
		public void ShowQRCodeLoading() {} // 0x0000000186269820-0x0000000186269950
		// [XID] // 0x0000000189A9A980-0x0000000189A9A9A0
		public void ShowQRCode(string url) {} // 0x0000000186269A60-0x0000000186269BB0
		// [XID] // 0x0000000189AA19F0-0x0000000189AA1A10
		public void ShowQRCodeOverdue() {} // 0x0000000186269950-0x0000000186269A60
		// [XID] // 0x0000000189B13FE0-0x0000000189B14000
		public void ShowNetworkError() {} // 0x0000000186269710-0x0000000186269820
		// [XID] // 0x0000000189AB0C00-0x0000000189AB0C20
		public void ShowScanSuccess() {} // 0x0000000186269BB0-0x0000000186269D00
		// [XID] // 0x0000000189AB82E0-0x0000000189AB8300
		public void ShowLoginSuccess() {} // 0x0000000186269630-0x0000000186269710
	}
}
