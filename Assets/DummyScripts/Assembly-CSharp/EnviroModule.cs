/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnviroModule : BaseModule // TypeDefIndex: 21473
{
	// Constructors
	private EnviroModule() {} // 0x00000001810BC8A0-0x00000001810BC920

	// Methods
	// [XID] // 0x0000000189AA3C20-0x0000000189AA3C40
	public override bool OnPacket(Packet packet) => default; // 0x00000001810BC290-0x00000001810BC3F0
	// [XID] // 0x0000000189AAB1F0-0x0000000189AAB210
	private void OnSceneAreaWeatherNotify(SceneAreaWeatherNotify notify) {} // 0x00000001810BC080-0x00000001810BC210
	// [XID] // 0x0000000189AB2BE0-0x0000000189AB2C00
	private void OnSceneWeatherForcastRsp(SceneWeatherForcastRsp rsp) {} // 0x00000001810BC570-0x00000001810BC620
	// [XID] // 0x0000000189ABA720-0x0000000189ABA740
	private void OnSetSceneWeatherAreaRsp(SetSceneWeatherAreaRsp rsp) {} // 0x00000001810BC740-0x00000001810BC8A0
	// [XID] // 0x0000000189AC2030-0x0000000189AC2050
	public override void ClearOnLevelDestroy() {} // 0x00000001810BC3F0-0x00000001810BC490
	// [XID] // 0x0000000189AC9680-0x0000000189AC96A0
	public override void ClearOnDisconnect() {} // 0x00000001810BC6A0-0x00000001810BC740
	// [XID] // 0x0000000189AD1010-0x0000000189AD1030
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001810BC490-0x00000001810BC570
}

