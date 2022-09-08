/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.UAuto;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

// [Category] // 0x0000000189985990-0x0000000189985A70
// [Description] // 0x0000000189985990-0x0000000189985A70
// [Order] // 0x0000000189985990-0x0000000189985A70
[TestFixture] // 0x0000000189985990-0x0000000189985A70
public class BagItems : TestCaseBase // TypeDefIndex: 28346
{
	// Fields
	public List<int> itemidList; // 0x198
	public int count; // 0x1A0
	public GameObject GrpBtnBag; // 0x1A8
	public GameObject BagPageContext; // 0x1B0
	private MonoBagPage bagProxyDialog; // 0x1B8
	public MonoBagTabContent _bagTabContent; // 0x1C0
	public List<BagItemSlot> _slotList; // 0x1C8
	private MonoUIContainer _returnBtn; // 0x1D0
	private MonoUIContainer _useButton; // 0x1D8
	private MonoUIContainer _dropButton; // 0x1E0
	public int _slotCount; // 0x1E8

	// Constructors
	public BagItems() {} // 0x0000000185074CC0-0x0000000185074D40

	// Methods
	// [Description] // 0x00000001899A74F0-0x00000001899A7590
	[SetUp] // 0x00000001899A74F0-0x00000001899A7590
	// [XID] // 0x00000001899A74F0-0x00000001899A7590
	public override void SetUp() {} // 0x00000001850749F0-0x0000000185074CC0
	[DebuggerHidden] // 0x00000001899BF3C0-0x00000001899BF480
	// [Description] // 0x00000001899BF3C0-0x00000001899BF480
	[MonoTest] // 0x00000001899BF3C0-0x00000001899BF480
	// [Order] // 0x00000001899BF3C0-0x00000001899BF480
	// [XID] // 0x00000001899BF3C0-0x00000001899BF480
	public IEnumerator AddItems() => default; // 0x0000000185074630-0x0000000185074740
	[DebuggerHidden] // 0x00000001899DCE70-0x00000001899DCEB0
	// [XID] // 0x00000001899DCE70-0x00000001899DCEB0
	public IEnumerator ChooseItemTab(int i, int expectCount = 0 /* Metadata: 0x00B0D616 */) => default; // 0x0000000185073FA0-0x00000001850740E0
	[DebuggerHidden] // 0x00000001899E79E0-0x00000001899E7AA0
	// [Description] // 0x00000001899E79E0-0x00000001899E7AA0
	[MonoTest] // 0x00000001899E79E0-0x00000001899E7AA0
	// [Order] // 0x00000001899E79E0-0x00000001899E7AA0
	// [XID] // 0x00000001899E79E0-0x00000001899E7AA0
	public IEnumerator ChooseItem() => default; // 0x00000001850740E0-0x00000001850741F0
	[DebuggerHidden] // 0x0000000189A057B0-0x0000000189A057F0
	// [XID] // 0x0000000189A057B0-0x0000000189A057F0
	public IEnumerator DropOneItemInTab(int i) => default; // 0x0000000185074390-0x00000001850744B0
	[DebuggerHidden] // 0x0000000189A0FA80-0x0000000189A0FAC0
	// [XID] // 0x0000000189A0FA80-0x0000000189A0FAC0
	public IEnumerator UseOneItemInTab(int index) => default; // 0x00000001850744B0-0x00000001850745D0
	[DebuggerHidden] // 0x0000000189A19DB0-0x0000000189A19E70
	// [Description] // 0x0000000189A19DB0-0x0000000189A19E70
	[MonoTest] // 0x0000000189A19DB0-0x0000000189A19E70
	// [Order] // 0x0000000189A19DB0-0x0000000189A19E70
	// [XID] // 0x0000000189A19DB0-0x0000000189A19E70
	public IEnumerator DropItems() => default; // 0x0000000185073E90-0x0000000185073FA0
	[DebuggerHidden] // 0x0000000189A37A80-0x0000000189A37B40
	// [Description] // 0x0000000189A37A80-0x0000000189A37B40
	[MonoTest] // 0x0000000189A37A80-0x0000000189A37B40
	// [Order] // 0x0000000189A37A80-0x0000000189A37B40
	// [XID] // 0x0000000189A37A80-0x0000000189A37B40
	public IEnumerator UseItems() => default; // 0x0000000185074740-0x0000000185074850
	[DebuggerHidden] // 0x0000000189A55810-0x0000000189A558D0
	// [Description] // 0x0000000189A55810-0x0000000189A558D0
	[MonoTest] // 0x0000000189A55810-0x0000000189A558D0
	// [Order] // 0x0000000189A55810-0x0000000189A558D0
	// [XID] // 0x0000000189A55810-0x0000000189A558D0
	public IEnumerator CloseBagPage() => default; // 0x0000000185073D80-0x0000000185073E90
	[DebuggerHidden] // 0x0000000189A739A0-0x0000000189A739E0
	// [XID] // 0x0000000189A739A0-0x0000000189A739E0
	public IEnumerator ChooseOneItemInTab(int itemIndex) => default; // 0x00000001850741F0-0x0000000185074310
	[DebuggerHidden] // 0x0000000189A7E280-0x0000000189A7E2C0
	// [XID] // 0x0000000189A7E280-0x0000000189A7E2C0
	public override IEnumerator OnNotify(GameObject sender) => default; // 0x00000001850748D0-0x00000001850749F0
}

