/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NotifyManager : GlobalManager // TypeDefIndex: 28690
{
	// Fields
	private List<BaseContext> _contextList; // 0x10
	private List<BaseModule> _moduleList; // 0x18
	private Dictionary<ushort, IPacketInterface> _interPktRegister; // 0x20
	private Dictionary<int, List<INotifyInterface>> _interNotifyRegister; // 0x28
	private bool _waitRemoveContext; // 0x30

	// Constructors
	public NotifyManager() {} // 0x00000001817EF140-0x00000001817EF240

	// Methods
	// [XID] // 0x0000000189862440-0x0000000189862460
	public void RegisterModuleByCmdId(ushort cmdId, IPacketInterface module) {} // 0x00000001817EDDA0-0x00000001817EDE80
	// [XID] // 0x000000018998FE50-0x000000018998FE70
	public void RegisterModuleByNotify(NotifyTypes type, INotifyInterface module) {} // 0x00000001817EE2D0-0x00000001817EE460
	// [XID] // 0x0000000189870AD0-0x0000000189870AF0
	public void RegisterComponentByNotify(NotifyTypes type, INotifyInterface component) {} // 0x00000001817EDCD0-0x00000001817EDDA0
	// [XID] // 0x00000001898785C0-0x00000001898785E0
	public void UnregisterModuleByNotify(NotifyTypes type, INotifyInterface module) {} // 0x00000001817EE830-0x00000001817EE950
	// [XID] // 0x000000018987FAD0-0x000000018987FAF0
	public void UnregisterComponentByNotify(NotifyTypes type, INotifyInterface component) {} // 0x00000001817ED830-0x00000001817ED900
	// [XID] // 0x0000000189887120-0x0000000189887140
	public void UnregisterModule(INotifyInterface module) {} // 0x00000001817EE620-0x00000001817EE830
	// [XID] // 0x000000018988E290-0x000000018988E2B0
	public override void Init() {} // 0x00000001817EE460-0x00000001817EE500
	// [XID] // 0x0000000189895920-0x0000000189895940
	public override void LateTick() {} // 0x00000001817EE950-0x00000001817EEAC0
	// [XID] // 0x000000018989D060-0x000000018989D080
	public override void Destroy() {} // 0x00000001817EDAF0-0x00000001817EDBE0
	// [XID] // 0x00000001898A48E0-0x00000001898A4900
	public override void ClearOnLevelDestroy() {} // 0x00000001817ED9F0-0x00000001817EDA90
	// [XID] // 0x00000001898ABDA0-0x00000001898ABDC0
	public void ClearAllContext() {} // 0x00000001817EEC20-0x00000001817EED20
	[Preserve] // 0x00000001898B34D0-0x00000001898B3510
	// [XID] // 0x00000001898B34D0-0x00000001898B3510
	public List<BaseContext> GetContextList() => default; // 0x00000001817EE230-0x00000001817EE2D0
	[Preserve] // 0x00000001898BDD00-0x00000001898BDD40
	// [XID] // 0x00000001898BDD00-0x00000001898BDD40
	public List<BaseModule> GetModuleList() => default; // 0x00000001817ED560-0x00000001817ED600
	[Preserve] // 0x00000001898C88B0-0x00000001898C88F0
	// [XID] // 0x00000001898C88B0-0x00000001898C88F0
	public BaseContext GetContext(string contextName) => default; // 0x00000001817EDE80-0x00000001817EDFE0
	// [XID] // 0x00000001897D9420-0x00000001897D9440
	public void RegisterContext(BaseContext context) {} // 0x00000001817EE500-0x00000001817EE620
	// [XID] // 0x00000001896D5D00-0x00000001896D5D20
	public void RemoveContext(BaseContext context) {} // 0x00000001817EEAC0-0x00000001817EEC20
	// [XID] // 0x00000001898E2390-0x00000001898E23B0
	public void RegisterModule(BaseModule listener) {} // 0x00000001817ED900-0x00000001817ED9F0
	// [XID] // 0x00000001898E9F30-0x00000001898E9F50
	public void RemoveModule(BaseModule listener) {} // 0x00000001817EDBE0-0x00000001817EDCD0
	// [XID] // 0x00000001898F16E0-0x00000001898F1700
	public bool FirePacket(Packet pkt, out bool hasCached) {
		hasCached = default;
		return default;
	} // 0x00000001817EDFE0-0x00000001817EE230
	// [XID] // 0x00000001898F8EC0-0x00000001898F8EE0
	public bool FireNotify(Notify cmd, bool canCache = true /* Metadata: 0x00B0DB36 */, bool isEternal = false /* Metadata: 0x00B0DB37 */) => default; // 0x00000001817ED600-0x00000001817ED830
	// [XID] // 0x0000000189900840-0x0000000189900860
	private bool HandlePacketForModules(Packet pkt) => default; // 0x00000001817EEF70-0x00000001817EF0A0
	// [XID] // 0x0000000189907FD0-0x0000000189907FF0
	public override void ReloadRes() {} // 0x00000001817EF0A0-0x00000001817EF140
	// [XID] // 0x0000000189B5A5A0-0x0000000189B5A5C0
	private bool HandleNotifyForModules(Notify ntf) => default; // 0x00000001817EED20-0x00000001817EEF70
}

