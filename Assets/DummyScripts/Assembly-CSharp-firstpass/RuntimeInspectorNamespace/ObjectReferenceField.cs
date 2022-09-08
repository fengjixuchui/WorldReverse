/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class ObjectReferenceField : InspectorField, IDropHandler // TypeDefIndex: 10002
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PointerEventListener input; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private PointerEventListener inspectReferenceButton; // 0x78
		private Image inspectReferenceImage; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected Image background; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected UnityEngine.UI.Text referenceNameText; // 0x90
	
		// Constructors
		public ObjectReferenceField() {} // 0x00000001867FC0E0-0x00000001867FC190
	
		// Methods
		// [XID] // 0x0000000189B01840-0x0000000189B01860
		public override void Initialize() {} // 0x00000001867FB070-0x00000001867FB210
		// [XID] // 0x0000000189A30FC0-0x0000000189A30FE0
		public override bool SupportsType(System.Type type) => default; // 0x00000001867FBE60-0x00000001867FBF60
		// [XID] // 0x0000000189A38C50-0x0000000189A38C70
		private void ShowReferencePicker(PointerEventData eventData) {} // 0x00000001867FBCF0-0x00000001867FBE60
		// [XID] // 0x0000000189AEB0D0-0x0000000189AEB0F0
		private void InspectReference(PointerEventData eventData) {} // 0x00000001867FB210-0x00000001867FB3B0
		// [XID] // 0x0000000189A47930-0x0000000189A47950
		protected override void OnBound() {} // 0x00000001867FB3B0-0x00000001867FB480
		// [XID] // 0x0000000189A4F0F0-0x0000000189A4F110
		protected virtual void OnReferenceChanged(UnityEngine.Object reference) {} // 0x00000001867FB5C0-0x00000001867FB830
		// [XID] // 0x0000000189870F40-0x0000000189870F60
		public void OnDrop(PointerEventData eventData) {} // 0x00000001867FB480-0x00000001867FB5C0
		// [XID] // 0x0000000189669CA0-0x0000000189669CC0
		protected override void OnSkinChanged() {} // 0x00000001867FB830-0x00000001867FBBF0
		// [XID] // 0x0000000189A65B80-0x0000000189A65BA0
		public override void Refresh() {} // 0x00000001867FBBF0-0x00000001867FBCF0
	}
}
