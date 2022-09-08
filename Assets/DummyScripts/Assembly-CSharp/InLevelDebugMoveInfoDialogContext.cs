/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugMoveInfoDialogContext : BaseDialogContext // TypeDefIndex: 28623
{
	// Fields
	private UnityEngine.UI.Text _textFsmState; // 0x178
	private UnityEngine.UI.Text _textSyncState; // 0x180
	private bool _syncStateShowMonster; // 0x188
	private bool _showLayers; // 0x189
	private UnityEngine.UI.Text _levelAreaInfo; // 0x190
	private UnityEngine.UI.Text _worldAreaInfo; // 0x198
	private StringBuilder _sb; // 0x1A0
	private MonoMoveDebugButton _moveDebug; // 0x1A8
	private string monsterSyncId; // 0x1B0
	public static bool moveInfoActive; // 0x00
	private BaseEntity _syncTestEntity; // 0x1B8

	// Properties
	private uint _syncTestEntityID { /* [XID] */ /* 0x0000000189A60100-0x0000000189A60120 */ get => default; } // 0x0000000182D782A0-0x0000000182D78380 

	// Constructors
	public InLevelDebugMoveInfoDialogContext() {} // 0x0000000182D7AA30-0x0000000182D7AC90

	// Methods
	// [XID] // 0x0000000189A42160-0x0000000189A42180
	public override void SetupView() {} // 0x0000000182D7A020-0x0000000182D7A430
	// [XID] // 0x0000000189A496F0-0x0000000189A49710
	public override void UpdateView() {} // 0x0000000182D7A430-0x0000000182D7AA30
	// [XID] // 0x0000000189A51080-0x0000000189A510A0
	public override void ClearView() {} // 0x0000000182D78380-0x0000000182D78480
	// [XID] // 0x0000000189A58640-0x0000000189A58660
	private void UpdateFsmState() {} // 0x0000000182D78480-0x0000000182D78620
	// [XID] // 0x0000000189A67D60-0x0000000189A67D80
	private bool HasLocalSyncTest() => default; // 0x0000000182D78DD0-0x0000000182D78F00
	// [XID] // 0x0000000189A6F130-0x0000000189A6F150
	private string GetSyncStateText() => default; // 0x0000000182D78680-0x0000000182D78DD0
	// [XID] // 0x0000000189A76970-0x0000000189A76990
	public void SetSyncStateShowMonster(bool isShow) {} // 0x0000000182D79D20-0x0000000182D79DD0
	// [XID] // 0x0000000189A7E240-0x0000000189A7E260
	private string GetMoveFsmStateText() => default; // 0x0000000182D79DD0-0x0000000182D7A020
	// [XID] // 0x0000000189A85C40-0x0000000189A85C60
	private void ShowPlayerInfo() {} // 0x0000000182D78FC0-0x0000000182D79C00
	// [XID] // 0x0000000189A8D520-0x0000000189A8D540
	public void ChangeMonsterSyncId(string text) {} // 0x0000000182D781F0-0x0000000182D782A0
}

