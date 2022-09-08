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
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class ObjectReferencePicker : SkinnedWindow, IListViewAdapter // TypeDefIndex: 10024
	{
		// Fields
		private const string SPRITE_ATLAS_PREFIX = "SpriteAtlasTexture-"; // Metadata: 0x00AE6E15
		private static ObjectReferencePicker m_instance; // 0x00
		private OnReferenceChanged onReferenceChanged; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image panel; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image scrollbar; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField searchBar; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image searchIcon; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image searchBarBackground; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text selectPromptText; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement searchBarLayoutElement; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private LayoutElement buttonsLayoutElement; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button cancelButton; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button okButton; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RecycledListView listView; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image listViewBackground; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ObjectReferencePickerItem referenceItemPrefab; // 0x90
		private List<UnityEngine.Object> references; // 0x98
		private List<UnityEngine.Object> filteredReferences; // 0xA0
		private UnityEngine.Object initialValue; // 0xA8
		private UnityEngine.Object currentlySelectedObject; // 0xB0
		private ObjectReferencePickerItem currentlySelectedItem; // 0xB8
	
		// Properties
		public static ObjectReferencePicker Instance { /* [XID] */ /* 0x00000001895F8D60-0x00000001895F8D80 */ get => default; } // 0x00000001867FE520-0x00000001867FE6B0 
		public int Count { /* [XID] */ /* 0x0000000189AEC3F0-0x0000000189AEC410 */ get => default; } // 0x00000001867FE460-0x00000001867FE520 
		public float ItemHeight { /* [XID] */ /* 0x0000000189AF3DD0-0x0000000189AF3DF0 */ get => default; } // 0x00000001867FE6B0-0x00000001867FE780 
	
		// Nested types
		public delegate void OnReferenceChanged(UnityEngine.Object reference); // TypeDefIndex: 10025; 0x00000001867FE890-0x00000001867FEAF0
	
		// Constructors
		public ObjectReferencePicker() {} // 0x00000001867FE3A0-0x00000001867FE460
	
		// Methods
		// [XID] // 0x0000000189845E70-0x0000000189845E90
		protected override void Awake() {} // 0x00000001867FCC10-0x00000001867FCE10
		// [XID] // 0x00000001899B71D0-0x00000001899B71F0
		public void Show(OnReferenceChanged onReferenceChanged, System.Type referenceType, UnityEngine.Object[] references, UnityEngine.Object initialReference) {} // 0x00000001867FE060-0x00000001867FE280
		// [XID] // 0x00000001899BECC0-0x00000001899BECE0
		public void Cancel() {} // 0x00000001867FCE10-0x00000001867FCF20
		// [XID] // 0x00000001898C06A0-0x00000001898C06C0
		public void Close() {} // 0x00000001867FCF20-0x00000001867FD030
		// [XID] // 0x00000001899CDBC0-0x00000001899CDBE0
		protected override void RefreshSkin() {} // 0x00000001867FDA80-0x00000001867FDE60
		// [XID] // 0x00000001898627B0-0x00000001898627D0
		private void GenerateReferenceItems(UnityEngine.Object[] references, System.Type referenceType) {} // 0x00000001867FD150-0x00000001867FD650
		// [XID] // 0x00000001899DC7C0-0x00000001899DC7E0
		public RecycledListItem CreateItem(Transform parent) => default; // 0x00000001867FD030-0x00000001867FD150
		// [XID] // 0x00000001899E40A0-0x00000001899E40C0
		private void OnSearchTextChanged(string value) {} // 0x00000001867FD860-0x00000001867FDA80
		// [XID] // 0x00000001899EB510-0x00000001899EB530
		public void SetItemContent(RecycledListItem item) {} // 0x00000001867FDE60-0x00000001867FE060
		// [XID] // 0x00000001899F3240-0x00000001899F3260
		public void OnItemClicked(RecycledListItem item) {} // 0x00000001867FD650-0x00000001867FD860
	}
}
