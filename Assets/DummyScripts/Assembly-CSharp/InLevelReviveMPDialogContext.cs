/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelReviveMPDialogContext : BaseDialogContext // TypeDefIndex: 29595
{
	// Fields
	private MonoReviveMPDialog _dialogMono; // 0x178
	private bool showBtnState; // 0x180
	private uint _dungeonID; // 0x184
	private bool _canRevive; // 0x188
	private long _reviveIntervalTime; // 0x190
	private long _lastRemainSeconds; // 0x198
	private DungeonExcelConfig _dungeonConfig; // 0x1A0

	// Constructors
	public InLevelReviveMPDialogContext() {} // Dummy constructor
	public InLevelReviveMPDialogContext(uint dungeonId = 0 /* Metadata: 0x00B0F9E1 */) {} // 0x0000000182A92750-0x0000000182A928B0

	// Methods
	// [XID] // 0x00000001899F1F40-0x00000001899F1F60
	private void InitDialog() {} // 0x0000000182A902D0-0x0000000182A903C0
	// [XID] // 0x00000001899F96C0-0x00000001899F96E0
	private void ClearChatDialog() {} // 0x0000000182A909C0-0x0000000182A90AC0
	// [XID] // 0x0000000189A009E0-0x0000000189A00A00
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182A90D50-0x0000000182A90F40
	// [XID] // 0x0000000189A08300-0x0000000189A08320
	private void ToggleChat() {} // 0x0000000182A919F0-0x0000000182A91B30
	// [XID] // 0x0000000189A0F820-0x0000000189A0F840
	private void ToggleMainPageBtn(bool open) {} // 0x0000000182A90810-0x0000000182A909C0
	// [XID] // 0x0000000189A16DE0-0x0000000189A16E00
	private void SetButtonState(bool state) {} // 0x0000000182A90F40-0x0000000182A916D0
	// [XID] // 0x0000000189A1E4A0-0x0000000189A1E4C0
	public override void SetupView() {} // 0x0000000182A92230-0x0000000182A923F0
	// [XID] // 0x0000000189A25BA0-0x0000000189A25BC0
	public override void UpdateView() {} // 0x0000000182A923F0-0x0000000182A92750
	// [XID] // 0x0000000189A2CFC0-0x0000000189A2CFE0
	protected override void BindViewCallbacks() {} // 0x0000000182A90500-0x0000000182A90720
	// [XID] // 0x0000000189A349C0-0x0000000189A349E0
	protected override void RegisterHandlePacket() {} // 0x0000000182A92180-0x0000000182A92230
	// [XID] // 0x0000000189A3BD70-0x0000000189A3BD90
	public override bool OnPacket(Packet packet) => default; // 0x0000000182A92080-0x0000000182A92180
	// [XID] // 0x0000000189A439C0-0x0000000189A439E0
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182A91F90-0x0000000182A92080
	// [XID] // 0x0000000189A4AE10-0x0000000189A4AE30
	private void RequestQuit() {} // 0x0000000182A91D10-0x0000000182A91F00
	// [XID] // 0x0000000189A52530-0x0000000189A52550
	private void RequestRestart() {} // 0x0000000182A91870-0x0000000182A919F0
	// [XID] // 0x0000000189A59E80-0x0000000189A59EA0
	private void RequestRevive() {} // 0x0000000182A91B30-0x0000000182A91CB0
	// [XID] // 0x0000000189A61650-0x0000000189A61670
	public void RequestDungeonRestart() {} // 0x0000000182A90AC0-0x0000000182A90BB0
	// [XID] // 0x0000000189A69590-0x0000000189A695B0
	private void OnDungeonDieOptionRsp(DungeonDieOptionRsp rsp) {} // 0x0000000182A91790-0x0000000182A91870
	// [XID] // 0x0000000189A70900-0x0000000189A70920
	public void RequestDungeonRevive() {} // 0x0000000182A90720-0x0000000182A90810
	// [XID] // 0x0000000189A781B0-0x0000000189A781D0
	public override void CloseDialog() {} // 0x0000000182A90BB0-0x0000000182A90C60
}

