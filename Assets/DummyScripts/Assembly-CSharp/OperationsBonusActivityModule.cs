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

public sealed class OperationsBonusActivityModule : BaseModule // TypeDefIndex: 21629
{
	// Fields
	private Dictionary<uint, OperationsBonusActivityInfo> _dataDict; // 0x10
	private List<OperationsBonusActivityInfo> _cachedActivityId; // 0x18

	// Nested types
	public abstract class OperationsBonusActivityInfo // TypeDefIndex: 21630
	{
		// Fields
		public uint activityId; // 0x10
		public uint beginTime; // 0x14
		public uint endTime; // 0x18
		public bool showRedpoint; // 0x1C

		// Constructors
		protected OperationsBonusActivityInfo() {} // Dummy constructor
		public OperationsBonusActivityInfo(uint activity, uint begin, uint end, bool showRP) {} // 0x00000001831C4790-0x00000001831C48B0
	}

	public class OperationsBonusActivityInfo_BonusInfo : OperationsBonusActivityInfo // TypeDefIndex: 21631
	{
		// Fields
		public uint leftBonusCount; // 0x20

		// Constructors
		public OperationsBonusActivityInfo_BonusInfo() {} // Dummy constructor
		public OperationsBonusActivityInfo_BonusInfo(uint activity, uint begin, uint end, bool showRP, uint leftBonus) {} // 0x00000001831C46E0-0x00000001831C4790
	}

	// Constructors
	public OperationsBonusActivityModule() {} // 0x00000001831B36A0-0x00000001831B3770

	// Methods
	// [XID] // 0x0000000189AAE330-0x0000000189AAE350
	protected override void RegisterModulesPkt(NotifyManager notifyMgr) {} // 0x00000001831B0800-0x00000001831B08F0
	// [XID] // 0x0000000189AB5B80-0x0000000189AB5BA0
	protected override void RegsiterModuleNotify(NotifyManager notifyMgr) {} // 0x00000001831B2D00-0x00000001831B2DD0
	// [XID] // 0x0000000189ABD5D0-0x0000000189ABD5F0
	public OperationsBonusActivityInfo GetInfo(uint activityId) => default; // 0x00000001831B2880-0x00000001831B2970
	// [XID] // 0x0000000189AC50B0-0x0000000189AC50D0
	public uint GetOpActivityMaxMultiplyFactor(uint entityRunTimeId) => default; // 0x00000001831B1810-0x00000001831B1DF0
	// [XID] // 0x0000000189ACC5E0-0x0000000189ACC600
	public uint GetBlossomMaxMultiplyFactor(MonoMapMark mark, uint refreshId) => default; // 0x00000001831B1DF0-0x00000001831B1FA0
	// [XID] // 0x0000000189AD4310-0x0000000189AD4330
	public uint GetDungeonMaxMultiplyFactor(uint dungeonId) => default; // 0x00000001831B04C0-0x00000001831B0580
	// [XID] // 0x0000000189ADBC60-0x0000000189ADBC80
	public bool ShouldActivityShowRedPoint(uint activityId) => default; // 0x00000001831B2240-0x00000001831B2340
	// [XID] // 0x0000000189AE3650-0x0000000189AE3670
	public void SetActivityRedpointDone(uint activityId) {} // 0x00000001831B2970-0x00000001831B2A70
	// [XID] // 0x0000000189AEAED0-0x0000000189AEAEF0
	public override bool OnPacket(Packet packet) => default; // 0x00000001831B0600-0x00000001831B0760
	// [XID] // 0x0000000189AF2860-0x0000000189AF2880
	public override bool OnNotify(Notify ntf) => default; // 0x00000001831B35B0-0x00000001831B36A0
	// [XID] // 0x0000000189AFA160-0x0000000189AFA180
	public override void ClearOnBackHome() {} // 0x00000001831B1FA0-0x00000001831B2040
	// [XID] // 0x0000000189B01700-0x0000000189B01720
	public override void ClearOnDisconnect() {} // 0x00000001831B2DD0-0x00000001831B2E70
	// [XID] // 0x0000000189B08C50-0x0000000189B08C70
	public override void ClearOnLevelDestroy() {} // 0x00000001831B0760-0x00000001831B0800
	// [XID] // 0x0000000189B10690-0x0000000189B106B0
	private void OnGetOpActivityInfoRsp(GetOpActivityInfoRsp rsp) {} // 0x00000001831B20C0-0x00000001831B2240
	// [XID] // 0x0000000189B17800-0x0000000189B17820
	private void OnOpActivityDataNotify(OpActivityDataNotify ntf) {} // 0x00000001831B2790-0x00000001831B2880
	// [XID] // 0x0000000189B1F0C0-0x0000000189B1F0E0
	private void OnOpActivityUpdateNotify(OpActivityUpdateNotify ntf) {} // 0x00000001831B1230-0x00000001831B1810
	// [XID] // 0x0000000189B269D0-0x0000000189B269F0
	private void HandleOpActivityListInternal(RepeatedMessageField<OpActivityInfo> list) {} // 0x00000001831B2E70-0x00000001831B3520
	// [XID] // 0x0000000189B2DB80-0x0000000189B2DBA0
	private uint GetOpActivityMaxMultiplyFactor_Blossom_Internal(uint refreshId, uint cityId) => default; // 0x00000001831B0E80-0x00000001831B1230
	// [XID] // 0x0000000189B34F90-0x0000000189B34FB0
	private uint GetOpActivityMaxMultiplyFactor_Dungeon_Internal(uint dungeonId) => default; // 0x00000001831B2340-0x00000001831B26B0
	// [XID] // 0x0000000189B3C860-0x0000000189B3C880
	private void ClearDataDict() {} // 0x00000001831B0C40-0x00000001831B0E80
	// [XID] // 0x0000000189B44610-0x0000000189B44630
	private void RefreshOnPlayerLevelChange() {} // 0x00000001831B08F0-0x00000001831B0C40
	// [XID] // 0x0000000189B4BDA0-0x0000000189B4BDC0
	private bool ShouldOpActivityShow(OpActivityExcelConfig activityConfig) => default; // 0x00000001831B2A70-0x00000001831B2D00
}

