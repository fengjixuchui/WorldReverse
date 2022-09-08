/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InTestSceneLevelPageContext : BasePageContext // TypeDefIndex: 29996
{
	// Fields
	private bool _isRunning; // 0x190
	private UnityEngine.UI.Text _textFsmState; // 0x198
	private StringBuilder _sb; // 0x1A0
	private GameObject _fpsIndicator; // 0x1A8
	private uint _fpsIndicatorResourceHandle; // 0x1B0
	private bool _caseChosHasBuild; // 0x1B4

	// Nested types
	public enum PageID // TypeDefIndex: 29997
	{
		Nothing = 0,
		Base = 1,
		Miscs = 2
	}

	// Constructors
	public InTestSceneLevelPageContext() {} // 0x0000000183B8C0A0-0x0000000183B8C190

	// Methods
	// [XID] // 0x0000000189AE05A0-0x0000000189AE05C0
	public override void SetupView() {} // 0x0000000183B8BDE0-0x0000000183B8BEF0
	// [XID] // 0x0000000189AE7AF0-0x0000000189AE7B10
	public override void UpdateView() {} // 0x0000000183B8BEF0-0x0000000183B8C0A0
	// [XID] // 0x0000000189AEF830-0x0000000189AEF850
	public override void ClearView() {} // 0x0000000183B8A950-0x0000000183B8AB10
	// [XID] // 0x0000000189AF6D70-0x0000000189AF6D90
	private void InitAvatarControl() {} // 0x0000000183B8B190-0x0000000183B8B410
	// [XID] // 0x0000000189AFE260-0x0000000189AFE280
	private void OnPlusSpeed(bool plus) {} // 0x0000000183B8AF70-0x0000000183B8B190
	// [XID] // 0x0000000189B05A90-0x0000000189B05AB0
	private void OnReturn() {} // 0x0000000183B8AD40-0x0000000183B8AE50
	// [XID] // 0x0000000189B0D1E0-0x0000000189B0D200
	private void SetMoveStatus(bool isRoleMoving, float roleMoveAngle, float roleMoveMold) {} // 0x0000000183B8A620-0x0000000183B8A8E0
	// [XID] // 0x0000000189B147C0-0x0000000189B147E0
	private void UpdateFsmState() {} // 0x0000000183B8AB10-0x0000000183B8AC20
	// [XID] // 0x0000000189B1BF90-0x0000000189B1BFB0
	private string GetMoveFsmStateText() => default; // 0x0000000183B8B920-0x0000000183B8BDE0
	// [XID] // 0x0000000189B23730-0x0000000189B23750
	private void InstantiateFpsIndicatorIfNecessary() {} // 0x0000000183B8B480-0x0000000183B8B5E0
	// [XID] // 0x0000000189B2A990-0x0000000189B2A9B0
	private void OnLoadedFpsIndicator(ulong hash, bool succeeded, uint handle, GameObject prefab) {} // 0x0000000183B8B5E0-0x0000000183B8B7A0
	// [XID] // 0x0000000189B31F00-0x0000000189B31F20
	private void BuildCaseChos() {} // 0x0000000183B8B7A0-0x0000000183B8B920
	// [XID] // 0x0000000189B396C0-0x0000000189B396E0
	private void OnChangeCase(int newCaseInListIndex) {} // 0x0000000183B8AC20-0x0000000183B8ACD0
}

