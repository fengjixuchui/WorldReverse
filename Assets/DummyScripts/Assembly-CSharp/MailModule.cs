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

public sealed class MailModule : BaseModule // TypeDefIndex: 21551
{
	// Properties
	public bool hasGetAllMail { /* [XID] */ /* 0x00000001897B8280-0x00000001897B82C0 */ get; /* [XID] */ /* 0x00000001897C2EF0-0x00000001897C2F30 */ private set; } // 0x00000001839FE940-0x00000001839FE9A0 0x00000001839FFC50-0x00000001839FFCB0
	public bool haveNewMail { /* [XID] */ /* 0x00000001897CD980-0x00000001897CD9C0 */ get; /* [XID] */ /* 0x00000001897D84C0-0x00000001897D8500 */ private set; } // 0x00000001839FFEB0-0x00000001839FFF10 0x00000001839FF3F0-0x00000001839FF450
	public bool isMailListTruncated { /* [XID] */ /* 0x00000001897E2840-0x00000001897E2880 */ get; /* [XID] */ /* 0x00000001897ED310-0x00000001897ED350 */ private set; } // 0x00000001839FF250-0x00000001839FF2B0 0x00000001839FF1F0-0x00000001839FF250
	public Dictionary<uint, MailDataItem> mailDataDic { /* [XID] */ /* 0x00000001897F7A30-0x00000001897F7A70 */ get; private set; } // 0x00000001839FF2B0-0x00000001839FF310 0x00000001839FF310-0x00000001839FF370

	// Constructors
	private MailModule() {} // 0x0000000183A00080-0x0000000183A00170

	// Methods
	// [XID] // 0x00000001898097A0-0x00000001898097C0
	private void ClearMailData() {} // 0x00000001839FE4D0-0x00000001839FE670
	// [XID] // 0x0000000189810F30-0x0000000189810F50
	public override bool OnPacket(Packet packet) => default; // 0x00000001839FE010-0x00000001839FE210
	// [XID] // 0x0000000189818A90-0x0000000189818AB0
	public override void ClearOnLevelDestroy() {} // 0x00000001839FE210-0x00000001839FE2B0
	// [XID] // 0x00000001898202D0-0x00000001898202F0
	public override void ClearOnDisconnect() {} // 0x00000001839FFE10-0x00000001839FFEB0
	// [XID] // 0x0000000189827930-0x0000000189827950
	public override void ClearOnBackHome() {} // 0x00000001839FE9A0-0x00000001839FEA40
	// [XID] // 0x000000018982EB50-0x000000018982EB70
	public MailDataItem GetMailDataByMailId(uint mailId) => default; // 0x00000001839FF080-0x00000001839FF1F0
	// [XID] // 0x00000001898364F0-0x0000000189836510
	public void RequestGetAllMail() {} // 0x00000001839FE3F0-0x00000001839FE4D0
	// [XID] // 0x000000018983D900-0x000000018983D920
	private void OnGetAllMailRsp(GetAllMailRsp rsp) {} // 0x00000001839FDA60-0x00000001839FDE50
	// [XID] // 0x00000001898451D0-0x00000001898451F0
	private void OnMailChangeNotify(MailChangeNotify ntf) {} // 0x00000001839FEA40-0x00000001839FF080
	// [XID] // 0x000000018984C640-0x000000018984C660
	public void SendReadMailNotify(List<uint> mailList) {} // 0x00000001839FFF10-0x0000000183A00080
	// [XID] // 0x00000001898536C0-0x00000001898536E0
	public void RequestGetMailItem(List<uint> mailList) {} // 0x00000001839FFAE0-0x00000001839FFC50
	// [XID] // 0x000000018985B1B0-0x000000018985B1D0
	private void OnGetMailItemRsp(GetMailItemRsp rsp) {} // 0x00000001839FF7A0-0x00000001839FFAE0
	// [XID] // 0x00000001898626B0-0x00000001898626D0
	public void SendChangeMailStarNotify(List<uint> mailList, bool isStar) {} // 0x00000001839FF4B0-0x00000001839FF640
	// [XID] // 0x0000000189869AA0-0x0000000189869AC0
	public void RequestDelMail(List<uint> mailList) {} // 0x00000001839FE7D0-0x00000001839FE940
	// [XID] // 0x0000000189870DE0-0x0000000189870E00
	private void OnDelMailRsp(DelMailRsp rsp) {} // 0x00000001839FFCB0-0x00000001839FFE10
	// [XID] // 0x00000001898787D0-0x00000001898787F0
	private void OnClientNewMailNotify(ClientNewMailNotify ntf) {} // 0x00000001839FF640-0x00000001839FF7A0
	// [XID] // 0x000000018987FD80-0x000000018987FDA0
	public void RequestGetAuthkey(string authAppid, uint signType, uint authkeyVer) {} // 0x00000001839FDED0-0x00000001839FE010
	// [XID] // 0x0000000189887380-0x00000001898873A0
	public void OnGetAuthkeyRsp(GetAuthkeyRsp rsp) {} // 0x00000001839FE670-0x00000001839FE7D0
	// [XID] // 0x000000018988E500-0x000000018988E520
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001839FE2B0-0x00000001839FE3F0
}

