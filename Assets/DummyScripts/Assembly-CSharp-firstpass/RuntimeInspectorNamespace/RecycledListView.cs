/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	// [RequireComponent] // 0x0000000189B28CC0-0x0000000189B28D10
	public class RecycledListView : MonoBehaviour // TypeDefIndex: 10031
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform viewportTransform; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform contentTransform; // 0x20
		private float itemHeight; // 0x28
		private float _1OverItemHeight; // 0x2C
		private float viewportHeight; // 0x30
		private Dictionary<int, RecycledListItem> items; // 0x38
		private Stack<RecycledListItem> pooledItems; // 0x40
		private IListViewAdapter adapter; // 0x48
		private bool isDirty; // 0x50
		private int currentTopIndex; // 0x54
		private int currentBottomIndex; // 0x58
	
		// Constructors
		public RecycledListView() {} // 0x0000000186803A90-0x0000000186803B60
	
		// Methods
		// [XID] // 0x0000000189B43C70-0x0000000189B43C90
		private void Start() {} // 0x0000000186803190-0x00000001868032B0
		// [XID] // 0x0000000189911ED0-0x0000000189911EF0
		private void Update() {} // 0x00000001868039A0-0x0000000186803A90
		// [XID] // 0x00000001897F4200-0x00000001897F4220
		public void SetAdapter(IListViewAdapter adapter) {} // 0x00000001868030B0-0x0000000186803190
		// [XID] // 0x0000000189B5A440-0x0000000189B5A460
		public void UpdateList() {} // 0x00000001868037B0-0x00000001868039A0
		// [XID] // 0x000000018980A600-0x000000018980A620
		public void ResetList() {} // 0x0000000186802F50-0x00000001868030B0
		// [XID] // 0x0000000189A89C60-0x0000000189A89C80
		private void OnRectTransformDimensionsChange() {} // 0x0000000186802EB0-0x0000000186802F50
		// [XID] // 0x00000001899CF040-0x00000001899CF060
		private void UpdateItemsInTheList(bool updateAllVisibleItems = false /* Metadata: 0x00AE6E2C */) {} // 0x0000000186803500-0x00000001868037B0
		// [XID] // 0x0000000189B77EC0-0x0000000189B77EE0
		private void CreateItemsBetweenIndices(int topIndex, int bottomIndex) {} // 0x0000000186802C80-0x0000000186802D60
		// [XID] // 0x0000000189B7F4A0-0x0000000189B7F4C0
		private void CreateItemAtIndex(int index) {} // 0x0000000186802A60-0x0000000186802C80
		// [XID] // 0x0000000189B870B0-0x0000000189B870D0
		private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex) {} // 0x0000000186802D60-0x0000000186802EB0
		// [XID] // 0x0000000189B8E240-0x0000000189B8E260
		private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex) {} // 0x0000000186803320-0x0000000186803500
	}
}
