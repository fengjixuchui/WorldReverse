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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InLevelDebugBudgetDialogContext : BaseDialogContext // TypeDefIndex: 28592
{
	// Fields
	private MonoInLevelDebugBudgetDialog _dialogMono; // 0x178
	private Button _selected; // 0x180
	private List<DebugBudgetItem> _items; // 0x188

	// Nested types
	private struct DebugBudgetItem // TypeDefIndex: 28593
	{
		// Fields
		public string name; // 0x00
		public float budget; // 0x08
		public uint runtimeID; // 0x0C
	}

	private struct DebugComponentItem // TypeDefIndex: 28594
	{
		// Fields
		public string component; // 0x00
		public float budget; // 0x08

		// Constructors
		public DebugComponentItem(string pcomponent, float pbudget) {
			component = default;
			budget = default;
		} // 0x0000000182A9A7D0-0x0000000182A9A850
	}

	// Constructors
	public InLevelDebugBudgetDialogContext() {} // 0x0000000182A8C760-0x0000000182A8C850

	// Methods
	// [XID] // 0x00000001899E49F0-0x00000001899E4A10
	public override void SetupView() {} // 0x0000000182A8C610-0x0000000182A8C760
	// [XID] // 0x00000001899EBE40-0x00000001899EBE60
	public override void ClearView() {} // 0x0000000182A8AEF0-0x0000000182A8AFC0
	// [XID] // 0x00000001899F38D0-0x00000001899F38F0
	private void GetBudgetList() {} // 0x0000000182A8C330-0x0000000182A8C610
	// [XID] // 0x00000001899FB1D0-0x00000001899FB1F0
	private void SortBudgetList() {} // 0x0000000182A8B870-0x0000000182A8B9A0
	// [XID] // 0x0000000189A023E0-0x0000000189A02400
	private void ClearBudgetView() {} // 0x0000000182A8B4B0-0x0000000182A8B700
	// [XID] // 0x0000000189A09C10-0x0000000189A09C30
	private void SetupBudgetView() {} // 0x0000000182A8B040-0x0000000182A8B4B0
	// [XID] // 0x0000000189A113D0-0x0000000189A113F0
	private void SetupComponentsView(Button button, string name, float budget, uint runtimeID) {} // 0x0000000182A8B9A0-0x0000000182A8C2B0
	// [XID] // 0x0000000189A187E0-0x0000000189A18800
	private void OnClose() {} // 0x0000000182A8B700-0x0000000182A8B7B0
}

