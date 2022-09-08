/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using MiHoYoSDKJSON;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKProtocolManager // TypeDefIndex: 8695
	{
		// Fields
		private JSONNode _protocol; // 0x10
		private string comboId; // 0x18
		private static MiHoYoSDKProtocolManager _instance; // 0x00
	
		// Properties
		public static MarketingProtocolModel marketingModel { /* [XID] */ /* 0x0000000189921130-0x0000000189921170 */ get; /* [XID] */ /* 0x0000000189916B50-0x0000000189916B90 */ private set; } // 0x0000000186267B70-0x0000000186267BE0 0x0000000186267BE0-0x0000000186267C50
	
		// Constructors
		public MiHoYoSDKProtocolManager() {} // 0x0000000186267B10-0x0000000186267B70
	
		// Methods
		// [XID] // 0x000000018983C410-0x000000018983C430
		public static MiHoYoSDKProtocolManager Instance() => default; // 0x00000001862656D0-0x00000001862657B0
		// [XID] // 0x00000001898439E0-0x0000000189843A00
		public void RequestProtocol() {} // 0x0000000186266630-0x0000000186266920
		// [XID] // 0x0000000189B77D20-0x0000000189B77D40
		public void RequestAgreementInfos() {} // 0x0000000186266190-0x00000001862663D0
		// [XID] // 0x000000018993AAB0-0x000000018993AAD0
		public void RequestOperateAgreement(string operation) {} // 0x00000001862663D0-0x0000000186266630
		// [XID] // 0x00000001899D4420-0x00000001899D4440
		private void ClearMarketingModel() {} // 0x0000000186265060-0x00000001862651E0
		// [XID] // 0x0000000189A0CA50-0x0000000189A0CA70
		private void OnAgreeMarketing(string responseString) {} // 0x0000000186265940-0x00000001862659F0
		// [XID] // 0x0000000189950F10-0x0000000189950F30
		private void OnGetMarketingProtocolInfo(string responseString) {} // 0x00000001862659F0-0x0000000186265D20
		// [XID] // 0x00000001899586A0-0x00000001899586C0
		private void OnGetMarketingProtocolTimeOut() {} // 0x0000000186265D20-0x0000000186265DF0
		// [XID] // 0x000000018995FD50-0x000000018995FD70
		private void OnProtocol(string responseString) {} // 0x0000000186265DF0-0x0000000186265FF0
		// [XID] // 0x0000000189825E00-0x0000000189825E20
		public JSONNode GetProtocol() => default; // 0x0000000186265440-0x00000001862655A0
		// [XID] // 0x000000018996E8B0-0x000000018996E8D0
		private void SetProcotol(JSONNode protocol) {} // 0x0000000186266920-0x0000000186266A50
		// [XID] // 0x0000000189976470-0x0000000189976490
		public void SetUserProtocolFlag(string combo_id) {} // 0x0000000186266A50-0x0000000186266DB0
		// [XID] // 0x000000018997D770-0x000000018997D790
		public JSONNode GetUserProtocolFlag(string combo_id) => default; // 0x00000001862655A0-0x00000001862656D0
		// [XID] // 0x0000000189985330-0x0000000189985350
		private string GetProtocolVersionKey() => default; // 0x0000000186265310-0x0000000186265440
		// [XID] // 0x0000000189AE74A0-0x0000000189AE74C0
		private string GetProtocolShowFlag() => default; // 0x00000001862651E0-0x0000000186265310
		// [XID] // 0x0000000189994B40-0x0000000189994B60
		public bool CheckShowProtocol(string combo_id) => default; // 0x0000000186264CD0-0x0000000186265060
		// [XID] // 0x000000018999C3A0-0x000000018999C3C0
		private void CheckOverseaShowProtocol() {} // 0x0000000186264920-0x0000000186264CD0
		// [XID] // 0x00000001899A3CA0-0x00000001899A3CC0
		public void ShowProtocol(bool isUpdate = false /* Metadata: 0x00AE1FED */) {} // 0x00000001862674E0-0x0000000186267660
		// [XID] // 0x0000000189AD8130-0x0000000189AD8150
		public void ShowOverseaProtocol(ProtocolType protocolType = ProtocolType.Default /* Metadata: 0x00AE1FEE */) {} // 0x0000000186266EB0-0x0000000186267030
		// [XID] // 0x0000000189A419A0-0x0000000189A419C0
		private void OnAcceptUserAgreement() {} // 0x0000000186265880-0x0000000186265940
		// [XID] // 0x0000000189A57DC0-0x0000000189A57DE0
		private void OnRefuseUserAgreement() {} // 0x00000001862660C0-0x0000000186266190
		// [XID] // 0x00000001899C1F10-0x00000001899C1F30
		private void OnAcceptOverseaUserAgreement(string user_status) {} // 0x00000001862657B0-0x0000000186265880
		// [XID] // 0x00000001899C92E0-0x00000001899C9300
		private void OnRefuseOverseaUserAgreement() {} // 0x0000000186265FF0-0x00000001862660C0
		// [XID] // 0x0000000189B319E0-0x0000000189B31A00
		public void ShowUserAgreement() {} // 0x0000000186267660-0x0000000186267B10
		// [XID] // 0x00000001898EA000-0x00000001898EA020
		public void ShowPrivacyProtocol() {} // 0x0000000186267030-0x00000001862674E0
		// [XID] // 0x00000001899DF8E0-0x00000001899DF900
		public void ShowMarketingProtocol(string marketingURL) {} // 0x0000000186266DB0-0x0000000186266EB0
	}
}
