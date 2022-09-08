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
	public class MonoPickupListPanel : MonoBehaviour // TypeDefIndex: 31255
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _listPanelContent; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoPickupListItem _itemPrefab; // 0x20
		private List<MonoPickupListItem> _listItems; // 0x28
		private int _allInstanceCount; // 0x30
		private HashSet<MonoPickupListItem> _objsInRemoving; // 0x38
		private Queue<MonoPickupListItem> _itemUnused; // 0x40
	
		// Properties
		public Action onAllItemsRemoved { /* [XID] */ /* 0x0000000189AE4B00-0x0000000189AE4B40 */ get; set; } // 0x000000018371E8A0-0x000000018371E900 0x000000018371E900-0x000000018371E960
		public int Count { /* [XID] */ /* 0x0000000189AF6A50-0x0000000189AF6A70 */ get => default; } // 0x000000018371E7E0-0x000000018371E8A0 
	
		// Constructors
		public MonoPickupListPanel() {} // 0x000000018371E6F0-0x000000018371E7E0
	
		// Methods
		// [XID] // 0x0000000189AFE020-0x0000000189AFE040
		public MonoPickupListItem At(int index) => default; // 0x000000018371DF00-0x000000018371DFF0
		// [XID] // 0x0000000189B05830-0x0000000189B05850
		public void RemoveAt(int index) {} // 0x000000018371E550-0x000000018371E6F0
		// [IDTag] // 0x0000000189B0CFE0-0x0000000189B0D020
		// [XID] // 0x0000000189B0CFE0-0x0000000189B0D020
		public virtual void Add(Action<Transform, int> onChange, int count) {} // 0x000000018371DBA0-0x000000018371DD80
		// [IDTag] // 0x0000000189B17140-0x0000000189B17180
		// [XID] // 0x0000000189B17140-0x0000000189B17180
		public MonoPickupListItem Add() => default; // 0x000000018371DD80-0x000000018371DF00
		// [XID] // 0x0000000189B21970-0x0000000189B21990
		public void ClearFadeOut() {} // 0x000000018371E210-0x000000018371E3E0
		// [XID] // 0x0000000189B290A0-0x0000000189B290C0
		public void ClearAll() {} // 0x000000018371E130-0x000000018371E210
		// [XID] // 0x0000000189B304D0-0x0000000189B304F0
		private void OnItemRemoveFinished(MonoPickupListItem item) {} // 0x000000018371DFF0-0x000000018371E130
		// [XID] // 0x0000000189B37DF0-0x0000000189B37E10
		private void Reuse(MonoPickupListItem item) {} // 0x000000018371E3E0-0x000000018371E550
		// [XID] // 0x0000000189B3F720-0x0000000189B3F740
		private MonoPickupListItem GetUnused() => default; // 0x000000018371DA00-0x000000018371DBA0
	}
}
