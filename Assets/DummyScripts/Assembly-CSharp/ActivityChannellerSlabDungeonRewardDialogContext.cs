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
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityChannellerSlabDungeonRewardDialogContext : BaseDialogContext // TypeDefIndex: 29496
{
	// Fields
	private MonoEffigyChallengeRewardDialog _dialogMono; // 0x178
	private uint _activityID; // 0x180
	private List<uint> _rewardList; // 0x188
	private RewardDataProvider _rewardDataProvider; // 0x190
	private List<RewardItemConfig> _tempRewardList; // 0x198

	// Nested types
	private class RewardDataProvider // TypeDefIndex: 29497
	{
		// Fields
		private List<uint> _takenRewardIdList; // 0x10

		// Nested types
		public struct RewardItem // TypeDefIndex: 29498
		{
			// Fields
			public uint id; // 0x00
			public uint rewardId; // 0x04
			public uint scoreGrade; // 0x08

			// Constructors
			public RewardItem(uint id, uint rewardId, uint scoreGrade) {
				this.id = default;
				this.rewardId = default;
				this.scoreGrade = default;
			} // 0x000000018324E400-0x000000018324E410
		}

		// Constructors
		public RewardDataProvider() {} // 0x000000018324E2E0-0x000000018324E400

		// Methods
		// [XID] // 0x0000000189654900-0x0000000189654920
		public uint GetCurScore() => default; // 0x000000018324DF40-0x000000018324E170
		// [XID] // 0x000000018965BFF0-0x000000018965C010
		public List<uint> GetAllRewardIdList() => default; // 0x000000018324DD50-0x000000018324DF40
		// [XID] // 0x0000000189663670-0x0000000189663690
		public void RefreshTakenRewardIdList() {} // 0x000000018324DA10-0x000000018324DCB0
		// [XID] // 0x000000018966AFF0-0x000000018966B010
		public List<uint> GetTakenRewardIdList() => default; // 0x000000018324DCB0-0x000000018324DD50
		// [XID] // 0x0000000189672BF0-0x0000000189672C10
		public RewardItem GetRewardItem(uint id) => default; // 0x000000018324E170-0x000000018324E2E0
	}

	// Constructors
	public ActivityChannellerSlabDungeonRewardDialogContext() {} // Dummy constructor
	public ActivityChannellerSlabDungeonRewardDialogContext(uint activityId) {} // 0x000000018324FAF0-0x000000018324FC00

	// Methods
	// [XID] // 0x0000000189611260-0x0000000189611280
	public override void SetupView() {} // 0x000000018324FA10-0x000000018324FAF0
	// [XID] // 0x0000000189618C30-0x0000000189618C50
	public override void ClearView() {} // 0x000000018324EF60-0x000000018324F030
	// [XID] // 0x0000000189620160-0x0000000189620180
	protected override void BindViewCallbacks() {} // 0x000000018324EE40-0x000000018324EF60
	// [XID] // 0x00000001896275D0-0x00000001896275F0
	public override bool OnNotify(Notify ntf) => default; // 0x000000018324F900-0x000000018324FA10
	// [XID] // 0x000000018962F0F0-0x000000018962F110
	private int SortFunc(uint x, uint y) => default; // 0x000000018324F3E0-0x000000018324F5C0
	// [XID] // 0x0000000189636A90-0x0000000189636AB0
	private void Refresh() {} // 0x000000018324E510-0x000000018324E8C0
	// [XID] // 0x000000018963DFC0-0x000000018963DFE0
	private void RefreshRewardRow(Transform trans, int index) {} // 0x000000018324E8C0-0x000000018324EE40
	// [XID] // 0x0000000189645950-0x0000000189645970
	private void RefreshRewardItems(Transform trans, int index) {} // 0x000000018324F030-0x000000018324F280
	// [XID] // 0x000000018964D160-0x000000018964D180
	public override void OnJoypadUIModuleSelectIndex(MonoJoypadUIModule sourceModule, int index, Transform transform, JoypadSelectIndexResult selectResult = JoypadSelectIndexResult.Normal /* Metadata: 0x00B0F871 */) {} // 0x000000018324F6B0-0x000000018324F900
}

