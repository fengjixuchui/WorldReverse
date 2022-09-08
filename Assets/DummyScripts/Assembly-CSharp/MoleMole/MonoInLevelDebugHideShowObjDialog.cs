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
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelDebugHideShowObjDialog : MonoBehaviour // TypeDefIndex: 30323
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public InLevelDebugHideShowObjDialogContext.HideShowObjData[] config; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject objBtnPrefab; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public Transform btnTransfromParent; // 0x28
		private Dictionary<DebugHideObjType, Button> _buttonMap; // 0x30
	
		// Constructors
		public MonoInLevelDebugHideShowObjDialog() {} // 0x000000018470BB00-0x000000018470BB60
	
		// Methods
		// [XID] // 0x00000001896127F0-0x0000000189612810
		public bool SetupMonoPage() => default; // 0x000000018470B6D0-0x000000018470B850
		// [XID] // 0x000000018961A180-0x000000018961A1A0
		public Button InitiateButton(DebugHideObjType objType) => default; // 0x000000018470B460-0x000000018470B6D0
		// [XID] // 0x0000000189621670-0x0000000189621690
		public void UpdateButtonState(DebugHideObjType objType, bool show, UnityAction btnAction = null) {} // 0x000000018470B850-0x000000018470BB00
	}
}
