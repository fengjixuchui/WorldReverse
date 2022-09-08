/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeNameDialogContext : BaseDialogContext // TypeDefIndex: 28866
{
	// Fields
	private MonoCountSelectDialog _dialogMono; // 0x178
	private ChangeNameDialogType _type; // 0x180
	public uint currID; // 0x184
	public string currName; // 0x188
	private uint _uidForChangeRemarkname; // 0x190
	private int _nameMaxLength; // 0x194
	private int _nameNumberMaxLength; // 0x198
	private const int NICKNAME_MIN_COUNT = 1; // Metadata: 0x00B0E7F6
	private MonoPS4IMEProxy _proxy; // 0x1A0
	private bool _passCheck; // 0x1A8

	// Nested types
	public enum ChangeNameDialogType // TypeDefIndex: 28867
	{
		Team = 0,
		Nickname = 1,
		Remarkname = 2
	}

	private enum InvalidCharState // TypeDefIndex: 28868
	{
		Valid = 0,
		Space = 1
	}

	// Constructors
	public ChangeNameDialogContext() {} // Dummy constructor
	public ChangeNameDialogContext(ChangeNameDialogType type, uint uidForChangeRemarkname = 0 /* Metadata: 0x00B0E7F2 */) {} // 0x0000000182A6EA30-0x0000000182A6EB20

	// Methods
	// [XID] // 0x0000000189914030-0x0000000189914050
	public override void SetupView() {} // 0x0000000182A6E790-0x0000000182A6EA30
	// [XID] // 0x000000018991BA80-0x000000018991BAA0
	protected override void BindViewCallbacks() {} // 0x0000000182A6C390-0x0000000182A6C610
	// [XID] // 0x0000000189923020-0x0000000189923040
	public void SetupContext() {} // 0x0000000182A6D9C0-0x0000000182A6DA90
	// [XID] // 0x000000018992A810-0x000000018992A830
	public void OnConfirmName() {} // 0x0000000182A6C280-0x0000000182A6C390
	// [XID] // 0x0000000189931E50-0x0000000189931E70
	public override bool OnNotify(Notify ntf) => default; // 0x0000000182A6E480-0x0000000182A6E650
	// [XID] // 0x00000001899397C0-0x00000001899397E0
	public override bool HandleInputActionEvent(InputActionEvent actionEvent) => default; // 0x0000000182A6D790-0x0000000182A6D9C0
	// [XID] // 0x0000000189940AB0-0x0000000189940AD0
	private void CheckNameString(string name) {} // 0x0000000182A6D6C0-0x0000000182A6D790
	// [XID] // 0x0000000189948390-0x00000001899483B0
	private bool CheckNameStringValid(string name) => default; // 0x0000000182A6C610-0x0000000182A6C700
	// [XID] // 0x000000018994FA90-0x000000018994FAB0
	public void SetupTeamNameView() {} // 0x0000000182A6DA90-0x0000000182A6DD90
	// [XID] // 0x00000001899570B0-0x00000001899570D0
	private bool CheckTeamNameStringValid(string name) => default; // 0x0000000182A6CBF0-0x0000000182A6CE90
	// [XID] // 0x000000018995EC20-0x000000018995EC40
	public void OnConfirmTeamName() {} // 0x0000000182A6DD90-0x0000000182A6DED0
	// [XID] // 0x00000001899662E0-0x0000000189966300
	public void SetupRemarknameView() {} // 0x0000000182A6CE90-0x0000000182A6D1B0
	// [XID] // 0x000000018996D760-0x000000018996D780
	public void OnConfirmRemarkname() {} // 0x0000000182A6E650-0x0000000182A6E790
	// [XID] // 0x0000000189975320-0x0000000189975340
	private bool CheckRemarknameStringValid(string name) => default; // 0x0000000182A6D1B0-0x0000000182A6D550
	// [XID] // 0x000000018997C4E0-0x000000018997C500
	public void SetupNicknameView() {} // 0x0000000182A6C830-0x0000000182A6CB60
	// [XID] // 0x00000001899841E0-0x0000000189984200
	public void OnConfirmNickname() {} // 0x0000000182A6C700-0x0000000182A6C830
	// [XID] // 0x000000018998BD70-0x000000018998BD90
	private bool CheckNicknameStringValid(string name) => default; // 0x0000000182A6DED0-0x0000000182A6E390
	// [XID] // 0x0000000189993940-0x0000000189993960
	private InvalidCharState HasInvalidChar(string accountName) => default; // 0x0000000182A6D550-0x0000000182A6D660
}

