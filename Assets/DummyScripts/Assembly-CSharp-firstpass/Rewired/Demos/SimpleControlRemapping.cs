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
	public class SimpleControlRemapping : MonoBehaviour // TypeDefIndex: 9800
	{
		// Fields
		private const string category = "Default"; // Metadata: 0x00AE62D2
		private const string layout = "Default"; // Metadata: 0x00AE62DD
		private const string uiCategory = "UI"; // Metadata: 0x00AE62E8
		private InputMapper inputMapper; // 0x18
		public GameObject buttonPrefab; // 0x20
		public GameObject textPrefab; // 0x28
		public RectTransform fieldGroupTransform; // 0x30
		public RectTransform actionGroupTransform; // 0x38
		public UnityEngine.UI.Text controllerNameUIText; // 0x40
		public UnityEngine.UI.Text statusUIText; // 0x48
		private ControllerType selectedControllerType; // 0x50
		private int selectedControllerId; // 0x54
		private List<Row> rows; // 0x58
	
		// Properties
		private Player player { /* [XID] */ /* 0x0000000189B4EC70-0x0000000189B4EC90 */ get => default; } // 0x00000001865620B0-0x0000000186562190 
		private ControllerMap controllerMap { /* [XID] */ /* 0x0000000189A2E250-0x0000000189A2E270 */ get => default; } // 0x0000000186561E80-0x0000000186561FE0 
		private Controller controller { /* [XID] */ /* 0x0000000189A35B00-0x0000000189A35B20 */ get => default; } // 0x0000000186561FE0-0x00000001865620B0 
	
		// Nested types
		private class Row // TypeDefIndex: 9801
		{
			// Fields
			public InputAction action; // 0x10
			public AxisRange actionRange; // 0x18
			public Button button; // 0x20
			public UnityEngine.UI.Text text; // 0x28
	
			// Constructors
			public Row() {} // 0x000000018655E6A0-0x000000018655E700
		}
	
		// Constructors
		public SimpleControlRemapping() {} // 0x0000000186561DD0-0x0000000186561E80
	
		// Methods
		// [XID] // 0x0000000189A3D150-0x0000000189A3D170
		private void OnEnable() {} // 0x00000001865610A0-0x0000000186561350
		// [XID] // 0x0000000189A449E0-0x0000000189A44A00
		private void OnDisable() {} // 0x0000000186560F30-0x00000001865610A0
		// [XID] // 0x0000000189A4C100-0x0000000189A4C120
		private void RedrawUI() {} // 0x0000000186561660-0x0000000186561AE0
		// [XID] // 0x0000000189A53830-0x0000000189A53850
		private void ClearUI() {} // 0x0000000186560310-0x0000000186560500
		// [XID] // 0x0000000189A5AFC0-0x0000000189A5AFE0
		private void InitializeUI() {} // 0x00000001865607C0-0x0000000186560DD0
		// [XID] // 0x0000000189A627A0-0x0000000189A627C0
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label) {} // 0x0000000186560500-0x00000001865607C0
		// [XID] // 0x0000000189A6A5C0-0x0000000189A6A5E0
		private void SetSelectedController(ControllerType controllerType) {} // 0x0000000186561AE0-0x0000000186561C90
		// [XID] // 0x0000000189A71990-0x0000000189A719B0
		public void OnControllerSelected(int controllerType) {} // 0x0000000186560E80-0x0000000186560F30
		// [XID] // 0x0000000189A79490-0x0000000189A794B0
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId) {} // 0x0000000186561350-0x0000000186561460
		[DebuggerHidden] // 0x0000000189A80C20-0x0000000189A80C60
		// [XID] // 0x0000000189A80C20-0x0000000189A80C60
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId) => default; // 0x0000000186561C90-0x0000000186561DD0
		// [XID] // 0x0000000189A8B860-0x0000000189A8B880
		private void OnControllerChanged(ControllerStatusChangedEventArgs args) {} // 0x0000000186560DD0-0x0000000186560E80
		// [XID] // 0x0000000189A92E40-0x0000000189A92E60
		private void OnInputMapped(InputMapper.InputMappedEventData data) {} // 0x0000000186561460-0x0000000186561510
		// [XID] // 0x0000000189A9A8A0-0x0000000189A9A8C0
		private void OnStopped(InputMapper.StoppedEventData data) {} // 0x0000000186561510-0x0000000186561660
	}
}
