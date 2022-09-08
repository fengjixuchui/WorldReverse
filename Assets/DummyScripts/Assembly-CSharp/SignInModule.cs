/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SignInModule : BaseModule // TypeDefIndex: 21628
{
	// Fields
	private List<SignInInfo> _curSignInInfoList; // 0x10

	// Properties
	public List<SignInInfo> curSignInInfoList { /* [XID] */ /* 0x0000000189A540F0-0x0000000189A54110 */ get => default; } // 0x000000018241B7D0-0x000000018241B870 

	// Constructors
	public SignInModule() {} // 0x000000018241CB10-0x000000018241CBC0

	// Methods
	// [XID] // 0x0000000189A451D0-0x0000000189A451F0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x000000018241B5D0-0x000000018241B6B0
	// [XID] // 0x0000000189A4C8E0-0x0000000189A4C900
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x000000018241C2D0-0x000000018241C3A0
	// [XID] // 0x0000000189A5BB40-0x0000000189A5BB60
	public SignInInfo GetSignInInfo(uint configId) => default; // 0x000000018241BEA0-0x000000018241C040
	// [XID] // 0x0000000189A632D0-0x0000000189A632F0
	public uint GetCurSignInPeroid(SignInInfo info) => default; // 0x000000018241C890-0x000000018241CB10
	// [XID] // 0x0000000189A6ADF0-0x0000000189A6AE10
	public List<SignInDayExcelConfig> GetCurSignInDataList(SignInInfo info) => default; // 0x000000018241C040-0x000000018241C2D0
	// [XID] // 0x0000000189A724A0-0x0000000189A724C0
	public override bool OnPacket(Packet packet) => default; // 0x000000018241B410-0x000000018241B530
	// [XID] // 0x0000000189A7A0B0-0x0000000189A7A0D0
	private void OnGetSignInRewardRsp(GetSignInRewardRsp ntf) {} // 0x000000018241B9B0-0x000000018241BCE0
	// [XID] // 0x0000000189A81550-0x0000000189A81570
	private void OnSignInInfoRsp(SignInInfoRsp ntf) {} // 0x000000018241C440-0x000000018241C890
	// [XID] // 0x0000000189A88F90-0x0000000189A88FB0
	public void RequestSignInInfoReq() {} // 0x000000018241BDC0-0x000000018241BEA0
	// [XID] // 0x0000000189A907B0-0x0000000189A907D0
	public void GetSignInRewardReq(uint schedule_id, uint dayCount) {} // 0x000000018241B6B0-0x000000018241B7D0
	// [XID] // 0x0000000189A97FD0-0x0000000189A97FF0
	public override void ClearOnBackHome() {} // 0x000000018241B870-0x000000018241B930
	// [XID] // 0x0000000189A9F3B0-0x0000000189A9F3D0
	public override void ClearOnDisconnect() {} // 0x000000018241C3A0-0x000000018241C440
	// [XID] // 0x0000000189AA6BA0-0x0000000189AA6BC0
	public override void ClearOnLevelDestroy() {} // 0x000000018241B530-0x000000018241B5D0
}

