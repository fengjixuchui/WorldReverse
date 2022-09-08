/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayModule : BaseModule // TypeDefIndex: 21654
{
	// Fields
	private uint _multistagePlayIndex; // 0x18
	private uint _multistageGroupId; // 0x1C

	// Properties
	public MultistagePlayInfo multistagePlayInfo { /* [XID] */ /* 0x000000018965F020-0x000000018965F060 */ get; /* [XID] */ /* 0x0000000189669AE0-0x0000000189669B20 */ private set; } // 0x0000000184C13E40-0x0000000184C13EA0 0x0000000184C13EA0-0x0000000184C13F00
	public uint multistagePlayIndex { /* [XID] */ /* 0x0000000189674590-0x00000001896745B0 */ get => default; } // 0x0000000184C12850-0x0000000184C128F0 
	public uint multistageGroupId { /* [XID] */ /* 0x000000018967BEC0-0x000000018967BEE0 */ get => default; } // 0x0000000184C13C40-0x0000000184C13CE0 

	// Constructors
	public MultistagePlayModule() {} // 0x0000000184C150A0-0x0000000184C15130

	// Methods
	// [XID] // 0x0000000189657970-0x0000000189657990
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x0000000184C13040-0x0000000184C131B0
	// [XID] // 0x00000001896834B0-0x00000001896834D0
	public override bool OnPacket(Packet packet) => default; // 0x0000000184C12970-0x0000000184C12C00
	// [XID] // 0x000000018968B070-0x000000018968B090
	public override void ClearOnDisconnect() {} // 0x0000000184C14F20-0x0000000184C14FC0
	// [XID] // 0x0000000189692D70-0x0000000189692D90
	public override void ClearOnLevelDestroy() {} // 0x0000000184C12FA0-0x0000000184C13040
	// [XID] // 0x000000018969A030-0x000000018969A050
	private void OnMultistagePlayInfoNotify(MultistagePlayInfoNotify ntf) {} // 0x0000000184C14810-0x0000000184C14B90
	// [XID] // 0x00000001896A1820-0x00000001896A1840
	public void CheckMultistagePlayInfo() {} // 0x0000000184C126F0-0x0000000184C12850
	// [XID] // 0x00000001896A8CC0-0x00000001896A8CE0
	private void OnMultistagePlayStageEndNotify(MultistagePlayStageEndNotify ntf) {} // 0x0000000184C14680-0x0000000184C14810
	// [XID] // 0x00000001896AFD30-0x00000001896AFD50
	private void OnMultistagePlayEndNotify(MultistagePlayEndNotify ntf) {} // 0x0000000184C14C70-0x0000000184C14E10
	// [XID] // 0x00000001896B7760-0x00000001896B7780
	public void SendMultistagePlayFinishStageReq() {} // 0x0000000184C14E10-0x0000000184C14F20
	// [XID] // 0x00000001896BE890-0x00000001896BE8B0
	private void OnMultistagePlayFinishStageRsp(MultistagePlayFinishStageRsp rsp) {} // 0x0000000184C132B0-0x0000000184C13410
	// [XID] // 0x00000001896C6190-0x00000001896C61B0
	public void ClearMultistagePlayInfo() {} // 0x0000000184C14FC0-0x0000000184C150A0
	// [XID] // 0x00000001896CD790-0x00000001896CD7B0
	private void CheckFleurFairPlayInfo() {} // 0x0000000184C12C00-0x0000000184C12FA0
	// [XID] // 0x00000001896D4BC0-0x00000001896D4BE0
	private void CheckHideAndSeekPlayInfo() {} // 0x0000000184C137C0-0x0000000184C13C40
	// [XID] // 0x00000001896DC240-0x00000001896DC260
	public void SendHideAndSeekSelectAvatarReq(uint avatarId) {} // 0x0000000184C131B0-0x0000000184C132B0
	// [XID] // 0x00000001896E39D0-0x00000001896E39F0
	private void OnHideAndSeekSelectAvatarRsp(HideAndSeekSelectAvatarRsp rsp) {} // 0x0000000184C13CE0-0x0000000184C13E40
	// [XID] // 0x00000001896EAE00-0x00000001896EAE20
	private void OnHideAndSeekPlayerSetAvatarNotify(HideAndSeekPlayerSetAvatarNotify ntf) {} // 0x0000000184C14060-0x0000000184C14310
	// [XID] // 0x00000001896F21D0-0x00000001896F21F0
	public void SendHideAndSeekSetReadyReq() {} // 0x0000000184C14B90-0x0000000184C14C70
	// [XID] // 0x00000001896F9B90-0x00000001896F9BB0
	private void OnHideAndSeekSetReadyRsp(HideAndSeekSetReadyRsp rsp) {} // 0x0000000184C13F00-0x0000000184C14060
	// [XID] // 0x00000001897013E0-0x0000000189701400
	private void OnHideAndSeekPlayerReadyNotify(HideAndSeekPlayerReadyNotify ntf) {} // 0x0000000184C13410-0x0000000184C137C0
	// [XID] // 0x0000000189708BA0-0x0000000189708BC0
	private void OnHideAndSeekSettleNotify(HideAndSeekSettleNotify ntf) {} // 0x0000000184C14310-0x0000000184C14600
}

