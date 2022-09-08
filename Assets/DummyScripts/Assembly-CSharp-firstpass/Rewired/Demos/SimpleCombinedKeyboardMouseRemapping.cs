/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour // TypeDefIndex: 9795
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00AE62B6
		private const string layout = "Default"; // Metadata: 0x00AE62C1
		private const string uiCategory = "UI"; // Metadata: 0x00AE62CC
		private InputMapper inputMapper_keyboard; // 0x18
		private InputMapper inputMapper_mouse; // 0x20
		public GameObject buttonPrefab; // 0x28
		public GameObject textPrefab; // 0x30
		public RectTransform fieldGroupTransform; // 0x38
		public RectTransform actionGroupTransform; // 0x40
		public UnityEngine.UI.Text controllerNameUIText; // 0x48
		public UnityEngine.UI.Text statusUIText; // 0x50
		private List<Row> rows; // 0x58
		private TargetMapping _replaceTargetMapping; // 0x60
	
		// Properties
		private Player player { /* [XID] */ /* 0x0000000189970160-0x0000000189970180 */ get => default; } // 0x0000000186560230-0x0000000186560310 
	
		// Nested types
		private class Row // TypeDefIndex: 9796
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row() {} // 0x000000018655E700-0x000000018655E760
		}
	
		private struct TargetMapping // TypeDefIndex: 9797
		{
			// Fields
			public ControllerMap controllerMap; // 0x00
			public int actionElementMapId; // 0x08
		}
	
		// Constructors
		public SimpleCombinedKeyboardMouseRemapping() {} // 0x0000000186560160-0x0000000186560230
	
		// Methods
		// [XID] // 0x0000000189977FB0-0x0000000189977FD0
		private void OnEnable() {} // 0x000000018655F2F0-0x000000018655F650
		// [XID] // 0x000000018997F0D0-0x000000018997F0F0
		private void OnDisable() {} // 0x000000018655F200-0x000000018655F2F0
		// [XID] // 0x0000000189986B10-0x0000000189986B30
		private void RedrawUI() {} // 0x000000018655FB20-0x0000000186560000
		// [XID] // 0x000000018998E630-0x000000018998E650
		private void ClearUI() {} // 0x000000018655E760-0x000000018655E930
		// [XID] // 0x00000001899961A0-0x00000001899961C0
		private void InitializeUI() {} // 0x000000018655EBF0-0x000000018655F200
		// [XID] // 0x0000000189B24320-0x0000000189B24340
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label) {} // 0x000000018655E930-0x000000018655EBF0
		// [XID] // 0x00000001899A5420-0x00000001899A5440
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) {} // 0x000000018655F650-0x000000018655F890
		[DebuggerHidden] // 0x00000001899ACED0-0x00000001899ACF10
		// [XID] // 0x00000001899ACED0-0x00000001899ACF10
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId) => default; // 0x0000000186560000-0x0000000186560160
		// [XID] // 0x00000001899B7250-0x00000001899B7270
		private void OnInputMapped(InputMapper.InputMappedEventData data) {} // 0x000000018655F890-0x000000018655F9D0
		// [XID] // 0x00000001899BED00-0x00000001899BED20
		private void OnStopped(InputMapper.StoppedEventData data) {} // 0x000000018655F9D0-0x000000018655FB20
	}
}
