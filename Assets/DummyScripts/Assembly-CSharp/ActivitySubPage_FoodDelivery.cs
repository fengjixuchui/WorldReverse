/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySubPage_FoodDelivery : BaseSubPageContext // TypeDefIndex: 29400
{
	// Fields
	private MonoActivityFoodDelivery _pageMono; // 0x178
	private const string DELIVERY_PREFAB_PATH = "ART/UI/Menus/Widget/Activity/Activity_FoodDelivery"; // Metadata: 0x00B0F740
	public const int ORDER_COUNT = 3; // Metadata: 0x00B0F776
	private uint _scheduleId; // 0x180
	private uint _dayIndex; // 0x184
	private uint _activityConfigId; // 0x188
	private uint _rewardItemID; // 0x18C
	private ActivityInfo _activityInfo; // 0x190
	private ActivityDeliveryDailyExcelConfig _dailyConfig; // 0x198
	private DeliveryActivityDetailInfo _detailInfo; // 0x1A0
	private bool _isOpen; // 0x1A8
	public static bool FoodDeliveryOpened; // 0x00
	private int _taskSlot; // 0x1AC

	// Constructors
	public ActivitySubPage_FoodDelivery() {} // Dummy constructor
	public ActivitySubPage_FoodDelivery(BasePageContext _parent, Transform _mountTrans) {} // 0x0000000181E81B10-0x0000000181E81C20
	static ActivitySubPage_FoodDelivery() {} // 0x0000000181E81AB0-0x0000000181E81B10

	// Methods
	// [XID] // 0x0000000189B2AA50-0x0000000189B2AA70
	public override void SetupView() {} // 0x0000000181E81830-0x0000000181E81AB0
	// [XID] // 0x0000000189B31F80-0x0000000189B31FA0
	protected override void BindViewCallbacks() {} // 0x0000000181E7F970-0x0000000181E7FB30
	// [XID] // 0x0000000189B39740-0x0000000189B39760
	public override bool OnNotify(Notify ntf) => default; // 0x0000000181E81650-0x0000000181E81730
	// [XID] // 0x0000000189B410F0-0x0000000189B41110
	private void RefreshActivity() {} // 0x0000000181E81730-0x0000000181E81830
	// [XID] // 0x0000000189B489E0-0x0000000189B48A00
	public override void OnParentFocusChangeed(bool focusOnParent) {} // 0x0000000181E80BF0-0x0000000181E80E90
	// [XID] // 0x0000000189B50170-0x0000000189B50190
	private void OnClickDesc() {} // 0x0000000181E7F860-0x0000000181E7F970
	// [XID] // 0x0000000189B579A0-0x0000000189B579C0
	private void Refresh() {} // 0x0000000181E7EAA0-0x0000000181E7F7E0
	// [XID] // 0x0000000189B5F2F0-0x0000000189B5F310
	private void RefreshPS4Infos() {} // 0x0000000181E80360-0x0000000181E805E0
	// [XID] // 0x0000000189B668E0-0x0000000189B66900
	private void SetPS4ReceiveBtnText(MonoUITemplate uiPS4Tpl, string str) {} // 0x0000000181E81070-0x0000000181E811E0
	// [XID] // 0x0000000189B6DE40-0x0000000189B6DE60
	private FOOD_DELIVERY_ORDER_STATE GetState(int index) => default; // 0x0000000181E811E0-0x0000000181E813F0
	// [XID] // 0x0000000189B75510-0x0000000189B75530
	private void OnClickOrder(int index) {} // 0x0000000181E813F0-0x0000000181E81560
	// [XID] // 0x0000000189B7C980-0x0000000189B7C9A0
	private bool HasAcceptedTask(int index) => default; // 0x0000000181E7FCE0-0x0000000181E7FEE0
	// [XID] // 0x0000000189B84800-0x0000000189B84820
	private void OnClickGotoDelivery(int index) {} // 0x0000000181E7FEE0-0x0000000181E80360
	// [XID] // 0x0000000189B8B690-0x0000000189B8B6B0
	private void OnClickRewardSlot(int index) {} // 0x0000000181E805E0-0x0000000181E806E0
	// [XID] // 0x0000000189B92DC0-0x0000000189B92DE0
	private void OnClickFetchReward() {} // 0x0000000181E80E90-0x0000000181E80FB0
	// [XID] // 0x0000000189B9A380-0x0000000189B9A3A0
	private void OnClickReward() {} // 0x0000000181E80B20-0x0000000181E80BF0
	// [XID] // 0x0000000189BA1AB0-0x0000000189BA1AD0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000181E80800-0x0000000181E80B20
	// [XID] // 0x0000000189BA8EF0-0x0000000189BA8F10
	private void RefreshCurrentItem(bool clear) {} // 0x0000000181E7FB30-0x0000000181E7FC50
	// [XID] // 0x0000000189BB06A0-0x0000000189BB06C0
	private void NextSlot() {} // 0x0000000181E806E0-0x0000000181E807A0
	// [XID] // 0x0000000189BB7A00-0x0000000189BB7A20
	private void PreSlot() {} // 0x0000000181E80FB0-0x0000000181E81070
}

