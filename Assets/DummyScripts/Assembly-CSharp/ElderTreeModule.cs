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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ElderTreeModule : BaseModule // TypeDefIndex: 21469
{
	// Fields
	public const uint ElderTreeOfferSystemId = 1; // Metadata: 0x00AFF877
	public uint ElderTreeMaxLevel; // 0x10
	public uint ElderTreeMiddleLevel; // 0x14
	public uint ElderTreeEntityId; // 0x18
	private InterActionGrp _closePageActionGrp; // 0x20

	// Properties
	public uint ElderTreeCurLevel { /* [XID] */ /* 0x00000001899F8050-0x00000001899F8070 */ get => default; } // 0x00000001839B3E40-0x00000001839B3F20 

	// Nested types
	public enum ElderTreeStep // TypeDefIndex: 21470
	{
		SmallTree = 1,
		MiddleTree = 2,
		GrownTree = 3
	}

	// Constructors
	public ElderTreeModule() {} // 0x00000001839B4480-0x00000001839B4510

	// Methods
	// [XID] // 0x00000001899FF6E0-0x00000001899FF700
	public List<RewardExcelConfig> GetRewards() => default; // 0x00000001839B30A0-0x00000001839B3180
	// [XID] // 0x0000000189A06F00-0x0000000189A06F20
	public void SetElderTreeEntity(BaseEntity entity) {} // 0x00000001839B35A0-0x00000001839B37E0
	// [XID] // 0x0000000189A0E610-0x0000000189A0E630
	public ElderTreeStep GetElderTreeStep() => default; // 0x00000001839B33C0-0x00000001839B3480
	// [XID] // 0x0000000189A15C20-0x0000000189A15C40
	public void ShowPushMessage() {} // 0x00000001839B4340-0x00000001839B4480
	// [XID] // 0x0000000189A1D050-0x0000000189A1D070
	public override bool OnPacket(Packet packet) => default; // 0x00000001839B3180-0x00000001839B3270
	// [XID] // 0x0000000189A24690-0x0000000189A246B0
	private void OnCodexDataFullNotify(CodexDataFullNotify notify) {} // 0x00000001839B2F70-0x00000001839B3020
	// [XID] // 0x0000000189A2BB30-0x0000000189A2BB50
	public override bool OnNotify(Notify ntf) => default; // 0x00000001839B4220-0x00000001839B4340
	// [XID] // 0x0000000189A330F0-0x0000000189A33110
	private void OnOfferingLevelChangeNotify(Notify ntf) {} // 0x00000001839B37E0-0x00000001839B3C60
	// [XID] // 0x0000000189A3A9E0-0x0000000189A3AA00
	private void AddClosePageActionGrp() {} // 0x00000001839B40A0-0x00000001839B4190
	// [XID] // 0x0000000189A42310-0x0000000189A42330
	private void OnNewItemEncountered(Notify ntf) {} // 0x00000001839B3C60-0x00000001839B3D60
	// [XID] // 0x0000000189A49920-0x0000000189A49940
	public override void ClearOnDisconnect() {} // 0x00000001839B4000-0x00000001839B40A0
	// [XID] // 0x0000000189A51270-0x0000000189A51290
	public override void ClearOnLevelDestroy() {} // 0x00000001839B3270-0x00000001839B3310
	// [XID] // 0x0000000189A588C0-0x0000000189A588E0
	public override void ClearOnBackHome() {} // 0x00000001839B3480-0x00000001839B3520
	// [XID] // 0x0000000189A603A0-0x0000000189A603C0
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001839B3310-0x00000001839B33C0
	// [XID] // 0x0000000189A67F30-0x0000000189A67F50
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001839B3F20-0x00000001839B4000
}

