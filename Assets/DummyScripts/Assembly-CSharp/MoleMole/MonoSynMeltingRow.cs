/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoSynMeltingRow : MonoBehaviour // TypeDefIndex: 29776
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _scroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MihoyoButton _button; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _selectGO; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _lockIcon; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _curText; // 0x38
		private List<IdCountConfig> _itemList; // 0x48
	
		// Properties
		public bool isSelected { /* [XID] */ /* 0x0000000189A615F0-0x0000000189A61610 */ set {} } // 0x000000018500AAF0-0x000000018500ABE0
		public MihoyoButton button { /* [XID] */ /* 0x0000000189A69530-0x0000000189A69550 */ get => default; } // 0x000000018500A7F0-0x000000018500A890 
		public int itemCount { /* [XID] */ /* 0x0000000189A708A0-0x0000000189A708C0 */ get => default; } // 0x000000018500A930-0x000000018500A9F0 
		public Transform lockIcon { /* [XID] */ /* 0x0000000189A78150-0x0000000189A78170 */ get => default; } // 0x000000018500A9F0-0x000000018500AA90 
		public Transform curText { /* [XID] */ /* 0x0000000189A7F740-0x0000000189A7F760 */ get => default; } // 0x000000018500A890-0x000000018500A930 
		public bool IsLock { /* [XID] */ /* 0x0000000189A87480-0x0000000189A874C0 */ get; /* [XID] */ /* 0x0000000189A91C10-0x0000000189A91C50 */ set; } // 0x000000018500A790-0x000000018500A7F0 0x000000018500AA90-0x000000018500AAF0
	
		// Constructors
		public MonoSynMeltingRow() {} // 0x000000018500A6E0-0x000000018500A790
	
		// Methods
		// [XID] // 0x0000000189A9C160-0x0000000189A9C180
		public void SetCombine(uint combineId) {} // 0x0000000185009E30-0x000000018500A130
		// [XID] // 0x0000000189AA3870-0x0000000189AA3890
		private void InitScrollerItem(Transform trans, int index) {} // 0x0000000185009AF0-0x0000000185009E30
		// [XID] // 0x0000000189AAAF10-0x0000000189AAAF30
		public void SetCurSelectItem(int lastIndex, int curIndex) {} // 0x000000018500A130-0x000000018500A410
		// [XID] // 0x0000000189AB28A0-0x0000000189AB28C0
		public Transform GetItemByIndex(int index) => default; // 0x0000000185009A20-0x0000000185009AF0
		// [XID] // 0x0000000189ABA3D0-0x0000000189ABA3F0
		public void ShowLockIcon(bool value) {} // 0x000000018500A5B0-0x000000018500A6E0
		// [XID] // 0x0000000189AC1D00-0x0000000189AC1D20
		public void ShowCurText(bool value) {} // 0x000000018500A410-0x000000018500A5B0
	}
}
