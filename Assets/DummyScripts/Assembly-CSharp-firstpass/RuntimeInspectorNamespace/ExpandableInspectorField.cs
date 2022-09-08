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
	public abstract class ExpandableInspectorField : InspectorField // TypeDefIndex: 9995
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected RectTransform drawArea; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PointerEventListener expandToggle; // 0x78
		private RectTransform expandToggleTransform; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutGroup layoutGroup; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image expandArrow; // 0x90
		protected List<InspectorField> elements; // 0x98
		private List<ExposedMethodField> exposedMethods; // 0xA0
		private bool m_isExpanded; // 0xA8
	
		// Properties
		protected virtual int Length { /* [XID] */ /* 0x00000001897CFF10-0x00000001897CFF30 */ get; } // 0x00000001867ED6E0-0x00000001867ED7A0 
		public bool IsExpanded { /* [XID] */ /* 0x00000001897D7790-0x00000001897D77B0 */ get; /* [XID] */ /* 0x00000001899E2780-0x00000001899E27A0 */ set; } // 0x00000001867ED630-0x00000001867ED6E0 0x00000001867ED7A0-0x00000001867EDA30
	
		// Constructors
		protected ExpandableInspectorField() {} // 0x00000001867ED520-0x00000001867ED630
	
		// Methods
		// [XID] // 0x00000001896E75E0-0x00000001896E7600
		public override void Initialize() {} // 0x00000001867EC680-0x00000001867EC7D0
		// [XID] // 0x00000001896AFD90-0x00000001896AFDB0
		protected override void OnUnbound() {} // 0x00000001867ECD80-0x00000001867ECE40
		// [XID] // 0x00000001897F5910-0x00000001897F5930
		protected override void OnSkinChanged() {} // 0x00000001867EC9B0-0x00000001867ECD80
		// [XID] // 0x00000001897FD150-0x00000001897FD170
		protected override void OnDepthChanged() {} // 0x00000001867EC7D0-0x00000001867EC9B0
		// [XID] // 0x00000001898047C0-0x00000001898047E0
		protected void RegenerateElements() {} // 0x00000001867ECFD0-0x00000001867ED190
		protected abstract void GenerateElements();
		// [XID] // 0x000000018980BD00-0x000000018980BD20
		private void GenerateMethods() {} // 0x00000001867EC280-0x00000001867EC680
		// [XID] // 0x0000000189985B70-0x0000000189985B90
		protected virtual void ClearElements() {} // 0x00000001867EB890-0x00000001867EBA70
		// [XID] // 0x0000000189730670-0x0000000189730690
		public override void Refresh() {} // 0x00000001867ECE40-0x00000001867ECFD0
		// [XID] // 0x00000001898226B0-0x00000001898226D0
		protected InspectorField CreateDrawerForComponent(Component component, string variableName = null) => default; // 0x00000001867EBA70-0x00000001867EBE00
		// [XID] // 0x0000000189829CB0-0x0000000189829CD0
		protected InspectorField CreateDrawerForVariable(MemberInfo variable, string variableName = null) => default; // 0x00000001867EBE00-0x00000001867EC0A0
		// [XID] // 0x00000001898311E0-0x0000000189831200
		protected InspectorField CreateDrawer(System.Type variableType, string variableName, Getter getter, Setter setter, bool drawObjectsAsFields = true /* Metadata: 0x00AE6E08 */) => default; // 0x00000001867EC0A0-0x00000001867EC280
	}
}
