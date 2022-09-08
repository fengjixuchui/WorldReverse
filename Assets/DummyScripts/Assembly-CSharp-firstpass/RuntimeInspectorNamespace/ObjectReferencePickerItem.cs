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
	public class ObjectReferencePickerItem : RecycledListItem // TypeDefIndex: 10026
	{
		// Fields
		private int m_skinVersion; // 0x38
		private UISkin m_skin; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image background; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RawImage texturePreview; // 0x50
		private LayoutElement texturePreviewLayoutElement; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text referenceNameText; // 0x60
		private bool m_isSelected; // 0x68
	
		// Properties
		public UnityEngine.Object Reference { /* [XID] */ /* 0x0000000189A25450-0x0000000189A25490 */ get; /* [XID] */ /* 0x0000000189A2FAC0-0x0000000189A2FB00 */ private set; } // 0x00000001867FC660-0x00000001867FC6C0 0x00000001867FC940-0x00000001867FC9A0
		public UISkin Skin { /* [XID] */ /* 0x0000000189A3A250-0x0000000189A3A270 */ get => default; /* [XID] */ /* 0x0000000189A41AD0-0x0000000189A41AF0 */ set {} } // 0x00000001867FC6C0-0x00000001867FC760 0x00000001867FC9A0-0x00000001867FCC10
		public bool IsSelected { /* [XID] */ /* 0x0000000189A49130-0x0000000189A49150 */ get => default; /* [XID] */ /* 0x0000000189871E30-0x0000000189871E50 */ set {} } // 0x00000001867FC5C0-0x00000001867FC660 0x00000001867FC760-0x00000001867FC940
	
		// Constructors
		public ObjectReferencePickerItem() {} // 0x00000001867FC510-0x00000001867FC5C0
	
		// Methods
		// [XID] // 0x0000000189A57EC0-0x0000000189A57EE0
		private void Awake() {} // 0x00000001867FC190-0x00000001867FC2B0
		// [XID] // 0x0000000189A5FB30-0x0000000189A5FB50
		public void SetContent(UnityEngine.Object reference) {} // 0x00000001867FC2B0-0x00000001867FC4B0
	}
}
