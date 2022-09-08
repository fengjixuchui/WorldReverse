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

public sealed class RestrictionSelectComponent : BaseContextComponent // TypeDefIndex: 29469
{
	// Fields
	private object _listObj; // 0x30
	private DataProvider _provider; // 0x38
	private Color _posColor; // 0x40
	private Color _negColor; // 0x50
	private List<int> _selectedList; // 0x60
	private int _selectedTotScore; // 0x68
	private Dictionary<uint, int> _restrictionExclusiveIdList; // 0x70
	private Action _onSelectChange; // 0x78

	// Properties
	public List<int> selectedList { /* [XID] */ /* 0x0000000189B2AA30-0x0000000189B2AA50 */ get => default; } // 0x0000000181575590-0x0000000181575630 
	public int selectedTotScore { /* [XID] */ /* 0x0000000189B31F60-0x0000000189B31F80 */ get => default; } // 0x0000000181575970-0x0000000181575A10 

	// Nested types
	public abstract class DataProvider : RestrictionOverviewComponent.DataProvider // TypeDefIndex: 29470
	{
		// Constructors
		protected DataProvider() {} // 0x000000018158EE90-0x000000018158F000

		// Methods
		// [XID] // 0x0000000189B91920-0x0000000189B91940
		public virtual int GetScore(int idx) => default; // 0x000000018158EC80-0x000000018158ED30
		// [XID] // 0x0000000189B98CE0-0x0000000189B98D00
		public virtual uint GetExlusiveId(int idx) => default; // 0x000000018158EDE0-0x000000018158EE90
		// [XID] // 0x0000000189BA0100-0x0000000189BA0120
		public virtual string GetScoreIconName(int idx) => default; // 0x000000018158ED30-0x000000018158EDE0
	}

	// Constructors
	public RestrictionSelectComponent() {} // 0x0000000181576090-0x0000000181576150

	// Methods
	// [XID] // 0x0000000189B39720-0x0000000189B39740
	public void SetToggle(int idx, bool isOn) {} // 0x0000000181574AD0-0x0000000181574C60
	// [XID] // 0x0000000189B410D0-0x0000000189B410F0
	public override void Init(GameObject view) {} // 0x0000000181575A10-0x0000000181575B10
	// [XID] // 0x0000000189B489C0-0x0000000189B489E0
	public override void Destroy() {} // 0x00000001815754F0-0x0000000181575590
	// [IDTag] // 0x0000000189B50130-0x0000000189B50170
	// [XID] // 0x0000000189B50130-0x0000000189B50170
	public void Setup(MonoGridScroller listObj, DataProvider provider, Action onSelectChange) {} // 0x0000000181575400-0x00000001815754F0
	// [IDTag] // 0x0000000189B5A920-0x0000000189B5A960
	// [XID] // 0x0000000189B5A920-0x0000000189B5A960
	public void Setup(MonoSimpleReusableList listObj, DataProvider provider, Action onSelectChange) {} // 0x0000000181575310-0x0000000181575400
	// [XID] // 0x0000000189B64FE0-0x0000000189B65000
	public void Refresh() {} // 0x0000000181574740-0x0000000181574A50
	// [XID] // 0x0000000189B6C5C0-0x0000000189B6C5E0
	public void Clear() {} // 0x0000000181575630-0x0000000181575710
	// [XID] // 0x0000000189B73D50-0x0000000189B73D70
	private void RefreshItem(Transform trans, int idx) {} // 0x0000000181574C60-0x0000000181575310
	// [XID] // 0x0000000189B7B3C0-0x0000000189B7B3E0
	public void OnRestrictionsValueChanged(int idx, bool isOn) {} // 0x0000000181575D20-0x0000000181576030
	// [XID] // 0x0000000189B82CE0-0x0000000189B82D00
	private void CheckOtherRestrictionExclusiveId(int index, uint exclusiveId, bool interactable) {} // 0x0000000181575710-0x0000000181575970
	// [XID] // 0x0000000189B8A2E0-0x0000000189B8A300
	private Transform GetListTrans(int idx) => default; // 0x0000000181575B10-0x0000000181575D20
}

