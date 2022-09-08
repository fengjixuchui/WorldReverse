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
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoDailyTask : MonoBehaviour // TypeDefIndex: 31131
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Button _actionButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _taskPointContainer; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rewardAvailableEffectGrp; // 0x28
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject _taskPointPrefab; // 0x30
		private List<GameObject> _taskPoints; // 0x38
	
		// Properties
		public Button actionButton { /* [XID] */ /* 0x0000000189857AE0-0x0000000189857B00 */ get => default; } // 0x0000000183F3CA30-0x0000000183F3CAD0 
		public bool rewardAvailable { /* [XID] */ /* 0x000000018986DC60-0x000000018986DC80 */ set {} } // 0x0000000183F3CAD0-0x0000000183F3CBB0
	
		// Constructors
		public MonoDailyTask() {} // 0x0000000183F3C990-0x0000000183F3CA30
	
		// Methods
		// [XID] // 0x000000018985EBB0-0x000000018985EBD0
		public void CreateTaskPoints(int count) {} // 0x0000000183F3C5E0-0x0000000183F3C820
		// [XID] // 0x0000000189866330-0x0000000189866350
		public void SetTaskPointCompleteAt(int index, bool complete) {} // 0x0000000183F3C820-0x0000000183F3C990
	}
}
