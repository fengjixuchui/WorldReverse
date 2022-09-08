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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public abstract class HierarchyItem : MonoBehaviour // TypeDefIndex: 9964
	{
		// Fields
		protected Color NORMAL_COLOR; // 0x18
		protected const float INACTIVE_ITEM_TEXT_ALPHA = 0.57f; // Metadata: 0x00AE6DDF
		private bool initialized; // 0x28
		private RuntimeHierarchy m_hierarchy; // 0x30
		private int m_skinVersion; // 0x38
		private UISkin m_skin; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected LayoutGroup layoutGroup; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform contentTransform; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text nameText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform drawArea; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected PointerEventListener clickListener; // 0x68
		private Image background; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PointerEventListener expandToggle; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image expandArrow; // 0x80
		protected List<HierarchyItemTransform> children; // 0x88
		private bool m_isExpanded; // 0x90
		protected bool m_isSelected; // 0x91
	
		// Properties
		public RuntimeHierarchy Hierarchy { /* [XID] */ /* 0x00000001897D1290-0x00000001897D12B0 */ get; /* [XID] */ /* 0x0000000189B5D450-0x0000000189B5D470 */ set; } // 0x00000001867F4A30-0x00000001867F4AD0 0x00000001867F4D70-0x00000001867F4E80
		public UISkin Skin { /* [XID] */ /* 0x0000000189B64B90-0x0000000189B64BB0 */ get; /* [XID] */ /* 0x00000001898414A0-0x00000001898414C0 */ set; } // 0x00000001867F4CD0-0x00000001867F4D70 0x00000001867F5380-0x00000001867F54C0
		protected abstract bool IsValid { get; }
		protected abstract int ChildCount { get; }
		protected virtual bool IsActive { /* [XID] */ /* 0x0000000189805C70-0x0000000189805C90 */ get; /* [XID] */ /* 0x0000000189832900-0x0000000189832920 */ set; } // 0x00000001867F4AD0-0x00000001867F4B70 0x00000001867F4E80-0x00000001867F4F30
		public bool IsExpanded { /* [XID] */ /* 0x0000000189A2B0C0-0x0000000189A2B0E0 */ get; /* [XID] */ /* 0x0000000189B89E10-0x0000000189B89E30 */ set; } // 0x00000001867F4B70-0x00000001867F4C20 0x00000001867F4F30-0x00000001867F5140
		public bool IsSelected { /* [XID] */ /* 0x0000000189B914F0-0x0000000189B91510 */ get; /* [XID] */ /* 0x00000001897D92D0-0x00000001897D92F0 */ set; } // 0x00000001867F4C20-0x00000001867F4CD0 0x00000001867F5140-0x00000001867F5380
	
		// Constructors
		protected HierarchyItem() {} // 0x00000001867F4970-0x00000001867F4A30
	
		// Methods
		// [XID] // 0x0000000189B9FC80-0x0000000189B9FCA0
		protected virtual void Initialize() {} // 0x00000001867F3450-0x00000001867F35C0
		// [XID] // 0x000000018990E250-0x000000018990E270
		public virtual void Unbind() {} // 0x00000001867F4890-0x00000001867F4970
		// [XID] // 0x0000000189648AC0-0x0000000189648AE0
		private void ClearChildren() {} // 0x00000001867F3080-0x00000001867F31D0
		// [XID] // 0x0000000189AEA350-0x0000000189AEA370
		protected virtual void OnSkinChanged() {} // 0x00000001867F35C0-0x00000001867F38E0
		// [XID] // 0x0000000189BBD3F0-0x0000000189BBD410
		public virtual void Refresh() {} // 0x00000001867F3BC0-0x00000001867F42B0
		// [XID] // 0x0000000189BC5130-0x0000000189BC5150
		public void RefreshNameOf(Transform target) {} // 0x00000001867F3980-0x00000001867F3BC0
		// [XID] // 0x0000000189BCCBE0-0x0000000189BCCC00
		protected virtual void RefreshContent() {} // 0x00000001867F38E0-0x00000001867F3980
		// [XID] // 0x0000000189714970-0x0000000189714990
		private void GenerateChildItem(Transform child, int index) {} // 0x00000001867F31D0-0x00000001867F3320
		// [XID] // 0x0000000189BDBB90-0x0000000189BDBBB0
		public HierarchyItem SelectTransform(Transform target, Transform nextInPath = null) => default; // 0x00000001867F42B0-0x00000001867F47A0
		// [XID] // 0x0000000189A23E10-0x0000000189A23E30
		protected int IndexOf(Transform transform) => default; // 0x00000001867F3320-0x00000001867F3450
		protected abstract Transform GetChild(int index);
	}
}
